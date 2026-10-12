using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt1
{
    public partial class Form1 : Form
    {
        private double _x, _y, _vx, _vy;
        private double _W, _H, _R;
        private readonly Stopwatch _sw = new Stopwatch();
        private int _hits;
        private double _simTime;
        private double _speedMul = 1.0;
        private readonly List<PointF> _hitPoints = new List<PointF>();
        private readonly List<PointF> _trail = new List<PointF>();

        public Form1()
        {
            InitializeComponent();
            ResetBall();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetBall();
        }

        // зчитує параметри й ставить кулю в початкове положення
        private void ResetBall()
        {
            _W = (double)_numW.Value;
            _H = (double)_numH.Value;
            _R = (double)_numR.Value;

            if (2 * _R >= Math.Min(_W, _H))
            {
                _timer.Stop();
                _btnPlay.Text = "Старт";
                MessageBox.Show("Радіус завеликий: потрібно, щоб 2r < min(W, H).",
                    "Помилка параметрів", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _W = 0; _H = 0; 
                _canvas.Invalidate();
                return;
            }

            _x = Math.Max(_R, Math.Min(_W - _R, (double)_numX0.Value));
            _y = Math.Max(_R, Math.Min(_H - _R, (double)_numY0.Value));

            double v = (double)_numV.Value;
            double a = (double)_numAngle.Value * Math.PI / 180.0;
            _vx = v * Math.Cos(a);
            _vy = v * Math.Sin(a);

            _hits = 0;
            _simTime = 0;
            _hitPoints.Clear();
            _trail.Clear();
            _trail.Add(new PointF((float)_x, (float)_y));
            _canvas.Invalidate();
        }
        private void _btnStep_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _sw.Stop();
            _btnPlay.Text = "Старт";
            Step(0.05);
            _canvas.Invalidate();
        }

        private void _trkSpeed_Scroll(object sender, EventArgs e)
        {
            _speedMul = _trkSpeed.Value / 10.0;
        }

        private void _chk_CheckedChanged(object sender, EventArgs e)
        {
            _canvas.Invalidate();
        }


        private void Step(double dt)
        {
            if (_W <= 0 || _H <= 0) return;
            _simTime += dt;
            _x += _vx * dt;
            _y += _vy * dt;

            while (_x < _R || _x > _W - _R)
            {
                double wall = _x < _R ? 0 : _W;
                _x = _x < _R ? 2 * _R - _x : 2 * (_W - _R) - _x;
                _vx = -_vx;
                _hits++;
                _hitPoints.Add(new PointF((float)wall, (float)_y));
                _trail.Add(new PointF((float)_x, (float)_y));
            }
            while (_y < _R || _y > _H - _R)
            {
                double wall = _y < _R ? 0 : _H;
                _y = _y < _R ? 2 * _R - _y : 2 * (_H - _R) - _y;
                _vy = -_vy;
                _hits++;
                _hitPoints.Add(new PointF((float)_x, (float)wall));
                _trail.Add(new PointF((float)_x, (float)_y));
            }
            _trail.Add(new PointF((float)_x, (float)_y));

            if (_trail.Count > 5000) _trail.RemoveRange(0, 1000);
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            double dt = _sw.Elapsed.TotalSeconds;
            _sw.Restart();
            if (dt > 0.1) dt = 0.1;
            Step(dt * _speedMul); 
            _canvas.Invalidate();
        }

        private void _btnPlay_Click(object sender, EventArgs e)
        {
            if (_timer.Enabled)
            {
                _timer.Stop();
                _sw.Stop();
                _btnPlay.Text = "Старт";
            }
            else
            {
                _sw.Restart();
                _timer.Start();
                _btnPlay.Text = "Пауза";
            }
        }

        private void _btnStop_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _sw.Stop();
            _btnPlay.Text = "Старт";
            ResetBall();
        }

        private void _canvas_Paint(object sender, PaintEventArgs e)
        {
            if (_W <= 0 || _H <= 0) return;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float scale = Math.Min((_canvas.Width - 40f) / (float)_W,
                                   (_canvas.Height - 40f) / (float)_H);
            if (scale <= 0) return;
            float ox = (_canvas.Width - scale * (float)_W) / 2f;
            float oy = (_canvas.Height - scale * (float)_H) / 2f;
            Func<double, double, PointF> toScreen = (x, y) =>
                new PointF(ox + (float)x * scale, oy + (float)(_H - y) * scale);

            // сітка кожні 50 одиниць
            if (_chkGrid.Checked)
            {
                using (var pen = new Pen(Color.Gainsboro, 1f))
                {
                    for (double gx = 50; gx < _W; gx += 50)
                        g.DrawLine(pen, toScreen(gx, 0), toScreen(gx, _H));
                    for (double gy = 50; gy < _H; gy += 50)
                        g.DrawLine(pen, toScreen(0, gy), toScreen(_W, gy));
                }
            }

            g.DrawRectangle(Pens.Black, ox, oy, scale * (float)_W, scale * (float)_H);

            // слід
            if (_chkTrail.Checked && _trail.Count >= 2)
            {
                var pts = new List<PointF>();
                foreach (PointF p in _trail)
                {
                    PointF s = toScreen(p.X, p.Y);
                    if (pts.Count == 0 ||
                        Math.Abs(s.X - pts[pts.Count - 1].X) > 0.01f ||
                        Math.Abs(s.Y - pts[pts.Count - 1].Y) > 0.01f)
                        pts.Add(s);
                }
                if (pts.Count >= 2)
                    using (var pen = new Pen(Color.CornflowerBlue, 1.5f))
                        g.DrawLines(pen, pts.ToArray());
            }

            // точки ударів з номерами
            if (_chkHits.Checked)
            {
                for (int i = 0; i < _hitPoints.Count; i++)
                {
                    PointF s = toScreen(_hitPoints[i].X, _hitPoints[i].Y);
                    g.FillEllipse(Brushes.OrangeRed, s.X - 3, s.Y - 3, 6, 6);
                    g.DrawString((i + 1).ToString(), Font, Brushes.DarkRed, s.X + 4, s.Y - 14);
                }
            }

            // куля
            PointF c = toScreen(_x, _y);
            float rr = (float)_R * scale;
            g.FillEllipse(Brushes.Black, c.X - rr, c.Y - rr, 2 * rr, 2 * rr);

            // вектор швидкості
            if (_chkVector.Checked)
            {
                using (var pen = new Pen(Color.Firebrick, 2f))
                {
                    pen.CustomEndCap = new AdjustableArrowCap(4, 6);
                    float k = 0.3f * scale;
                    g.DrawLine(pen, c.X, c.Y, c.X + (float)_vx * k, c.Y - (float)_vy * k);
                }
            }

            // інфопанель
            if (_chkInfo.Checked)
            {
                string info = string.Format(
                    "t = {0:F2} с\nx = {1:F1}, y = {2:F1}\n|v| = {3:F1}\nУдарів: {4}",
                    _simTime, _x, _y, Math.Sqrt(_vx * _vx + _vy * _vy), _hits);
                g.DrawString(info, Font, Brushes.Black, 8, 8);
            }
        }
    }
}

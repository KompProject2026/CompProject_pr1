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
            _x = (double)_numX0.Value;
            _y = (double)_numY0.Value;

            // куля має бути повністю всередині коробки
            _x = Math.Max(_R, Math.Min(_W - _R, _x));
            _y = Math.Max(_R, Math.Min(_H - _R, _y));

            double v = (double)_numV.Value;
            double a = (double)_numAngle.Value * Math.PI / 180.0;
            _vx = v * Math.Cos(a);
            _vy = v * Math.Sin(a);

            _trail.Clear();
            _trail.Add(new PointF((float)_x, (float)_y));
            _canvas.Invalidate();
        }

        // один крок моделі; відбиття пружне: міняємо знак компоненти швидкості
        private void Step(double dt)
        {
            _x += _vx * dt;
            _y += _vy * dt;

            // цикли while, щоб великий dt не виводив кулю за стінку
            while (_x < _R || _x > _W - _R)
            {
                if (_x < _R) _x = 2 * _R - _x; else _x = 2 * (_W - _R) - _x;
                _vx = -_vx;
                _trail.Add(new PointF((float)_x, (float)_y));
            }
            while (_y < _R || _y > _H - _R)
            {
                if (_y < _R) _y = 2 * _R - _y; else _y = 2 * (_H - _R) - _y;
                _vy = -_vy;
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
            Step(dt);
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
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // однаковий масштаб по обох осях, щоб куля була круглою
            float scale = Math.Min((_canvas.Width - 40f) / (float)_W,
                                   (_canvas.Height - 40f) / (float)_H);
            if (scale <= 0) return;
            float ox = (_canvas.Width - scale * (float)_W) / 2f;
            float oy = (_canvas.Height - scale * (float)_H) / 2f;

            // Y у Windows іде вниз, тому H - y
            Func<double, double, PointF> toScreen = (x, y) =>
                new PointF(ox + (float)x * scale, oy + (float)(_H - y) * scale);

            // рамка коробки
            g.DrawRectangle(Pens.Black, ox, oy, scale * (float)_W, scale * (float)_H);

            // слід
            if (_trail.Count >= 2)
            {
                var pts = new List<PointF>();
                foreach (PointF p in _trail)
                {
                    PointF s = toScreen(p.X, p.Y);
                    // прибираємо збіжні сусідні точки (інакше GDI+ може видати помилку)
                    if (pts.Count == 0 ||
                        Math.Abs(s.X - pts[pts.Count - 1].X) > 0.01f ||
                        Math.Abs(s.Y - pts[pts.Count - 1].Y) > 0.01f)
                        pts.Add(s);
                }
                if (pts.Count >= 2)
                    using (var pen = new Pen(Color.CornflowerBlue, 1.5f))
                        g.DrawLines(pen, pts.ToArray());
            }

            // куля
            PointF c = toScreen(_x, _y);
            float rr = (float)_R * scale;
            g.FillEllipse(Brushes.Black, c.X - rr, c.Y - rr, 2 * rr, 2 * rr);

            // вектор швидкості
            using (var pen = new Pen(Color.Firebrick, 2f))
            {
                pen.CustomEndCap = new AdjustableArrowCap(4, 6);
                float k = 0.3f * scale;
                g.DrawLine(pen, c.X, c.Y, c.X + (float)_vx * k, c.Y - (float)_vy * k);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

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
            NumericUpDown[] nums = { _numW, _numH, _numX0, _numY0, _numR, _numV, _numAngle };
            foreach (NumericUpDown n in nums)
                n.ValueChanged += _num_ValueChanged;

            _btnSavePng.Click += _btnSavePng_Click;
            ResetBall();
        }

        private void _num_ValueChanged(object sender, EventArgs e)
        {
            ResetBall();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetBall();
        }
        private class CmpRun
        {
            public string Label, Short;
            public List<PointF> Pts;
            public Color Color;
            public double W, H;
        }
        private readonly List<CmpRun> _cmpRuns = new List<CmpRun>();
        private readonly Color[] _cmpColors = { Color.Crimson, Color.SeaGreen, Color.DarkOrange,
    Color.MediumPurple, Color.Teal, Color.Goldenrod, Color.DeepPink, Color.SaddleBrown };

        private List<PointF> SimulatePath(double x, double y, double vx, double vy,
    double R, double W, double H, double tmax, out int hits, out double firstHit)
        {
            var pts = new List<PointF>();
            pts.Add(new PointF((float)x, (float)y));
            hits = 0;
            firstHit = -1;
            double t = 0;
            int guard = 0;
            while (t < tmax && guard++ < 5000)
            {
                double tx = double.MaxValue, ty = double.MaxValue;
                if (vx > 1e-12) tx = (W - R - x) / vx; else if (vx < -1e-12) tx = (R - x) / vx;
                if (vy > 1e-12) ty = (H - R - y) / vy; else if (vy < -1e-12) ty = (R - y) / vy;
                double dt = Math.Min(tx, ty);
                if (dt == double.MaxValue) break;
                if (dt < 0) dt = 0;

                if (t + dt >= tmax)
                {
                    dt = tmax - t;
                    x += vx * dt; y += vy * dt;
                    pts.Add(new PointF((float)x, (float)y));
                    break;
                }
                x += vx * dt; y += vy * dt; t += dt;
                if (firstHit < 0) firstHit = t;
                if (tx <= ty) { vx = -vx; hits++; }
                if (ty <= tx) { vy = -vy; hits++; }
                pts.Add(new PointF((float)x, (float)y));
            }
            return pts;
        }
        private static void DrawPoly(Graphics g, List<PointF> src, Pen pen, Func<double, double, PointF> toScreen)
        {
            var pts = new List<PointF>();
            foreach (PointF p in src)
            {
                PointF s = toScreen(p.X, p.Y);
                if (pts.Count == 0 ||
                    Math.Abs(s.X - pts[pts.Count - 1].X) > 0.01f ||
                    Math.Abs(s.Y - pts[pts.Count - 1].Y) > 0.01f)
                    pts.Add(s);
            }
            if (pts.Count >= 2) g.DrawLines(pen, pts.ToArray());
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

        private void _btnAddCmp_Click(object sender, EventArgs e)
        {
            if (_cmpRuns.Count >= 8)
            {
                MessageBox.Show("Максимум 8 запусків. Очистіть список.", "Порівняння");
                return;
            }
            double W = (double)_numW.Value, H = (double)_numH.Value, R = (double)_numR.Value;
            if (2 * R >= Math.Min(W, H)) return;

            double x0 = Math.Max(R, Math.Min(W - R, (double)_numX0.Value));
            double y0 = Math.Max(R, Math.Min(H - R, (double)_numY0.Value));
            double v = (double)_numV.Value;
            double ang = (double)_numAngle.Value;
            double a = ang * Math.PI / 180.0;
            double tmax = (double)_numTmax.Value;

            int hits; double first;
            List<PointF> pts = SimulatePath(x0, y0, v * Math.Cos(a), v * Math.Sin(a), R, W, H, tmax, out hits, out first);

            var run = new CmpRun();
            run.Pts = pts;
            run.W = W; run.H = H;
            run.Color = _cmpColors[_cmpRuns.Count];
            run.Short = string.Format("v={0}, α={1}°", v, ang);
            run.Label = string.Format("v={0}, α={1}°, r={2}, ({3};{4}), коробка {5}×{6} | ударів за {7} с: {8}, перший удар: {9}",
                v, ang, R, x0, y0, W, H, tmax, hits, first < 0 ? "немає" : first.ToString("F2") + " с");
            _cmpRuns.Add(run);
            _clbCmp.Items.Add(run.Label, true);
            _canvas.Invalidate();
        }

        private void _btnClearCmp_Click(object sender, EventArgs e)
        {
            _cmpRuns.Clear();
            _clbCmp.Items.Clear();
            _canvas.Invalidate();
        }

        private void _clbCmp_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // стан прапорця ще не змінився, тому перемальовуємо після події
            BeginInvoke((Action)(() => _canvas.Invalidate()));
        }

        private void _btnSavePng_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "PNG (*.png)|*.png";
                dlg.FileName = "bounce_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
                if (dlg.ShowDialog() != DialogResult.OK) return;
                try
                {
                    using (var bmp = new Bitmap(_canvas.Width, _canvas.Height))
                    {
                        _canvas.DrawToBitmap(bmp, new Rectangle(0, 0, _canvas.Width, _canvas.Height));
                        bmp.Save(dlg.FileName, ImageFormat.Png);
                    }
                    MessageBox.Show("Збережено: " + dlg.FileName, "Експорт");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка експорту", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            // траєкторії збережених запусків (лише ті, що для поточної коробки)
            for (int i = 0; i < _cmpRuns.Count; i++)
            {
                CmpRun r = _cmpRuns[i];
                if (!_clbCmp.GetItemChecked(i)) continue;
                if (r.W != _W || r.H != _H) continue;
                using (var pen = new Pen(r.Color, 1.5f))
                {
                    pen.DashStyle = DashStyle.Dash;
                    DrawPoly(g, r.Pts, pen, toScreen);
                }
            }
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
            // легенда порівняння
            int ly = 8;
            for (int i = 0; i < _cmpRuns.Count; i++)
            {
                CmpRun r = _cmpRuns[i];
                if (!_clbCmp.GetItemChecked(i) || r.W != _W || r.H != _H) continue;
                using (var pen = new Pen(r.Color, 2f))
                    g.DrawLine(pen, _canvas.Width - 170, ly + 7, _canvas.Width - 145, ly + 7);
                g.DrawString(r.Short, Font, Brushes.Black, _canvas.Width - 140, ly);
                ly += 16;
            }
        }
    }
}

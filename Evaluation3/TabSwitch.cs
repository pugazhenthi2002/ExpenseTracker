using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation3
{
    class TabSwitch:UserControl
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            DoubleBuffered = true;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(Width / 6, Height / 7, Width / 6, Height / 7), 90, 180);
            path.AddArc(new Rectangle(Width * 4 / 6, Height / 7, Width / 6, Height / 7), 270, 180);
            path.CloseFigure();
            path.AddArc(new Rectangle(Width / 6, Height * 3 / 7, Width / 6, Height / 7), 90, 180);
            path.AddArc(new Rectangle(Width * 4 / 6, Height * 3 / 7, Width / 6, Height / 7), 270, 180);
            path.CloseFigure();
            path.AddArc(new Rectangle(Width / 6, Height * 5 / 7, Width / 6, Height / 7), 90, 180);
            path.AddArc(new Rectangle(Width * 4 / 6, Height * 5 / 7, Width / 6, Height / 7), 270, 180);
            path.CloseAllFigures();

            Brush b = new SolidBrush(Color.White);
            g.FillPath(b, path);
            path.Dispose(); b.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            Width = Height;
            this.Invalidate();
        }
    }
}

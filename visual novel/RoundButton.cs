using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_novel
{
    class RoundButton : Button
    {
        private int radius = 10;
        private Color borderColor = Color.Black;
        private int borderThickness = 1;

        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public int BorderThickness
        {
            get { return borderThickness; }
            set
            {
                borderThickness = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 2 * radius, 2 * radius, 180, 90);
            path.AddArc(Width - 2 * radius, 0, 2 * radius, 2 * radius, 270, 90);
            path.AddArc(Width - 2 * radius, Height - 2 * radius, 2 * radius, 2 * radius, 0, 90);
            path.AddArc(0, Height - 2 * radius, 2 * radius, 2 * radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            using (Pen pen = new Pen(borderColor, borderThickness))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}

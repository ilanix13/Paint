using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Paint
{
    class NewPencil : IPaintable
    {
        public Pen pen { get; set; }
        public Brush brush { get; set; }

        List<Point> points  = new List<Point>();

        public NewPencil(Pen pen)
        {
            this.pen = pen;
        }

        public void StartDraw(Point position, Control control)
        {
            points.Add(position);
            points.Add(position);
        }

        public void Drawing(Point position, Control control)
        {
            points.Add(position);
            control.Invalidate();
        }

        public void EndDraw(Point position, Control control)
        {
            control.Invalidate();
        }

        public void Update(Graphics g)
        {
            g.DrawLines(pen, points.ToArray());
        }
    }
}

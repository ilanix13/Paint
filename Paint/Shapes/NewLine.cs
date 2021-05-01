using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class NewLine : IPaintable
    {
        protected Point startPosition;
        protected Point currentPosition;

        public Pen pen { get; set; }
        public Brush brush { get; set; }


        public NewLine(Pen pen)
        {
            this.pen = pen;
        }

        public virtual void StartDraw(Point position, Control control)
        {
            currentPosition = startPosition = position;
        }

        public virtual void Drawing(Point position, Control control)
        {
            currentPosition = position;
            control.Invalidate();
        }

        public virtual void EndDraw(Point position, Control control)
        {
            control.Invalidate();
        }

        public virtual void Update(Graphics g)
        {
            g.DrawLine(pen, startPosition, currentPosition);
        }

    }
}

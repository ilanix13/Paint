using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class NewRectangle: IPaintable
    {
        protected Point startPosition;
        protected Point currentPosition;

        public Pen pen { get; set; }
        public Brush brush { get; set; }

        protected virtual Rectangle GetRectangle
        {
            get
            {
                return new Rectangle(
                Math.Min(startPosition.X, currentPosition.X),
                Math.Min(startPosition.Y, currentPosition.Y),
                Math.Abs(startPosition.X - currentPosition.X),
                Math.Abs(startPosition.Y - currentPosition.Y));
            }
        }

        public NewRectangle(Pen pen, Brush brush)
        {
            this.pen = pen;
            this.brush = brush;
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

        public virtual void Update(Graphics graphics)
        {
            graphics.DrawRectangle(pen, GetRectangle);
            graphics.FillRectangle(brush, GetRectangle);
        }
    }
}

using System.Drawing;

namespace Paint
{
    class NewEllipse : NewRectangle 
    {
        public NewEllipse(Pen pen, Brush brush) : base(pen, brush) {}

        public override void Update(Graphics graphics)
        {
            graphics.DrawEllipse(pen, GetRectangle);
            graphics.FillEllipse(brush, GetRectangle);
        }
    }
}

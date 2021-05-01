using System.Drawing;

namespace Paint
{
    public enum Shape {Pencil, Line, Ellipse, Rectangle}

    static class CreateShapes
    {
        public static Pen pen { get; set; } = Pens.Black;
        public static Brush fillColor { get; set; } = Brushes.Transparent;

        public static IPaintable CreateShape(Shape shapes)
        {
            switch (shapes)
            {
                case Shape.Line:
                    return MakeLine();
                case Shape.Ellipse:
                    return MakeEllipse();
                case Shape.Rectangle:
                    return MakeRectangle();
                case Shape.Pencil:
                default:
                    return MakePencil();
            }
        }

        public static IPaintable MakePencil()
        {
            return new NewPencil(pen);
        }

        public static IPaintable MakeLine()
        {
            return new NewLine(pen);
        }

        public static IPaintable MakeEllipse()
        {
            return new NewEllipse(pen, fillColor);
        }

        public static IPaintable MakeRectangle()
        {
            return new NewRectangle(pen, fillColor);
        }
    }
}
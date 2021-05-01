using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    interface IPaintable
    {
        Pen pen { get; set; }
        Brush brush { get; set;}

        void StartDraw(Point position, Control control);      
        void Drawing(Point position, Control control);       
        void EndDraw(Point position, Control control);
        void Update(Graphics graphics);
    }
}

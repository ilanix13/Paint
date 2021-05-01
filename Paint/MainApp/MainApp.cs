using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Paint
{
    public partial class MainApp : Form
    {
        List<IPaintable> DrawingShapes = new List<IPaintable>();
        List<IPaintable> RemovedShapes = new List<IPaintable>();

        IPaintable shape;
        Shape currentShape;
        bool IsChange = false;
        Color penColor = Color.Black, brushColor = Color.White, newColor;

        public MainApp()
        {
            InitializeComponent();
            comboBoxThick.SelectedIndex = 0;
        }

        #region menu
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.BMP; *.JPG)| *.BMP; *.JPG";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    CanvasClean();
                    MemoryStream memoryStream = new MemoryStream();
                    using (FileStream stream = File.OpenRead(open.FileName))
                    {
                        stream.CopyTo(memoryStream);
                        Canvas.Image = Bitmap.FromStream(memoryStream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Bitmap bitmap = new Bitmap(Canvas.Width, Canvas.Height))
                {
                    Canvas.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "Bitmap Picture (*.BMP)| *.BMP";
                    save.FileName = "image_" + DateTime.Now.ToString("yyyy-dd-MM_HH-mm-ss");

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        bitmap.Save(save.FileName);
                        MessageBox.Show("Изображение сохранено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region draw
        public void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            shape = CreateShapes.CreateShape(currentShape);
            shape.pen = new Pen(penColor, int.Parse(comboBoxThick.Text));
            shape.brush = new SolidBrush(brushColor);
            shape.StartDraw(e.Location, Canvas);
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && shape != null)
                shape.Drawing(e.Location, Canvas);
        }
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (shape != null)
            {
                shape.EndDraw(e.Location, Canvas);
                DrawingShapes.Add(shape);
                shape = null;
            }
        }
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (DrawingShapes.Count != 0)
            {
                DrawingShapes.ForEach(x => x.Update(e.Graphics));
            }

            if (shape != null)
            {
                shape.Update(e.Graphics);
            }
        }
        #endregion

        #region shapes
        private void btnPencil_Click(object sender, EventArgs e)
        {
            var penc = Shape.Pencil;
            currentShape = penc;
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            var line = Shape.Line;
            currentShape = line;
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            var rect = Shape.Rectangle;
            currentShape = rect;
        }
        private void btnEllipse_Click(object sender, EventArgs e)
        {
            var el = Shape.Ellipse;
            currentShape = el;
        }
        #endregion

        #region options
        private void CanvasClean()
        {
            DrawingShapes.Clear();
            Canvas.BackColor = Color.White;
            Canvas.Image = null;
            Canvas.BackgroundImage = null;
            Canvas.Invalidate();
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                if (!IsChange)
                {
                    btnPenColor.BackColor = penColor = colorDlg.Color;
                }

                else
                {
                    btnBrushColor.BackColor = brushColor = colorDlg.Color;
                }
            }
        }
        private void btnCanvaColor_Click(object sender, EventArgs e)
        {
            Control cntrl = sender as Control;
            ColorDialog colorDlg = new ColorDialog();

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                cntrl.BackColor = colorDlg.Color;
                Canvas.BackColor = ((Button)sender).BackColor = colorDlg.Color;
            }
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            Control cntrl = sender as Control;
            ColorDialog colorDlg = new ColorDialog();

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                cntrl.BackColor = colorDlg.Color;
                ((Button)sender).BackColor = colorDlg.Color;
            }
        }
        private void chkFill_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFill.Checked == true)
            {
                brushColor = Color.Transparent;
                btnBrushColor.Enabled = false;
            }

            else if (chkFill.Checked == false)
            {
                brushColor = btnBrushColor.BackColor;
                btnBrushColor.Enabled = true;
            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            CanvasClean();
        }
        private void changeColor(object sender, EventArgs e)
        {
            newColor = ((Button)sender).BackColor;

            if (!IsChange)
            {
                btnPenColor.BackColor = penColor = newColor;
            }

            else
            {
                btnBrushColor.BackColor = brushColor = newColor;
            }
        }
        private void btnPen_Click(object sender, EventArgs e)
        {
            IsChange = false;
        }
        private void btnBrush_Click(object sender, EventArgs e)
        {
            IsChange = true;

        }
        #endregion

        #region undo/redo
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (DrawingShapes.Count > 0)
            {
                IPaintable shape = DrawingShapes.Last();
                RemovedShapes.Add(shape);
                DrawingShapes.Remove(shape);
                Canvas.Invalidate();
            }
        }
        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (RemovedShapes.Count > 0)
            {
                IPaintable shape = RemovedShapes.Last();
                DrawingShapes.Add(shape);
                RemovedShapes.Remove(shape);
                Canvas.Invalidate();
            }
        }
        #endregion
    }
}
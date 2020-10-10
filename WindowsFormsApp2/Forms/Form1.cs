using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        ShapeType shapeType;
        System.Drawing.Rectangle rectangle_bounds = new System.Drawing.Rectangle();
        List<IShape> shapes = new List<IShape>();
        List<IShape> removedShapes = new List<IShape>();

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void drawing_Canvas(object sender, PaintEventArgs e)
        {
            redraw();
        }

        private void freeDrawButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            shapeType = ShapeType.Free;
        }
        private void elipseButton(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            shapeType = ShapeType.Circle;
        }
        private void mouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            this.rectangle_bounds.Location = e.Location;

        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (shapeType == ShapeType.Free)
            {
                if (moving && x != -1 && y != -1)
                {
                    Options options = new Options();
                    options.X = x;
                    options.Y = y;
                    options.Location = e.Location;
                    AbstractFactory shapeFactory1 = FactoryProducer.getFactory(shapeType, pen, options, g);
                    IShape shape1 = shapeFactory1.getShape(shapeType);
                    shapes.Add(shape1);
                    redraw();
                }
            }

            x = e.X;
            y = e.Y;

        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            this.rectangle_bounds.Size = new Size(e.X - this.rectangle_bounds.X, e.Y - this.rectangle_bounds.Y);
            if (shapeType != ShapeType.Free)
            {
                if (moving && x != -1 && y != -1)
                {
                    Options options = new Options();
                    options.RectangleBounds = rectangle_bounds;

                    AbstractFactory shapeFactory = FactoryProducer.getFactory(shapeType, pen, options, g);
                    IShape shape = shapeFactory.getShape(shapeType);
                    shapes.Add(shape);
                    redraw();
                }
            }
            moving = false;
            x = -1;
            y = -1;

        }

        private void rectangleButton(object sender, EventArgs e)
        {
            Button d = (Button)sender;
            shapeType = ShapeType.Square;
        }

        public void redraw()
        {
            foreach (var item in shapes)
            {
                item.Draw();
            }

            panel1.Focus();
        }

        private void panel1_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Z && e.Control)
            {
                if (shapes.Count == 0)
                {
                    return;
                }
                IShape lastShape = shapes.Last();
                shapes.Remove(lastShape);
                removedShapes.Add(lastShape);
                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.Y && e.Control)
            {
                if (removedShapes.Count==0)
                {
                    return;
                }
                IShape lastShape = removedShapes.Last();
                removedShapes.Remove(lastShape);
                shapes.Add(lastShape);
                panel1.Invalidate();
            }
        }
    }
}

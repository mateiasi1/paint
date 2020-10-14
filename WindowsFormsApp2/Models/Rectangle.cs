using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Rectangle : IShape
    {
        Options options;
        Graphics g;
        Pen pen;
        ShapeType shapeType;
        public Rectangle(ShapeType ShapeType, Pen Pen,Options Options, Graphics G)
        {
            options = Options;
            g = G;
            pen = Pen;
            shapeType = ShapeType;
        }
        public void Draw()
        {
            g.DrawRectangle(pen, options.RectangleBounds);
        }

        public Options GetOptions(IShape shape)
        {
            return options;
        }

        public IShape MoveShape(Point point, IShape shape)
        {
            options.RectangleBounds = new System.Drawing.Rectangle(point.X, point.Y, options.RectangleBounds.Width, options.RectangleBounds.Height);
            return shape;
        }

        public IShape RotateShape(float angle, IShape shape)
        {
            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(options.RectangleBounds.Left + (options.RectangleBounds.Width / 2),
                                          options.RectangleBounds.Top + (options.RectangleBounds.Height / 2)));
                g.Transform = m;
            }
            return shape;
        }
    }
}

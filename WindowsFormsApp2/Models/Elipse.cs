using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Elipse : IShape
    {
        Options options;
        Graphics g;
        Pen pen;
        ShapeType shapeType;
        public Elipse(ShapeType ShapeType, Pen Pen, Options Options, Graphics G)
        {
            options = Options;
            g = G;
            pen = Pen;
            shapeType = ShapeType;
        }
        public void Draw()
        {
            g.DrawEllipse(pen, options.RectangleBounds);
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
    }
}

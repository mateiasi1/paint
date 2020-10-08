using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class ShapeComplexFactory : AbstractFactory
    {
        public ShapeType shapeType { get; set; }
        public Pen pen { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public Graphics g { get; set; }

        public ShapeComplexFactory(ShapeType ShapeType, Pen Pen, int X, int Y, float Width, float Height, Graphics G, System.Windows.Forms.MouseEventArgs e)
        {
            shapeType = ShapeType;
            pen = Pen;
            x = X;
            y = Y;
            width = Width;
            height = Height;
            g = G;

        }
        public override IShape getShape(ShapeType shapeType)
        {
            return null;

        }

        public override IShape getComplexShape(ShapeType shapeType)
        {
            if (shapeType == ShapeType.Circle)
            {
                return new Circle(shapeType, pen, x, y, 50, 50, g);
            }
            else if (shapeType == ShapeType.Square)
            {
                return new Square(shapeType, pen, x, y, 50, 50, g);
            }
            return null;
        }
    }
}

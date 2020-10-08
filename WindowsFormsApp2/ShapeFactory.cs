using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class ShapeFactory : AbstractFactory
    {
        public ShapeType shapeType { get; set; }
        public Pen pen { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public Graphics g { get; set; }
        public Point e { get; set; }

        public ShapeFactory(ShapeType shapeType, Pen pen, int x, int y, Graphics g, Point e)
        {
            this.shapeType = shapeType;
            this.pen = pen;
            this.x = x;
            this.y = y;
            this.g = g;
            this.e = e;
        }

        public override IShape getShape(ShapeType shapeType)
        {
            if (shapeType == ShapeType.Free)
            {
                return new Line(shapeType, pen, x, y, g, e);
            }
            return null;
        }

        public override IShape getComplexShape(ShapeType shapeType)
        {
            return null;
        }
    }
    
}

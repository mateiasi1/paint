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
        List<object> options = new List<object>();
        Pen pen;

        public ShapeFactory(ShapeType shapeType, Pen Pen, List<object> List)
        {
            options = List;
            pen = Pen;
        }

        public override IShape getShape(ShapeType shapeType)
        {
            if (shapeType == ShapeType.Free)
            {
                return new Line(pen, options);
            }
            else if (shapeType == ShapeType.Circle)
            {
                return new Elipse(pen, options);
            }
            else if (shapeType == ShapeType.Square)
            {
                return new Rectangle(pen, options);
            }
            return null;
        }

    }
    
}

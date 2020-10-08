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
        List<object> list = new List<object>();

        public ShapeFactory(List<object> List)
        {
            list = List;
        }

        public override IShape getShape(ShapeType shapeType)
        {
            if (shapeType == ShapeType.Free)
            {
                return new Line(list);
            }
            else if (shapeType == ShapeType.Circle)
            {
                return new Elipse(list);
            }
            else if (shapeType == ShapeType.Square)
            {
                return new Rectangle(list);
            }
            return null;
        }

    }
    
}

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
                return new Line((ShapeType)list.ElementAtOrDefault(0), (Pen)list.ElementAtOrDefault(1), (int)list.ElementAtOrDefault(2), (int)list.ElementAtOrDefault(3), (Graphics)list.ElementAtOrDefault(4), (Point)list.ElementAtOrDefault(5));
            }
            else if (shapeType == ShapeType.Circle)
            {
                return new Circle((ShapeType)list.ElementAtOrDefault(0), (Pen)list.ElementAtOrDefault(1), (int)list.ElementAtOrDefault(2), (int)list.ElementAtOrDefault(3), (int)list.ElementAtOrDefault(4), (int)list.ElementAtOrDefault(5), (Graphics)list.ElementAtOrDefault(6));
            }
            else if (shapeType == ShapeType.Square)
            {
                return new Square((ShapeType)list.ElementAtOrDefault(0), (Pen)list.ElementAtOrDefault(1), (int)list.ElementAtOrDefault(2), (int)list.ElementAtOrDefault(3), (int)list.ElementAtOrDefault(4), (int)list.ElementAtOrDefault(5), (Graphics)list.ElementAtOrDefault(6));
            }
            return null;
        }

    }
    
}

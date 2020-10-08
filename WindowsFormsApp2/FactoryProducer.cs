using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(ShapeType shapeType, Pen pen, Options options, Graphics g)
        {
            return new ShapeFactory(shapeType, pen, options, g);
        }


    }
}

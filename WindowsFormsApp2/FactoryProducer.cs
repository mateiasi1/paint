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
        public static AbstractFactory getFactory(ShapeType ShapeType, Pen Pen, int X, int Y,float Width, float Height, Graphics G, MouseEventArgs E)
        {
            return new  ShapeComplexFactory(ShapeType,  Pen,  X,  Y, Width, Height, G,  E);
        }

        internal static AbstractFactory getFactory(ShapeType ShapeType, Pen Pen, int X, int Y, Point E, Graphics G)
        {
            return new ShapeFactory(ShapeType, Pen, X, Y, G, E);
        }
    }
}

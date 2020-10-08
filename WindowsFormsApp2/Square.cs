using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Square : Shape
    {
        public Square(int X, int Y, bool Moving, int Width, int Height, Graphics G, Pen Pen)
        {
            x = X;
            y = Y;
            moving = Moving;
            width = Width;
            height = Height;
            g = G;
            pen = Pen;
        }
        public override void Draw()
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawRectangle(pen, x, y, width, height);

            }
        }
    }
}

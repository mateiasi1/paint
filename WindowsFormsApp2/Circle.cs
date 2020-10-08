using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Circle : Shape
    {
        public MouseEventArgs e { get; set; }
        public Circle(int X, int Y, bool Moving, int Width, int Height, MouseEventArgs E, Graphics G, Pen Pen)
        {
            x = X;
            y = Y;
            moving = Moving;
            width = Width;
            height = Height;
            g = G;
            pen = Pen;
            e = E;
        }

        public override void Draw()
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawEllipse(pen, x, y, width, height);

            }
        }
    }
}

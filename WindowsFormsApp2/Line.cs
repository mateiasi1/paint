using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Line : Shape
    {
        public MouseEventArgs e { get; set; }
        public Line(int X, int Y, bool Moving, MouseEventArgs E, Graphics G, Pen Pen)
        {
            x = X;
            y = Y;
            moving = Moving;
            g = G;
            pen = Pen;
            e = E;

        }
        public override void Draw()
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);

            }
        }
    }
}

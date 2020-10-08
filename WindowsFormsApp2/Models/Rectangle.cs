using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Rectangle : IShape
    {
        Options options;
        Graphics g;
        Pen pen;
        public Rectangle(Pen Pen,Options Options, Graphics G)
        {
            options = Options;
            g = G;
            pen = Pen;
        }
        public void Draw()
        {
            g.DrawRectangle(pen, options.RectangleBounds);
        }
    }
}

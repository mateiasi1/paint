using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Line : IShape
    {

        public Point eve { get; set; }
        public ShapeType shapeType { get; set; }
        public Pen pen { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Graphics g { get; set; }

        public Line(ShapeType ShapeType,Pen Pen, int X, int Y, Graphics G, Point e)
        {
            shapeType = ShapeType;
            pen = Pen;
            x = X;
            y = Y;
            g = G;
            eve = e;
        }

        public void Draw()
        {
            g.DrawLine(pen, new Point( x, y), eve);
        }
    }
}

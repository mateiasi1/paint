using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Square : IShape
    {
        public ShapeType shapeType { get; set; }
        public Pen pen { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public Graphics g { get; set; }
        public Square(ShapeType ShapeType, Pen Pen, int X, int Y, float Width, float Height, Graphics G)
        {
            shapeType = ShapeType;
            pen = Pen;
            x = X;
            y = Y;
            width = Width;
            height = Height;
            g = G;
        }
        public void Draw()
        {
            g.DrawRectangle(pen, x, y, width, height);
        }
    }
}

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
        Graphics g;
        Pen pen;
        List<object> options = new List<object>();
        public Line(Pen Pen,List<object> List)
        {
            options = List;
            g = (Graphics)options.ElementAtOrDefault(2);
            pen = Pen;
        }

        public void Draw()
        {
            g.DrawLine(pen, new Point((int)options.ElementAtOrDefault(0), (int)options.ElementAtOrDefault(1)), (Point)options.ElementAtOrDefault(3));
        }
    }
}

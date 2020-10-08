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
        List<object> list = new List<object>();
        public Line(List<object> List)
        {
            list = List;
            g = (Graphics)list.ElementAtOrDefault(4);
        }

        public void Draw()
        {
            g.DrawLine((Pen)list.ElementAtOrDefault(1), new Point((int)list.ElementAtOrDefault(2), (int)list.ElementAtOrDefault(3)), (Point)list.ElementAtOrDefault(5));
        }
    }
}

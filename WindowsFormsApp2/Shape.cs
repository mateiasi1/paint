using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public abstract class Shape
    {
        public int x { get; set; }
        public int y { get; set; }
        public bool moving { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Graphics g { get; set; }
        public Pen pen { get; set; }
        public virtual void Draw() { }
    }
}

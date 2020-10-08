﻿using System;
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
        List<object> options;
        Graphics g;
        Pen pen;
        public Rectangle(Pen Pen,List<object> List)
        {
            options = List;
            g = (Graphics)options.ElementAtOrDefault(4);
            pen = Pen;
        }
        public void Draw()
        {
            g.DrawRectangle(pen, (System.Drawing.Rectangle)options.ElementAtOrDefault(5));
        }
    }
}

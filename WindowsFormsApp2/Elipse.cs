﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Elipse : IShape
    {
        List<object> list;
        Graphics g;
        public Elipse(List<object> List)
        {
            list = List;
            g = (Graphics)list.ElementAtOrDefault(6);
        }
        public void Draw()
        {
            g.DrawEllipse((Pen)list.ElementAtOrDefault(1), (System.Drawing.Rectangle)list.ElementAtOrDefault(7));
        }

    }
}
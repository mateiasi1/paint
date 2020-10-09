﻿using System;
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
        Options options;
        public Line(Pen Pen,Options Options, Graphics G)
        {
            options = Options;
            g = G;
            pen = Pen;
        }

        public void Draw()
        {
            g.DrawLine(pen, new Point(options.X, options.Y), options.Location);
        }
    }
}
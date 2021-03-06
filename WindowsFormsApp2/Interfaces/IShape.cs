﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public interface IShape
    {
        void Draw();
        Options GetOptions(IShape shape);
        IShape MoveShape(Point point, IShape shape);
        IShape RotateShape(float angle, IShape shape);
    }
}

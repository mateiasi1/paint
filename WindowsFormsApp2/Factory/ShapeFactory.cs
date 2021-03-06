﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class ShapeFactory : AbstractFactory
    {
        Options options;
        Pen pen;
        Graphics g;

        public ShapeFactory(ShapeType shapeType, Pen Pen, Options Options, Graphics G)
        {
            options = Options;
            pen = Pen;
            g = G;
        }

        public override IShape getShape(ShapeType shapeType)
        {
            if (shapeType == ShapeType.Free)
            {
                return new Line(shapeType, pen, options, g);
            }
            else if (shapeType == ShapeType.Circle)
            {
                return new Elipse(shapeType, pen, options, g);
            }
            else if (shapeType == ShapeType.Square)
            {
                return new Rectangle(shapeType, pen, options, g);
            }
            return null;
        }

    }

}

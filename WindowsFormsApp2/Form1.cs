﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        ShapeType shapeType;
        Rectangle rectangle_bounds = new Rectangle();

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            shapeType = ShapeType.Free;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            shapeType = ShapeType.Circle;
        }
        private void mouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            this.rectangle_bounds.Location = e.Location;
           
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (shapeType == ShapeType.Free)
            {
                if (moving && x != -1 && y != -1)
                {
                    List<object> list = new List<object>();
                    list.Add(shapeType);
                    list.Add(pen);
                    list.Add(x);
                    list.Add(y);
                    list.Add(g);
                    list.Add(e.Location);
                    AbstractFactory shapeFactory1 = FactoryProducer.getFactory(list);
                    IShape shape1 = shapeFactory1.getShape(shapeType);
                    shape1.Draw();
                }
            }

            x = e.X;
            y = e.Y;

        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            this.rectangle_bounds.Size = new Size(e.X - this.rectangle_bounds.X, e.Y - this.rectangle_bounds.Y);
            if (shapeType != ShapeType.Free)
            {
                if (moving && x != -1 && y != -1)
                {
                    List<object> list = new List<object>();
                    list.Add(shapeType);
                    list.Add(pen);
                    list.Add(x);
                    list.Add(y);
                    list.Add(50);
                    list.Add(50);
                    list.Add(g);
                    list.Add(rectangle_bounds);

                    AbstractFactory shapeFactory = FactoryProducer.getFactory(list);
                    IShape shape = shapeFactory.getShape(shapeType);
                    shape.Draw();

                }
            }
            moving = false;
            x = -1;
            y = -1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button d = (Button)sender;
            shapeType = ShapeType.Square;
        }
    }
}

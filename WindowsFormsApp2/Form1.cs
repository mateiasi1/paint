using System;
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
        PenType penType;
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
            penType = PenType.Free;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            penType = PenType.Circle;
        }
        private void mouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            if (penType is PenType.Circle)
            {
                Circle circle = new Circle(x, y, moving, 200, 200, e, g, pen);
                circle.Draw();


            }
            else if (penType is PenType.Square)
            {
                Square square = new Square(x, y, moving, 200, 200, g, pen);
                square.Draw();
            }
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (penType is PenType.Free)
            {
                Line line = new Line(x, y, moving, e, g, pen);
                line.Draw();
                x = e.X;
                y = e.Y;
            }
            
            
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button d = (Button)sender;
            penType = PenType.Square;
        }
    }
}

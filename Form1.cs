using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLappolainen3
{
    public partial class Form1 : Form
    {
            int X, Y, dX, dY;
            int LastClicked = 0;
            bool RectangleClicked, CircleClicked, SquareClicked = false;
            int RectangleX, CircleX2, SquareX3, RectangleY, CircleY2, SquareY3 = 0;

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, Circle);
            e.Graphics.FillRectangle(Brushes.Blue, Square);
            e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (CircleClicked)
            {
                Circle.X = e.X - CircleX2;
                Circle.Y = e.Y - CircleY2;
                pictureBox1.Invalidate();
            }
            if (RectangleClicked)
            {
                Rectangle.X = e.X - RectangleX;
                Rectangle.Y = e.Y - RectangleY;
                pictureBox1.Invalidate();
            }
            if (SquareClicked)
            {
                Square.X = e.X - SquareX3;
                Square.Y = e.Y - SquareY3;
                pictureBox1.Invalidate();
            }

            if((label1.Location.X < Square.X + Square.Width)&&(label1.Location.X > Square.X))
            {
                if((label1.Location.Y < Square.Y + Square.Height)&&(label1.Location.Y > Square.Y))
                {
                    label3.Text = "Cиний квадрат";
                    label2.Text = "Квадрат";
                    label1.Text = "Синий";
                }
            }
            if ((label1.Location.X < Rectangle.X + Rectangle.Width) && (label1.Location.X > Rectangle.X))
            {
                if ((label1.Location.Y < Rectangle.Y + Rectangle.Height) && (label1.Location.Y > Rectangle.Y))
                {
                    label3.Text = "Жёлтый прямоугольник";
                    label2.Text = "Прямоугольник";
                    label1.Text = "Жёлтый";
                }
            }
            if ((label1.Location.X < Circle.X + Circle.Width) && (label1.Location.X > Circle.X))
            {
                if ((label1.Location.Y < Circle.Y + Circle.Height) && (label1.Location.Y > Circle.Y))
                {
                    label3.Text = "Красный круг";
                    label2.Text = "Круг";
                    label1.Text = "Красный";
                }
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            RectangleClicked = false;
            CircleClicked = false;
            SquareClicked = false;

            if (LastClicked == 2)
            {
                if((label2.Location.X < Circle.X + Circle.Width)&&(label2.Location.X > Circle.X))
                {
                    if((label2.Location.Y < Circle.Y + Circle.Height)&&(label2.Location.Y > Circle.Y))
                    {
                        X = Circle.X;
                        Y = Circle.Y;
                        dX = CircleX2;
                        dY = CircleY2;
                        Circle.X = Square.X;
                        Circle.X = Square.X;
                        CircleX2 = SquareX3;
                        CircleY2 = SquareY3;

                        Square.X = X;
                        Square.Y = Y;
                        SquareX3 = dX;
                        SquareY3 = dY;
                    }
                }
            }
        }

        private void PictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {

        }

             Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
            Rectangle Circle = new Rectangle(220,10,150,150);
            Rectangle Square = new Rectangle(380,10,150,150);
        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseDown += PictureBox1_MouseDown;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < Rectangle.X + Rectangle.Width)&&(e.X> Rectangle.X))
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height)&&(e.Y > Rectangle.Y))
                {
                    RectangleClicked = true;

                    RectangleX = e.X - Rectangle.X;
                    RectangleY = e.Y - Rectangle.Y;
                }
            }
            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    CircleClicked = true;

                    CircleX2 = e.X - Circle.X;
                    CircleY2 = e.Y - Circle.Y;
                }
            }
            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    SquareClicked = true;

                    SquareX3 = e.X - Square.X;
                    SquareY3 = e.Y - Square.Y;
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

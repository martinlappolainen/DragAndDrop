using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LabLappolainen3
{
    public partial class Form1 : Form
    {
        /*int X, Y, dX, dY;
        int LastClicked = 0*/
        bool RectangleClicked, CircleClicked, SquareClicked = false;
        int RectangleX, CircleX2, SquareX3, RectangleY, CircleY2, SquareY3 = 0;
        private Random Rand = new Random();

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.FromArgb(255,
           255 * Rand.Next(2),
           255 * Rand.Next(2),
           255 * Rand.Next(2));

            using (Brush brush = new SolidBrush(color))
            {
                e.Graphics.FillEllipse(brush, Circle);
                e.Graphics.FillRectangle(Brushes.Green, Square);
                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
            }
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

            if ((label2.Location.X < Square.X + Square.Width) && (label2.Location.X > Square.X))
            {
                if ((label2.Location.Y < Square.Y + Square.Height) && (label2.Location.Y > Square.Y))
                {
                    label5.Text = "Молодец ты выбрал правильную фигуру";

                    Square.X = 300;
                    Square.Y = 349;
                    SquareClicked = false;
                }
            }
            if ((label3.Location.X < Rectangle.X + Rectangle.Width) && (label3.Location.X > Rectangle.X))
            {
                if ((label3.Location.Y < Rectangle.Y + Rectangle.Height) && (label3.Location.Y > Rectangle.Y))
                {
                    label5.Text = "Молодец ты выбрал правильную фигуру";
                    Rectangle.X = 546;
                    Rectangle.Y = 349;

                    RectangleClicked = false;
                }
            }
            if ((label1.Location.X < Circle.X + Circle.Width) && (label1.Location.X > Circle.X))
            {
                if ((label1.Location.Y < Circle.Y + Circle.Height) && (label1.Location.Y > Circle.Y))
                {
                    label5.Text = "Молодец ты выбрал правильную фигуру";
                    Circle.X = 83;
                    Circle.Y = 349;

                    CircleClicked = false;
                }
            }
            if ((label3.Location.X < Square.X + Square.Width) && (label3.Location.X > Square.X))
            {
                if ((label3.Location.Y < Square.Y + Square.Height) && (label3.Location.Y > Square.Y))
                {
                    Square.X = 363;
                    Square.Y = 33;
                    label5.Text = "Не правильно, попробуй снова";
                }
            }
            if ((label3.Location.X < Circle.X + Circle.Width) && (label3.Location.X > Circle.X))
            {
                if ((label3.Location.Y < Circle.Y + Circle.Height) && (label3.Location.Y > Circle.Y))
                {
                    Circle.X = 210;
                    Circle.Y = 33;
                    label5.Text = "Не правильно, попробуй снова";
                }
            }
            if ((label2.Location.X < Circle.X + Circle.Width) && (label2.Location.X > Circle.X))
            {
                if ((label2.Location.Y < Circle.Y + Circle.Height) && (label2.Location.Y > Circle.Y))
                {
                    Circle.X = 210;
                    Circle.Y = 33;
                    label5.Text = "Не правильно, попробуй снова";
                }
            }
            if ((label2.Location.X < Rectangle.X + Rectangle.Width) && (label2.Location.X > Rectangle.X))
            {
                if ((label2.Location.Y < Rectangle.Y + Rectangle.Height) && (label2.Location.Y > Rectangle.Y))
                {
                    Rectangle.X = 23;
                    Rectangle.Y = 33;
                    label5.Text = "Не правильно, попробуй снова";
                }
            }
            if ((label1.Location.X < Square.X + Square.Width) && (label1.Location.X > Square.X))
            {
                if ((label1.Location.Y < Square.Y + Square.Height) && (label1.Location.Y > Square.Y))
                {
                    Square.X = 363;
                    Square.Y = 33;
                    label5.Text = "Не правильно, попробуй снова";
                }
            }
            if ((label1.Location.X < Rectangle.X + Rectangle.Width) && (label1.Location.X > Rectangle.X))
            {
                if ((label1.Location.Y < Rectangle.Y + Rectangle.Height) && (label1.Location.Y > Rectangle.Y))
                {
                    Rectangle.X = 23;
                    Rectangle.Y = 33;
                    label5.Text = "Не правильно, попробуй снова";
                }
            }



            /*if ((CircleClicked && SquareClicked && RectangleClicked))
            {
                label5.Text = "Молодец, ты умный";
            }*/
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            RectangleClicked = false;
            CircleClicked = false;
            SquareClicked = false;


            /*if (LastClicked == 2)
            {
                if((label2.Location.X < Circle.X + Circle.Width)&&(label2.Location.X > Circle.X))
                {
                    if((label2.Location.Y < Circle.Y + Circle.Height)&&(label2.Location.Y > Circle.Y))
                    {
                        X = Circle.X;
                        Y = Circle.Y;
                        dX = CircleX2;
                        dY = CircleY2;
                        Circle.X = Rectangle.X;
                        Circle.Y = Rectangle.Y;
                        CircleX2 = RectangleX;
                        CircleY2 = RectangleY;

                        Rectangle.X = X;
                        Rectangle.Y = Y;
                        RectangleX = dX;
                        RectangleY = dY;
                    }
                }
            }
            if (LastClicked == 3)
            {
                if((label2.Location.X < Square.X + Square.Width)&&(label2.Location.X > Square.X))
                {
                    if((label2.Location.Y < Square.Y + Square.Height)&&(label2.Location.Y > Square.Y))
                    {
                        X = Square.X;
                        Y = Square.Y;
                        dX = SquareX3;
                        dY = SquareY3;
                        Square.X = Circle.X;
                        Square.Y = Circle.Y;
                        SquareX3 = CircleX2;
                        SquareY3 = CircleY2;

                        Circle.X = X;
                        Circle.Y = Y;
                        CircleX2 = dX;
                        CircleY2 = dY;
                    }
                }
            }
            if (LastClicked == 1)
            {
                if ((label2.Location.X < Rectangle.X + Rectangle.Width) && (label2.Location.X > Rectangle.X))
                {
                    if ((label2.Location.Y < Rectangle.Y + Rectangle.Height) && (label2.Location.Y > Rectangle.Y))
                    {
                        X = Rectangle.X;
                        Y = Rectangle.Y;
                        dX = RectangleX;
                        dY = RectangleY;
                        Rectangle.X = Square.X;
                        Rectangle.Y = Square.Y;
                        RectangleX = SquareX3;
                        RectangleY = SquareY3;

                        Square.X = X;
                        Square.Y = Y;
                        SquareX3 = dX;
                        SquareY3 = dY;
                    }
                }
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {

        }
        

        
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150); 
        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            


        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            

            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X))
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    RectangleClicked = true;

                    RectangleX = e.X - Rectangle.X;
                    RectangleY = e.Y - Rectangle.Y;
                    //LastClicked = 1;
                }
            }
            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    CircleClicked = true;

                    CircleX2 = e.X - Circle.X;
                    CircleY2 = e.Y - Circle.Y;
                    //LastClicked = 2;
                }
            }
            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    SquareClicked = true;

                    SquareX3 = e.X - Square.X;
                    SquareY3 = e.Y - Square.Y;
                    //LastClicked = 3;
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

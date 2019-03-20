using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBalls
{
    public partial class MainScreen : UserControl
    {
        SolidBrush drawBrush = new SolidBrush(Color.White);
        List<Ball> ballsList = new List<Ball>();
        List<Ball> shadowList = new List<Ball>();
        Random randGen = new Random();

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Click(object sender, EventArgs e)
        {
            Point clickPoint = Cursor.Position;

            int xSpeed, ySpeed;

            do
            {
                xSpeed = randGen.Next(-8, 9);
                ySpeed = randGen.Next(-8, 9);
            }
            while (xSpeed == 0 || ySpeed == 0);

            Color ballColour = Color.FromArgb(255, randGen.Next(0, 256), randGen.Next(0, 256), randGen.Next(0, 256));

            int size;

            do
            {
                size = randGen.Next(20, 50);
            }
            while (size % 2 != 1);

            Form f = this.FindForm();
            Rectangle clickRectangle = new Rectangle(clickPoint.X - f.Location.X, clickPoint.Y - f.Location.Y, 1, 1);

            Rectangle tempRectangle = new Rectangle(clickPoint.X - f.Location.X - size / 2, clickPoint.Y - f.Location.Y - size / 2, size, size);

            Ball b1 = new Ball(tempRectangle, xSpeed, ySpeed, ballColour);

            bool collision = false;

            for (int i = 0; i < ballsList.Count; i++)
            {
                if (ballsList[i].rectangle.IntersectsWith(clickRectangle))
                {
                    ballsList.Remove(ballsList[i]);
                    shadowList.Remove(shadowList[i]);
                    collision = true;
                }
            }

            if (collision == false)
            {
                b1.rectangle = new Rectangle(clickPoint.X - f.Location.X - size / 2, clickPoint.Y - f.Location.Y - size / 2, size, size);

                ballsList.Add(b1);

                Ball b2 = new Ball(b1.rectangle, xSpeed, ySpeed, ballColour);

                b2.rectangle.X += 5;
                b2.rectangle.Y += 5;

                b2.colour = Color.Silver;
                shadowList.Add(b2);

                //add a number of balls on the screen
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //collideIndex = ballsList.FindIndex(f => f.xSpeed == 7);

            for (int i = 0; i < ballsList.Count; i++)
            {
                ballsList[i].Collide(this);

                if (ballsList.Count > 1)
                {
                    for (int j = i + 1; j <= ballsList.Count - 1; j++)
                    {
                        ballsList[i].Collide(ballsList[j]);
                    }
                }
            }

            for (int i = 0; i<shadowList.Count; i++)
            {
                shadowList[i].xSpeed = ballsList[i].xSpeed;
                shadowList[i].ySpeed = ballsList[i].ySpeed;
            }

            //?????
            foreach (Ball b in ballsList)
            {
                b.Move();
            }

            for (int i = 0; i < shadowList.Count; i++)
            {
                Rectangle shadowRec = new Rectangle(ballsList[i].rectangle.X + 5, ballsList[i].rectangle.Y + 5, ballsList[i].rectangle.Height, ballsList[i].rectangle.Height);
                shadowList[i].rectangle = shadowRec;
            }

            Refresh();
        }

        private void MainScreen_Paint(object sender, PaintEventArgs e)
        {
            /*
            Form f = this.FindForm();

            this.Width = f.Width;
            this.Height = f.Height;
            */
            foreach (Ball b in shadowList.Union(ballsList))
            {
                drawBrush.Color = b.colour;
                e.Graphics.FillEllipse(drawBrush, b.rectangle);
            }
        }
    }
}

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
        Random randGen = new Random();

        public MainScreen()
        {
            InitializeComponent();
        }

        public void InitializeValues()
        {

        }

        private void MainScreen_Click(object sender, EventArgs e)
        {
            int xSpeed = randGen.Next(0, 11) - 5;
            int ySpeed = randGen.Next(0, 11) - 5;

            Color ballColour = Color.FromArgb(160, randGen.Next(0, 256), randGen.Next(0, 256), randGen.Next(0, 256));

            int size = randGen.Next(10, 41);
            Form f = this.FindForm();
            Rectangle ballRect = new Rectangle(Cursor.Position.X - f.Location.X - size/2, Cursor.Position.Y - f.Location.Y - size/2, size, size);

            Ball b1 = new Ball(ballRect, xSpeed, ySpeed, ballColour);

            //add ball to thew list
            ballsList.Add(b1);

            if(false)
            {
                //balls collide delete both of them
            }
            else
            {
                //draw them all and let them go
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            foreach(Ball b in ballsList)
            {
                //check for collisions, move or switch velocity
                b.Collide();
                b.Move();
            }
            Refresh();
        }

        private void MainScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Ball b in ballsList)
            {
                drawBrush.Color = b.colour;
                e.Graphics.FillEllipse(drawBrush, b.rectangle);
            }
        }
    }
}

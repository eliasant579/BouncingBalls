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

            Ball b1 = new Ball(Cursor.Position, xSpeed, ySpeed, ballColour);

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
                
            }
        }
    }
}

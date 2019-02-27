using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BouncingBalls
{
    class Ball
    {

        public int xSpeed, ySpeed;
        public Color colour;
        public Rectangle rectangle;

        public Ball(Point _position, int _xSpeed, int _ySpeed, Color _colour)
        {
            //based on where I click spawn a ball with a random size. 
            //If you click over another ball (collision to a pre exixsting ball) make both disappear
        }
    }
}

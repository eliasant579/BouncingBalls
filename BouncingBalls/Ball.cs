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

        public Ball(Rectangle _rectangle, int _xSpeed, int _ySpeed, Color _colour)
        {
            rectangle = _rectangle;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            colour = _colour;
        }

        public void Move()
        {
            rectangle.X += xSpeed;
            rectangle.Y += ySpeed;
        }

        public void Collide()
        {
            if (false)
            { }
        }
    }
}

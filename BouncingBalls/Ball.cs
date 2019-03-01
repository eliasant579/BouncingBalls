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

        public void Collide(MainScreen mainScreen)
        {
            if (rectangle.X < 0 || rectangle.X > mainScreen.Width - rectangle.Width)
            {
                xSpeed *= -1;
                
            }
            if (rectangle.Y < 0 || rectangle.Y > mainScreen.Height - rectangle.Height)
            {
                ySpeed *= -1;
            }
        }

        public void Collide(Ball b2)
        {
            if (rectangle.IntersectsWith(b2.rectangle))
            {
                //change direction of received ball
                b2.xSpeed *= -1;
                b2.ySpeed *= -1;
                //change direction of this ball
                xSpeed *= -1;
                ySpeed *= -1;
            }
        }
    }
}

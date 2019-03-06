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

            Rectangle temprect = new Rectangle();
        }

        public void Move()
        {
            rectangle.X += xSpeed;
            rectangle.Y += ySpeed;

            float slope = ySpeed / xSpeed;
            //FLOATING POINTSSSSSSSS
            for (int i = 1; i <= ySpeed; i++)
            {
                //rectangle.X += slope;
                rectangle.Y += 1;
            }
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
                //this should change depending on which quarter of the ball is bounces
                /*
                 * TopRight: x is the same, y is oppsite
                 * TopL
                 */

                //change direction of received ball
                //change direction of this ball

                if (rectangle.Y > b2.rectangle.Y + b2.rectangle.Height || rectangle.Y + rectangle.Height < b2.rectangle.Y)
                {
                    b2.ySpeed *= -1;
                    ySpeed *= -1;
                }

                //if (rectangle.X > b2.rectangle.X + b2.rectangle.Width || rectangle.X + rectangle.Width < b2.rectangle.X)
                else
                {
                    b2.xSpeed *= -1;
                    xSpeed *= -1;
                }
            }
        }
    }
}

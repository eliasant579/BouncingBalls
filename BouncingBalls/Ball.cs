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

        public void Move(List<Ball> ballsList)
        {
            Ball tempBall = new Ball(rectangle, xSpeed, ySpeed, colour);

            //*
            rectangle.X += xSpeed;
            rectangle.Y += ySpeed;
            //*/

            /*
            for (int i = 1; i <= ySpeed; i++)
            {
                rectangle.Y += 1;
            }
            for (int i = 1; i <= xSpeed; i++)
            {
                rectangle.X += 1;
            }
            //*/

            
            for (int i = 0; i < ballsList.Count; i++)
            {

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
            if (rectangle.IntersectsWith(b2.rectangle) == true)
            {
                //this should change depending on which quarter of the ball is bounces

                //change direction of received ball
                //change direction of this ball

                //if the balls have to same speed signs bounce the one that is approaching
                //if they have opposite speed make them bounce in the opposite direction

                ///problems
                ///alright?

                Point p1 = new Point((rectangle.X + rectangle.X + rectangle.Width)/2, (rectangle.Y + rectangle.Y + rectangle.Height) / 2);
                Point p2 = new Point((b2.rectangle.X + b2.rectangle.X + b2.rectangle.Width) / 2, (b2.rectangle.Y + b2.rectangle.Y + b2.rectangle.Height) / 2);
                
                /*
                if (rectangle.Y > b2.rectangle.Y + b2.rectangle.Height || rectangle.Y + rectangle.Height > b2.rectangle.Y)
                {
                    b2.ySpeed *= -1;
                    ySpeed *= -1;
                }

                //if (rectangle.X > b2.rectangle.X + b2.rectangle.Width || rectangle.X + rectangle.Width > b2.rectangle.X)
                else
                {
                    b2.xSpeed *= -1;
                    xSpeed *= -1;
                }
                //*/

                //HOW ABOUT I USE THE CENTRE OF THE CIRCLE INSTEAD OF THE CORNER?
            }
        }
    }
}

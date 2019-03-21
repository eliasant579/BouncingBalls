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
        public Point centre;

        public Ball(Rectangle _rectangle, int _xSpeed, int _ySpeed, Color _colour)
        {
            rectangle = _rectangle;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            colour = _colour;
            centre = new Point(rectangle.X + rectangle.Width / 2, rectangle.Y + rectangle.Height / 2);
        }

        public void Move(List<Ball> ballList)
        {
            //Ball tempBall = new Ball(rectangle, xSpeed, ySpeed, colour);

            /*
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

            int xFrames = Math.Abs(xSpeed);
            int yFrames = Math.Abs(ySpeed);

            for (int i = 0; i < xFrames; i++)
            {
                if (xSpeed >= 0)
                {
                    rectangle.X++;
                }
                else
                {
                    rectangle.X--;
                }
                CollideArea(ballList);
            }

            for (int i = 0; i < yFrames; i++)
            {
                if (ySpeed >= 0)
                {
                    rectangle.Y++;
                }
                else
                {
                    rectangle.Y--;
                }
                CollideArea(ballList);
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

                //*

                int dX = b2.centre.X - centre.X;
                int dY = b2.centre.Y - centre.Y;

                if (dY < dX)
                {
                    xSpeed *= -1;
                    b2.xSpeed *= -1;
                }
                else if (dY > dX)
                {
                    ySpeed *= -1;
                    b2.ySpeed *= -1;
                }
                else
                {

                }



                /*
                if (rectangle.Y > b2.rectangle.Y + b2.rectangle.Height || rectangle.Y + rectangle.Height > b2.rectangle.Y)
                {                  
                    if (rectangle.X > b2.rectangle.X + b2.rectangle.Width || rectangle.X + rectangle.Width > b2.rectangle.X)
                    //else
                    {
                        b2.xSpeed *= -1;
                        xSpeed *= -1;
                    }
                    else
                    {
                        b2.ySpeed *= -1;
                        ySpeed *= -1;
                    }
                }

                /*
                if (rectangle.X > b2.rectangle.X + b2.rectangle.Width || rectangle.X + rectangle.Width > b2.rectangle.X)
                //else
                {
                    b2.xSpeed *= -1;
                    xSpeed *= -1;
                }
                //*/

                //HOW ABOUT I USE THE CENTRE OF THE CIRCLE INSTEAD OF THE CORNER?

            }
        }

        public void CollideArea(List<Ball> ballsList)
        {
            foreach (Ball b in ballsList)
            {
                if (centre.X + 150 < b.centre.X && centre.Y + 150 < b.centre.Y)
                {
                    Collide(b);
                }
            }
        }
    }
}

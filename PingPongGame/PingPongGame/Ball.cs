using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public class Ball
    {

        private PictureBox ball;
        int xSpeed, ySpeed;
        public Ball(PictureBox ball)
        {
            this.ball = ball;
            xSpeed = 2;
            ySpeed = 1;
        }

        internal void ProcessMove()
        {
            var limitR = PongLimitLocation.RightOfGround - ball.Width;
            ball.Location = new System.Drawing.Point(
                Math.Max(PongLimitLocation.LeftOfGround,
                    Math.Min(limitR, ball.Location.X + xSpeed))
                , ball.Location.Y + ySpeed);
               
            if (ball.Location.X == limitR || ball.Location.X == PongLimitLocation.LeftOfGround)
            {
                xSpeed *= -1;
            }
            if (ball.Location.Y == PongLimitLocation.TopOfGround )
            {
                Score();
            } else if(ball.Location.Y == PongLimitLocation.BottomOfGround - ball.Height)
            {
                Score();
            }
        }

        private void Score()
        {
            throw new NotImplementedException();
        }
    }
}

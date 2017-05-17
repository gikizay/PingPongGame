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
        Random rand = new Random();
        public Player topsidePlayer, bottomsidePlayer;
        int xSpeed, ySpeed;
       
        public Ball(PictureBox ball, Player topsidePlayer,Player bottomsidePlayer)
        {
            this.ball = ball;
            this.topsidePlayer = topsidePlayer;
            this.bottomsidePlayer = bottomsidePlayer;
            xSpeed = 2;
            ySpeed = 1;
            ResetBall();
        }

        internal void ProcessMove()
        {
            var limitR = PongLimitLocation.RightOfGround - ball.Width;
            ball.Location = new System.Drawing.Point(
                Math.Max(PongLimitLocation.LeftOfGround,
                    Math.Min(limitR, ball.Location.X + xSpeed))
                , ball.Location.Y + ySpeed);
               
            if (ball.Location.X >= limitR || ball.Location.X <= PongLimitLocation.LeftOfGround)
            {
                xSpeed *= -1;
            }
            if (ball.Location.Y <= PongLimitLocation.TopOfGround )
            {
                Score(topsidePlayer);
            } else if(ball.Location.Y >= PongLimitLocation.BottomOfGround - ball.Height)
            {
                Score(bottomsidePlayer);
            }
            if (topsidePlayer.ground.Bounds.IntersectsWith(ball.Bounds)
                || bottomsidePlayer.ground.Bounds.IntersectsWith(ball.Bounds) )
            {
                ySpeed *= -1;
            }
        }

        private void Score(Player sidePlayer)
        {
            sidePlayer.Score++;
            ResetBall();

        }

        private void ResetBall()
        {
            ball.Location = new System.Drawing.Point((PongLimitLocation.LeftOfGround + PongLimitLocation.RightOfGround) / 2, (PongLimitLocation.TopOfGround + PongLimitLocation.BottomOfGround) / 2);
            do
            {
                xSpeed = rand.Next(-3, 3);
                ySpeed = rand.Next(-3, 3);

            } while ((xSpeed+ySpeed)>=3|| Math.Abs(ySpeed)==0);
        }
    }
}

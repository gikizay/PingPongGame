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
        PongForm form;
        private PictureBox ballPictureBox, ballModel;
        Random rand = new Random();
        public Player topsidePlayer, bottomsidePlayer;
        int xSpeed, ySpeed;
       
        public Ball(PongForm form,PictureBox aballModel, Player topsidePlayer,Player bottomsidePlayer)
        {
            this.form = form;
            ballModel = aballModel;
            this.ballPictureBox = new PictureBox();
            this.ballPictureBox.Size = aballModel.Size;
            this.ballPictureBox.Image = aballModel.Image;
            form.Controls.Add(ballPictureBox);
            this.topsidePlayer = topsidePlayer;
            this.bottomsidePlayer = bottomsidePlayer;
           
            ResetBall();
        }

        internal bool ProcessMove()
        {
            DoMove();
            var limitR = PongLimitLocation.RightOfGround - ballPictureBox.Width;
            if (ballPictureBox.Location.X >= limitR || ballPictureBox.Location.X <= PongLimitLocation.LeftOfGround)
            {
                xSpeed *= -1;
            }
            if (ballPictureBox.Location.Y <= PongLimitLocation.TopOfGround)
            {
                Score(topsidePlayer);
                return true;
            }
            else if (ballPictureBox.Location.Y >= PongLimitLocation.BottomOfGround - ballPictureBox.Height)
            {
                Score(bottomsidePlayer);
                return true;
            }
            if (topsidePlayer.ground.Bounds.IntersectsWith(ballPictureBox.Bounds)
                || bottomsidePlayer.ground.Bounds.IntersectsWith(ballPictureBox.Bounds))
            {
                ySpeed *= -2;
                //xSpeed *= 2;
                form.ballList.Add( new Ball(form, ballModel, topsidePlayer, bottomsidePlayer));
                while (topsidePlayer.ground.Bounds.IntersectsWith(ballPictureBox.Bounds)
                || bottomsidePlayer.ground.Bounds.IntersectsWith(ballPictureBox.Bounds))
                {
                    DoMove();

                }

            }
            return false;
        }

        private int DoMove()
        {
            var limitR = PongLimitLocation.RightOfGround - ballPictureBox.Width;
            ballPictureBox.Location = new System.Drawing.Point(
                Math.Max(PongLimitLocation.LeftOfGround,
                    Math.Min(limitR, ballPictureBox.Location.X + xSpeed))
                , ballPictureBox.Location.Y + ySpeed);
            return limitR;
        }

        private void Score(Player sidePlayer)
        {
            sidePlayer.Score++;
            form.Controls.Remove(ballPictureBox);
        }

        private void ResetBall()
        {
            ballPictureBox.Location = new System.Drawing.Point((PongLimitLocation.LeftOfGround + PongLimitLocation.RightOfGround) / 2, (PongLimitLocation.TopOfGround + PongLimitLocation.BottomOfGround) / 2);
            do
            {
                xSpeed = rand.Next(-3, 3);
                ySpeed = rand.Next(-3, 3);

            } while ((xSpeed+ySpeed)>=3|| Math.Abs(ySpeed)==0 || Math.Abs(xSpeed) == 0);
        }
    }
}
   
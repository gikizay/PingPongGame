using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace PingPongGame
{
    public class Player
    {
        const int movementSpeed = 5;
        PictureBox ground;
        Label ScoreLabel;
        int score;
        public bool isLeftPressed, isRightPressed;
        

        public Player(PictureBox ground, Label ScoreLabel)
        {
            
            this.ground = ground;
            this.ScoreLabel = ScoreLabel;
        }

        internal void ProcessMove()
        {
            bool? goingUp = null;

            if (isLeftPressed == true)
            {
                goingUp = true;
            }
            if (isRightPressed == true)
            {
                if (goingUp.HasValue)
                {
                    goingUp = null;
                }
                else
                {
                    goingUp = false;
                }
            }
            DoMove(ground, goingUp);



        }

        private void DoMove(PictureBox Ground, bool? goingUp)
        {
            if (goingUp.HasValue)
            {
                var speed = movementSpeed;
                if (goingUp.Value)
                {
                    speed *= -1;
                }
                Ground.Location = new Point( 
                    Math.Max( PongLimitLocation.LeftOfGround, 
                    Math.Min(PongLimitLocation.RightOfGround - ground.Width+ 45
                    , Ground.Location.X + speed)), Ground.Location.Y);
            }
        }
    }
}

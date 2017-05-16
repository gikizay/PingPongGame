using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Form1 : Form
    {
        Player player1, player2;
        Ball ball;
        public Form1()
        {
            InitializeComponent();
            player1 = new Player(Ground,LabelPlayer1);
            player2 = new Player(Ground2,LabelPlayer2);
            ball = new Ball(Ball,player1,player2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            player1.ProcessMove();
            player2.ProcessMove();
            ball.ProcessMove();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            CheckKeys(e, true);

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            CheckKeys(e, false);
        }

        private void CheckKeys(KeyEventArgs e, bool isLeft)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player1.isLeftPressed = isLeft;
                    break;
                case Keys.Oemcomma:
                case Keys.Right:
                    player1.isRightPressed = isLeft;
                    break;
                case Keys.A:
                    player2.isLeftPressed = isLeft;
                    break;
                case Keys.D:
                    player2.isRightPressed = isLeft;
                    break;
            }
        }

    }
}

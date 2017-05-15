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
        const int movementSpeed = 3;
        bool? isLeftPressed, isRightPressed;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isLeftPressed== true)
            {
                Ground.Location = new Point(Ground.Location.X-movementSpeed, Ground.Location.Y);
            } else if (isRightPressed == true)
            {
                Ground.Location = new Point(Ground.Location.X + movementSpeed, Ground.Location.Y);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                isLeftPressed = true;
            } else if(e.KeyCode == Keys.Right)
            {
                isRightPressed = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                isLeftPressed = false;
              
            }
            else if (e.KeyCode == Keys.Right)
            {
                isRightPressed = false;
            }
        }
    }
}

namespace PingPongGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ground2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelPlayer1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPlayer2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground2)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(4, 394);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(174, 25);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(366, 124);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(45, 45);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ground2
            // 
            this.Ground2.Image = ((System.Drawing.Image)(resources.GetObject("Ground2.Image")));
            this.Ground2.Location = new System.Drawing.Point(272, 12);
            this.Ground2.Name = "Ground2";
            this.Ground2.Size = new System.Drawing.Size(174, 25);
            this.Ground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ground2.TabIndex = 2;
            this.Ground2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // LabelPlayer1
            // 
            this.LabelPlayer1.AutoSize = true;
            this.LabelPlayer1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayer1.ForeColor = System.Drawing.Color.White;
            this.LabelPlayer1.Location = new System.Drawing.Point(79, 422);
            this.LabelPlayer1.Name = "LabelPlayer1";
            this.LabelPlayer1.Size = new System.Drawing.Size(26, 30);
            this.LabelPlayer1.TabIndex = 4;
            this.LabelPlayer1.Text = "0";
            this.LabelPlayer1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(111, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelPlayer2
            // 
            this.LabelPlayer2.AutoSize = true;
            this.LabelPlayer2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayer2.ForeColor = System.Drawing.Color.White;
            this.LabelPlayer2.Location = new System.Drawing.Point(139, 422);
            this.LabelPlayer2.Name = "LabelPlayer2";
            this.LabelPlayer2.Size = new System.Drawing.Size(26, 30);
            this.LabelPlayer2.TabIndex = 6;
            this.LabelPlayer2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(847, 451);
            this.Controls.Add(this.LabelPlayer2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ground2);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Ground);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ping Pong Smile";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Ground2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelPlayer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelPlayer2;
    }
}


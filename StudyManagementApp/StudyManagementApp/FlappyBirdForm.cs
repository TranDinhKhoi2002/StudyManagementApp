using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp
{
    public partial class lbStart : Form
    {
        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;

        public lbStart()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void timerFlappyBird_Tick(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeTop.Left -= pipeSpeed;
            pipeBottom.Left -= pipeSpeed;
            lbScore.Text = "Score: " + score;

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }
            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || flappyBird.Bounds.IntersectsWith(ptbGround.Bounds) || flappyBird.Top < -25)
            {
                EndGame();
            }

            if (score > 5)
            {
                pipeSpeed = 12;
            }
            else if (score > 15)
            {
                pipeSpeed = 16;
            }
            else if (score > 30)
            {
                pipeSpeed = 20;
            }
        }

        private void FlappyBirdForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void FlappyBirdForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void EndGame()
        {
            timerFlappyBird.Stop();
            lbScore.Text += " Game over";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            flappyBird.Location = new Point(19, 107);
            pipeTop.Location = new Point(303, 1);
            pipeBottom.Location = new Point(179, 273);
            score = 0;
            pipeSpeed = 8;
            timerFlappyBird.Enabled = true;
        }
    }
}

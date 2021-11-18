
namespace StudyManagementApp
{
    partial class FlappyBirdForm
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
            this.lbScore = new System.Windows.Forms.Label();
            this.ptbGround = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.timerFlappyBird = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.White;
            this.lbScore.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(12, 638);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(81, 31);
            this.lbScore.TabIndex = 5;
            this.lbScore.Text = "Score: 0";
            // 
            // ptbGround
            // 
            this.ptbGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ptbGround.Image = global::StudyManagementApp.Properties.Resources.ground;
            this.ptbGround.Location = new System.Drawing.Point(0, 592);
            this.ptbGround.Name = "ptbGround";
            this.ptbGround.Size = new System.Drawing.Size(564, 98);
            this.ptbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGround.TabIndex = 4;
            this.ptbGround.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::StudyManagementApp.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(286, 363);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(100, 231);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 3;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::StudyManagementApp.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(405, 1);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 222);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::StudyManagementApp.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(30, 200);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(71, 57);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // timerFlappyBird
            // 
            this.timerFlappyBird.Enabled = true;
            this.timerFlappyBird.Interval = 20;
            this.timerFlappyBird.Tick += new System.EventHandler(this.timerFlappyBird_Tick);
            // 
            // FlappyBirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(564, 690);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ptbGround);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.MaximizeBox = false;
            this.Name = "FlappyBirdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBirdForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FlappyBirdForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ptbGround;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer timerFlappyBird;
    }
}
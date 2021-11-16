using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Media;
namespace StudyManagementApp
{
    public partial class Game2048 : Form
    {
        Random random = new Random();
        bool isPlaying = true;
        static ArrayList arrNumberOfBlanks = new ArrayList();
        public Game2048()
        {
            InitializeComponent();
        }
        public void UpdateColor()
        {
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (Game[i, j].Text == "")
                    {
                        Game[i, j].BackColor = Color.CadetBlue;
                    }
                    if (Game[i, j].Text == "2")
                    {
                        Game[i, j].BackColor = Color.Silver;
                        Game[i, j].ForeColor = Color.White;

                    }
                    if (Game[i, j].Text == "4")
                    {
                        Game[i, j].BackColor = Color.Gray;
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "8")
                    {
                        Game[i, j].BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "16")
                    {
                        Game[i, j].BackColor = Color.Black;
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "32")
                    {
                        Game[i, j].BackColor = Color.Yellow;
                        Game[i, j].ForeColor = Color.Silver;
                    }
                    if (Game[i, j].Text == "64")
                    {
                        Game[i, j].BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "128")
                    {
                        Game[i, j].BackColor = Color.Olive;
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "256")
                    {
                        Game[i, j].BackColor = Color.Gold;
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "512")
                    {
                        Game[i, j].BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "1024")
                    {
                        Game[i, j].BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "2048")
                    {
                        Game[i, j].BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
                        Game[i, j].ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                    }
                    if (Game[i, j].Text == "4096")
                    {
                        Game[i, j].BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        Game[i, j].ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                    }
                    if (Game[i, j].Text == "8192")
                    {
                        Game[i, j].BackColor = Color.Maroon;
                        Game[i, j].ForeColor =Color.Yellow;
                    }
                }
            }

        }

        public void initGame()
        {
            arrNumberOfBlanks.Clear();

            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[i, j].Text == "")
                    {
                        arrNumberOfBlanks.Add(i * 4 + j + 1);
                    }
                }
            }

            if (arrNumberOfBlanks.Count > 0)
            {

                int IndexImage = int.Parse(arrNumberOfBlanks[random.Next(0, arrNumberOfBlanks.Count - 1)].ToString());
                int i0 = (IndexImage - 1) / 4;
                int j0 = (IndexImage - 1) - i0 * 4;
                int Randomize = random.Next(1, 10);
                if (Randomize == 1 || Randomize == 2 || Randomize == 3 || Randomize == 4 || Randomize == 5 || Randomize == 6)
                {
                    Game[i0, j0].Text = "2";
                }
                else
                {
                    Game[i0, j0].Text = "4";
                }

            }
            UpdateColor();
        }
        public void MoveUp()
        {
            bool notMove = true;
            bool score = false;
            bool kTraKhoiTao = false;
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int Blank = 0;
                for (int j = 0; j < 4; j++)
                {
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[k, i].Text != "")
                        {
                            if (Game[k, i].Text == Game[j, i].Text)
                            {
                                score = true;
                            }
                            break;
                        }
                    }
                    if (Game[j, i].Text == "")
                    {
                        Blank++;
                    }
                    else
                    {
                        for (int m = j; m >= 0; m--)
                        {
                            if (Game[m, i].Text == "")
                            {
                                kTraKhoiTao = true;
                                break;
                            }
                        }
                        if (j + 1 < 4)
                        {
                            bool flag = true;

                            for (int k = j + 1; k < 4; k++)
                            {
                                if (Game[k, i].Text != "")
                                {
                                    if (Game[j, i].Text == Game[k, i].Text)
                                    {
                                        notMove = false;
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(Game[j, i].Text) * 2).ToString();
                                        kTraKhoiTao = true;
                                        flag = false;
                                        Game[j, i].Text = (int.Parse(Game[j, i].Text) * 2).ToString();
                                        if (Blank != 0)
                                        {
                                            Game[j - Blank, i].Text = Game[j, i].Text;
                                            Game[j, i].Text = "";

                                        }
                                        Game[k, i].Text = "";
                                        break;

                                    }
                                    break;
                                }
                            }
                            if (flag == true && Blank != 0)
                            {
                                notMove = false;
                                Game[j - Blank, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }
                        else
                        {
                            if (Blank != 0)
                            {
                                notMove = false;
                                Game[j - Blank, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }


                    }
                }
            }
           
            if (kTraKhoiTao == true)
            {
                initGame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initGame();
            initGame();
            initGame();
        }
        public void MoveDown()
        {
            bool notMoveDown = true;
            bool Score = false;
            bool isInit = false;
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int blank = 0;
                for (int j = 3; j >= 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (Game[k, i].Text != "")
                        {
                            if (Game[k, i].Text == Game[j, i].Text)
                            {
                                Score = true;
                            }
                            break;
                        }
                    }
                    if (Game[j, i].Text == "")
                    {
                        blank++;
                    }
                    else
                    {
                        for (int m = j + 1; m <= 3; m++)
                        {
                            if (Game[m, i].Text == "")
                            {
                                isInit = true;
                                break;
                            }
                        }
                        if (j - 1 >= 0)
                        {
                            bool flag = true;

                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (Game[k, i].Text != "")
                                {
                                    if (Game[j, i].Text == Game[k, i].Text)
                                    {
                                        notMoveDown = false;
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(Game[j, i].Text) * 2).ToString();
                                        isInit = true;
                                        flag = false;
                                        Game[j, i].Text = (int.Parse(Game[j, i].Text) * 2).ToString();
                                        if (blank != 0)
                                        {
                                            Game[j + blank, i].Text = Game[j, i].Text;
                                            Game[j, i].Text = "";

                                        }
                                        Game[k, i].Text = "";
                                        break;

                                    }
                                    break;
                                }
                            }
                            if (flag == true && blank != 0)
                            {
                                notMoveDown = false;
                                Game[j + blank, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }
                        else
                        {
                            if (blank != 0)
                            {
                                notMoveDown = false;
                                Game[j + blank, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }


                    }
                }
            }
           
            if (isInit == true)
            {
                initGame();
            }
        }
        public void MoveLeft()
        {
            bool notMoveLeft = true;
            bool anDiem = false;
            bool isInit = false;
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int Blank = 0;
                for (int j = 0; j < 4; j++)
                {

                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[i, k].Text != "")
                        {
                            if (Game[i, j].Text == Game[i, k].Text)
                            {
                                anDiem = true;
                            }
                            break;
                        }
                    }
                    if (Game[i, j].Text == "")
                    {
                        Blank++;
                    }
                    else
                    {
                        for (int m = j - 1; m >= 0; m--)
                        {
                            if (Game[i, m].Text == "")
                            {
                                isInit = true;
                                break;
                            }
                        }
                        if (j + 1 < 4)
                        {
                            bool flag = true;

                            for (int k = j + 1; k < 4; k++)
                            {
                                if (Game[i, k].Text != "")
                                {

                                    if (Game[i, j].Text == Game[i, k].Text)
                                    {
                                        notMoveLeft = false;
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(Game[i, j].Text) * 2).ToString();
                                        isInit = true;
                                        flag = false;
                                        Game[i, j].Text = (int.Parse(Game[i, j].Text) * 2).ToString();
                                        if (Blank != 0)
                                        {
                                            Game[i, j - Blank].Text = Game[i, j].Text;
                                            Game[i, j].Text = "";

                                        }
                                        Game[i, k].Text = "";
                                        break;

                                    }
                                    break;
                                }
                            }
                            if (flag == true && Blank != 0)
                            {
                                notMoveLeft = false;
                                Game[i, j - Blank].Text = Game[i, j].Text;
                                Game[i, j].Text = "";

                            }
                        }
                        else
                        {
                            if (Blank != 0)
                            {
                                notMoveLeft = false;
                                Game[i, j - Blank].Text = Game[i, j].Text;
                                Game[i, j].Text = "";

                            }
                        }


                    }
                }
            }
           
            if (isInit == true)
            {
                initGame();
            }
        }
        public void MoveRight()
        {
            bool notMoveRight = true;
            bool anDiem = false;
            bool checkInit = false;
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int oRong = 0;
                for (int j = 3; j >= 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (Game[i, k].Text != "")
                        {
                            if (Game[i, k].Text == Game[i, j].Text)
                            {
                                anDiem = true;
                            }
                            break;
                        }
                    }
                    if (Game[i, j].Text == "")
                    {
                        oRong++;
                    }
                    else
                    {
                        for (int m = j + 1; m < 4; m++)
                        {
                            if (Game[i, m].Text == "")
                            {
                                checkInit = true;
                                break;
                            }
                        }
                        if (j - 1 >= 0)
                        {
                            bool ktra = true;

                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (Game[i, k].Text != "")
                                {


                                    if (Game[i, j].Text == Game[i, k].Text)
                                    {
                                        notMoveRight = false;
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(Game[i, j].Text) * 2).ToString();
                                        checkInit = true;
                                        ktra = false;
                                        Game[i, j].Text = (int.Parse(Game[i, j].Text) * 2).ToString();
                                        if (oRong != 0)
                                        {
                                            Game[i, j + oRong].Text = Game[i, j].Text;
                                            Game[i, j].Text = "";

                                        }
                                        Game[i, k].Text = "";
                                        break;

                                    }
                                    break;
                                }
                            }
                            if (ktra == true && oRong != 0)
                            {
                                notMoveRight = false;
                                Game[i, j + oRong].Text = Game[i, j].Text;
                                Game[i, j].Text = "";

                            }
                        }
                        else
                        {
                            if (oRong != 0)
                            {
                                notMoveRight = false;
                                Game[i, j + oRong].Text = Game[i, j].Text;
                                Game[i, j].Text = "";

                            }
                        }
                    }
                }
            }
           
            if (checkInit == true)
            {
                initGame();
            }
        }
        public bool endGame()
        {
            
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[i, j].Text == "")
                    {
                        return false;
                    }
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[i, j].Text != "")
                        {
                            if (Game[i, j].Text == Game[i, k].Text)
                            {
                                return false;
                            }
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[j, i].Text == "")
                    {
                        return false;
                    }
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[k, i].Text != "")
                        {
                            if (Game[j, i].Text == Game[k, i].Text)
                            {
                                return false;
                            }
                            break;
                        }
                    }
                }
            }
            return true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (endGame() == false)
            {
                if (e.KeyCode == Keys.Up)
                {
                    MoveUp();

                }
                if (e.KeyCode == Keys.Down)
                {
                    MoveDown();
                }
                if (e.KeyCode == Keys.Left)
                {
                    MoveLeft();
                }
                if (e.KeyCode == Keys.Right)
                {
                    MoveRight();
                }
            }
            else
            {
                label1.Enabled = false;
                lbInstruction.Hide();
                continueToolStripMenuItem.Visible = false;
                lblGameOver.Text = "Game Over";
                isPlaying = false;
                lblGameOver.Visible = true;
                btnNewGame.Visible = true;
                btnExit.Visible = true;
                btnExit.Enabled = true;
                btnNewGame.Enabled = true;
                this.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            }

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            label1.Enabled = true;
            isShowing = false;

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            lblScore.Text = "0";
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            lblGameOver.Visible = false;
            btnExit.Visible = false;
            isPlaying = true;
            btnNewGame.Visible = false;
            btnNewGame.Enabled = false;
            btnExit.Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Game[i, j].Text = "";
                }
            }
            initGame();
            initGame();
            initGame();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
            continueToolStripMenuItem.Visible = true;
            lblAbout.Visible = false;
          
            label2.Visible = true;
            lblScore.Visible = true;

            if (isPlaying == false)
            {
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            }
            isPlaying = true;
            lblScore.Text = "0";
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            lblGameOver.Visible = false;
            btnExit.Visible = false;
            btnNewGame.Visible = false;
            btnNewGame.Enabled = false;
            btnExit.Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Game[i, j].Visible = true;
                    Game[i, j].Text = "";
                }
            }
            initGame();
            initGame();
            initGame();
        }

        private void continueToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
            lblAbout.Visible = false;
           
            label2.Visible = true;
            lblScore.Visible = true;

            if (isPlaying == false)
            {
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            }
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            lblGameOver.Visible = false;
            btnExit.Visible = false;
            btnNewGame.Visible = false;
            btnNewGame.Enabled = false;
            btnExit.Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Game[i, j].Visible = true;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;
            lblScore.Visible = false;
            label2.Visible = false;
            btnNewGame.Visible = false;
            btnExit.Visible = false;
            lblAbout.Visible = true;
            lblAbout.Location = new System.Drawing.Point(0, 41);
            lblAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Game[i, j].Visible = false;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewGame_MouseHover(object sender, EventArgs e)
        {
            btnNewGame.BackColor = Color.Black;
        }

        private void btnNewGame_MouseLeave(object sender, EventArgs e)
        {
            btnNewGame.BackColor = Color.Gray;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Black;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Gray;
        }

        private void ptbImage_Click(object sender, EventArgs e)
        {

        }
        bool isShowing = false;
        private void label1_Click(object sender, EventArgs e)
        {
            lbInstruction.Show();
            isShowing = !isShowing;
            if (isShowing)
            {
                lbInstruction.Text = "1/ Nhấn phím lên, xuống, trái, phải trên bàn phím để đẩy các con số theo hướng tương ứng." +
                   Environment.NewLine + Environment.NewLine + "2/ Nếu tồn tại 2 số giống nhau trên cùng hàng (không có số khác nằm giữa chúng) thì khi nhấn trái, phải hoặc cùng cột (không có số khác nằm giữa chúng) khi nhấn lên/xuống thì hai giá trị đó sẽ được cộng lại và được đẩy về hướng chỉ định đến lúc đụng phải viền ngoài hoặc một một ô chứa số khác." +
                   Environment.NewLine + Environment.NewLine + "3/ Điểm mỗi lần nhấn nút là tổng tất cả ô có giá trị trùng trong lần đó." +
                   Environment.NewLine + Environment.NewLine + "4/ Trò chơi kết thúc khi toàn bộ 16 ô bị lấp đầy bởi số và lần nhấn tiếp theo không có bất kỳ thay đổi nào nữa." +
                   Environment.NewLine + Environment.NewLine + "Cùng chinh phục ô số 2048 nào!!!" +
                   Environment.NewLine + Environment.NewLine + "CHÚC BẠN GIẢI LAO HIỆU QUẢ VÀ TRỞ LẠI CÔNG VIỆC NĂNG SUẤT HƠN NHÉ!";
                label1.Text = "Instruction (Click to Close)";
            }
            else
            {
                lbInstruction.Text = "";
                label1.Text = "Instruction (Click to Show)";
            }
        }
    }
}

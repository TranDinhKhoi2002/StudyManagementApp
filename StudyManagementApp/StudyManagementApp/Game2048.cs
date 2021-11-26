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
                        Game[i, j].BackColor = Color.FromArgb(193, 177, 154);
                    }
                    if (Game[i, j].Text == "2")
                    {
                        Game[i, j].BackColor = Color.FromArgb(237, 224, 200);
                        Game[i, j].ForeColor = Color.FromArgb(119, 110, 101);

                    }
                    if (Game[i, j].Text == "4")
                    {
                        Game[i, j].BackColor = Color.FromArgb(246, 124, 95);
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "8")
                    {
                        Game[i, j].BackColor = Color.FromArgb(242, 177, 121);
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "16")
                    {
                        Game[i, j].BackColor = Color.FromArgb(253, 151, 93);
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "32")
                    {
                        Game[i, j].BackColor = Color.FromArgb(254, 126, 91);
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "64")
                    {
                        Game[i, j].BackColor = Color.FromArgb(253, 93, 49);
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "128")
                    {
                        Game[i, j].BackColor = Color.FromArgb(254, 205, 100);
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "256")
                    {
                        Game[i, j].BackColor = Color.FromArgb(237, 204, 97);
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "512")
                    {
                        Game[i, j].BackColor = Color.FromArgb(254, 200, 48);
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "1024")
                    {
                        Game[i, j].BackColor = Color.FromArgb(237, 197, 63);
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "2048")
                    {
                        Game[i, j].BackColor = Color.FromArgb(223, 154, 2);
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "4096")
                    {
                        
                        Game[i, j].BackColor = Color.FromArgb(237, 194, 46);
                        Game[i, j].ForeColor = Color.White;
                    }
                    if (Game[i, j].Text == "8192")
                    {
                        Game[i, j].BackColor = Color.FromArgb(255, 134, 1);
                        Game[i, j].ForeColor = Color.White;
                    }
                }
            }

        }

        public void InitGame()
        {
            arrNumberOfBlanks.Clear();

            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
     //Đánh số cho chỗ trống
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[i, j].Text == "")
                    {
                        arrNumberOfBlanks.Add(i * 4 + j + 1); // *4 là xuống dòng, +1 là do mảng từ 0
                    }
                }
            }
//Nếu còn tồn tại ô trống thì bắt đầu thêm ngẫu nhiên
            if (arrNumberOfBlanks.Count > 0)
            {

                int IndexImage = int.Parse(arrNumberOfBlanks[random.Next(0, arrNumberOfBlanks.Count - 1)].ToString()); //Chọn ngẫu nhiên một ô trống trong tập ô trống
                int i0 = (IndexImage - 1) / 4; //Một phép tính random ra hàng
                int j0 = (IndexImage - 1) - i0 * 4; //Một phép tính random ra cột
                int Randomize = random.Next(1, 10); //Một cái random chọn số thêm vô
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
            //Hai biến này để làm hiệu ứng âm thanh nhưng chưa có file âm thanh nên để sẵn, nào rãnh thì làm
            bool notMove = true;
            bool score = false;
           
            bool CheckInit = false;
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            for (int i = 0; i < 4; i++)
            {
                //Đang xử lí nút lên, nên phải xét từng cột, khi qua cột mới Blank trả lại = 0
                int Blank = 0;
                for (int j = 0; j < 4; j++)
                {
                    //Khúc for này là xử lý điểm cộng
                    for (int k = j + 1; k < 4; k++)
                    {
                        //Trong từng cái cột xét ô đó và ô lần lượt dưới nó
                        //Nếu không trống thì xét coi có bằng không
                        if (Game[k, i].Text != "")
                        {
                            if (Game[k, i].Text == Game[j, i].Text)
                            {
                                score = true;
                            }
                            break;
                            //Không bằng thì thoát khỏi cái j hiện tại, xét cái j tiếp theo
                        }
                    }
                    if (Game[j, i].Text == "")
                    {
                        Blank++;
                        //Đếm ô rỗng trong cột, nếu không rỗng thì tới công chuyện
                    }
                    //Khúc else này là xử lý biến đổi của cái game
                    else
                    {
                        for (int m = j - 1; m >= 0; m--)
                        {
                           //Check coi có khởi tạo tiếp được không, nếu đẩy lên được thì khởi tạo tiếp được
                            if (Game[m, i].Text == "")
                            {
                                CheckInit = true;
                                break;
                            }
                        }
                        if (j + 1 < 4) //Là hàng cuối thì không được
                        {
                            bool flag = true;

                            for (int k = j + 1; k < 4; k++)
                            {
                                if (Game[k, i].Text != "")
                                {
                                    if (Game[j, i].Text == Game[k, i].Text)
                                    {
                                        //Cập nhật điểm
                                        notMove = false;
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(Game[j, i].Text) * 2).ToString();
                                        CheckInit = true;
                                        flag = false;
                                        //Cập nhật ô được nhận 2
                                        Game[j, i].Text = (int.Parse(Game[j, i].Text) * 2).ToString();

                                        //Đẩy mọi thứ lên phía trên
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

            if (CheckInit == true)
            {
                InitGame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Khi khởi tạo cho sẵn 3 số
            InitGame();
            InitGame();
            InitGame();
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
                InitGame();
            }
        }
        public void MoveLeft()
        {
            bool notMoveLeft = true;
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
                int Blank = 0;
                for (int j = 0; j < 4; j++)
                {

                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[i, k].Text != "")
                        {
                            if (Game[i, j].Text == Game[i, k].Text)
                            {
                                Score = true;
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
                InitGame();
            }
        }
        public void MoveRight()
        {
            bool notMoveRight = true;
            bool Score = false;
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
                                Score = true;
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
                InitGame();
            }
        }
        public bool EndGame()
        {

            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };

    //Kiểm tra hàng dọc còn đi tiếp được không
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
    //Kiểm tra hàng ngang còn đi tiếp được không
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
            if (EndGame() == false)
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
             
                continueToolStripMenuItem.Visible = false;
                lblGameOver.Text = "Game Over";
                isPlaying = false;
                lblGameOver.Visible = true;
                btnNewGame.Visible = true;
                btnExit.Visible = true;
                btnExit.Enabled = true;
                btnNewGame.Enabled = true;
                this.KeyDown -= new KeyEventHandler(this.Form1_KeyDown);
            }

        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
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
            InitGame();
            InitGame();
            InitGame();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
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
            InitGame();
            InitGame();
            InitGame();
        }

        private void ContinueToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNewGame_MouseHover(object sender, EventArgs e)
        {
            btnNewGame.BackColor = Color.Black;
        }

        private void BtnNewGame_MouseLeave(object sender, EventArgs e)
        {
            btnNewGame.BackColor = Color.Gray;
        }

        private void BtnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Black;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Gray;
        }

        private void PtbImage_Click(object sender, EventArgs e)
        {

        }
      
    }
}

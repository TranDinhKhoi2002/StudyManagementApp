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
    public partial class WorkPlace : Form
    {
        public WorkPlace()
        {
            InitializeComponent();
            HideAllSubMenu();

            WorkPlacePanel.Visible = true;
            aboutUC1.Visible = false;
            helpUC1.Visible = false;
        }

        //Khi tắt workplace thì làm gì?
        private void WorkPlace_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        /*---------------------------------Điều khiển các item trong menu bên trái---------------------------------*/
        //Hàm dấu tất cả các subMenu_panel
        void HideAllSubMenu()
        {
            //Code giấu
            SubTableMenu_panel.Visible = false;
            SubToDoListMenu_panel.Visible = false;
            SubFreeStyleMenu_panel.Visible = false;
            //Code để icon tam giác trong các iconButton quay qua bên phải
            TableMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            ToDoListMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            FreeStyleMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
        }
        //Hàm hiện 1 subMenu_panel được truyền vào
        void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideAllSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        //Khi click Table_menu_iconButton thì làm gì?
        private void TableMenu_iconButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubTableMenu_panel);
            if (SubTableMenu_panel.Visible == true)
                TableMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            else
                TableMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
        }
        //Khi click ToDoList_menu_iconButton thì làm gì?
        private void ToDoListMenu_iconButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubToDoListMenu_panel);
            if (SubToDoListMenu_panel.Visible == true)
                ToDoListMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            else
                ToDoListMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
        }
        //Khi click FreeStyle_menu_iconButton thì làm gì?
        private void FreeStyleMenu_iconButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubFreeStyleMenu_panel);
            if (SubFreeStyleMenu_panel.Visible == true)
                FreeStyleMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            else
                FreeStyleMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
        }
        /*---------------------------------Điều khiển các item trong menu bên trái---------------------------------*/


        /*---------------------------------Chức năng 3 nút home, about, help---------------------------------*/
        //Khai báo 3 biến đánh dấu các nút được click chưa hay chưa?
        bool isHomeClick = true;
        bool isAboutClick = false;
        bool isHelpClick = false;
        //Nhấn Home thì làm gì?
        private void Home_iconButton_Click(object sender, EventArgs e)
        {
            if (isHomeClick)
            {
                return;
            }
            else
            {
                WorkPlacePanel.Visible = true;
                isHomeClick = true;
                Home_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked home.png");
                if (isAboutClick)
                {
                   
                    aboutUC1.Visible = false;
                    isAboutClick = false;
                    About_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\about.png");
                }
                if (isHelpClick)
                {
                    
                    helpUC1.Visible = false;
                    isHelpClick = false;
                    Help_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\help.png");
                }
            }
        }
        //Nhấn About thì làm gì?
        private void About_iconButton_Click(object sender, EventArgs e)
        {
            if (isAboutClick)
                return;
            else
            {
                aboutUC1.Visible = true;
                isAboutClick = true;
                About_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked about.png");
                if (isHomeClick)
                {
                    WorkPlacePanel.Visible = false;
                    isHomeClick = false;
                    Home_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\home.png");
                }
                if (isHelpClick)
                {
                    helpUC1.Visible = false;
                    isHelpClick = false;
                    Help_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\help.png");
                }
            }
        }
        //Nhấn Help thì làm gì?
        private void Help_iconButton_Click(object sender, EventArgs e)
        {
            if (isHelpClick)
                return;
            else
            {
                helpUC1.Visible = true;
                isHelpClick = true;
                Help_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked help.png");
                if (isHomeClick)
                {
                    WorkPlacePanel.Visible = false;
                    isHomeClick = false;
                    Home_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\home.png");
                }
                if (isAboutClick)
                {
                    aboutUC1.Visible = false;
                    isAboutClick = false;
                    About_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\about.png");
                }
               
            }
        }

        
        /*---------------------------------Chức năng 3 nút home, about, help---------------------------------*/

    }
}

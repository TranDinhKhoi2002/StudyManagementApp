using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp.TodolistFolder
{
    public partial class Update_Delete_TYPECOLOR : Form
    {
        List<Display_TYPEITEM> mang_displayitem = new List<Display_TYPEITEM>();
        public Update_Delete_TYPECOLOR()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            DataTable all_typeitem = WorkPlace.bang_AllTYPEITEM_TDL;
            for (int i = 0; i < all_typeitem.Rows.Count; i++)
            {
                string pk = all_typeitem.Rows[i]["PK_COLOR"].ToString();
                Color bg = ColorTranslator.FromHtml(all_typeitem.Rows[i]["TYPECOLOR"].ToString());
                string txt = all_typeitem.Rows[i]["NAMETYPE"].ToString();
                Display_TYPEITEM temp = new Display_TYPEITEM(pk, bg, txt);
                mang_displayitem.Add(temp);
            }
            for (int i = 0; i < mang_displayitem.Count; i++)
            {
                mang_displayitem[i].TopLevel = false;
                mang_displayitem[i].Dock = DockStyle.Top;
                main_panel.Controls.Add(mang_displayitem[i]);
                mang_displayitem[i].Show();
            }
        }

        public new void ShowDialog()
        {
            LoadData();
            base.ShowDialog();
        }

        private void close_iconButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

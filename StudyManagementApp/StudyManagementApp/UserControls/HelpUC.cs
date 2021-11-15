using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp.UserControls
{
    public partial class HelpUC : UserControl
    {
        public HelpUC()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            LoadMau();
            base.Show();
        }

        void HamDoiMau(Color x, Color y, Color z)
        {
            this.BackColor = x;

            panel3.BackColor = y;
            panel4.BackColor = y;

            Lb_Instruction.ForeColor = z;
        }

        void LoadMau()
        {
            if (Program.Theme == true)
            {
               HamDoiMau(SacMau.trangvua, Color.Gray, Color.Gray);
              
            }
            else
            {
                HamDoiMau(SacMau.dendam, SacMau.dennhat, SacMau.trangvua);
               
            }
        }

        private void HelpUC_Load(object sender, EventArgs e)
        {
            LoadMau();
        }
    }
}

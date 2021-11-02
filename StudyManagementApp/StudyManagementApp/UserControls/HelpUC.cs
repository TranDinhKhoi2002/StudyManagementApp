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
            Lb_Instruction.ForeColor = Color.White;
            HelpPanel.BackColor = Color.FromArgb(47, 52, 55);
        }
    }
}

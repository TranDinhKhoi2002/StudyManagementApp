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
  
    public partial class SettingPomodoro : Form
    {
        
        public SettingPomodoro()
        {
            InitializeComponent();
            cbbNotification.SelectedIndex = 0;
        }

        public delegate void GETDATA(string Data);
        public GETDATA myData1, myData2, myData3, myData4, myData5, myData6;
        private void btnOK_Click(object sender, EventArgs e)
        {         
            this.Hide();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            myData1(numPomodoro.Value.ToString());            
            myData2(numShortBreak.Value.ToString());        
            myData3(numLongBreak.Value.ToString());
            myData4(numInterval.Value.ToString());
            myData5(numNotification1.Value.ToString());
            myData6(cbbNotification.SelectedIndex.ToString());
        }
      
    }
    public static class ShareVar
    {
        static public int SelectType = 0;

    }
}

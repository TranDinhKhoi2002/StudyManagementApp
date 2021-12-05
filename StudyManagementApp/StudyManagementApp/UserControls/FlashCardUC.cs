using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp.UserControls
{
    public partial class FlashCardUC : UserControl
    {
        public FlashCardUC()
        {
            InitializeComponent();
        }

        #region Fields

        bool isFlip;

        #endregion

        #region Controller

        public void FlashCardFlip()
        {
            isFlip = !isFlip;
            WordPanel.Visible = !WordPanel.Visible;
            DefDesTableLayout.Visible = !DefDesTableLayout.Visible;
        }

        #endregion

        #region Event Handlers
        //
        // FlashCardUC
        //
        private void FlashCardUC_Load(object sender, EventArgs e)
        {
            // Set initial state
            isFlip = false;
            WordPanel.Visible = true;
            DefDesTableLayout.Visible = false;
        }
        //
        // FlipRcbtn
        //
        private void FlipRcbtn_Click(object sender, EventArgs e)
        {
            FlashCardFlip();
        }

        #endregion

        
    }
}

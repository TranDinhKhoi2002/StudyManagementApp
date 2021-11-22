using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace StudyManagementApp
{
    public partial class ScanForm : Form
    {
        public ScanForm()
        {
            InitializeComponent();
            QRCodeGenerator qr = new QRCodeGenerator();
            string link = "https://www.youtube.com/channel/UCTme98VLVMx9CK59V_jBWFw";
            QRCodeData data = qr.CreateQrCode(link, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            ptbQR.Image = code.GetGraphic(5);
        }
    }
}

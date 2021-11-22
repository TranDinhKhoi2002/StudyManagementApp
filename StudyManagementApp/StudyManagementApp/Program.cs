using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp
{
    static class Program
    {
        public static bool Theme; //false: dark, true: light
        public static Login globalLogin;
        public static WorkPlace globalWorkPlace;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            globalLogin = new Login();
            globalWorkPlace = new WorkPlace();
            Application.Run(globalLogin);
            Theme = false;
        }
    }
}

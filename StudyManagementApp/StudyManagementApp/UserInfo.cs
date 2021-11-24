using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyManagementApp
{
    class UserInfo
    {
        public static UserInfo instance = new UserInfo();


        //Attribute
        private string username = "";
        private string password = "";

        private UserInfo() { }

        //Property
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public static UserInfo getInstance()
        {
            if (instance == null)
            {
                instance = new UserInfo();
            }
            return instance;
        }
    }
}

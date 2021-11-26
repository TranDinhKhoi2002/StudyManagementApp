using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyManagementApp
{
    class UserInfo
    {
        private static UserInfo instance = new UserInfo();

        public static UserInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserInfo();
                return instance;
            }
            private set => instance = value;
        }

        //Attribute
        private string username = "";
        private string password = "";

        private UserInfo() { }

        //Property
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}

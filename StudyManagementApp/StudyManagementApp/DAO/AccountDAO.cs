using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace StudyManagementApp.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return AccountDAO.instance;
            }
            private set => instance = value; 
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";

            string passwordHash;

            using (SHA256 sha256Hash = SHA256.Create())
            {
                passwordHash = Hash.GetHash(sha256Hash, passWord);
            }

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passwordHash });

            return result.Rows.Count > 0;
        }

        public bool Signup(string userName, string passWord, string email)
        {
            string query = "USP_Signup @userName , @passWord , @email";

            //Create hashcode for password
            string passwordHash;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                passwordHash = Hash.GetHash(sha256Hash, passWord);
            }

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, passwordHash, email });

            return result > 0;
        }

        public bool ChangePassword(string userName, string newPassword)
        {
            string query = "USP_ChangePassword @username , @newPassowrd";

            //Create hashcode for password
            string passwordHash;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                passwordHash = Hash.GetHash(sha256Hash, newPassword);
            }

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, passwordHash });

            return result > 0;
        }

        public bool UserExist(string userName)
        {
            try
            {
                string query = "USP_VerifyUserExist @userName";

                if (DataProvider.Instance.ExecuteQuery(query, new object[] { userName }).Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message);
                return false;
            }
        }

        public bool EmailExist(string email)
        {
            try
            {
                string query = "USP_VerifyEmailExist @email";

                if (DataProvider.Instance.ExecuteQuery(query, new object[] { email}).Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message);
                return false;
            }
        }

        public bool EmailOfEachUser(string userName, string email)
        {
            try
            {
                string query = "USP_EmailOfEachUser @userName , @email";
                if (DataProvider.Instance.ExecuteQuery(query, new object[] { userName, email}).Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message);
                return false;
            }
        }

        public DataTable GetAll_TYPEITEM_TDL(string userName)
        {
            string query = "LOAD_ALL_COLORITEM @userName ";

            DataTable result = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            return result;
        }

        public DataTable GetAll_TASK_TDL(string userName)
        {
            string query = "LOAD_ALLITEM @userName ";

            DataTable result = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            return result;
        }

        public bool Add_TYPEITEM_TDL(string userName, string typeCOLOR, string nameTYPE)
        {
            string query = "ADD_COLORITEM @pk_COLOR , @userName , @typeCOLOR , @nameTYPE ";

            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName + DateTime.Now.ToString("MM/dd/yyyyHH:mm:ss"), userName, typeCOLOR, nameTYPE });

            return result > 0;
        }

        public bool Add_TASK_TDL(string userName, DateTime datetimeCREATE, string taskNAME, DateTime datetimeDEADLINE, string note, bool done, string pk_COLOR, DateTime datetimeNOTI)
        {
            string query = "ADD_ITEM @userName , @datetimeCREATE , @taskNAME , @datetimeDEADLINE , @note , @done , @pk_COLOR , @datetimeNOTI ";

            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, datetimeCREATE, taskNAME, datetimeDEADLINE, note, done, pk_COLOR , datetimeNOTI });

            return result > 0;
        }
        public bool Update_TASKDONE_TDL(string userName, DateTime datetimeCreate, bool done)
        {
            string query = "UPDATE_CHECK @userName , @datetimeCreate , @done ";

            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, datetimeCreate, done });

            return result > 0;
        }

        public bool Update_TYPEITEM_TDL(string pk_color,string userName, string typeColor, string nameType)
        {
            string query = "UPDATE_TYPEITEM @pk_COLOR , @userName , @typeCOLOR , @nameTYPE ";

            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { pk_color, userName, typeColor, nameType });

            return result > 0;
        }
    }
}

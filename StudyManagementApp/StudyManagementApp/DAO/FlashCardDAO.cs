using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyManagementApp.DAO
{
    class FlashCardDAO
    {
        private FlashCardDAO instance;

        public FlashCardDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FlashCardDAO();
                return instance;
            }
            private set => instance = value;
        }

        private FlashCardDAO() { }
    }
}

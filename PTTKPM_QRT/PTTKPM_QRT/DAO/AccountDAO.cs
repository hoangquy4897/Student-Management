using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public Account GetAccount(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { userName, passWord });

            if (data.Rows.Count > 0)
            {
                Account account = new Account(data.Rows[0]);
                return account;
            }

            return null;
        }

        public string LoginTypeID(string userName, string passWord)
        {
            string query = "USP_LoginTypeID @userName , @passWord";

            string typeID = DataProvider.Instance.ExcuteScalar(query, new object[] { userName, passWord }).ToString();

            return typeID;
        }
    }
}

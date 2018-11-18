using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.BUS
{
    class AccountBUS
    {
        // Get account
        public static Account GetAccount(string userName, string passWord)
        {
            Console.WriteLine("Checking account id: " + userName);

            return DAO.AccountDAO.Instance.GetAccount(userName, passWord);
        }
    }
}

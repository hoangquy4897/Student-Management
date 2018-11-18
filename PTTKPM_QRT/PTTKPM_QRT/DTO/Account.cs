using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DTO
{
    class Account
    {
        public Account(string accountType, string id, string password)
        {
            this.accountType = accountType;
            this.id = id;
            this.password = password;
        }

        public Account(DataRow row)
        {
            this.accountType = row["LoaiTaiKhoan"].ToString();
            this.id = row["ID"].ToString();
            this.password = row["Pass"].ToString();
        }

        private string accountType;
        private string id;
        private string password;

        public string AccountType { get => accountType; set => accountType = value; }
        public string Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
    }
}

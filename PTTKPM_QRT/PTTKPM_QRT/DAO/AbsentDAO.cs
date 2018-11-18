using System;
using PTTKPM_QRT.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DAO
{
    class AbsentDAO
    {
        private static AbsentDAO instance;

        internal static AbsentDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AbsentDAO();
                return AbsentDAO.instance;
            }
            private set => AbsentDAO.instance = value;
        }

        private AbsentDAO() { }

        // Update list absent
        public void UpdateAbsent(DTO.Absent absent)
        {
            string query = "USP_Absent @StudentID , @Time , @Semester , @Year";

            DataProvider.Instance.ExcuteQuery(query, new object[] { absent.IDStudent , absent.Times, absent.Semester, absent.Year });
        }
    }
}

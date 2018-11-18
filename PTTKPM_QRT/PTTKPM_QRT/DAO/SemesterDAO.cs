using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DAO
{
    class SemesterDAO
    {
        private static SemesterDAO instance;

        internal static SemesterDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SemesterDAO();
                return SemesterDAO.instance;
            }
            set => SemesterDAO.instance = value;
        }

        private SemesterDAO() { }

        public List<Semester> GetListSemester()
        {
            List<Semester> semesters = new List<Semester>();

            string query = "Select * From HOCKY";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            DataRow[] dataRows = data.Select();

            if (dataRows != null)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    Semester semester = new Semester(dataRows[i]);
                    semesters.Add(semester);
                }
                return semesters;
            }

            return null;
        }
    }
}

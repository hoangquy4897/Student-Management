using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DAO
{
    class GradeDAO
    {
        private static GradeDAO instance;

        internal static GradeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GradeDAO();
                return GradeDAO.instance;
            }
            set => GradeDAO.instance = value;
        }

        private GradeDAO() { }

        public List<Grade> GetListGrade()
        {
            List<Grade> grades = new List<Grade>();

            string query = "Select * From KHOI";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            DataRow[] dataRows = data.Select();

            if (dataRows != null)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    Grade grade = new Grade(dataRows[i]);
                    grades.Add(grade);
                }
                return grades;
            }

            return null;
        }
    }
}

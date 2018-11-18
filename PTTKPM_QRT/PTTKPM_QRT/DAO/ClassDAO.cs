using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DAO
{
    class ClassDAO
    {
        private static ClassDAO instance;

        internal static ClassDAO Instance
        {   get
            {
                if (instance == null)
                    instance = new ClassDAO();
                return ClassDAO.instance;
            }
            set => ClassDAO.instance = value;
        }

        private ClassDAO() { }

        public DataTable LoadClass2()
        {
            List<Classes> classes = new List<Classes>();

            string query = "Select * From LOP";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }

        // Get list class by grade
        public List<Classes> GetListClass(string grade)
        {
            List<Classes> classes = new List<Classes>();

            string query = "Select * From LOP Where MaKhoi = " + grade;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            DataRow[] dataRows = data.Select();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                Classes cls = new Classes(dataRows[i]);
                classes.Add(cls);
            }

            return classes;
        }

        // Return data table of list student not have class
        public DataTable ShowListStudentNotHaveClass(int grade, int numberOfStudent)
        {
            string query = "USP_ShowStudent @grade , @numOfStudent";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { grade, numberOfStudent });

            return data;
        }

        // Adding list student to class
        public void AddStudentToClass(int grade, int numberOfStudent, string classID)
        {
            string query = "USP_ValidateListClass @grade , @numOfStudent , @class";

            DataProvider.Instance.ExcuteQuery(query, new object[] { grade, numberOfStudent, classID });
        }
    }
}

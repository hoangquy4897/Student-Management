using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DAO
{
    class SubjectDAO
    {
        private static SubjectDAO instance;

        internal static SubjectDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SubjectDAO();
                return SubjectDAO.instance;
            }
            set => SubjectDAO.instance = value;
        }

        private SubjectDAO() { }

        public List<Subject> GetListSubject()
        {
            List<Subject> subjects = new List<Subject>();

            string query = "Select * From MONHOC";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            DataRow[] dataRows = data.Select();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                Subject subject = new Subject(dataRows[i]);
                subjects.Add(subject);
            }

            return subjects;
        }

        public DataTable LoadSubject2()
        {
            string query = "Select * From MONHOC";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }

        public void AddSubject(Subject subject)
        {
            string query = "Insert into MONHOC values('" + subject.iD + "',N'" + subject.Name + "')";

            DataProvider.Instance.ExcuteQuery(query);
        }

        public void DeleteSubject(Subject subject)
        {
            string query = "Delete From MONHOC Where MaMonHoc = '" + subject.iD + "'";

            DataProvider.Instance.ExcuteQuery(query);
        }

        public string SubjectToSubjectID(string subject)
        {
            string subjectID = "";
            switch (subject)
            {
                case "Toán": subjectID = "T"; break;
                case "Lý": subjectID = "L"; break;
                case "Hóa": subjectID = "H"; break;
                case "Sinh": subjectID = "Si"; break;
                case "Sử": subjectID = "Su"; break;
                case "Địa": subjectID = "D"; break;
                case "Văn": subjectID = "V"; break;
                case "Đạo Đức": subjectID = "DD"; break;
                case "Thể Dục": subjectID = "TD"; break;
            }
            return subjectID;
        }
    }
}

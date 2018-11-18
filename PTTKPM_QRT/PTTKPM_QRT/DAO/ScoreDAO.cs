using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DAO
{
    class ScoreDAO
    {
        private static ScoreDAO instance;

        internal static ScoreDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScoreDAO();
                return ScoreDAO.instance;
            }
            set => ScoreDAO.instance = value;
        }

        private ScoreDAO() { }

        public DataTable CreateAverageScore(string subject, string semester, int year, int grade)
        {
            string query = "USP_StudentNotHaveAVGScore @Subject , @Semester , @Year , @Grade";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { SubjectDAO.Instance.SubjectToSubjectID(subject), semester, year, grade });

            return data;
        }

        public void InitAverageScore(Score score)
        {
            string query = "Insert into DIEMMON values(" + score.iDStudent + ",'" + SubjectDAO.Instance.SubjectToSubjectID(score.iDSubject) + "','" + score.iDSemester + "'," + score.Year + ",null)";

            DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable CreateScoreTable(int year, string subject, string semester, string type, int frequency, int grade, string classID)
        {
            string query = "USP_CreateScoreTable @Year , @SubjectID , @Semester , @TestID , @Frequency , @Grade , @Class";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { year, SubjectDAO.Instance.SubjectToSubjectID(subject), semester, TypeTestDAO.Instance.TypeToTypeID(type), frequency, grade, classID });

            return data;
        }

        public DataTable SearchingScore(int iD, int year, string semester)
        {
            string query = "USP_SearchingScore @Year , @Semester , @StudentID";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { year, semester, iD });

            return data;
        }

        public void UpdateAverageScore(Score score)
        {
            string query = "USP_AverageScore @Year , @Semester , @Subject , @StudentID";

            DataProvider.Instance.ExcuteQuery(query, new object[] { score.Year, score.iDSemester, score.iDSubject, score.iDStudent });
        }

        public DataTable SearchClassScore(int grade, string className, string semester, string subject, string testID, int year, int frequency)
        {
            string query = "USP_AddingScore @Grade , @Class , @Semester , @Subject , @TestID , @Year , @Frequency";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { grade, className, semester, SubjectDAO.Instance.SubjectToSubjectID(subject), TypeTestDAO.Instance.TypeToTypeID(testID), year, frequency });

            return data;
        }
    }
}

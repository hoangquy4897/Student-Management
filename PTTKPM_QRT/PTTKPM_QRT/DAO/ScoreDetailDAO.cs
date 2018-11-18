using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DAO
{
    class ScoreDetailDAO
    {
        private static ScoreDetailDAO instance;

        internal static ScoreDetailDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScoreDetailDAO();
                return ScoreDetailDAO.instance;
            }
            set => instance = value;
        }

        private ScoreDetailDAO() { }

        public void UpdateScoreDetail(ScoreDetail score)
        {
            string query = "USP_UpdateTable @Score , @StudentID , @Year , @SubjectID , @Semester , @TestID , @Frequency";

            DataProvider.Instance.ExcuteQuery(query, new object[] { score.Score, score.IdStudent, score.Year, score.IdSubject, score.IdSemester, score.IdTypeTest, score.Frequency });
        }

        public void InitScoreDetail(ScoreDetail scoreDetail)
        {
            string query = "USP_InsertNullValue @StudentID , @Year , @SubjectID , @Semester , @TestID , @Frequency";

            DataProvider.Instance.ExcuteQuery(query, new object[] { scoreDetail.IdStudent, scoreDetail.Year, SubjectDAO.Instance.SubjectToSubjectID(scoreDetail.IdSubject), scoreDetail.IdSemester, scoreDetail.Score, scoreDetail.Frequency });
        }
    }
}

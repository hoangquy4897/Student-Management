using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.BUS
{
    class ScoreDetailBUS
    {
        // Update score detail
        public static void UpdateScoreDetail(ScoreDetail score)
        {
            Console.WriteLine("Updating score student id: " + score.IdStudent + " -Subject id: " + score.IdSubject);
            DAO.ScoreDetailDAO.Instance.UpdateScoreDetail(score);
            Console.WriteLine("Update score success!");
        }

        // Create score detail
        public static void InitScoreDetail(ScoreDetail scoreDetail)
        {
            Console.WriteLine("Create score student id: " + scoreDetail.IdStudent + " -Subject id: " + scoreDetail.IdSubject);
            DAO.ScoreDetailDAO.Instance.InitScoreDetail(scoreDetail);
            Console.WriteLine("Update score success!");
        }
    }
}

using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.BUS
{
    class ScoreBUS
    {
        // Update average score
        public static void UpdateAverageScore(Score score)
        {
            Console.WriteLine("Updating average score of student id: " + score.iDStudent);
            DAO.ScoreDAO.Instance.UpdateAverageScore(score);
            Console.WriteLine("Update average score success!");
        }

        // Init average score
        public static void InitAverageScore(Score score)
        {
            Console.WriteLine("Create average score of student id: " + score.iDStudent);
            DAO.ScoreDAO.Instance.InitAverageScore(score);
            Console.WriteLine("Create average score success!");
        }
    }
}

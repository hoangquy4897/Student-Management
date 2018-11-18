using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.BUS
{
    class GradeBUS
    {
        // Load list of grades
        public static List<Grade> GetListGrade()
        {
            Console.WriteLine("Loading list grades...");
            return DAO.GradeDAO.Instance.GetListGrade();
        }
    }
}

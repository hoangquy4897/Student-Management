using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.BUS
{
    class SemesterBUS
    {
        // Get semester
        public static List<Semester> GetListSemester()
        {
            Console.WriteLine("Loading list semester...");
            return DAO.SemesterDAO.Instance.GetListSemester();
        }
    }
}

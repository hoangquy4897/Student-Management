using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.BUS
{
    class AbsentBUS
    {
        // Update list absent
        public static void UpdateAbsent(DTO.Absent absent)
        {
            Console.WriteLine("Updating absent list...");
            DAO.AbsentDAO.Instance.UpdateAbsent(absent);
            Console.WriteLine("Update absent list success!");
        }
    }
}

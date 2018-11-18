using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.BUS
{
    class TypeTestBUS
    {
        // Get list all the type of test
        public static List<TypeTest> GetListTypeTest()
        {
            Console.WriteLine("Loading list type test...");
            return DAO.TypeTestDAO.Instance.GetListTypeTest();
        }
    }
}

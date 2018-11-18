using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.BUS
{
    class RuleBUS
    {
        // Get list rules
        public static List<Rule> GetListRules()
        {
            Console.WriteLine("Loading list rules...");
            List<Rule> rules = DAO.RuleDAO.Instance.GetListRules();
            Console.WriteLine("Load list rules success!");
            return rules;
        }
    }
}

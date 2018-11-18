using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DAO
{
    class RuleDAO
    {
        private static RuleDAO instance;

        internal static RuleDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RuleDAO();
                return RuleDAO.instance;
            }
            set => RuleDAO.instance = value;
        }

        public List<Rule> GetListRules()
        {
            List<Rule> rules = new List<Rule>();

            string query = "Select * From QUYDINH";

            System.Data.DataTable data = DataProvider.Instance.ExcuteQuery(query);

            System.Data.DataRow[] dataRows = data.Select();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DTO.Rule rule = new Rule(dataRows[i]);
                rules.Add(rule);
            }

            return rules;
        }
    }
}

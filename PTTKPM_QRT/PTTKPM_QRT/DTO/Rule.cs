using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DTO
{
    class Rule
    {
        public static int minAge;
        public static int maxAge;
        public static int maxNumberOfStudent;
        public static float passGrade;

        public Rule(int id, string name, string content)
        {
            this.iD = id;
            this.Name = name;
            this.Content = content;
        }

        public Rule(DataRow row)
        {
            this.iD = (int)row["MAQD"];
            this.Name = row["TenQD"].ToString();
            this.Content = row["GhiChu"].ToString();
        }

        private int id;
        private string name;
        private string content;

        public int iD { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Content { get => content; set => content = value; }
    }
}

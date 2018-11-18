using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DTO
{
    class TypeTest
    {
        public TypeTest(string id, string name)
        {
            this.iD = id;
            this.Name = name;
        }

        public TypeTest(DataRow row)
        {
            this.iD = row["MaLKT"].ToString();
            this.Name = row["TenLKT"].ToString();
        }

        private string id;
        private string name;

        public string iD { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}

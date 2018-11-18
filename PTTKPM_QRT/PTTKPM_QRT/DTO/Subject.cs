using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DTO
{
    class Subject
    {
        public Subject(string id, string name)
        {
            this.iD = id;
            this.Name = name;
        }

        public Subject(DataRow row)
        {
            this.iD = row["MaMonHoc"].ToString();
            this.Name = row["TenMonHoc"].ToString();
        }

        private string id;
        private string name;

        public string iD { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}

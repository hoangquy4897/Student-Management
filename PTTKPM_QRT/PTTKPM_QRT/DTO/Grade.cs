using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DTO
{
    class Grade
    {
        public Grade(int id, string name, int numberOfClass)
        {
            this.iD = id;
            this.Name = name;
            this.NumberOfClass = numberOfClass;
        }

        public Grade(DataRow row)
        {
            this.iD = (int)row["MaKhoi"];
            this.Name = row["TenKhoi"].ToString();
            this.NumberOfClass = (int)row["SoLopToiDa"];
        }

        private int id;
        private string name;
        private int numberOfClass;

        public int iD { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int NumberOfClass { get => numberOfClass; set => numberOfClass = value; }
    }
}

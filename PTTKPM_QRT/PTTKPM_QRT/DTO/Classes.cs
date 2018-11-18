using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DTO
{
    class Classes
    {
        public Classes(string idClass, int idGrade, string name, int numberOfStudent)
        {
            this.iDClass = idClass;
            this.iDGrade = idGrade;
            this.Name = name;
            this.NumberOfStudent = numberOfStudent;
        }

        public Classes(DataRow row)
        {
            this.iDClass = row["MaLop"].ToString();
            this.iDGrade = (int)row["MaKhoi"];
            this.Name = row["TenLop"].ToString();
            this.NumberOfStudent = (int)row["SiSo"];
        }

        private string idClass;
        private int idGrade;
        private string name;
        private int numberOfStudent;

        public string iDClass { get => idClass; set => idClass = value; }
        public int iDGrade { get => idGrade; set => idGrade = value; }
        public string Name { get => name; set => name = value; }
        public int NumberOfStudent { get => numberOfStudent; set => numberOfStudent = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DTO
{
    class Semester
    {
        public Semester(string id, int year)
        {
            this.iD = id;
            this.Year = year;
        }

        public Semester(DataRow row)
        {
            this.iD = row["MaHocKy"].ToString();
            this.Year = (int)row["NamHoc"];
        }

        private string id;
        private int year;

        public string iD { get => id; set => id = value; }
        public int Year { get => year; set => year = value; }
    }
}

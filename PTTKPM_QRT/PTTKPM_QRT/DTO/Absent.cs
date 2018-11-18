using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DTO
{
    class Absent
    {
        public Absent(int idStudent, int times, string semester, int year)
        {
            this.idStudent = idStudent;
            this.times = times;
            this.semester = semester;
            this.year = year;
        }

        public Absent(DataRow row)
        {
            this.idStudent = (int)row["MaHS"];
            this.times = (int)row["Vang"];
            this.semester = row["MaHocKy"].ToString();
            this.year = (int)row["NamHoc"];
        }

        private int idStudent;
        private int times;
        private string semester;
        private int year;

        public int IDStudent { get => idStudent; set => idStudent = value; }
        public int Times { get => times; set => times = value; }
        public string Semester { get => semester; set => semester = value; }
        public int Year { get => year; set => year = value; }
    }
}

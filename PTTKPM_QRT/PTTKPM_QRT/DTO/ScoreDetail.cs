using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DTO
{
    class ScoreDetail
    {
        public ScoreDetail(int idStudent, string idSubject, string idSemester, int year, string idTypeTest, float score, int frequency)
        {
            this.idStudent = idStudent;
            this.idSubject = idSubject;
            this.idSemester = idSemester;
            this.year = year;
            this.idTypeTest = idTypeTest;
            this.score = score;
            this.frequency = frequency;
        }

        public ScoreDetail(DataRow row)
        {
            this.idStudent = (int)row["MaHS"];
            this.idSubject = row["MaMonHoc"].ToString();
            this.idSemester = row["MaHocKy"].ToString();
            this.year = (int)row["NamHoc"];
            this.idTypeTest = row["MaKT"].ToString();
            this.score = (float)row["Diem"];
            this.frequency = (int)row["Lan"];
        }

        private int idStudent;
        private string idSubject;
        private string idSemester;
        private int year;
        private string idTypeTest;
        private float score;
        private int frequency;

        public int IdStudent { get => idStudent; set => idStudent = value; }
        public string IdSubject { get => idSubject; set => idSubject = value; }
        public string IdSemester { get => idSemester; set => idSemester = value; }
        public int Year { get => year; set => year = value; }
        public string IdTypeTest { get => idTypeTest; set => idTypeTest = value; }
        public float Score { get => score; set => score = value; }
        public int Frequency { get => frequency; set => frequency = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DTO
{
    class Score
    {
        public Score(int idStudent, string idSubject, string idSemester, int year, float averageScore)
        {
            this.iDStudent = idStudent;
            this.iDSubject = idSubject;
            this.iDSemester = idSemester;
            this.Year = year;
            this.AverageScore = averageScore;
        }

        public Score(DataRow row)
        {
            this.iDStudent = (int)row["MaHS"];
            this.iDSubject = row["MaMonHoc"].ToString();
            this.iDSemester = row["MaHocKy"].ToString();
            this.Year = (int)row["NamHoc"];
            this.AverageScore = (float)row["DiemTrungBinh"];
        }

        private int idStudent;
        private string idSubject;
        private string idSemester;
        private int year;
        private float averageScore;

        public int iDStudent { get => idStudent; set => idStudent = value; }
        public string iDSubject { get => idSubject; set => idSubject = value; }
        public string iDSemester { get => idSemester; set => idSemester = value; }
        public int Year { get => year; set => year = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }
    }
}

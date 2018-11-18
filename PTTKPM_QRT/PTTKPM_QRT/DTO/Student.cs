using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DTO
{
    class Student
    {
        public Student(int id, string name, string gender, string birthday, string address, string idClass, string idGrade, string phoneNumber)
        {
            this.iD = id;
            this.Name = name;
            this.Gender = gender;
            this.Birthday = birthday;
            this.Address = address;
            this.IdClass = idClass;
            this.IdGrade = idGrade;
            this.PhoneNumber = phoneNumber;
        }

        public Student(DataRow row)
        {
            this.iD = (int)row["MaHS"];
            this.Name = row["Hoten"].ToString();
            this.Gender = row["Phai"].ToString();
            this.Birthday = row["NgaySinh"].ToString();
            this.Address = row["DiaChi"].ToString();
            this.IdClass = row["MaLop"].ToString();
            this.IdGrade = row["MaKhoi"].ToString();
            this.PhoneNumber = row["SDT"].ToString();
        }

        private int id;
        private string name;
        private string gender;
        private string birthday;
        private string address;
        private string idClass;
        private string idGrade;
        private string phoneNumber;

        public int iD { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }
        public string IdClass { get => idClass; set => idClass = value; }
        public string IdGrade { get => idGrade; set => idGrade = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}

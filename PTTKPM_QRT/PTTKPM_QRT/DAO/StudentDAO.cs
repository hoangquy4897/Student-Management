using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DAO
{
    class StudentDAO
    {
        private static StudentDAO instance;

        internal static StudentDAO Instance
        {
            get
            {
                if(instance == null)
                    instance = new StudentDAO();
                return StudentDAO.instance;
            }
            private set => StudentDAO.instance = value;
        }

        private StudentDAO() { }

        // Get list students
        public List<Student> LoadStudent()
        {
            List<Student> students = new List<Student>();

            string query = "Select * From HOCSINH";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            DataRow[] dataRows = data.Select();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                Student student = new Student(dataRows[i]);
                students.Add(student);
            }

            return students;
        }

        public DataTable LoadStudentTable()
        {
            string query = "Select hs.MaHS as [Mã học sinh], hs.HoTen as [Họ Tên], hs.NgaySinh as [Ngày Sinh], hs.Phai as [Giới Tính], hs.DiaChi as [Địa chỉ], hs.MaKhoi as [Khối], hs.MaLop as [Lớp], hs.SDT as [Số Điện Thoại] From HOCSINH hs";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }

        // Get new ID to add new student
        public int GetNewStudentID(int grade)
        {
            string query = "FindMaxStudentID @Grade";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { grade });

            DataRow[] dataRows = data.Select();

            if (data != null)
            {
                Student student = new Student(dataRows[0]);
                return student.iD + 1;
            }

            return 0;
        }

        // Check student is available
        public bool CheckStudent(Student student)
        {
            string query = "Select * from HOCSINH where MaHs = " + student.iD;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
                return true;

            return false;
        }

        // Check student is available by id
        public bool CheckStudent(int id)
        {
            string query = "Select * from HOCSINH where MaHs = " + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
                return true;

            return false;
        }

        // Add student
        public void AddStudent(Student student)
        {
            string query = "Insert into HOCSINH values(" + student.iD + ", N'" + student.Name + "', N'" + student.Gender + "', '"
                        + student.Birthday + "', N'" + student.Address + "', null, " + student.IdGrade + ", '" + student.PhoneNumber + "')";

            DataProvider.Instance.ExcuteQuery(query);
        }

        // Search student by name
        public DataTable SearchStudent(string name)
        {
            string query = "USP_ShowStudent_SearchingStudent @name";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { name });

            return data;
        }

        
        public DataTable StudentHaveAverageScore(int year, string subject, string semester)
        {
            string query = "USP_GetStudentID_AvgScore @Year , @Subject , @Semester";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { year, subject, semester });

            return data;
        }

        public void InitStudentAbsent(int studentID, string semester, int year)
        {
            string query = "USP_CreateAbsent @StudentID , @Semester , @Year";

            DataProvider.Instance.ExcuteQuery(query, new object[] { studentID, semester, year });
        }

        public DataTable LoadAbsentList(string semester, int year)
        {
            string query = "USP_LoadAbsentList @Semester , @Year";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { semester, year });

            return data;
        }

        public void DeleteStudent(int studentID)
        {
            string query = "Delete From HOCSINH Where MaHS = " + studentID.ToString();

            DataProvider.Instance.ExcuteQuery(query);
        }

        // Update student information
        public void UpdateStudentInformation(int studentID, string name, string gender, string birthday, string address, int grade, string phoneNumber)
        {
            string query = "UpdateStudent @StudentID , @Name , @Gender , @Birthday , @Address , @Grade , @Phone";

            DataProvider.Instance.ExcuteQuery(query, new object[] { studentID, name, gender, birthday, address, grade, phoneNumber });
        }

        public void DeleteAbsent(int studentID)
        {
            string query = "Delete From VANG Where MaHS = " + studentID.ToString();

            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}

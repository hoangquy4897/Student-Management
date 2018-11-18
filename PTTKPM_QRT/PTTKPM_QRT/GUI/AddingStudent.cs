using PTTKPM_QRT.DAO;
using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKPM_QRT
{
    public partial class AddingStudent : Form
    {
        public AddingStudent()
        {
            InitializeComponent();

            LoadGrade();
            LoadGender();
            LoadListStudent();
        }

        // Load mã khối
        void LoadGrade()
        {
            List<Grade> grades = BUS.GradeBUS.GetListGrade();
            
            ComboboxGrade.DataSource = grades;
            ComboboxGrade.DisplayMember = "iD";
            ComboboxGrade.ValueMember = "iD";
        }

        // Load giới tính
        void LoadGender()
        {
            List<string> list = new List<string>();
            list.Add("Nam");
            list.Add("Nữ");
            ComboboxGender.DataSource = list;
        }

        // Xóa tất cả các dòng textbox
        void BlankAllControls()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control item in controls)
                {
                    if (item is TextBox)
                    {
                        (item as TextBox).Clear();
                    }
                    else
                    {
                        func(item.Controls);
                    }
                }
            };
            func(Controls);
        }

        // Add student
        private void button_Validate_Click(object sender, EventArgs e)
        {
            // Check information
            if (TextboxName.Text == "" || TextboxAddress.Text == "" || TextboxBirthDay.Text == "" || TextboxPhoneNumber.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                // Count age
                string[] list = TextboxBirthDay.Text.Split('-');
                int age = 2018 - Int32.Parse(list[0]);

                // Check adding student condition
                if (age >= DTO.Rule.minAge && age <= DTO.Rule.maxAge)
                {
                    if (MessageBox.Show("Bạn chắc chắn đã điền đầy đủ thông tin?", "Xác nhận", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        int id = StudentDAO.Instance.GetNewStudentID(Int32.Parse(ComboboxGrade.Text));
                        Console.WriteLine("New student id: " + id);

                        Student student = new Student(id, TextboxName.Text, ComboboxGender.Text, TextboxBirthDay.Text,
                            TextboxAddress.Text, null, ComboboxGrade.Text, TextboxPhoneNumber.Text);
                        BUS.StudentBUS.AddStudent(student);

                        List<Semester> semesters = BUS.SemesterBUS.GetListSemester();
                        List<string> listSemester = new List<string>();
                        List<int> listYear = new List<int>();
                        for (int i = 0; i < semesters.Count; i++)
                        {
                            listSemester.Add(semesters[i].iD.ToString());
                            listYear.Add(semesters[i].Year);
                        }
                        listSemester = listSemester.Distinct().ToList();
                        listYear = listYear.Distinct().ToList();
                        for (int i = 0; i < listSemester.Count; i++)
                        {
                            for (int j = 0; j < listYear.Count; j++)
                            {
                                StudentDAO.Instance.InitStudentAbsent(id, listSemester[i], listYear[j]);
                                Console.WriteLine("Create absent data for student +" + student.Name + " success!");
                            }
                        }
                        BlankAllControls();
                        LoadListStudent();
                    }
                }
                else
                    MessageBox.Show("Tuổi của học sinh phải từ 15 đến 20", "Thông báo", MessageBoxButtons.OK);
            }
        }

        // Delete student
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa học sinh này khỏi danh sách?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;             
            else
            {
                int studentID = Int32.Parse(DataGridViewListStudent.Rows[DataGridViewListStudent.CurrentCell.RowIndex].Cells[0].Value.ToString());
                BUS.StudentBUS.DeleteStudent(studentID);
                LoadListStudent();
                MessageBox.Show("Xóa học sinh thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        // Update student information
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn lưu bảng thông tin học sinh này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            else
            {
                string name, gender, birthday, address, phoneNumber;
                int studentID, grade;
                foreach (DataGridViewRow row in DataGridViewListStudent.Rows)
                {
                    if (row.Cells[0].Value == null)
                        break;
                    studentID = Int32.Parse(row.Cells[0].Value.ToString());
                    name = row.Cells[1].Value.ToString();
                    birthday = row.Cells[2].Value.ToString();
                    gender = row.Cells[3].Value.ToString();
                    address = row.Cells[4].Value.ToString();
                    grade = Int32.Parse(row.Cells[5].Value.ToString());
                    //classID = row.Cells[6].Value.ToString();
                    phoneNumber = row.Cells[7].Value.ToString();
                    BUS.StudentBUS.UpdateStudentInformation(studentID, name, gender, birthday, address, grade, phoneNumber);
                }
                MessageBox.Show("Cập nhật thông tin học sinh thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        // Load list student to table
        void LoadListStudent()
        {
            DataGridViewListStudent.DataSource = StudentDAO.Instance.LoadStudentTable();
        }

        private void TextboxBirthDay_MouseClick(object sender, MouseEventArgs e)
        {
            DateTimePicker date = new DateTimePicker();
            date.Show();
        }

        private void TextboxBirthDay_MouseDown(object sender, MouseEventArgs e)
        {
            DateTimePickerBirthday.Visible = true;
        }

        private void DateTimePickerBirthday_CloseUp(object sender, EventArgs e)
        {
            TextboxBirthDay.Text = DateTimePickerBirthday.Value.ToString("yyyy-MM-dd");
            DateTimePickerBirthday.Visible = false;
        }
    }
}

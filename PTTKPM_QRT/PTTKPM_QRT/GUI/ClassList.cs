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
    public partial class ClassList : Form
    {
        public ClassList()
        {
            InitializeComponent();
            LoadGrade();
        }

        // Load mã lớp vào combobox theo mã khối
        void LoadClass(string grade)
        {
            List<Classes> classes = BUS.ClassBUS.GetListClasses(grade);
            List<string> list = new List<string>();
            for (int i = 0; i < classes.Count; i++)
            {
                list.Add(classes[i].iDClass.ToString());
            }
            ComboboxClass.DataSource = list;
        }

        // Load mã khối vào combobox
        void LoadGrade()
        {
            List<Grade> grades = BUS.GradeBUS.GetListGrade();
            List<string> list = new List<string>();
            for (int i = 0; i < grades.Count; i++)
            {
                list.Add(grades[i].iD.ToString());
            }
            ComboboxGrade.DataSource = list;
        }

        private void ComboboxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            string grade = cb.SelectedItem as string;
            LoadClass(grade);
        }

        // Exporting list student dont have class to grid table
        void ShowListClass()
        {
            // Lấy khối và sỉ số
            int grade = Int32.Parse(ComboboxGrade.Text);
            int numOfStudent = Int32.Parse(TextboxNumberOfStudent.Text);

            if (numOfStudent <= DTO.Rule.maxNumberOfStudent)
            {
                // Đưa danh sách học sinh ra bảng data
                DataGridViewStudent.DataSource = ClassDAO.Instance.ShowListStudentNotHaveClass(grade, numOfStudent);
            }
            else
                MessageBox.Show("Sỉ số học sinh không được quá " + DTO.Rule.maxNumberOfStudent.ToString(), "Thông báo", MessageBoxButtons.OK);
        }

        private void ButtonArrange_Click(object sender, EventArgs e)
        {
            if (TextboxNumberOfStudent.Text == "")
                MessageBox.Show("Yêu cầu thêm đầy đủ thông tin", "Thông báo");
            else
                ShowListClass();
        }

        // Xác nhận danh sách học sinh và đưa vào lớp
        void ValidateListClass(int grade, int numberOfStudent, string classID)
        {
            ClassDAO.Instance.AddStudentToClass(grade, numberOfStudent, classID);
        }

        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            // Lấy mã khối, sỉ số và mã lớp
            int grade = Int32.Parse(ComboboxGrade.Text);
            int numberOfStudent = 0;
            string classID = ComboboxClass.Text;

            // Nếu sỉ số bỏ trống thì không xếp lớp, nếu không thì set mã lớp của các học sinh đã xếp
            if (TextboxNumberOfStudent.Text == "")
                MessageBox.Show("Yêu cầu thêm đầy đủ thông tin", "Thông báo");
            else
            {
                numberOfStudent = Int32.Parse(TextboxNumberOfStudent.Text);
                if (DataGridViewStudent.DataSource == null)
                {
                    MessageBox.Show("Hãy nhấn xếp lớp trước khi xác nhận", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (MessageBox.Show("Bạn chắc chắn xếp những học sinh dưới vào lớp đã chọn?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        ValidateListClass(grade, numberOfStudent, classID);
                        MessageBox.Show("Xếp lớp thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}

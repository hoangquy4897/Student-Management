using PTTKPM_QRT.BUS;
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
    public partial class Absent : Form
    {
        public Absent()
        {
            InitializeComponent();
            LoadSemesterYear();
        }

        // Load semester to combobox
        void LoadSemesterYear()
        {
            List<Semester> semesters = BUS.SemesterBUS.GetListSemester();
            List<string> listSemester = new List<string>();
            List<string> listYear = new List<string>();
            for (int i = 0; i < semesters.Count; i++)
            {
                listSemester.Add(semesters[i].iD.ToString());
                listYear.Add(semesters[i].Year.ToString());
            }
            ComboboxYear.DataSource = listYear.Distinct().ToList();
            ComboboxSemester.DataSource = listSemester.Distinct().ToList();
        }

        // Create list absent for student dont have list absent
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            List<Student> students = StudentDAO.Instance.LoadStudent();

            for (int i = 0; i < students.Count(); i++)
            {
                StudentDAO.Instance.InitStudentAbsent(Int32.Parse(students[i].iD.ToString()), ComboboxSemester.Text, Int32.Parse(ComboboxYear.Text));
            }
            MessageBox.Show("Tạo danh sách vắng thành công", "Thông báo", MessageBoxButtons.OK);
            Reload();
        }

        // Reaload list absent
        void Reload()
        {
            DataGridViewAbsent.DataSource = StudentDAO.Instance.LoadAbsentList(ComboboxSemester.Text, Int32.Parse(ComboboxYear.Text));
        }

        private void Absent_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void ComboboxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void ComboboxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }

        // Update list absent
        private void ButtonAbsent_Click(object sender, EventArgs e)
        {
            int studentID = Int32.Parse(DataGridViewAbsent.Rows[DataGridViewAbsent.CurrentCell.RowIndex].Cells[0].Value.ToString());
            int times = Int32.Parse(DataGridViewAbsent.Rows[DataGridViewAbsent.CurrentCell.RowIndex].Cells[3].Value.ToString());

            DTO.Absent absent = new DTO.Absent(studentID, times, ComboboxSemester.Text, Int32.Parse(ComboboxYear.Text));
            AbsentBUS.UpdateAbsent(absent);

            Reload();
        }
    }
}

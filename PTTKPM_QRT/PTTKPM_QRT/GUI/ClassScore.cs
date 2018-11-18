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
    public partial class ClassScore : Form
    {
        public ClassScore()
        {
            InitializeComponent();
            LoadGrade();
            LoadSubject();
            LoadSemesterYear();
            LoadType();
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
            for(int i=0;i<grades.Count;i++)
            {
                list.Add(grades[i].iD.ToString());
            }
            ComboboxGrade.DataSource = list;
        }

        // Load tên môn học vào combobox
        void LoadSubject()
        {
            List<Subject> subjects = BUS.SubjectBUS.GetListSubject();
            Console.WriteLine("Loading list subject success!");
            List<string> list = new List<string>();
            for (int i = 0; i < subjects.Count; i++)
            {
                list.Add(subjects[i].Name.ToString());
            }
            ComboboxSubject.DataSource = list;
        }

        // Load mã học kì và năm học vào combobox
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
            ComboboxSemester.DataSource = listSemester.Distinct().ToList();
            ComboboxYear.DataSource = listYear.Distinct().ToList();
        }

        // Load loại kiểm trả
        void LoadType()
        {
            List<TypeTest> typeTests = BUS.TypeTestBUS.GetListTypeTest();
            Console.WriteLine("Loading list type test success!");
            List<string> list = new List<string>();
            for (int i = 0; i < typeTests.Count; i++)
            {
                list.Add(typeTests[i].Name.ToString());
            }
            ComboboxType.DataSource = list;
        }

        // Load lần kiểm tra theo loại kt
        void LoadFrequency()
        {
            List<string> list = new List<string>();
            switch (ComboboxType.Text)
            {
                case "15 Phút":
                    {
                        list.Add("1");
                        list.Add("2");
                    }
                    break;
                case "Miệng":
                    {
                        list.Add("1");
                    }
                    break;
                case "1 Tiết":
                    {
                        list.Add("1");
                        list.Add("2");
                    }
                    break;
                case "Thi Học Kỳ":
                    {
                        list.Add("1");
                    }
                    break;
            }
            ComboboxFrequency.DataSource = list;
        }

        private void ComboboxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            string grade = cb.SelectedItem as string;
            LoadClass(grade);
        }

        private void ComboboxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFrequency();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn lưu bảng điểm này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            else
            {
                string studentID, subjectID, semesterID, year, testID, score, frequency;
                foreach (DataGridViewRow row in DataGridViewScore.Rows)
                {
                    if (row.Cells[0].Value == null)
                        break;
                    studentID = row.Cells[0].Value.ToString();
                    subjectID = row.Cells[2].Value.ToString();
                    semesterID = row.Cells[3].Value.ToString();
                    year = row.Cells[4].Value.ToString();
                    testID = row.Cells[5].Value.ToString();
                    score = row.Cells[6].Value.ToString();
                    if (score == "")
                        continue;
                    frequency = row.Cells[7].Value.ToString();
                    ScoreDetail scoreDetail = new ScoreDetail(Int32.Parse(studentID), subjectID, semesterID, Int32.Parse(year), testID, float.Parse(score), Int32.Parse(frequency));
                    BUS.ScoreDetailBUS.UpdateScoreDetail(scoreDetail);
                }

                // Update điểm trung bình cho từng bộ môn của từng học sinh
                List<Subject> subjects = BUS.SubjectBUS.GetListSubject();
                for (int i = 0; i < subjects.Count(); i++)
                {
                    DataTable data = StudentDAO.Instance.StudentHaveAverageScore(Int32.Parse(ComboboxYear.Text), subjects[i].iD, ComboboxSemester.Text);
                    for (int j = 0; j < data.Rows.Count; j++)
                    {
                        string temp = data.Rows[0][0].ToString();
                        Score scr = new Score(Int32.Parse(data.Rows[j][0].ToString()), subjects[i].iD, ComboboxSemester.Text, Int32.Parse(ComboboxYear.Text), 0);
                        BUS.ScoreBUS.UpdateAverageScore(scr);
                    }
                }
                MessageBox.Show("Lưu điểm thành công!", "Thông báo");
            }
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            DataGridViewScore.DataSource = ScoreDAO.Instance.SearchClassScore(Int32.Parse(ComboboxGrade.Text), ComboboxClass.Text,
                ComboboxSemester.Text, ComboboxSubject.Text, ComboboxType.Text, Int32.Parse(ComboboxYear.Text), Int32.Parse(ComboboxFrequency.Text));
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn khởi tạo bảng điểm?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            else
            {
                // Khởi tạo điểm trung bình cho những học sinh chưa khởi tạo điểm
                DataGridViewScore.DataSource = ScoreDAO.Instance.CreateAverageScore(ComboboxSubject.Text, ComboboxSemester.Text, Int32.Parse(ComboboxYear.Text), Int32.Parse(ComboboxGrade.Text));
                foreach (DataGridViewRow row in DataGridViewScore.Rows)
                {
                    if (row.Cells[0].Value == null)
                        break;
                    Score scr = new Score(Int32.Parse(row.Cells[0].Value.ToString()), ComboboxSubject.Text, ComboboxSemester.Text, Int32.Parse(ComboboxYear.Text), 0);
                    BUS.ScoreBUS.InitAverageScore(scr);
                }

                // Khởi tạo chi tiết điểm cho những học sinh chưa khởi tạo điểm chi tiết
                DataGridViewScore.DataSource = ScoreDAO.Instance.CreateScoreTable(Int32.Parse(ComboboxYear.Text), ComboboxSubject.Text, ComboboxSemester.Text, ComboboxType.Text, Int32.Parse(ComboboxFrequency.Text), Int32.Parse(ComboboxGrade.Text), ComboboxClass.Text);
                foreach (DataGridViewRow row in DataGridViewScore.Rows)
                {
                    if (row.Cells[0].Value == null)
                        break;
                    ScoreDetail scrDetail = new ScoreDetail(Int32.Parse(row.Cells[0].Value.ToString()), ComboboxSubject.Text, ComboboxSemester.Text, Int32.Parse(ComboboxYear.Text), TypeTestDAO.Instance.TypeToTypeID(ComboboxType.Text), 0, Int32.Parse(ComboboxFrequency.Text));
                    BUS.ScoreDetailBUS.InitScoreDetail(scrDetail);
                }
                DataGridViewScore.DataSource = ScoreDAO.Instance.SearchClassScore(Int32.Parse(ComboboxGrade.Text), ComboboxClass.Text,
                ComboboxSemester.Text, ComboboxSubject.Text, ComboboxType.Text, Int32.Parse(ComboboxYear.Text), Int32.Parse(ComboboxFrequency.Text));
            }
        }
    }
}

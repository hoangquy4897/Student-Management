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
    public partial class StatisticSubject : Form
    {
        public StatisticSubject()
        {
            InitializeComponent();
            LoadSemesterYear();
            LoadSubject();
        }

        // Load tên môn học vào combobox
        void LoadSubject()
        {
            List<Subject> subjects = BUS.SubjectBUS.GetListSubject();
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

        private void StatisticSubject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLHSDataSet.USP_SubjectStatisticReport1' table. You can move, or remove it, as needed.
            this.USP_SubjectStatisticReport1TableAdapter.Fill(this.QLHSDataSet.USP_SubjectStatisticReport1, SubjectDAO.Instance.SubjectToSubjectID(ComboboxSubject.Text),Int32.Parse(ComboboxYear.Text),ComboboxSemester.Text);

            this.reportViewer1.RefreshReport();
        }

        private void ButtonStatistic_Click(object sender, EventArgs e)
        {
            this.USP_SubjectStatisticReport1TableAdapter.Fill(this.QLHSDataSet.USP_SubjectStatisticReport1, SubjectDAO.Instance.SubjectToSubjectID(ComboboxSubject.Text), Int32.Parse(ComboboxYear.Text), ComboboxSemester.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}

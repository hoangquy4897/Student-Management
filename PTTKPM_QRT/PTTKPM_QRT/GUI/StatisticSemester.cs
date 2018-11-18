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
    public partial class StatisticSemester : Form
    {
        public StatisticSemester()
        {
            InitializeComponent();
            LoadSemesterYear();
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

        private void StatisticSemester_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLHSDataSet2.USP_SemesterStatisticReport' table. You can move, or remove it, as needed.
            this.USP_SemesterStatisticReportTableAdapter.Fill(this.QLHSDataSet2.USP_SemesterStatisticReport, Int32.Parse(ComboboxYear.Text),ComboboxSemester.Text);
            this.reportViewer1.RefreshReport();
        }

        private void ButtonStatistic_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLHSDataSet2.USP_SemesterStatisticReport' table. You can move, or remove it, as needed.
            this.USP_SemesterStatisticReportTableAdapter.Fill(this.QLHSDataSet2.USP_SemesterStatisticReport, Int32.Parse(ComboboxYear.Text), ComboboxSemester.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}

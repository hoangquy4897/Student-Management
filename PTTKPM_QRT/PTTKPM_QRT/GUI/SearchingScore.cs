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
    public partial class SearchingScore : Form
    {
        public SearchingScore()
        {
            InitializeComponent();
            LoadSemesterYear();
        }

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

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            DataGridViewScore.DataSource = ScoreDAO.Instance.SearchingScore(Int32.Parse(Login.studentID), Int32.Parse(ComboboxYear.Text), ComboboxSemester.Text);
        }
    }
}

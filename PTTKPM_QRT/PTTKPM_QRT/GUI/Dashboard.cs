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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            PanelSystemDisplay.Visible = true;
            PanelSearchDisplay.Visible = false;
            PanelManageDisplay.Visible = false;
            PanelStatisticDisplay.Visible = false;
        }

        private void PanelImgSystem_Click(object sender, EventArgs e)
        {
            PanelSystem.BackColor = Color.FromArgb(84, 140, 175);
            PanelSystem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            PanelSearch.BackColor = Color.FromArgb(43, 190, 182);
            PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelManage.BackColor = Color.FromArgb(43, 190, 182);
            PanelManage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelStatictis.BackColor = Color.FromArgb(43, 190, 182);
            PanelStatictis.BorderStyle = System.Windows.Forms.BorderStyle.None;

            PanelSystemDisplay.Visible = true;
            PanelSearchDisplay.Visible = false;
            PanelManageDisplay.Visible = false;
            PanelStatisticDisplay.Visible = false;
        }

        private void PanelSearch_Click(object sender, EventArgs e)
        {
            PanelSearch.BackColor = Color.FromArgb(84, 140, 175);
            PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            PanelSystem.BackColor = Color.FromArgb(43, 190, 182);
            PanelSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelManage.BackColor = Color.FromArgb(43, 190, 182);
            PanelManage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelStatictis.BackColor = Color.FromArgb(43, 190, 182);
            PanelStatictis.BorderStyle = System.Windows.Forms.BorderStyle.None;

            PanelSystemDisplay.Visible = false;
            PanelSearchDisplay.Visible = true;
            PanelManageDisplay.Visible = false;
            PanelStatisticDisplay.Visible = false;
        }

        private void PanelManage_Click(object sender, EventArgs e)
        {
            PanelManage.BackColor = Color.FromArgb(84, 140, 175);
            PanelManage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            PanelSearch.BackColor = Color.FromArgb(43, 190, 182);
            PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelSystem.BackColor = Color.FromArgb(43, 190, 182);
            PanelSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelStatictis.BackColor = Color.FromArgb(43, 190, 182);
            PanelStatictis.BorderStyle = System.Windows.Forms.BorderStyle.None;

            PanelSystemDisplay.Visible = false;
            PanelSearchDisplay.Visible = false;
            PanelManageDisplay.Visible = true;
            PanelStatisticDisplay.Visible = false;
        }

        private void PanelStatictis_Click(object sender, EventArgs e)
        {
            PanelStatictis.BackColor = Color.FromArgb(84, 140, 175);
            PanelStatictis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            PanelSearch.BackColor = Color.FromArgb(43, 190, 182);
            PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelManage.BackColor = Color.FromArgb(43, 190, 182);
            PanelManage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelSystem.BackColor = Color.FromArgb(43, 190, 182);
            PanelSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;

            PanelSystemDisplay.Visible = false;
            PanelSearchDisplay.Visible = false;
            PanelManageDisplay.Visible = false;
            PanelStatisticDisplay.Visible = true;
        }

        private void PanelSearchStudentArea_Click(object sender, EventArgs e)
        {
            SearchingStudent f = new SearchingStudent();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void PanelLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelClass_Click(object sender, EventArgs e)
        {
            ClassList f = new ClassList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void PanelStudent_Click(object sender, EventArgs e)
        {
            AddingStudent f = new AddingStudent();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void PanelScore_Click(object sender, EventArgs e)
        {
            ClassScore f = new ClassScore();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void PanelReportSubject_Click(object sender, EventArgs e)
        {
            StatisticSubject f = new StatisticSubject();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void LabelReportSemester_Click(object sender, EventArgs e)
        {
            StatisticSemester f = new StatisticSemester();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void PanelAbsent_Click(object sender, EventArgs e)
        {
            Absent f = new Absent();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void PanelSystemDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelChangingRule_Click(object sender, EventArgs e)
        {

        }

        private void PanelImgChangingRule_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelChangingRule_Click(object sender, EventArgs e)
        {
            ChangingRule f = new ChangingRule();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}

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
    public partial class Dashboard_Student : Form
    {
        public Dashboard_Student()
        {
            InitializeComponent();
        } 

        private void Dashboard_Student_Load(object sender, EventArgs e)
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

        private void PanelSearchScoreArea_Click(object sender, EventArgs e)
        {
            SearchingScore f = new SearchingScore();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

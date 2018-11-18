using PTTKPM_QRT.DAO;
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
    public partial class SearchingStudent : Form
    {
        public SearchingStudent()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextboxName.Text == "")
                MessageBox.Show("Vui lòng điền tên học sinh", "Thông báo", MessageBoxButtons.OK);
            else
            {
                DataTable data = StudentDAO.Instance.SearchStudent(TextboxName.Text);
                if (data.Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy thông tin học sinh cần tìm", "Tìm kiếm thất bại");
                else
                {
                    DataGridViewStudent.DataSource = data;
                }
            }
        }
    }
}

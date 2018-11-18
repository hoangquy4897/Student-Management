using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTKPM_QRT.DAO;
using PTTKPM_QRT.DTO;

namespace PTTKPM_QRT
{
    public partial class Login : Form
    {
        public static string studentID;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txtBx_Login.Text;
            string passWord = txtBx_Password.Text;
            Account account = BUS.AccountBUS.GetAccount(userName, passWord);
            if (account != null)
            {
                Console.WriteLine("Login success! Hello " + account.Id);
                /* Dash board giáo viên */
                if (account.AccountType == "GV")
                {
                    Dashboard f = new Dashboard();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                /* Dash board học sinh */
                else if(account.AccountType == "HS")
                {
                    studentID = userName;
                    Dashboard_Student f = new Dashboard_Student();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                Console.WriteLine("Login fail!");
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TextReader txt = new StreamReader("..\\..\\Rule.txt");
            DTO.Rule.minAge = Int32.Parse(txt.ReadLine());
            DTO.Rule.maxAge = Int32.Parse(txt.ReadLine());
            DTO.Rule.maxNumberOfStudent = Int32.Parse(txt.ReadLine());
            DTO.Rule.passGrade = float.Parse(txt.ReadLine());
            txt.Close();
        }
    }
}

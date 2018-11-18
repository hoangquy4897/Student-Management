using PTTKPM_QRT.DAO;
using PTTKPM_QRT.DTO;
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

namespace PTTKPM_QRT
{
    public partial class ChangingRule : Form
    {
        public ChangingRule()
        {
            InitializeComponent();
            LoadRules();
        }

        void LoadRules()
        {
            List<DTO.Rule> rules = BUS.RuleBUS.GetListRules();
            List<string> list = new List<string>();
            for (int i = 0; i < rules.Count; i++)
            {
                list.Add(rules[i].Name.ToString());
            }
            ComboboxRule.DataSource = list;
        }

        private void ComboboxRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rule = ComboboxRule.Text;
            switch (rule)
            {
                case "Quy Định 1":
                    PanelRule1.Visible = true;
                    PanelRule2.Visible = false;
                    PanelRule3.Visible = false;
                    PanelRule4.Visible = false;
                    break;
                case "Quy Đinh 2":
                    PanelRule1.Visible = false;
                    PanelRule2.Visible = true;
                    PanelRule3.Visible = false;
                    PanelRule4.Visible = false;
                    break;
                case "Quy Định 3":
                    PanelRule1.Visible = false;
                    PanelRule2.Visible = false;
                    PanelRule4.Visible = false;
                    PanelRule3.Visible = true;
                    break;
                case "Quy Định 4":
                    PanelRule1.Visible = false;
                    PanelRule2.Visible = false;
                    PanelRule3.Visible = false;
                    PanelRule4.Visible = true;
                    break;
            }
        }

        private void ChangingRule_Load(object sender, EventArgs e)
        {
            DataGridViewClass.DataSource = ClassDAO.Instance.LoadClass2();
            DataGridViewRule3.DataSource = SubjectDAO.Instance.LoadSubject2();
            PanelRule1.Visible = true;
            PanelRule2.Visible = false;
            PanelRule3.Visible = false;
            PanelRule4.Visible = false;
        }

        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn cập nhật quy định này?", "Xác nhận", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int a = DTO.Rule.minAge;
                int b = DTO.Rule.maxAge;
                DTO.Rule.minAge = Int32.Parse(TextboxMinAge.Text);
                DTO.Rule.maxAge = Int32.Parse(TextboxMaxAge.Text);
                SaveToFile();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn cập nhật quy định này?", "Xác nhận", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DTO.Rule.maxNumberOfStudent = Int32.Parse(TextboxNumberOfStudent.Text);
                SaveToFile();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        void SaveToFile()
        {
            TextWriter txt = new StreamWriter("..\\..\\Rule.txt");
            txt.WriteLine(DTO.Rule.minAge);
            txt.WriteLine(DTO.Rule.maxAge);
            txt.WriteLine(DTO.Rule.maxNumberOfStudent);
            txt.WriteLine(DTO.Rule.passGrade);
            txt.Close();
        }

        private void ButtonValidate4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn cập nhật quy định này?", "Xác nhận", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DTO.Rule.passGrade = float.Parse(TextBoxPassGrade.Text);
                SaveToFile();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void ButtonOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonValidate3_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thêm môn học này?", "Xác nhận", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Subject subject = new Subject(TextboxSubjectID.Text, TextboxSubject.Text);
                BUS.SubjectBUS.AddSubject(subject);
                DataGridViewRule3.DataSource = SubjectDAO.Instance.LoadSubject2();
                MessageBox.Show("Thêm môn học thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string subjectID = DataGridViewRule3.Rows[DataGridViewRule3.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string subjectName = DataGridViewRule3.Rows[DataGridViewRule3.CurrentCell.RowIndex].Cells[1].Value.ToString();
            Subject subject = new Subject(subjectID, subjectName);

            BUS.SubjectBUS.DeleteSubject(subject);

            DataGridViewRule3.DataSource = SubjectDAO.Instance.LoadSubject2();
        }
    }
}

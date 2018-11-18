namespace PTTKPM_QRT
{
    partial class StatisticSemester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticSemester));
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ComboboxSemester = new System.Windows.Forms.ComboBox();
            this.ButtonStatistic = new System.Windows.Forms.Button();
            this.LabelYear = new System.Windows.Forms.Label();
            this.LabelSemester = new System.Windows.Forms.Label();
            this.ComboboxYear = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLHSDataSet2 = new PTTKPM_QRT.QLHSDataSet2();
            this.USP_SemesterStatisticReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_SemesterStatisticReportTableAdapter = new PTTKPM_QRT.QLHSDataSet2TableAdapters.USP_SemesterStatisticReportTableAdapter();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_SemesterStatisticReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.PanelHeader.Controls.Add(this.ButtonBack);
            this.PanelHeader.Controls.Add(this.ComboboxSemester);
            this.PanelHeader.Controls.Add(this.ButtonStatistic);
            this.PanelHeader.Controls.Add(this.LabelYear);
            this.PanelHeader.Controls.Add(this.LabelSemester);
            this.PanelHeader.Controls.Add(this.ComboboxYear);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(746, 93);
            this.PanelHeader.TabIndex = 27;
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.White;
            this.ButtonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.ForeColor = System.Drawing.Color.Black;
            this.ButtonBack.Location = new System.Drawing.Point(588, 30);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(129, 35);
            this.ButtonBack.TabIndex = 28;
            this.ButtonBack.Text = "Quay lại";
            this.ButtonBack.UseVisualStyleBackColor = false;
            // 
            // ComboboxSemester
            // 
            this.ComboboxSemester.FormattingEnabled = true;
            this.ComboboxSemester.Location = new System.Drawing.Point(305, 38);
            this.ComboboxSemester.Name = "ComboboxSemester";
            this.ComboboxSemester.Size = new System.Drawing.Size(83, 21);
            this.ComboboxSemester.TabIndex = 32;
            // 
            // ButtonStatistic
            // 
            this.ButtonStatistic.BackColor = System.Drawing.Color.DimGray;
            this.ButtonStatistic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStatistic.ForeColor = System.Drawing.Color.White;
            this.ButtonStatistic.Location = new System.Drawing.Point(453, 30);
            this.ButtonStatistic.Name = "ButtonStatistic";
            this.ButtonStatistic.Size = new System.Drawing.Size(129, 35);
            this.ButtonStatistic.TabIndex = 27;
            this.ButtonStatistic.Text = "Thống kê";
            this.ButtonStatistic.UseVisualStyleBackColor = false;
            this.ButtonStatistic.Click += new System.EventHandler(this.ButtonStatistic_Click);
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYear.ForeColor = System.Drawing.Color.White;
            this.LabelYear.Location = new System.Drawing.Point(21, 34);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(90, 25);
            this.LabelYear.TabIndex = 29;
            this.LabelYear.Text = "Năm học";
            // 
            // LabelSemester
            // 
            this.LabelSemester.AutoSize = true;
            this.LabelSemester.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSemester.ForeColor = System.Drawing.Color.White;
            this.LabelSemester.Location = new System.Drawing.Point(228, 34);
            this.LabelSemester.Name = "LabelSemester";
            this.LabelSemester.Size = new System.Drawing.Size(71, 25);
            this.LabelSemester.TabIndex = 31;
            this.LabelSemester.Text = "Học kỳ";
            // 
            // ComboboxYear
            // 
            this.ComboboxYear.FormattingEnabled = true;
            this.ComboboxYear.Location = new System.Drawing.Point(117, 38);
            this.ComboboxYear.Name = "ComboboxYear";
            this.ComboboxYear.Size = new System.Drawing.Size(83, 21);
            this.ComboboxYear.TabIndex = 30;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.USP_SemesterStatisticReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PTTKPM_QRT.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(746, 328);
            this.reportViewer1.TabIndex = 28;
            // 
            // QLHSDataSet2
            // 
            this.QLHSDataSet2.DataSetName = "QLHSDataSet2";
            this.QLHSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_SemesterStatisticReportBindingSource
            // 
            this.USP_SemesterStatisticReportBindingSource.DataMember = "USP_SemesterStatisticReport";
            this.USP_SemesterStatisticReportBindingSource.DataSource = this.QLHSDataSet2;
            // 
            // USP_SemesterStatisticReportTableAdapter
            // 
            this.USP_SemesterStatisticReportTableAdapter.ClearBeforeFill = true;
            // 
            // StatisticSemester
            // 
            this.AcceptButton = this.ButtonStatistic;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonBack;
            this.ClientSize = new System.Drawing.Size(746, 421);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.PanelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatisticSemester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý học sinh - Báo cáo tổng kết học kì";
            this.Load += new System.EventHandler(this.StatisticSemester_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_SemesterStatisticReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.ComboBox ComboboxSemester;
        private System.Windows.Forms.Button ButtonStatistic;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label LabelSemester;
        private System.Windows.Forms.ComboBox ComboboxYear;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_SemesterStatisticReportBindingSource;
        private QLHSDataSet2 QLHSDataSet2;
        private QLHSDataSet2TableAdapters.USP_SemesterStatisticReportTableAdapter USP_SemesterStatisticReportTableAdapter;
    }
}
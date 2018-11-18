namespace PTTKPM_QRT
{
    partial class StatisticSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticSubject));
            this.USP_SubjectStatisticReport1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLHSDataSet = new PTTKPM_QRT.QLHSDataSet();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelSubject = new System.Windows.Forms.Label();
            this.ComboboxSubject = new System.Windows.Forms.ComboBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ComboboxSemester = new System.Windows.Forms.ComboBox();
            this.ButtonStatistic = new System.Windows.Forms.Button();
            this.LabelYear = new System.Windows.Forms.Label();
            this.LabelSemester = new System.Windows.Forms.Label();
            this.ComboboxYear = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_SubjectStatisticReport1TableAdapter = new PTTKPM_QRT.QLHSDataSetTableAdapters.USP_SubjectStatisticReport1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.USP_SubjectStatisticReport1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSDataSet)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // USP_SubjectStatisticReport1BindingSource
            // 
            this.USP_SubjectStatisticReport1BindingSource.DataMember = "USP_SubjectStatisticReport1";
            this.USP_SubjectStatisticReport1BindingSource.DataSource = this.QLHSDataSet;
            // 
            // QLHSDataSet
            // 
            this.QLHSDataSet.DataSetName = "QLHSDataSet";
            this.QLHSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.PanelHeader.Controls.Add(this.LabelSubject);
            this.PanelHeader.Controls.Add(this.ComboboxSubject);
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
            // LabelSubject
            // 
            this.LabelSubject.AutoSize = true;
            this.LabelSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubject.ForeColor = System.Drawing.Color.White;
            this.LabelSubject.Location = new System.Drawing.Point(13, 56);
            this.LabelSubject.Name = "LabelSubject";
            this.LabelSubject.Size = new System.Drawing.Size(88, 25);
            this.LabelSubject.TabIndex = 33;
            this.LabelSubject.Text = "Môn học";
            // 
            // ComboboxSubject
            // 
            this.ComboboxSubject.FormattingEnabled = true;
            this.ComboboxSubject.Location = new System.Drawing.Point(109, 60);
            this.ComboboxSubject.Name = "ComboboxSubject";
            this.ComboboxSubject.Size = new System.Drawing.Size(83, 21);
            this.ComboboxSubject.TabIndex = 34;
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.White;
            this.ButtonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.ForeColor = System.Drawing.Color.Black;
            this.ButtonBack.Location = new System.Drawing.Point(595, 31);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(129, 35);
            this.ButtonBack.TabIndex = 28;
            this.ButtonBack.Text = "Quay lại";
            this.ButtonBack.UseVisualStyleBackColor = false;
            // 
            // ComboboxSemester
            // 
            this.ComboboxSemester.FormattingEnabled = true;
            this.ComboboxSemester.Location = new System.Drawing.Point(297, 24);
            this.ComboboxSemester.Name = "ComboboxSemester";
            this.ComboboxSemester.Size = new System.Drawing.Size(83, 21);
            this.ComboboxSemester.TabIndex = 32;
            // 
            // ButtonStatistic
            // 
            this.ButtonStatistic.BackColor = System.Drawing.Color.DimGray;
            this.ButtonStatistic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStatistic.ForeColor = System.Drawing.Color.White;
            this.ButtonStatistic.Location = new System.Drawing.Point(460, 31);
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
            this.LabelYear.Location = new System.Drawing.Point(13, 20);
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
            this.LabelSemester.Location = new System.Drawing.Point(220, 20);
            this.LabelSemester.Name = "LabelSemester";
            this.LabelSemester.Size = new System.Drawing.Size(71, 25);
            this.LabelSemester.TabIndex = 31;
            this.LabelSemester.Text = "Học kỳ";
            // 
            // ComboboxYear
            // 
            this.ComboboxYear.FormattingEnabled = true;
            this.ComboboxYear.Location = new System.Drawing.Point(109, 24);
            this.ComboboxYear.Name = "ComboboxYear";
            this.ComboboxYear.Size = new System.Drawing.Size(83, 21);
            this.ComboboxYear.TabIndex = 30;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_SubjectStatisticReport1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PTTKPM_QRT.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(746, 328);
            this.reportViewer1.TabIndex = 28;
            // 
            // USP_SubjectStatisticReport1TableAdapter
            // 
            this.USP_SubjectStatisticReport1TableAdapter.ClearBeforeFill = true;
            // 
            // StatisticSubject
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
            this.Name = "StatisticSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý học sinh - Thống kê môn học";
            this.Load += new System.EventHandler(this.StatisticSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_SubjectStatisticReport1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSDataSet)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label LabelSubject;
        private System.Windows.Forms.ComboBox ComboboxSubject;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.ComboBox ComboboxSemester;
        private System.Windows.Forms.Button ButtonStatistic;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label LabelSemester;
        private System.Windows.Forms.ComboBox ComboboxYear;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_SubjectStatisticReport1BindingSource;
        private QLHSDataSet QLHSDataSet;
        private QLHSDataSetTableAdapters.USP_SubjectStatisticReport1TableAdapter USP_SubjectStatisticReport1TableAdapter;
    }
}
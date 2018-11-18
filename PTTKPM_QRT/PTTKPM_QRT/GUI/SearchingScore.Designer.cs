namespace PTTKPM_QRT
{
    partial class SearchingScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchingScore));
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.DataGridViewScore = new System.Windows.Forms.DataGridView();
            this.LabelYear = new System.Windows.Forms.Label();
            this.ComboboxYear = new System.Windows.Forms.ComboBox();
            this.LabelSemester = new System.Windows.Forms.Label();
            this.ComboboxSemester = new System.Windows.Forms.ComboBox();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewScore)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.DimGray;
            this.ButtonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonBack.Location = new System.Drawing.Point(604, 128);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(129, 35);
            this.ButtonBack.TabIndex = 20;
            this.ButtonBack.Text = "Quay lại";
            this.ButtonBack.UseVisualStyleBackColor = false;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(186)))), ((int)(((byte)(182)))));
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonSearch.Location = new System.Drawing.Point(460, 128);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(129, 35);
            this.ButtonSearch.TabIndex = 19;
            this.ButtonSearch.Text = "Tìm kiếm";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.PanelHeader.Controls.Add(this.LabelHeader);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(746, 113);
            this.PanelHeader.TabIndex = 18;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.ForeColor = System.Drawing.Color.White;
            this.LabelHeader.Location = new System.Drawing.Point(32, 21);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(323, 65);
            this.LabelHeader.TabIndex = 1;
            this.LabelHeader.Text = "Tra Cứu Điểm";
            // 
            // DataGridViewScore
            // 
            this.DataGridViewScore.AllowUserToAddRows = false;
            this.DataGridViewScore.AllowUserToDeleteRows = false;
            this.DataGridViewScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewScore.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewScore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewScore.GridColor = System.Drawing.Color.LightGray;
            this.DataGridViewScore.Location = new System.Drawing.Point(0, 180);
            this.DataGridViewScore.Name = "DataGridViewScore";
            this.DataGridViewScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewScore.Size = new System.Drawing.Size(746, 241);
            this.DataGridViewScore.TabIndex = 21;
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYear.Location = new System.Drawing.Point(23, 132);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(90, 25);
            this.LabelYear.TabIndex = 22;
            this.LabelYear.Text = "Năm học";
            // 
            // ComboboxYear
            // 
            this.ComboboxYear.FormattingEnabled = true;
            this.ComboboxYear.Location = new System.Drawing.Point(120, 135);
            this.ComboboxYear.Name = "ComboboxYear";
            this.ComboboxYear.Size = new System.Drawing.Size(83, 21);
            this.ComboboxYear.TabIndex = 23;
            // 
            // LabelSemester
            // 
            this.LabelSemester.AutoSize = true;
            this.LabelSemester.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSemester.Location = new System.Drawing.Point(231, 132);
            this.LabelSemester.Name = "LabelSemester";
            this.LabelSemester.Size = new System.Drawing.Size(71, 25);
            this.LabelSemester.TabIndex = 24;
            this.LabelSemester.Text = "Học kỳ";
            // 
            // ComboboxSemester
            // 
            this.ComboboxSemester.FormattingEnabled = true;
            this.ComboboxSemester.Location = new System.Drawing.Point(308, 135);
            this.ComboboxSemester.Name = "ComboboxSemester";
            this.ComboboxSemester.Size = new System.Drawing.Size(83, 21);
            this.ComboboxSemester.TabIndex = 25;
            // 
            // SearchingScore
            // 
            this.AcceptButton = this.ButtonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonBack;
            this.ClientSize = new System.Drawing.Size(746, 421);
            this.Controls.Add(this.ComboboxSemester);
            this.Controls.Add(this.LabelSemester);
            this.Controls.Add(this.ComboboxYear);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.DataGridViewScore);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.PanelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchingScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý học sinh - Tra cứu điểm";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridView DataGridViewScore;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.ComboBox ComboboxYear;
        private System.Windows.Forms.Label LabelSemester;
        private System.Windows.Forms.ComboBox ComboboxSemester;
    }
}
namespace PTTKPM_QRT
{
    partial class Absent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Absent));
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.ComboboxSemester = new System.Windows.Forms.ComboBox();
            this.LabelYear = new System.Windows.Forms.Label();
            this.LabelSemester = new System.Windows.Forms.Label();
            this.ComboboxYear = new System.Windows.Forms.ComboBox();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonAbsent = new System.Windows.Forms.Button();
            this.ButtonOut = new System.Windows.Forms.Button();
            this.DataGridViewAbsent = new System.Windows.Forms.DataGridView();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAbsent)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.PanelHeader.Controls.Add(this.LabelHeader);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(746, 113);
            this.PanelHeader.TabIndex = 1;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.ForeColor = System.Drawing.Color.White;
            this.LabelHeader.Location = new System.Drawing.Point(32, 21);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(269, 65);
            this.LabelHeader.TabIndex = 1;
            this.LabelHeader.Text = "Đánh Vắng";
            // 
            // ComboboxSemester
            // 
            this.ComboboxSemester.FormattingEnabled = true;
            this.ComboboxSemester.Location = new System.Drawing.Point(313, 128);
            this.ComboboxSemester.Name = "ComboboxSemester";
            this.ComboboxSemester.Size = new System.Drawing.Size(83, 21);
            this.ComboboxSemester.TabIndex = 36;
            this.ComboboxSemester.SelectedIndexChanged += new System.EventHandler(this.ComboboxSemester_SelectedIndexChanged);
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.LabelYear.Location = new System.Drawing.Point(17, 121);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(102, 30);
            this.LabelYear.TabIndex = 33;
            this.LabelYear.Text = "Năm học";
            // 
            // LabelSemester
            // 
            this.LabelSemester.AutoSize = true;
            this.LabelSemester.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.LabelSemester.Location = new System.Drawing.Point(224, 121);
            this.LabelSemester.Name = "LabelSemester";
            this.LabelSemester.Size = new System.Drawing.Size(81, 30);
            this.LabelSemester.TabIndex = 35;
            this.LabelSemester.Text = "Học kỳ";
            // 
            // ComboboxYear
            // 
            this.ComboboxYear.FormattingEnabled = true;
            this.ComboboxYear.Location = new System.Drawing.Point(125, 128);
            this.ComboboxYear.Name = "ComboboxYear";
            this.ComboboxYear.Size = new System.Drawing.Size(83, 21);
            this.ComboboxYear.TabIndex = 34;
            this.ComboboxYear.SelectedIndexChanged += new System.EventHandler(this.ComboboxYear_SelectedIndexChanged);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.ButtonCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonCreate.Location = new System.Drawing.Point(544, 124);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(80, 30);
            this.ButtonCreate.TabIndex = 39;
            this.ButtonCreate.Text = "Khởi tạo";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonAbsent
            // 
            this.ButtonAbsent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.ButtonAbsent.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAbsent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAbsent.Location = new System.Drawing.Point(440, 124);
            this.ButtonAbsent.Name = "ButtonAbsent";
            this.ButtonAbsent.Size = new System.Drawing.Size(98, 30);
            this.ButtonAbsent.TabIndex = 38;
            this.ButtonAbsent.Text = "Đánh vắng";
            this.ButtonAbsent.UseVisualStyleBackColor = false;
            this.ButtonAbsent.Click += new System.EventHandler(this.ButtonAbsent_Click);
            // 
            // ButtonOut
            // 
            this.ButtonOut.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonOut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOut.ForeColor = System.Drawing.Color.Black;
            this.ButtonOut.Location = new System.Drawing.Point(630, 124);
            this.ButtonOut.Name = "ButtonOut";
            this.ButtonOut.Size = new System.Drawing.Size(80, 30);
            this.ButtonOut.TabIndex = 37;
            this.ButtonOut.Text = "Quay lại";
            this.ButtonOut.UseVisualStyleBackColor = false;
            // 
            // DataGridViewAbsent
            // 
            this.DataGridViewAbsent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridViewAbsent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewAbsent.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewAbsent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewAbsent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewAbsent.Location = new System.Drawing.Point(0, 177);
            this.DataGridViewAbsent.Name = "DataGridViewAbsent";
            this.DataGridViewAbsent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewAbsent.Size = new System.Drawing.Size(746, 244);
            this.DataGridViewAbsent.TabIndex = 40;
            // 
            // Absent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonOut;
            this.ClientSize = new System.Drawing.Size(746, 421);
            this.Controls.Add(this.DataGridViewAbsent);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.ButtonAbsent);
            this.Controls.Add(this.ButtonOut);
            this.Controls.Add(this.ComboboxSemester);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.LabelSemester);
            this.Controls.Add(this.ComboboxYear);
            this.Controls.Add(this.PanelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Absent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý học sinh - Đánh vắng";
            this.Load += new System.EventHandler(this.Absent_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAbsent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.ComboBox ComboboxSemester;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label LabelSemester;
        private System.Windows.Forms.ComboBox ComboboxYear;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonAbsent;
        private System.Windows.Forms.Button ButtonOut;
        private System.Windows.Forms.DataGridView DataGridViewAbsent;
    }
}
namespace PTTKPM_QRT
{
    partial class ClassList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassList));
            this.LabelGrade = new System.Windows.Forms.Label();
            this.ComboboxGrade = new System.Windows.Forms.ComboBox();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.LabelClass = new System.Windows.Forms.Label();
            this.ComboboxClass = new System.Windows.Forms.ComboBox();
            this.LabelNumberOfStudent = new System.Windows.Forms.Label();
            this.TextboxNumberOfStudent = new System.Windows.Forms.TextBox();
            this.ButtonValidate = new System.Windows.Forms.Button();
            this.ButtonArrange = new System.Windows.Forms.Button();
            this.ButtonOut = new System.Windows.Forms.Button();
            this.DataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelGrade
            // 
            this.LabelGrade.AutoSize = true;
            this.LabelGrade.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.LabelGrade.Location = new System.Drawing.Point(9, 126);
            this.LabelGrade.Name = "LabelGrade";
            this.LabelGrade.Size = new System.Drawing.Size(58, 30);
            this.LabelGrade.TabIndex = 0;
            this.LabelGrade.Text = "Khối";
            // 
            // ComboboxGrade
            // 
            this.ComboboxGrade.FormattingEnabled = true;
            this.ComboboxGrade.Location = new System.Drawing.Point(73, 133);
            this.ComboboxGrade.Name = "ComboboxGrade";
            this.ComboboxGrade.Size = new System.Drawing.Size(77, 21);
            this.ComboboxGrade.TabIndex = 2;
            this.ComboboxGrade.SelectedIndexChanged += new System.EventHandler(this.ComboboxGrade_SelectedIndexChanged);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.PanelHeader.Controls.Add(this.LabelHeader);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(746, 113);
            this.PanelHeader.TabIndex = 3;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.ForeColor = System.Drawing.Color.White;
            this.LabelHeader.Location = new System.Drawing.Point(32, 21);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(442, 65);
            this.LabelHeader.TabIndex = 1;
            this.LabelHeader.Text = "Lập Danh Sách Lớp";
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.LabelClass.Location = new System.Drawing.Point(165, 126);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(50, 30);
            this.LabelClass.TabIndex = 4;
            this.LabelClass.Text = "Lớp";
            // 
            // ComboboxClass
            // 
            this.ComboboxClass.FormattingEnabled = true;
            this.ComboboxClass.Location = new System.Drawing.Point(221, 133);
            this.ComboboxClass.Name = "ComboboxClass";
            this.ComboboxClass.Size = new System.Drawing.Size(77, 21);
            this.ComboboxClass.TabIndex = 5;
            // 
            // LabelNumberOfStudent
            // 
            this.LabelNumberOfStudent.AutoSize = true;
            this.LabelNumberOfStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberOfStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.LabelNumberOfStudent.Location = new System.Drawing.Point(316, 126);
            this.LabelNumberOfStudent.Name = "LabelNumberOfStudent";
            this.LabelNumberOfStudent.Size = new System.Drawing.Size(59, 30);
            this.LabelNumberOfStudent.TabIndex = 6;
            this.LabelNumberOfStudent.Text = "Sỉ số";
            // 
            // TextboxNumberOfStudent
            // 
            this.TextboxNumberOfStudent.Location = new System.Drawing.Point(381, 134);
            this.TextboxNumberOfStudent.Name = "TextboxNumberOfStudent";
            this.TextboxNumberOfStudent.Size = new System.Drawing.Size(77, 20);
            this.TextboxNumberOfStudent.TabIndex = 7;
            // 
            // ButtonValidate
            // 
            this.ButtonValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.ButtonValidate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonValidate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonValidate.Location = new System.Drawing.Point(566, 129);
            this.ButtonValidate.Name = "ButtonValidate";
            this.ButtonValidate.Size = new System.Drawing.Size(80, 30);
            this.ButtonValidate.TabIndex = 22;
            this.ButtonValidate.Text = "Xác nhận";
            this.ButtonValidate.UseVisualStyleBackColor = false;
            this.ButtonValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // ButtonArrange
            // 
            this.ButtonArrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.ButtonArrange.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonArrange.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonArrange.Location = new System.Drawing.Point(480, 129);
            this.ButtonArrange.Name = "ButtonArrange";
            this.ButtonArrange.Size = new System.Drawing.Size(80, 30);
            this.ButtonArrange.TabIndex = 21;
            this.ButtonArrange.Text = "Xếp lớp";
            this.ButtonArrange.UseVisualStyleBackColor = false;
            this.ButtonArrange.Click += new System.EventHandler(this.ButtonArrange_Click);
            // 
            // ButtonOut
            // 
            this.ButtonOut.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonOut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOut.ForeColor = System.Drawing.Color.Black;
            this.ButtonOut.Location = new System.Drawing.Point(652, 129);
            this.ButtonOut.Name = "ButtonOut";
            this.ButtonOut.Size = new System.Drawing.Size(80, 30);
            this.ButtonOut.TabIndex = 20;
            this.ButtonOut.Text = "Quay lại";
            this.ButtonOut.UseVisualStyleBackColor = false;
            // 
            // DataGridViewStudent
            // 
            this.DataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewStudent.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewStudent.GridColor = System.Drawing.Color.LightGray;
            this.DataGridViewStudent.Location = new System.Drawing.Point(0, 180);
            this.DataGridViewStudent.Name = "DataGridViewStudent";
            this.DataGridViewStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewStudent.Size = new System.Drawing.Size(746, 241);
            this.DataGridViewStudent.TabIndex = 23;
            // 
            // ClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonOut;
            this.ClientSize = new System.Drawing.Size(746, 421);
            this.Controls.Add(this.DataGridViewStudent);
            this.Controls.Add(this.ButtonValidate);
            this.Controls.Add(this.ButtonArrange);
            this.Controls.Add(this.ButtonOut);
            this.Controls.Add(this.TextboxNumberOfStudent);
            this.Controls.Add(this.LabelNumberOfStudent);
            this.Controls.Add(this.ComboboxClass);
            this.Controls.Add(this.LabelClass);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.ComboboxGrade);
            this.Controls.Add(this.LabelGrade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClassList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý học sinh - Lập danh sách lớp";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelGrade;
        private System.Windows.Forms.ComboBox ComboboxGrade;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Label LabelClass;
        private System.Windows.Forms.ComboBox ComboboxClass;
        private System.Windows.Forms.Label LabelNumberOfStudent;
        private System.Windows.Forms.TextBox TextboxNumberOfStudent;
        private System.Windows.Forms.Button ButtonValidate;
        private System.Windows.Forms.Button ButtonArrange;
        private System.Windows.Forms.Button ButtonOut;
        private System.Windows.Forms.DataGridView DataGridViewStudent;
    }
}
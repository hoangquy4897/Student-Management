namespace PTTKPM_QRT
{
    partial class SearchingStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchingStudent));
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.TextboxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.DataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudent)).BeginInit();
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
            this.PanelHeader.TabIndex = 0;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.ForeColor = System.Drawing.Color.White;
            this.LabelHeader.Location = new System.Drawing.Point(32, 21);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(402, 65);
            this.LabelHeader.TabIndex = 1;
            this.LabelHeader.Text = "Tra Cứu Học Sinh";
            // 
            // TextboxName
            // 
            this.TextboxName.Location = new System.Drawing.Point(160, 133);
            this.TextboxName.Name = "TextboxName";
            this.TextboxName.Size = new System.Drawing.Size(265, 20);
            this.TextboxName.TabIndex = 14;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.White;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.LabelName.Location = new System.Drawing.Point(10, 125);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(142, 31);
            this.LabelName.TabIndex = 15;
            this.LabelName.Text = "Tên học sinh";
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.DimGray;
            this.ButtonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonBack.Location = new System.Drawing.Point(592, 126);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(129, 35);
            this.ButtonBack.TabIndex = 17;
            this.ButtonBack.Text = "Quay lại";
            this.ButtonBack.UseVisualStyleBackColor = false;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(186)))), ((int)(((byte)(182)))));
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonSearch.Location = new System.Drawing.Point(448, 126);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(129, 35);
            this.ButtonSearch.TabIndex = 16;
            this.ButtonSearch.Text = "Tìm kiếm";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
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
            this.DataGridViewStudent.TabIndex = 18;
            // 
            // SearchingStudent
            // 
            this.AcceptButton = this.ButtonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonBack;
            this.ClientSize = new System.Drawing.Size(746, 421);
            this.Controls.Add(this.DataGridViewStudent);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextboxName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.PanelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchingStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý học sinh - Tra cứu học sinh";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.TextBox TextboxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.DataGridView DataGridViewStudent;
    }
}
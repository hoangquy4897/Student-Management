namespace PTTKPM_QRT
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Out = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtBx_Login = new System.Windows.Forms.TextBox();
            this.txtBx_Password = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(325, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 65);
            this.label1.TabIndex = 15;
            this.label1.Text = "Đăng Nhập";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 421);
            this.panel1.TabIndex = 14;
            // 
            // btn_Out
            // 
            this.btn_Out.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Out.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.btn_Out.Location = new System.Drawing.Point(519, 289);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.Size = new System.Drawing.Size(175, 36);
            this.btn_Out.TabIndex = 13;
            this.btn_Out.Text = "Thoát";
            this.btn_Out.UseVisualStyleBackColor = false;
            this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Login.Location = new System.Drawing.Point(336, 289);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(175, 36);
            this.btn_Login.TabIndex = 12;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtBx_Login
            // 
            this.txtBx_Login.Location = new System.Drawing.Point(487, 171);
            this.txtBx_Login.Name = "txtBx_Login";
            this.txtBx_Login.Size = new System.Drawing.Size(207, 20);
            this.txtBx_Login.TabIndex = 10;
            // 
            // txtBx_Password
            // 
            this.txtBx_Password.Location = new System.Drawing.Point(487, 223);
            this.txtBx_Password.Name = "txtBx_Password";
            this.txtBx_Password.Size = new System.Drawing.Size(207, 20);
            this.txtBx_Password.TabIndex = 11;
            this.txtBx_Password.UseSystemPasswordChar = true;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Login.Location = new System.Drawing.Point(332, 167);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(129, 23);
            this.label_Login.TabIndex = 8;
            this.label_Login.Text = "Tên Đăng Nhập";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Password.Location = new System.Drawing.Point(332, 219);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(85, 23);
            this.label_Password.TabIndex = 9;
            this.label_Password.Text = "Mật Khẩu";
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_Out;
            this.ClientSize = new System.Drawing.Size(746, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Out);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtBx_Login);
            this.Controls.Add(this.txtBx_Password);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label_Password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Học Sinh - Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Out;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txtBx_Login;
        private System.Windows.Forms.TextBox txtBx_Password;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Password;
    }
}


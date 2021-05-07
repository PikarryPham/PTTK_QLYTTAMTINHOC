
namespace GUI_PTTK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginusername = new System.Windows.Forms.TextBox();
            this.loginpassword = new System.Windows.Forms.TextBox();
            this.loginoption = new System.Windows.Forms.GroupBox();
            this.loginquanli = new System.Windows.Forms.RadioButton();
            this.loginbophanvp = new System.Windows.Forms.RadioButton();
            this.logintiepnhan = new System.Windows.Forms.RadioButton();
            this.nhanvienketoan = new System.Windows.Forms.RadioButton();
            this.logingiaovien = new System.Windows.Forms.RadioButton();
            this.loginhthong = new System.Windows.Forms.Button();
            this.loginoption.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(113, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "He thong trung tam tin hoc KHTN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dang nhap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ten dang nhap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mat khau";
            // 
            // loginusername
            // 
            this.loginusername.Location = new System.Drawing.Point(211, 175);
            this.loginusername.Name = "loginusername";
            this.loginusername.Size = new System.Drawing.Size(384, 22);
            this.loginusername.TabIndex = 10;
            // 
            // loginpassword
            // 
            this.loginpassword.Location = new System.Drawing.Point(211, 236);
            this.loginpassword.Name = "loginpassword";
            this.loginpassword.PasswordChar = '*';
            this.loginpassword.Size = new System.Drawing.Size(384, 22);
            this.loginpassword.TabIndex = 11;
            // 
            // loginoption
            // 
            this.loginoption.Controls.Add(this.loginquanli);
            this.loginoption.Controls.Add(this.loginbophanvp);
            this.loginoption.Controls.Add(this.logintiepnhan);
            this.loginoption.Controls.Add(this.nhanvienketoan);
            this.loginoption.Controls.Add(this.logingiaovien);
            this.loginoption.Location = new System.Drawing.Point(45, 299);
            this.loginoption.Name = "loginoption";
            this.loginoption.Size = new System.Drawing.Size(621, 144);
            this.loginoption.TabIndex = 12;
            this.loginoption.TabStop = false;
            this.loginoption.Text = "Vui long chon loai nguoi dung cua ban";
            // 
            // loginquanli
            // 
            this.loginquanli.AutoSize = true;
            this.loginquanli.Location = new System.Drawing.Point(489, 64);
            this.loginquanli.Name = "loginquanli";
            this.loginquanli.Size = new System.Drawing.Size(78, 21);
            this.loginquanli.TabIndex = 4;
            this.loginquanli.Text = "Quan ly";
            this.loginquanli.UseVisualStyleBackColor = true;
            // 
            // loginbophanvp
            // 
            this.loginbophanvp.AutoSize = true;
            this.loginbophanvp.Location = new System.Drawing.Point(266, 91);
            this.loginbophanvp.Name = "loginbophanvp";
            this.loginbophanvp.Size = new System.Drawing.Size(155, 21);
            this.loginbophanvp.TabIndex = 3;
            this.loginbophanvp.Text = "Bo phan Van phong";
            this.loginbophanvp.UseVisualStyleBackColor = true;
            // 
            // logintiepnhan
            // 
            this.logintiepnhan.AutoSize = true;
            this.logintiepnhan.Location = new System.Drawing.Point(266, 44);
            this.logintiepnhan.Name = "logintiepnhan";
            this.logintiepnhan.Size = new System.Drawing.Size(156, 21);
            this.logintiepnhan.TabIndex = 2;
            this.logintiepnhan.Text = "Nhan vien tiep nhan";
            this.logintiepnhan.UseVisualStyleBackColor = true;
            // 
            // nhanvienketoan
            // 
            this.nhanvienketoan.AutoSize = true;
            this.nhanvienketoan.Location = new System.Drawing.Point(44, 91);
            this.nhanvienketoan.Name = "nhanvienketoan";
            this.nhanvienketoan.Size = new System.Drawing.Size(144, 21);
            this.nhanvienketoan.TabIndex = 1;
            this.nhanvienketoan.Text = "Nhan vien ke toan";
            this.nhanvienketoan.UseVisualStyleBackColor = true;
            // 
            // logingiaovien
            // 
            this.logingiaovien.AutoSize = true;
            this.logingiaovien.Location = new System.Drawing.Point(44, 39);
            this.logingiaovien.Name = "logingiaovien";
            this.logingiaovien.Size = new System.Drawing.Size(91, 21);
            this.logingiaovien.TabIndex = 0;
            this.logingiaovien.Text = "Giao Vien";
            this.logingiaovien.UseVisualStyleBackColor = true;
            // 
            // loginhthong
            // 
            this.loginhthong.Location = new System.Drawing.Point(278, 461);
            this.loginhthong.Name = "loginhthong";
            this.loginhthong.Size = new System.Drawing.Size(176, 46);
            this.loginhthong.TabIndex = 13;
            this.loginhthong.Text = "Dang nhap";
            this.loginhthong.UseVisualStyleBackColor = true;
            this.loginhthong.Click += new System.EventHandler(this.loginhthong_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 519);
            this.Controls.Add(this.loginhthong);
            this.Controls.Add(this.loginoption);
            this.Controls.Add(this.loginpassword);
            this.Controls.Add(this.loginusername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.loginoption.ResumeLayout(false);
            this.loginoption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginusername;
        private System.Windows.Forms.TextBox loginpassword;
        private System.Windows.Forms.GroupBox loginoption;
        private System.Windows.Forms.RadioButton logingiaovien;
        private System.Windows.Forms.RadioButton nhanvienketoan;
        private System.Windows.Forms.RadioButton logintiepnhan;
        private System.Windows.Forms.RadioButton loginbophanvp;
        private System.Windows.Forms.RadioButton loginquanli;
        private System.Windows.Forms.Button loginhthong;
    }
}
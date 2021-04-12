namespace GUI_PTTK
{
    partial class ThanhToanThe
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxChiNhanh = new System.Windows.Forms.TextBox();
            this.textBoxTenNganHang = new System.Windows.Forms.TextBox();
            this.labelChinhanh = new System.Windows.Forms.Label();
            this.labelTennganhang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSotaikhoan = new System.Windows.Forms.Label();
            this.textBoxSoTK = new System.Windows.Forms.TextBox();
            this.labelChutaikhoan = new System.Windows.Forms.Label();
            this.textBoxChuTK = new System.Windows.Forms.TextBox();
            this.buttonQuayVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Xac nhan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxChiNhanh
            // 
            this.textBoxChiNhanh.Location = new System.Drawing.Point(371, 211);
            this.textBoxChiNhanh.Name = "textBoxChiNhanh";
            this.textBoxChiNhanh.Size = new System.Drawing.Size(167, 22);
            this.textBoxChiNhanh.TabIndex = 18;
            this.textBoxChiNhanh.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxTenNganHang
            // 
            this.textBoxTenNganHang.Location = new System.Drawing.Point(371, 160);
            this.textBoxTenNganHang.Name = "textBoxTenNganHang";
            this.textBoxTenNganHang.Size = new System.Drawing.Size(167, 22);
            this.textBoxTenNganHang.TabIndex = 17;
            // 
            // labelChinhanh
            // 
            this.labelChinhanh.AutoSize = true;
            this.labelChinhanh.Location = new System.Drawing.Point(243, 211);
            this.labelChinhanh.Name = "labelChinhanh";
            this.labelChinhanh.Size = new System.Drawing.Size(72, 17);
            this.labelChinhanh.TabIndex = 16;
            this.labelChinhanh.Text = "Chi nhanh";
            this.labelChinhanh.Click += new System.EventHandler(this.labelChinhanh_Click);
            // 
            // labelTennganhang
            // 
            this.labelTennganhang.AutoSize = true;
            this.labelTennganhang.Location = new System.Drawing.Point(243, 160);
            this.labelTennganhang.Name = "labelTennganhang";
            this.labelTennganhang.Size = new System.Drawing.Size(105, 17);
            this.labelTennganhang.TabIndex = 15;
            this.labelTennganhang.Text = "Ten ngan hang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nhap thong tin tai khoan";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSotaikhoan
            // 
            this.labelSotaikhoan.AutoSize = true;
            this.labelSotaikhoan.Location = new System.Drawing.Point(243, 110);
            this.labelSotaikhoan.Name = "labelSotaikhoan";
            this.labelSotaikhoan.Size = new System.Drawing.Size(87, 17);
            this.labelSotaikhoan.TabIndex = 13;
            this.labelSotaikhoan.Text = "So tai khoan";
            // 
            // textBoxSoTK
            // 
            this.textBoxSoTK.Location = new System.Drawing.Point(371, 107);
            this.textBoxSoTK.Name = "textBoxSoTK";
            this.textBoxSoTK.Size = new System.Drawing.Size(167, 22);
            this.textBoxSoTK.TabIndex = 12;
            // 
            // labelChutaikhoan
            // 
            this.labelChutaikhoan.AutoSize = true;
            this.labelChutaikhoan.Location = new System.Drawing.Point(243, 59);
            this.labelChutaikhoan.Name = "labelChutaikhoan";
            this.labelChutaikhoan.Size = new System.Drawing.Size(122, 17);
            this.labelChutaikhoan.TabIndex = 11;
            this.labelChutaikhoan.Text = "Ten chu tai khoan";
            // 
            // textBoxChuTK
            // 
            this.textBoxChuTK.Location = new System.Drawing.Point(371, 56);
            this.textBoxChuTK.Name = "textBoxChuTK";
            this.textBoxChuTK.Size = new System.Drawing.Size(167, 22);
            this.textBoxChuTK.TabIndex = 10;
            // 
            // buttonQuayVe
            // 
            this.buttonQuayVe.Location = new System.Drawing.Point(13, 14);
            this.buttonQuayVe.Name = "buttonQuayVe";
            this.buttonQuayVe.Size = new System.Drawing.Size(75, 23);
            this.buttonQuayVe.TabIndex = 20;
            this.buttonQuayVe.Text = "Quay ve";
            this.buttonQuayVe.UseVisualStyleBackColor = true;
            // 
            // ThanhToanThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuayVe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxChiNhanh);
            this.Controls.Add(this.textBoxTenNganHang);
            this.Controls.Add(this.labelChinhanh);
            this.Controls.Add(this.labelTennganhang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSotaikhoan);
            this.Controls.Add(this.textBoxSoTK);
            this.Controls.Add(this.labelChutaikhoan);
            this.Controls.Add(this.textBoxChuTK);
            this.Name = "ThanhToanThe";
            this.Text = "ThanhToanThe";
            this.Load += new System.EventHandler(this.ThanhToanThe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxChiNhanh;
        private System.Windows.Forms.TextBox textBoxTenNganHang;
        private System.Windows.Forms.Label labelChinhanh;
        private System.Windows.Forms.Label labelTennganhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSotaikhoan;
        private System.Windows.Forms.TextBox textBoxSoTK;
        private System.Windows.Forms.Label labelChutaikhoan;
        private System.Windows.Forms.TextBox textBoxChuTK;
        private System.Windows.Forms.Button buttonQuayVe;
    }
}
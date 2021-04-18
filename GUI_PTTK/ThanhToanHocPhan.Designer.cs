namespace GUI_PTTK
{
    partial class ThanhToanHocPhan
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
            this.labThemHV = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.txbIDHV = new System.Windows.Forms.TextBox();
            this.labTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbTienMat = new System.Windows.Forms.RadioButton();
            this.rbThe = new System.Windows.Forms.RadioButton();
            this.btnThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labThemHV
            // 
            this.labThemHV.AutoSize = true;
            this.labThemHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labThemHV.Location = new System.Drawing.Point(259, 24);
            this.labThemHV.Name = "labThemHV";
            this.labThemHV.Size = new System.Drawing.Size(235, 25);
            this.labThemHV.TabIndex = 24;
            this.labThemHV.Text = "Thanh toan hoc phan";
            this.labThemHV.Click += new System.EventHandler(this.labThemHV_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(295, 148);
            this.dataGridView1.TabIndex = 25;
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.Location = new System.Drawing.Point(60, 23);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(102, 33);
            this.btnQuayVe.TabIndex = 26;
            this.btnQuayVe.Text = "Quay ve";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            // 
            // txbIDHV
            // 
            this.txbIDHV.Location = new System.Drawing.Point(343, 245);
            this.txbIDHV.Name = "txbIDHV";
            this.txbIDHV.Size = new System.Drawing.Size(179, 20);
            this.txbIDHV.TabIndex = 28;
            this.txbIDHV.TextChanged += new System.EventHandler(this.txbTenHV_TextChanged);
            // 
            // labTen
            // 
            this.labTen.AutoSize = true;
            this.labTen.Location = new System.Drawing.Point(226, 248);
            this.labTen.Name = "labTen";
            this.labTen.Size = new System.Drawing.Size(62, 13);
            this.labTen.TabIndex = 27;
            this.labTen.Text = "ID hoc vien";
            this.labTen.Click += new System.EventHandler(this.labTen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Hinh thuc thanh toan";
            // 
            // rbTienMat
            // 
            this.rbTienMat.AutoSize = true;
            this.rbTienMat.Location = new System.Drawing.Point(356, 289);
            this.rbTienMat.Name = "rbTienMat";
            this.rbTienMat.Size = new System.Drawing.Size(66, 17);
            this.rbTienMat.TabIndex = 30;
            this.rbTienMat.TabStop = true;
            this.rbTienMat.Text = "Tien mat";
            this.rbTienMat.UseVisualStyleBackColor = true;
            this.rbTienMat.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbThe
            // 
            this.rbThe.AutoSize = true;
            this.rbThe.Location = new System.Drawing.Point(456, 291);
            this.rbThe.Name = "rbThe";
            this.rbThe.Size = new System.Drawing.Size(44, 17);
            this.rbThe.TabIndex = 31;
            this.rbThe.TabStop = true;
            this.rbThe.Text = "The";
            this.rbThe.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(343, 336);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(102, 33);
            this.btnThanhToan.TabIndex = 32;
            this.btnThanhToan.Text = "Thanh toan";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // ThanhToanHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 445);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.rbThe);
            this.Controls.Add(this.rbTienMat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbIDHV);
            this.Controls.Add(this.labTen);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labThemHV);
            this.Name = "ThanhToanHocPhan";
            this.Text = "ThanhToanHocPhan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labThemHV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.TextBox txbIDHV;
        private System.Windows.Forms.Label labTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTienMat;
        private System.Windows.Forms.RadioButton rbThe;
        private System.Windows.Forms.Button btnThanhToan;
    }
}

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
            this.lb_TTHP = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_DSHD = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_Quaylai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaHD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TTHP
            // 
            this.lb_TTHP.AutoSize = true;
            this.lb_TTHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TTHP.Location = new System.Drawing.Point(283, 22);
            this.lb_TTHP.Name = "lb_TTHP";
            this.lb_TTHP.Size = new System.Drawing.Size(235, 25);
            this.lb_TTHP.TabIndex = 0;
            this.lb_TTHP.Text = "Thanh toan hoc phan";
            this.lb_TTHP.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 197);
            this.dataGridView1.TabIndex = 1;
            // 
            // lb_DSHD
            // 
            this.lb_DSHD.AutoSize = true;
            this.lb_DSHD.Location = new System.Drawing.Point(107, 66);
            this.lb_DSHD.Name = "lb_DSHD";
            this.lb_DSHD.Size = new System.Drawing.Size(176, 13);
            this.lb_DSHD.TabIndex = 2;
            this.lb_DSHD.Text = "Danh sach hoa don can thanh toan";
            this.lb_DSHD.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(338, 370);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(129, 33);
            this.btn_ThanhToan.TabIndex = 3;
            this.btn_ThanhToan.Text = "Tien hanh thanh toan";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            // 
            // btn_Quaylai
            // 
            this.btn_Quaylai.Location = new System.Drawing.Point(110, 22);
            this.btn_Quaylai.Name = "btn_Quaylai";
            this.btn_Quaylai.Size = new System.Drawing.Size(75, 23);
            this.btn_Quaylai.TabIndex = 4;
            this.btn_Quaylai.Text = "Quay ve";
            this.btn_Quaylai.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhap ma hoa don";
            // 
            // txbMaHD
            // 
            this.txbMaHD.Location = new System.Drawing.Point(226, 315);
            this.txbMaHD.Name = "txbMaHD";
            this.txbMaHD.Size = new System.Drawing.Size(100, 20);
            this.txbMaHD.TabIndex = 6;
            // 
            // ThanhToanHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbMaHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Quaylai);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.lb_DSHD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_TTHP);
            this.Name = "ThanhToanHocPhan";
            this.Text = "ThanhToanHocPhan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TTHP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_DSHD;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_Quaylai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaHD;
    }
}
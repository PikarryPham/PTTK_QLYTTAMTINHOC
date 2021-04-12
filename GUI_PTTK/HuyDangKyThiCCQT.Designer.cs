namespace GUI_PTTK
{
    partial class HuyDangKyThiCCQT
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
            this.Button_Quayve = new System.Windows.Forms.Button();
            this.CMND_CCCD = new System.Windows.Forms.Label();
            this.HovaTen = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ki_thi_CCQT = new System.Windows.Forms.Label();
            this.button_xem_CCQT_da_dang_ky = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Quayve
            // 
            this.Button_Quayve.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Button_Quayve.Location = new System.Drawing.Point(12, 12);
            this.Button_Quayve.Name = "Button_Quayve";
            this.Button_Quayve.Size = new System.Drawing.Size(80, 32);
            this.Button_Quayve.TabIndex = 20;
            this.Button_Quayve.Text = "Quay ve";
            this.Button_Quayve.UseVisualStyleBackColor = true;
            // 
            // CMND_CCCD
            // 
            this.CMND_CCCD.AutoSize = true;
            this.CMND_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CMND_CCCD.Location = new System.Drawing.Point(51, 137);
            this.CMND_CCCD.Name = "CMND_CCCD";
            this.CMND_CCCD.Size = new System.Drawing.Size(123, 24);
            this.CMND_CCCD.TabIndex = 24;
            this.CMND_CCCD.Text = "CMND/CCCD";
            // 
            // HovaTen
            // 
            this.HovaTen.AutoSize = true;
            this.HovaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.HovaTen.Location = new System.Drawing.Point(51, 94);
            this.HovaTen.Name = "HovaTen";
            this.HovaTen.Size = new System.Drawing.Size(98, 24);
            this.HovaTen.TabIndex = 23;
            this.HovaTen.Text = "Ho va Ten";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 22);
            this.textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 22);
            this.textBox1.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // Ki_thi_CCQT
            // 
            this.Ki_thi_CCQT.AutoSize = true;
            this.Ki_thi_CCQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Ki_thi_CCQT.Location = new System.Drawing.Point(51, 192);
            this.Ki_thi_CCQT.Name = "Ki_thi_CCQT";
            this.Ki_thi_CCQT.Size = new System.Drawing.Size(108, 24);
            this.Ki_thi_CCQT.TabIndex = 26;
            this.Ki_thi_CCQT.Text = "Ki thi CCQT";
            this.Ki_thi_CCQT.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_xem_CCQT_da_dang_ky
            // 
            this.button_xem_CCQT_da_dang_ky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_xem_CCQT_da_dang_ky.Location = new System.Drawing.Point(180, 399);
            this.button_xem_CCQT_da_dang_ky.Name = "button_xem_CCQT_da_dang_ky";
            this.button_xem_CCQT_da_dang_ky.Size = new System.Drawing.Size(240, 49);
            this.button_xem_CCQT_da_dang_ky.TabIndex = 27;
            this.button_xem_CCQT_da_dang_ky.Text = "Xem CCQT da dang ky";
            this.button_xem_CCQT_da_dang_ky.UseVisualStyleBackColor = true;
            // 
            // HuyDangKyThiCCQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 478);
            this.Controls.Add(this.button_xem_CCQT_da_dang_ky);
            this.Controls.Add(this.Ki_thi_CCQT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CMND_CCCD);
            this.Controls.Add(this.HovaTen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Button_Quayve);
            this.Name = "HuyDangKyThiCCQT";
            this.Text = "HuyDangKyThiCCQT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Quayve;
        private System.Windows.Forms.Label CMND_CCCD;
        private System.Windows.Forms.Label HovaTen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Ki_thi_CCQT;
        private System.Windows.Forms.Button button_xem_CCQT_da_dang_ky;
    }
}
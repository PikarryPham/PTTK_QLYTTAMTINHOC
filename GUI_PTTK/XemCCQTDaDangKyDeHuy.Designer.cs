namespace GUI_PTTK
{
    partial class XemCCQTDaDangKyDeHuy
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
            this.Ki_thi_CCQT = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma_ki_thi_CCQT = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_huy_dang_ky = new System.Windows.Forms.Button();
            this.Button_Quayve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ki_thi_CCQT
            // 
            this.Ki_thi_CCQT.AutoSize = true;
            this.Ki_thi_CCQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Ki_thi_CCQT.Location = new System.Drawing.Point(122, 34);
            this.Ki_thi_CCQT.Name = "Ki_thi_CCQT";
            this.Ki_thi_CCQT.Size = new System.Drawing.Size(108, 24);
            this.Ki_thi_CCQT.TabIndex = 28;
            this.Ki_thi_CCQT.Text = "Ki thi CCQT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(279, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(354, 250);
            this.dataGridView1.TabIndex = 27;
            // 
            // Ma_ki_thi_CCQT
            // 
            this.Ma_ki_thi_CCQT.AutoSize = true;
            this.Ma_ki_thi_CCQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Ma_ki_thi_CCQT.Location = new System.Drawing.Point(122, 316);
            this.Ma_ki_thi_CCQT.Name = "Ma_ki_thi_CCQT";
            this.Ma_ki_thi_CCQT.Size = new System.Drawing.Size(136, 24);
            this.Ma_ki_thi_CCQT.TabIndex = 30;
            this.Ma_ki_thi_CCQT.Text = "Ma ki thi CCQT";
            this.Ma_ki_thi_CCQT.Click += new System.EventHandler(this.Ma_ki_thi_CCQT_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(279, 318);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 22);
            this.textBox2.TabIndex = 29;
            // 
            // button_huy_dang_ky
            // 
            this.button_huy_dang_ky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_huy_dang_ky.Location = new System.Drawing.Point(279, 362);
            this.button_huy_dang_ky.Name = "button_huy_dang_ky";
            this.button_huy_dang_ky.Size = new System.Drawing.Size(240, 49);
            this.button_huy_dang_ky.TabIndex = 31;
            this.button_huy_dang_ky.Text = "Huy dang ky";
            this.button_huy_dang_ky.UseVisualStyleBackColor = true;
            // 
            // Button_Quayve
            // 
            this.Button_Quayve.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Button_Quayve.Location = new System.Drawing.Point(12, 12);
            this.Button_Quayve.Name = "Button_Quayve";
            this.Button_Quayve.Size = new System.Drawing.Size(80, 32);
            this.Button_Quayve.TabIndex = 32;
            this.Button_Quayve.Text = "Quay ve";
            this.Button_Quayve.UseVisualStyleBackColor = true;
            // 
            // XemCCQTDaDangKyDeHuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Quayve);
            this.Controls.Add(this.button_huy_dang_ky);
            this.Controls.Add(this.Ma_ki_thi_CCQT);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Ki_thi_CCQT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "XemCCQTDaDangKyDeHuy";
            this.Text = "XemCCQTDaDangKyDeHuy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ki_thi_CCQT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Ma_ki_thi_CCQT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_huy_dang_ky;
        private System.Windows.Forms.Button Button_Quayve;
    }
}
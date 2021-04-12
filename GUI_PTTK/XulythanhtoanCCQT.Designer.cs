namespace GUI_PTTK
{
    partial class XulythanhtoanCCQT
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
            this.Tong_tien = new System.Windows.Forms.Label();
            this.button_tien_mat = new System.Windows.Forms.Button();
            this.button_the = new System.Windows.Forms.Button();
            this.tien_dang_ky_CCQT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Quayve
            // 
            this.Button_Quayve.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Button_Quayve.Location = new System.Drawing.Point(12, 12);
            this.Button_Quayve.Name = "Button_Quayve";
            this.Button_Quayve.Size = new System.Drawing.Size(80, 32);
            this.Button_Quayve.TabIndex = 18;
            this.Button_Quayve.Text = "Quay ve";
            this.Button_Quayve.UseVisualStyleBackColor = true;
            // 
            // Tong_tien
            // 
            this.Tong_tien.AutoSize = true;
            this.Tong_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Tong_tien.Location = new System.Drawing.Point(115, 86);
            this.Tong_tien.Name = "Tong_tien";
            this.Tong_tien.Size = new System.Drawing.Size(90, 24);
            this.Tong_tien.TabIndex = 20;
            this.Tong_tien.Text = "Tong tien";
            this.Tong_tien.Click += new System.EventHandler(this.HovaTen_Click);
            // 
            // button_tien_mat
            // 
            this.button_tien_mat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_tien_mat.Location = new System.Drawing.Point(78, 160);
            this.button_tien_mat.Name = "button_tien_mat";
            this.button_tien_mat.Size = new System.Drawing.Size(127, 49);
            this.button_tien_mat.TabIndex = 21;
            this.button_tien_mat.Text = "Tien mat";
            this.button_tien_mat.UseVisualStyleBackColor = true;
            // 
            // button_the
            // 
            this.button_the.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_the.Location = new System.Drawing.Point(244, 160);
            this.button_the.Name = "button_the";
            this.button_the.Size = new System.Drawing.Size(127, 49);
            this.button_the.TabIndex = 22;
            this.button_the.Text = "The";
            this.button_the.UseVisualStyleBackColor = true;
            // 
            // tien_dang_ky_CCQT
            // 
            this.tien_dang_ky_CCQT.AutoSize = true;
            this.tien_dang_ky_CCQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tien_dang_ky_CCQT.Location = new System.Drawing.Point(240, 86);
            this.tien_dang_ky_CCQT.Name = "tien_dang_ky_CCQT";
            this.tien_dang_ky_CCQT.Size = new System.Drawing.Size(52, 24);
            this.tien_dang_ky_CCQT.TabIndex = 23;
            this.tien_dang_ky_CCQT.Text = "XXX";
            // 
            // XulythanhtoanCCQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 257);
            this.Controls.Add(this.tien_dang_ky_CCQT);
            this.Controls.Add(this.button_the);
            this.Controls.Add(this.button_tien_mat);
            this.Controls.Add(this.Tong_tien);
            this.Controls.Add(this.Button_Quayve);
            this.Name = "XulythanhtoanCCQT";
            this.Text = "XulythanhtoanCCQT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Quayve;
        private System.Windows.Forms.Label Tong_tien;
        private System.Windows.Forms.Button button_tien_mat;
        private System.Windows.Forms.Button button_the;
        private System.Windows.Forms.Label tien_dang_ky_CCQT;
    }
}
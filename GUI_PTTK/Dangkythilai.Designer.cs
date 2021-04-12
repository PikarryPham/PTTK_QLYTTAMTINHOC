
namespace GUI_PTTK
{
    partial class Dangkythilai
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tenhpdkthilai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(122, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dang ky thi lai hoc phan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(67, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ban co muon thi lai hoc phan nay hay khong?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 56);
            this.button1.TabIndex = 17;
            this.button1.Text = "Dong y";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 56);
            this.button2.TabIndex = 18;
            this.button2.Text = "Khong dong y";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tenhpdkthilai
            // 
            this.tenhpdkthilai.AutoSize = true;
            this.tenhpdkthilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenhpdkthilai.Location = new System.Drawing.Point(229, 121);
            this.tenhpdkthilai.Name = "tenhpdkthilai";
            this.tenhpdkthilai.Size = new System.Drawing.Size(133, 25);
            this.tenhpdkthilai.TabIndex = 15;
            this.tenhpdkthilai.Text = "Ten hoc phan";
            // 
            // Dangkythilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tenhpdkthilai);
            this.Controls.Add(this.label1);
            this.Name = "Dangkythilai";
            this.Text = "Dangkythilai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label tenhpdkthilai;
    }
}
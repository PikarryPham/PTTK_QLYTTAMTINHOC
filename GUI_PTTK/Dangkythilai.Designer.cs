
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
            this.dongy_thilaibtn = new System.Windows.Forms.Button();
            this.khongdongy_thilaibtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(122, 50);
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
            this.label2.Location = new System.Drawing.Point(48, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ban co muon thi lai hoc phan nay hay khong?";
            // 
            // dongy_thilaibtn
            // 
            this.dongy_thilaibtn.Location = new System.Drawing.Point(129, 218);
            this.dongy_thilaibtn.Name = "dongy_thilaibtn";
            this.dongy_thilaibtn.Size = new System.Drawing.Size(169, 56);
            this.dongy_thilaibtn.TabIndex = 17;
            this.dongy_thilaibtn.Text = "Dong y";
            this.dongy_thilaibtn.UseVisualStyleBackColor = true;
            this.dongy_thilaibtn.Click += new System.EventHandler(this.dongy_thilaibtn_Click);
            // 
            // khongdongy_thilaibtn
            // 
            this.khongdongy_thilaibtn.Location = new System.Drawing.Point(318, 218);
            this.khongdongy_thilaibtn.Name = "khongdongy_thilaibtn";
            this.khongdongy_thilaibtn.Size = new System.Drawing.Size(169, 56);
            this.khongdongy_thilaibtn.TabIndex = 18;
            this.khongdongy_thilaibtn.Text = "Khong dong y";
            this.khongdongy_thilaibtn.UseVisualStyleBackColor = true;
            this.khongdongy_thilaibtn.Click += new System.EventHandler(this.khongdongy_thilaibtn_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.username.Location = new System.Drawing.Point(489, 24);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(106, 26);
            this.username.TabIndex = 19;
            this.username.Text = "Username";
            // 
            // Dangkythilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 312);
            this.Controls.Add(this.username);
            this.Controls.Add(this.khongdongy_thilaibtn);
            this.Controls.Add(this.dongy_thilaibtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dangkythilai";
            this.Text = "Dangkythilai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dongy_thilaibtn;
        private System.Windows.Forms.Button khongdongy_thilaibtn;
        private System.Windows.Forms.Label username;
    }
}
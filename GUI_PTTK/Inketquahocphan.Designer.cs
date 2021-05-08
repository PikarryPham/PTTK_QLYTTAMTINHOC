
namespace GUI_PTTK
{
    partial class Inketquahocphan
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
            this.username = new System.Windows.Forms.Label();
            this.khongdongy_inkqhpBtn = new System.Windows.Forms.Button();
            this.dongy_inkqhpBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.username.Location = new System.Drawing.Point(462, 21);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(106, 26);
            this.username.TabIndex = 25;
            this.username.Text = "Username";
            // 
            // khongdongy_inkqhpBtn
            // 
            this.khongdongy_inkqhpBtn.Location = new System.Drawing.Point(291, 199);
            this.khongdongy_inkqhpBtn.Name = "khongdongy_inkqhpBtn";
            this.khongdongy_inkqhpBtn.Size = new System.Drawing.Size(169, 56);
            this.khongdongy_inkqhpBtn.TabIndex = 24;
            this.khongdongy_inkqhpBtn.Text = "Khong dong y";
            this.khongdongy_inkqhpBtn.UseVisualStyleBackColor = true;
            this.khongdongy_inkqhpBtn.Click += new System.EventHandler(this.khongdongy_inkqhpBtn_Click);
            // 
            // dongy_inkqhpBtn
            // 
            this.dongy_inkqhpBtn.Location = new System.Drawing.Point(90, 199);
            this.dongy_inkqhpBtn.Name = "dongy_inkqhpBtn";
            this.dongy_inkqhpBtn.Size = new System.Drawing.Size(169, 56);
            this.dongy_inkqhpBtn.TabIndex = 23;
            this.dongy_inkqhpBtn.Text = "Dong y";
            this.dongy_inkqhpBtn.UseVisualStyleBackColor = true;
            this.dongy_inkqhpBtn.Click += new System.EventHandler(this.dongy_inkqhpBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(32, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ban co muon in ket qua hoc phan nay hay khong?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(158, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "In ket qua hoc phan";
            // 
            // Inketquahocphan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(586, 292);
            this.Controls.Add(this.username);
            this.Controls.Add(this.khongdongy_inkqhpBtn);
            this.Controls.Add(this.dongy_inkqhpBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inketquahocphan";
            this.Text = "Inketquahocphan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button khongdongy_inkqhpBtn;
        private System.Windows.Forms.Button dongy_inkqhpBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
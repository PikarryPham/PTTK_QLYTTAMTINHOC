
namespace GUI_PTTK
{
    partial class TracuuketquahocphanStep3
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
            this.backTrang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.thongtinhp_tracuu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backTrang
            // 
            this.backTrang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.backTrang.Location = new System.Drawing.Point(18, 21);
            this.backTrang.Name = "backTrang";
            this.backTrang.Size = new System.Drawing.Size(99, 36);
            this.backTrang.TabIndex = 12;
            this.backTrang.Text = "Quay ve";
            this.backTrang.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(218, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tra cuu ket qua hoc phan";
            // 
            // thongtinhp_tracuu
            // 
            this.thongtinhp_tracuu.Location = new System.Drawing.Point(178, 135);
            this.thongtinhp_tracuu.Name = "thongtinhp_tracuu";
            this.thongtinhp_tracuu.Size = new System.Drawing.Size(571, 22);
            this.thongtinhp_tracuu.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ten hoc phan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Thong tin chi tiet dang ky hoc phan";
            // 
            // TracuuketquahocphanStep3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thongtinhp_tracuu);
            this.Controls.Add(this.backTrang);
            this.Controls.Add(this.label1);
            this.Name = "TracuuketquahocphanStep3";
            this.Text = "TracuuketquahocphanStep3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backTrang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox thongtinhp_tracuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
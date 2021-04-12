
namespace GUI_PTTK
{
    partial class QuanlikithiCCQT
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
            this.label1 = new System.Windows.Forms.Label();
            this.taokithiccqt = new System.Windows.Forms.Button();
            this.backTrang = new System.Windows.Forms.Button();
            this.dscackithiccqt = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(911, 19);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(85, 29);
            this.username.TabIndex = 0;
            this.username.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(257, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quan li ki thi chung chi quoc te";
            // 
            // taokithiccqt
            // 
            this.taokithiccqt.Location = new System.Drawing.Point(757, 362);
            this.taokithiccqt.Name = "taokithiccqt";
            this.taokithiccqt.Size = new System.Drawing.Size(239, 57);
            this.taokithiccqt.TabIndex = 2;
            this.taokithiccqt.Text = "Tao moi ki thi CCQT";
            this.taokithiccqt.UseVisualStyleBackColor = true;
            // 
            // backTrang
            // 
            this.backTrang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.backTrang.Location = new System.Drawing.Point(22, 12);
            this.backTrang.Name = "backTrang";
            this.backTrang.Size = new System.Drawing.Size(99, 36);
            this.backTrang.TabIndex = 6;
            this.backTrang.Text = "Back";
            this.backTrang.UseVisualStyleBackColor = false;
            // 
            // dscackithiccqt
            // 
            this.dscackithiccqt.Location = new System.Drawing.Point(12, 132);
            this.dscackithiccqt.Name = "dscackithiccqt";
            this.dscackithiccqt.Size = new System.Drawing.Size(706, 566);
            this.dscackithiccqt.TabIndex = 7;
            this.dscackithiccqt.TabStop = false;
            this.dscackithiccqt.Text = "DanhsachcackithiCCQT";
            // 
            // QuanlikithiCCQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 727);
            this.Controls.Add(this.dscackithiccqt);
            this.Controls.Add(this.backTrang);
            this.Controls.Add(this.taokithiccqt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuanlikithiCCQT";
            this.Text = "Quan li ki thi CCQT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button taokithiccqt;
        private System.Windows.Forms.Button backTrang;
        private System.Windows.Forms.GroupBox dscackithiccqt;
    }
}


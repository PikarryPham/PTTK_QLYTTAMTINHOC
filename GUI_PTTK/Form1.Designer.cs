
namespace GUI_PTTK
{
    partial class Form1
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
            this.taomoikithiccqt = new System.Windows.Forms.Button();
            this.capnhatkythiCCQT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(668, 19);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(70, 25);
            this.username.TabIndex = 0;
            this.username.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(178, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quan ly ky thi chung chi quoc te";
            // 
            // taomoikithiccqt
            // 
            this.taomoikithiccqt.Location = new System.Drawing.Point(120, 167);
            this.taomoikithiccqt.Name = "taomoikithiccqt";
            this.taomoikithiccqt.Size = new System.Drawing.Size(243, 70);
            this.taomoikithiccqt.TabIndex = 2;
            this.taomoikithiccqt.Text = "Tao moi ky thi CCQT";
            this.taomoikithiccqt.UseVisualStyleBackColor = true;
            // 
            // capnhatkythiCCQT
            // 
            this.capnhatkythiCCQT.Location = new System.Drawing.Point(419, 167);
            this.capnhatkythiCCQT.Name = "capnhatkythiCCQT";
            this.capnhatkythiCCQT.Size = new System.Drawing.Size(243, 70);
            this.capnhatkythiCCQT.TabIndex = 3;
            this.capnhatkythiCCQT.Text = "Cap nhat thong tin ky thi CCQT";
            this.capnhatkythiCCQT.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tao moi ky thi CCQT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.capnhatkythiCCQT);
            this.Controls.Add(this.taomoikithiccqt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Quan li ki thi CCQT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button taomoikithiccqt;
        private System.Windows.Forms.Button capnhatkythiCCQT;
        private System.Windows.Forms.Button button1;
    }
}


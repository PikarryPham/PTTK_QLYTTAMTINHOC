
namespace GUI_PTTK.component
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.xembtn = new System.Windows.Forms.Button();
            this.suabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thong tin ki thi CCQT";
            // 
            // xembtn
            // 
            this.xembtn.Location = new System.Drawing.Point(21, 249);
            this.xembtn.Name = "xembtn";
            this.xembtn.Size = new System.Drawing.Size(107, 35);
            this.xembtn.TabIndex = 1;
            this.xembtn.Text = "Xem them";
            this.xembtn.UseVisualStyleBackColor = true;
            // 
            // suabtn
            // 
            this.suabtn.Location = new System.Drawing.Point(360, 249);
            this.suabtn.Name = "suabtn";
            this.suabtn.Size = new System.Drawing.Size(107, 35);
            this.suabtn.TabIndex = 2;
            this.suabtn.Text = "Sua";
            this.suabtn.UseMnemonic = false;
            this.suabtn.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.suabtn);
            this.Controls.Add(this.xembtn);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(505, 309);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button xembtn;
        private System.Windows.Forms.Button suabtn;
    }
}

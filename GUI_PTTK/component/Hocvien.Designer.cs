
namespace GUI_PTTK.component
{
    partial class Hocvien
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
            this.thongtinhocvien = new System.Windows.Forms.Label();
            this.tracuukqhocphanbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // thongtinhocvien
            // 
            this.thongtinhocvien.AutoSize = true;
            this.thongtinhocvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtinhocvien.Location = new System.Drawing.Point(22, 15);
            this.thongtinhocvien.Name = "thongtinhocvien";
            this.thongtinhocvien.Size = new System.Drawing.Size(209, 29);
            this.thongtinhocvien.TabIndex = 0;
            this.thongtinhocvien.Text = "Thong tin hoc vien";
            // 
            // tracuukqhocphanbtn
            // 
            this.tracuukqhocphanbtn.Location = new System.Drawing.Point(126, 244);
            this.tracuukqhocphanbtn.Name = "tracuukqhocphanbtn";
            this.tracuukqhocphanbtn.Size = new System.Drawing.Size(186, 44);
            this.tracuukqhocphanbtn.TabIndex = 1;
            this.tracuukqhocphanbtn.Text = "Tra cuu ket qua hoc phan";
            this.tracuukqhocphanbtn.UseVisualStyleBackColor = true;
            // 
            // Hocvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tracuukqhocphanbtn);
            this.Controls.Add(this.thongtinhocvien);
            this.Name = "Hocvien";
            this.Size = new System.Drawing.Size(422, 312);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thongtinhocvien;
        private System.Windows.Forms.Button tracuukqhocphanbtn;
    }
}

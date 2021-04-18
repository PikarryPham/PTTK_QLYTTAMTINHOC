
namespace GUI_PTTK
{
    partial class XacNhanTTTienMat
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
            this.labTTTienMat = new System.Windows.Forms.Label();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnTuChoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labTTTienMat
            // 
            this.labTTTienMat.AutoSize = true;
            this.labTTTienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTTTienMat.Location = new System.Drawing.Point(240, 48);
            this.labTTTienMat.Name = "labTTTienMat";
            this.labTTTienMat.Size = new System.Drawing.Size(321, 25);
            this.labTTTienMat.TabIndex = 25;
            this.labTTTienMat.Text = "Xac nhan thanh toan tien mat";
            this.labTTTienMat.Click += new System.EventHandler(this.labThemHV_Click);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.Location = new System.Drawing.Point(53, 47);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(102, 33);
            this.btnQuayVe.TabIndex = 27;
            this.btnQuayVe.Text = "Quay ve";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(245, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(295, 148);
            this.dataGridView1.TabIndex = 28;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(245, 321);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(102, 33);
            this.btnXacNhan.TabIndex = 33;
            this.btnXacNhan.Text = "Xac nhan";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnTuChoi
            // 
            this.btnTuChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuChoi.Location = new System.Drawing.Point(438, 321);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(102, 33);
            this.btnTuChoi.TabIndex = 34;
            this.btnTuChoi.Text = "Tu choi";
            this.btnTuChoi.UseVisualStyleBackColor = true;
            // 
            // XacNhanTTTienMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTuChoi);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.labTTTienMat);
            this.Name = "XacNhanTTTienMat";
            this.Text = "XacNhanTTTienMat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTTTienMat;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnTuChoi;
    }
}
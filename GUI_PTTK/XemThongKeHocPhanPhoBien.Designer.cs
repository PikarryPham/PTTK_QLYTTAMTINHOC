namespace GUI_PTTK
{
    partial class XemThongKeHocPhanPhoBien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hoc_phan_pho_bien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Quayve
            // 
            this.Button_Quayve.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Button_Quayve.Location = new System.Drawing.Point(12, 12);
            this.Button_Quayve.Name = "Button_Quayve";
            this.Button_Quayve.Size = new System.Drawing.Size(80, 32);
            this.Button_Quayve.TabIndex = 19;
            this.Button_Quayve.Text = "Quay ve";
            this.Button_Quayve.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(491, 377);
            this.dataGridView1.TabIndex = 20;
            // 
            // Hoc_phan_pho_bien
            // 
            this.Hoc_phan_pho_bien.AutoSize = true;
            this.Hoc_phan_pho_bien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Hoc_phan_pho_bien.Location = new System.Drawing.Point(172, 20);
            this.Hoc_phan_pho_bien.Name = "Hoc_phan_pho_bien";
            this.Hoc_phan_pho_bien.Size = new System.Drawing.Size(173, 24);
            this.Hoc_phan_pho_bien.TabIndex = 21;
            this.Hoc_phan_pho_bien.Text = "Hoc phan pho bien";
            // 
            // XemThongKeHocPhanPhoBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hoc_phan_pho_bien);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button_Quayve);
            this.Name = "XemThongKeHocPhanPhoBien";
            this.Text = "XemThongKeHocPhanPhoBien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Quayve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Hoc_phan_pho_bien;
    }
}
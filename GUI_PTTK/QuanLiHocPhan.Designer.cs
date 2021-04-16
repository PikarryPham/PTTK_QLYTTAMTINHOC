namespace GUI_PTTK
{
    partial class QuanLiHocPhan
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
            this.buttonQuayVe = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelHienthi = new System.Windows.Forms.Label();
            this.textBoxIDHocPhan = new System.Windows.Forms.TextBox();
            this.labelIDHocPhan = new System.Windows.Forms.Label();
            this.buttonSua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQuayVe
            // 
            this.buttonQuayVe.Location = new System.Drawing.Point(12, 12);
            this.buttonQuayVe.Name = "buttonQuayVe";
            this.buttonQuayVe.Size = new System.Drawing.Size(75, 23);
            this.buttonQuayVe.TabIndex = 21;
            this.buttonQuayVe.Text = "Quay ve";
            this.buttonQuayVe.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 197);
            this.dataGridView1.TabIndex = 22;
            // 
            // labelHienthi
            // 
            this.labelHienthi.AutoSize = true;
            this.labelHienthi.Location = new System.Drawing.Point(290, 46);
            this.labelHienthi.Name = "labelHienthi";
            this.labelHienthi.Size = new System.Drawing.Size(220, 17);
            this.labelHienthi.TabIndex = 23;
            this.labelHienthi.Text = "Thong tin tat ca hoc phan hien co";
            this.labelHienthi.Click += new System.EventHandler(this.labelHienthi_Click);
            // 
            // textBoxIDHocPhan
            // 
            this.textBoxIDHocPhan.Location = new System.Drawing.Point(345, 286);
            this.textBoxIDHocPhan.Name = "textBoxIDHocPhan";
            this.textBoxIDHocPhan.Size = new System.Drawing.Size(100, 22);
            this.textBoxIDHocPhan.TabIndex = 24;
            this.textBoxIDHocPhan.TextChanged += new System.EventHandler(this.textBoxIDHocPhan_TextChanged);
            // 
            // labelIDHocPhan
            // 
            this.labelIDHocPhan.AutoSize = true;
            this.labelIDHocPhan.Location = new System.Drawing.Point(147, 289);
            this.labelIDHocPhan.Name = "labelIDHocPhan";
            this.labelIDHocPhan.Size = new System.Drawing.Size(176, 17);
            this.labelIDHocPhan.TabIndex = 25;
            this.labelIDHocPhan.Text = "Nhap ID hoc phan can sua";
            this.labelIDHocPhan.Click += new System.EventHandler(this.labelIDHocPhan_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(483, 286);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(168, 23);
            this.buttonSua.TabIndex = 26;
            this.buttonSua.Text = "Sua thong tin hoc phan";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 28;
            this.button1.Text = "Them thong tin hoc phan moi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuanLiHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.labelIDHocPhan);
            this.Controls.Add(this.textBoxIDHocPhan);
            this.Controls.Add(this.labelHienthi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonQuayVe);
            this.Name = "QuanLiHocPhan";
            this.Text = "QuanLiHocPhan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuayVe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelHienthi;
        private System.Windows.Forms.TextBox textBoxIDHocPhan;
        private System.Windows.Forms.Label labelIDHocPhan;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button button1;
    }
}
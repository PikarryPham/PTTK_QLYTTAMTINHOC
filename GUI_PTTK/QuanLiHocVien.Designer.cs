namespace GUI_PTTK
{
    partial class QuanLiHocVien
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
            this.labQLHV = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labIDHV = new System.Windows.Forms.Label();
            this.txbIDHV = new System.Windows.Forms.TextBox();
            this.btnThemHV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuayVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labQLHV
            // 
            this.labQLHV.AutoSize = true;
            this.labQLHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQLHV.Location = new System.Drawing.Point(305, 33);
            this.labQLHV.Name = "labQLHV";
            this.labQLHV.Size = new System.Drawing.Size(183, 25);
            this.labQLHV.TabIndex = 0;
            this.labQLHV.Text = "Quan li hoc vien";
            this.labQLHV.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(256, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(281, 183);
            this.dataGridView1.TabIndex = 1;
            // 
            // labIDHV
            // 
            this.labIDHV.AutoSize = true;
            this.labIDHV.Location = new System.Drawing.Point(136, 295);
            this.labIDHV.Name = "labIDHV";
            this.labIDHV.Size = new System.Drawing.Size(103, 13);
            this.labIDHV.TabIndex = 2;
            this.labIDHV.Text = "ID hoc vien can sua";
            this.labIDHV.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txbIDHV
            // 
            this.txbIDHV.Location = new System.Drawing.Point(280, 292);
            this.txbIDHV.Name = "txbIDHV";
            this.txbIDHV.Size = new System.Drawing.Size(153, 20);
            this.txbIDHV.TabIndex = 3;
            this.txbIDHV.TextChanged += new System.EventHandler(this.txbIDHV_TextChanged);
            // 
            // btnThemHV
            // 
            this.btnThemHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHV.Location = new System.Drawing.Point(478, 374);
            this.btnThemHV.Name = "btnThemHV";
            this.btnThemHV.Size = new System.Drawing.Size(181, 33);
            this.btnThemHV.TabIndex = 4;
            this.btnThemHV.Text = "Them hoc vien moi";
            this.btnThemHV.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(478, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sua thong tin hoc vien";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.Location = new System.Drawing.Point(55, 32);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(102, 33);
            this.btnQuayVe.TabIndex = 6;
            this.btnQuayVe.Text = "Quay ve";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            this.btnQuayVe.Click += new System.EventHandler(this.button2_Click);
            // 
            // QuanLiHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThemHV);
            this.Controls.Add(this.txbIDHV);
            this.Controls.Add(this.labIDHV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labQLHV);
            this.Name = "QuanLiHocVien";
            this.Text = "QuanLiHocVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labQLHV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labIDHV;
        private System.Windows.Forms.TextBox txbIDHV;
        private System.Windows.Forms.Button btnThemHV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuayVe;
    }
}
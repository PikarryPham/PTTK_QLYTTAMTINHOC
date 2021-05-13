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
            this.DSHocVien = new System.Windows.Forms.DataGridView();
            this.NDKT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDKT_TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDKT_CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDKT_GTINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDKT_DCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDKT_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDKT_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labIDHV = new System.Windows.Forms.Label();
            this.txbIDHV = new System.Windows.Forms.TextBox();
            this.btnThemHV = new System.Windows.Forms.Button();
            this.btnSuaTTHV = new System.Windows.Forms.Button();
            this.btnQuayVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSHocVien)).BeginInit();
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
            // DSHocVien
            // 
            this.DSHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSHocVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NDKT_ID,
            this.NDKT_TEN,
            this.NDKT_CMND,
            this.NDKT_GTINH,
            this.NDKT_DCHI,
            this.NDKT_EMAIL,
            this.NDKT_SDT});
            this.DSHocVien.Location = new System.Drawing.Point(27, 86);
            this.DSHocVien.Name = "DSHocVien";
            this.DSHocVien.Size = new System.Drawing.Size(743, 182);
            this.DSHocVien.TabIndex = 1;
            this.DSHocVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSHocVien_CellContentClick);
            // 
            // NDKT_ID
            // 
            this.NDKT_ID.DataPropertyName = "NDKT_ID";
            this.NDKT_ID.HeaderText = "Mã học viên";
            this.NDKT_ID.Name = "NDKT_ID";
            // 
            // NDKT_TEN
            // 
            this.NDKT_TEN.DataPropertyName = "NDKT_TEN";
            this.NDKT_TEN.HeaderText = "Tên học viên";
            this.NDKT_TEN.Name = "NDKT_TEN";
            // 
            // NDKT_CMND
            // 
            this.NDKT_CMND.DataPropertyName = "NDKT_CMND";
            this.NDKT_CMND.HeaderText = "Số CMND";
            this.NDKT_CMND.Name = "NDKT_CMND";
            // 
            // NDKT_GTINH
            // 
            this.NDKT_GTINH.DataPropertyName = "NDKT_GTINH";
            this.NDKT_GTINH.HeaderText = "Giới tính";
            this.NDKT_GTINH.Name = "NDKT_GTINH";
            // 
            // NDKT_DCHI
            // 
            this.NDKT_DCHI.DataPropertyName = "NDKT_DCHI";
            this.NDKT_DCHI.HeaderText = "Địa chỉ";
            this.NDKT_DCHI.Name = "NDKT_DCHI";
            // 
            // NDKT_EMAIL
            // 
            this.NDKT_EMAIL.DataPropertyName = "NDKT_EMAIL";
            this.NDKT_EMAIL.HeaderText = "Email";
            this.NDKT_EMAIL.Name = "NDKT_EMAIL";
            // 
            // NDKT_SDT
            // 
            this.NDKT_SDT.DataPropertyName = "NDKT_SDT";
            this.NDKT_SDT.HeaderText = "SĐT";
            this.NDKT_SDT.Name = "NDKT_SDT";
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
            this.btnThemHV.Click += new System.EventHandler(this.btnThemHV_Click);
            // 
            // btnSuaTTHV
            // 
            this.btnSuaTTHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTTHV.Location = new System.Drawing.Point(478, 285);
            this.btnSuaTTHV.Name = "btnSuaTTHV";
            this.btnSuaTTHV.Size = new System.Drawing.Size(181, 33);
            this.btnSuaTTHV.TabIndex = 5;
            this.btnSuaTTHV.Text = "Sua thong tin hoc vien";
            this.btnSuaTTHV.UseVisualStyleBackColor = true;
            this.btnSuaTTHV.Click += new System.EventHandler(this.btnSuaTTHV_Click);
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
            this.Controls.Add(this.btnSuaTTHV);
            this.Controls.Add(this.btnThemHV);
            this.Controls.Add(this.txbIDHV);
            this.Controls.Add(this.labIDHV);
            this.Controls.Add(this.DSHocVien);
            this.Controls.Add(this.labQLHV);
            this.Name = "QuanLiHocVien";
            this.Text = "QuanLiHocVien";
            this.Load += new System.EventHandler(this.QuanLiHocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSHocVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labQLHV;
        private System.Windows.Forms.DataGridView DSHocVien;
        private System.Windows.Forms.Label labIDHV;
        private System.Windows.Forms.TextBox txbIDHV;
        private System.Windows.Forms.Button btnThemHV;
        private System.Windows.Forms.Button btnSuaTTHV;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDKT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDKT_TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDKT_CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDKT_GTINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDKT_DCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDKT_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDKT_SDT;
    }
}
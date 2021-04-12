
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
            this.label1 = new System.Windows.Forms.Label();
            this.taokithiccqt = new System.Windows.Forms.Button();
            this.backTrang = new System.Windows.Forms.Button();
            this.capnhatkithiccqt = new System.Windows.Forms.Button();
            this.dscackithiccqtTrang = new System.Windows.Forms.GroupBox();
            this.listdskithiCCQT = new System.Windows.Forms.DataGridView();
            this.xemthongtinccqt = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.dscackithiccqtTrang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listdskithiCCQT)).BeginInit();
            this.SuspendLayout();
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
            this.taokithiccqt.Location = new System.Drawing.Point(767, 270);
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
            this.backTrang.Text = "Quay ve";
            this.backTrang.UseVisualStyleBackColor = false;
            // 
            // capnhatkithiccqt
            // 
            this.capnhatkithiccqt.Location = new System.Drawing.Point(767, 374);
            this.capnhatkithiccqt.Name = "capnhatkithiccqt";
            this.capnhatkithiccqt.Size = new System.Drawing.Size(239, 57);
            this.capnhatkithiccqt.TabIndex = 8;
            this.capnhatkithiccqt.Text = "Cap nhat ki thi CCQT";
            this.capnhatkithiccqt.UseVisualStyleBackColor = true;
            // 
            // dscackithiccqtTrang
            // 
            this.dscackithiccqtTrang.Controls.Add(this.listdskithiCCQT);
            this.dscackithiccqtTrang.Location = new System.Drawing.Point(12, 132);
            this.dscackithiccqtTrang.Name = "dscackithiccqtTrang";
            this.dscackithiccqtTrang.Size = new System.Drawing.Size(734, 566);
            this.dscackithiccqtTrang.TabIndex = 7;
            this.dscackithiccqtTrang.TabStop = false;
            this.dscackithiccqtTrang.Text = "Danh sach cac ki thi CCQT";
            // 
            // listdskithiCCQT
            // 
            this.listdskithiCCQT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listdskithiCCQT.Location = new System.Drawing.Point(10, 21);
            this.listdskithiCCQT.Name = "listdskithiCCQT";
            this.listdskithiCCQT.RowHeadersWidth = 51;
            this.listdskithiCCQT.RowTemplate.Height = 24;
            this.listdskithiCCQT.Size = new System.Drawing.Size(696, 545);
            this.listdskithiCCQT.TabIndex = 0;
            // 
            // xemthongtinccqt
            // 
            this.xemthongtinccqt.Location = new System.Drawing.Point(767, 469);
            this.xemthongtinccqt.Name = "xemthongtinccqt";
            this.xemthongtinccqt.Size = new System.Drawing.Size(239, 57);
            this.xemthongtinccqt.TabIndex = 9;
            this.xemthongtinccqt.Text = "Xem thong tin ki thi CCQT";
            this.xemthongtinccqt.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.username.Location = new System.Drawing.Point(885, 16);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(106, 26);
            this.username.TabIndex = 10;
            this.username.Text = "Username";
            // 
            // QuanlikithiCCQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 727);
            this.Controls.Add(this.username);
            this.Controls.Add(this.xemthongtinccqt);
            this.Controls.Add(this.capnhatkithiccqt);
            this.Controls.Add(this.dscackithiccqtTrang);
            this.Controls.Add(this.backTrang);
            this.Controls.Add(this.taokithiccqt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuanlikithiCCQT";
            this.Text = "Quan li ki thi CCQT";
            this.dscackithiccqtTrang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listdskithiCCQT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button taokithiccqt;
        private System.Windows.Forms.Button backTrang;
        private System.Windows.Forms.Button capnhatkithiccqt;
        private System.Windows.Forms.GroupBox dscackithiccqtTrang;
        private System.Windows.Forms.DataGridView listdskithiCCQT;
        private System.Windows.Forms.Button xemthongtinccqt;
        private System.Windows.Forms.Label username;
    }
}


﻿
namespace GUI_PTTK
{
    partial class Chon_ngay_thi_cho_ky_thi_CCQT
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
            this.backTrangTaomoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.makithiccqt_quanli = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timdscacngaythi_chinhsuangaythikithiccqt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chinhsuangaythi_dskithiCCQT = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.showlistkithiccqt_chinhsuangaythi = new System.Windows.Forms.Button();
            this.suangaythi = new System.Windows.Forms.TabPage();
            this.suangaythi_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.xoangaythi = new System.Windows.Forms.TabPage();
            this.xoangaythi_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.themngaythi = new System.Windows.Forms.TabPage();
            this.themngaythi_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlforChinhsuangaythi = new System.Windows.Forms.TabControl();
            this.ngaythimoi_textbox = new System.Windows.Forms.DateTimePicker();
            this.xoangaythi_txt = new System.Windows.Forms.DateTimePicker();
            this.ngaythicu = new System.Windows.Forms.DateTimePicker();
            this.ngaythimoi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makithiccqt_quanli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhsuangaythi_dskithiCCQT)).BeginInit();
            this.suangaythi.SuspendLayout();
            this.xoangaythi.SuspendLayout();
            this.themngaythi.SuspendLayout();
            this.tabControlforChinhsuangaythi.SuspendLayout();
            this.SuspendLayout();
            // 
            // backTrangTaomoi
            // 
            this.backTrangTaomoi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.backTrangTaomoi.Location = new System.Drawing.Point(12, 7);
            this.backTrangTaomoi.Name = "backTrangTaomoi";
            this.backTrangTaomoi.Size = new System.Drawing.Size(99, 36);
            this.backTrangTaomoi.TabIndex = 9;
            this.backTrangTaomoi.Text = "Quay ve";
            this.backTrangTaomoi.UseVisualStyleBackColor = false;
            this.backTrangTaomoi.Click += new System.EventHandler(this.backTrangTaomoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(88, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quan ly ngay thi cho ki thi CCQT";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.username.Location = new System.Drawing.Point(978, 17);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(106, 26);
            this.username.TabIndex = 48;
            this.username.Text = "Username";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.makithiccqt_quanli);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.timdscacngaythi_chinhsuangaythikithiccqt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 415);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin cac ngay thi cua ky thi CCQT";
            // 
            // makithiccqt_quanli
            // 
            this.makithiccqt_quanli.Location = new System.Drawing.Point(159, 35);
            this.makithiccqt_quanli.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.makithiccqt_quanli.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.makithiccqt_quanli.Name = "makithiccqt_quanli";
            this.makithiccqt_quanli.Size = new System.Drawing.Size(292, 22);
            this.makithiccqt_quanli.TabIndex = 55;
            this.makithiccqt_quanli.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 275);
            this.dataGridView1.TabIndex = 54;
            // 
            // timdscacngaythi_chinhsuangaythikithiccqt
            // 
            this.timdscacngaythi_chinhsuangaythikithiccqt.Location = new System.Drawing.Point(159, 72);
            this.timdscacngaythi_chinhsuangaythikithiccqt.Name = "timdscacngaythi_chinhsuangaythikithiccqt";
            this.timdscacngaythi_chinhsuangaythikithiccqt.Size = new System.Drawing.Size(248, 35);
            this.timdscacngaythi_chinhsuangaythikithiccqt.TabIndex = 53;
            this.timdscacngaythi_chinhsuangaythikithiccqt.Text = "Tim danh sach cac ngay thi ";
            this.timdscacngaythi_chinhsuangaythikithiccqt.UseVisualStyleBackColor = true;
            this.timdscacngaythi_chinhsuangaythikithiccqt.Click += new System.EventHandler(this.timdscacngaythi_chinhsuangaythikithiccqt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ma ki thi CCQT";
            // 
            // chinhsuangaythi_dskithiCCQT
            // 
            this.chinhsuangaythi_dskithiCCQT.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.chinhsuangaythi_dskithiCCQT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chinhsuangaythi_dskithiCCQT.Location = new System.Drawing.Point(588, 131);
            this.chinhsuangaythi_dskithiCCQT.Name = "chinhsuangaythi_dskithiCCQT";
            this.chinhsuangaythi_dskithiCCQT.RowHeadersWidth = 51;
            this.chinhsuangaythi_dskithiCCQT.RowTemplate.Height = 24;
            this.chinhsuangaythi_dskithiCCQT.Size = new System.Drawing.Size(505, 549);
            this.chinhsuangaythi_dskithiCCQT.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(746, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Danh sach cac ki thi CCQT";
            // 
            // showlistkithiccqt_chinhsuangaythi
            // 
            this.showlistkithiccqt_chinhsuangaythi.Location = new System.Drawing.Point(751, 686);
            this.showlistkithiccqt_chinhsuangaythi.Name = "showlistkithiccqt_chinhsuangaythi";
            this.showlistkithiccqt_chinhsuangaythi.Size = new System.Drawing.Size(284, 35);
            this.showlistkithiccqt_chinhsuangaythi.TabIndex = 52;
            this.showlistkithiccqt_chinhsuangaythi.Text = "Hien thi danh sach cac ki thi CCQT";
            this.showlistkithiccqt_chinhsuangaythi.UseVisualStyleBackColor = true;
            this.showlistkithiccqt_chinhsuangaythi.Click += new System.EventHandler(this.showlistkithiccqt_chinhsuangaythi_Click);
            // 
            // suangaythi
            // 
            this.suangaythi.Controls.Add(this.ngaythimoi);
            this.suangaythi.Controls.Add(this.ngaythicu);
            this.suangaythi.Controls.Add(this.suangaythi_btn);
            this.suangaythi.Controls.Add(this.label7);
            this.suangaythi.Controls.Add(this.label6);
            this.suangaythi.Location = new System.Drawing.Point(4, 25);
            this.suangaythi.Name = "suangaythi";
            this.suangaythi.Size = new System.Drawing.Size(562, 195);
            this.suangaythi.TabIndex = 2;
            this.suangaythi.Text = "Sua ngay thi cho ki thi CCQT";
            this.suangaythi.UseVisualStyleBackColor = true;
            // 
            // suangaythi_btn
            // 
            this.suangaythi_btn.Location = new System.Drawing.Point(165, 119);
            this.suangaythi_btn.Name = "suangaythi_btn";
            this.suangaythi_btn.Size = new System.Drawing.Size(248, 35);
            this.suangaythi_btn.TabIndex = 61;
            this.suangaythi_btn.Text = "Doi ngay thi";
            this.suangaythi_btn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Ngay thi moi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Ngay thi cu";
            // 
            // xoangaythi
            // 
            this.xoangaythi.Controls.Add(this.xoangaythi_txt);
            this.xoangaythi.Controls.Add(this.xoangaythi_btn);
            this.xoangaythi.Controls.Add(this.label3);
            this.xoangaythi.Location = new System.Drawing.Point(4, 25);
            this.xoangaythi.Name = "xoangaythi";
            this.xoangaythi.Padding = new System.Windows.Forms.Padding(3);
            this.xoangaythi.Size = new System.Drawing.Size(562, 195);
            this.xoangaythi.TabIndex = 1;
            this.xoangaythi.Text = "Xoa ngay thi cho ki thi CCQT";
            this.xoangaythi.UseVisualStyleBackColor = true;
            // 
            // xoangaythi_btn
            // 
            this.xoangaythi_btn.Location = new System.Drawing.Point(122, 102);
            this.xoangaythi_btn.Name = "xoangaythi_btn";
            this.xoangaythi_btn.Size = new System.Drawing.Size(248, 35);
            this.xoangaythi_btn.TabIndex = 58;
            this.xoangaythi_btn.Text = "Xoa ngay thi";
            this.xoangaythi_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Ngay thi";
            // 
            // themngaythi
            // 
            this.themngaythi.Controls.Add(this.ngaythimoi_textbox);
            this.themngaythi.Controls.Add(this.themngaythi_btn);
            this.themngaythi.Controls.Add(this.label2);
            this.themngaythi.Location = new System.Drawing.Point(4, 25);
            this.themngaythi.Name = "themngaythi";
            this.themngaythi.Padding = new System.Windows.Forms.Padding(3);
            this.themngaythi.Size = new System.Drawing.Size(562, 195);
            this.themngaythi.TabIndex = 0;
            this.themngaythi.Text = "Them ngay thi moi cho ki thi CCQT";
            this.themngaythi.UseVisualStyleBackColor = true;
            // 
            // themngaythi_btn
            // 
            this.themngaythi_btn.Location = new System.Drawing.Point(128, 88);
            this.themngaythi_btn.Name = "themngaythi_btn";
            this.themngaythi_btn.Size = new System.Drawing.Size(248, 35);
            this.themngaythi_btn.TabIndex = 55;
            this.themngaythi_btn.Text = "Them ngay thi moi";
            this.themngaythi_btn.UseVisualStyleBackColor = true;
            this.themngaythi_btn.Click += new System.EventHandler(this.themngaythi_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Ngay thi";
            // 
            // tabControlforChinhsuangaythi
            // 
            this.tabControlforChinhsuangaythi.Controls.Add(this.themngaythi);
            this.tabControlforChinhsuangaythi.Controls.Add(this.xoangaythi);
            this.tabControlforChinhsuangaythi.Controls.Add(this.suangaythi);
            this.tabControlforChinhsuangaythi.Location = new System.Drawing.Point(12, 542);
            this.tabControlforChinhsuangaythi.Name = "tabControlforChinhsuangaythi";
            this.tabControlforChinhsuangaythi.SelectedIndex = 0;
            this.tabControlforChinhsuangaythi.Size = new System.Drawing.Size(570, 224);
            this.tabControlforChinhsuangaythi.TabIndex = 53;
            // 
            // ngaythimoi_textbox
            // 
            this.ngaythimoi_textbox.CustomFormat = "yyyy-MM-dd";
            this.ngaythimoi_textbox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaythimoi_textbox.Location = new System.Drawing.Point(128, 32);
            this.ngaythimoi_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.ngaythimoi_textbox.Name = "ngaythimoi_textbox";
            this.ngaythimoi_textbox.Size = new System.Drawing.Size(387, 22);
            this.ngaythimoi_textbox.TabIndex = 58;
            this.ngaythimoi_textbox.Value = new System.DateTime(2021, 5, 8, 0, 0, 0, 0);
            // 
            // xoangaythi_txt
            // 
            this.xoangaythi_txt.CustomFormat = "yyyy-MM-dd";
            this.xoangaythi_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.xoangaythi_txt.Location = new System.Drawing.Point(122, 42);
            this.xoangaythi_txt.Margin = new System.Windows.Forms.Padding(4);
            this.xoangaythi_txt.Name = "xoangaythi_txt";
            this.xoangaythi_txt.Size = new System.Drawing.Size(387, 22);
            this.xoangaythi_txt.TabIndex = 60;
            this.xoangaythi_txt.Value = new System.DateTime(2021, 5, 8, 0, 0, 0, 0);
            // 
            // ngaythicu
            // 
            this.ngaythicu.CustomFormat = "yyyy-MM-dd";
            this.ngaythicu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaythicu.Location = new System.Drawing.Point(155, 21);
            this.ngaythicu.Margin = new System.Windows.Forms.Padding(4);
            this.ngaythicu.Name = "ngaythicu";
            this.ngaythicu.Size = new System.Drawing.Size(387, 22);
            this.ngaythicu.TabIndex = 62;
            this.ngaythicu.Value = new System.DateTime(2021, 5, 8, 0, 0, 0, 0);
            // 
            // ngaythimoi
            // 
            this.ngaythimoi.CustomFormat = "yyyy-MM-dd";
            this.ngaythimoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaythimoi.Location = new System.Drawing.Point(155, 63);
            this.ngaythimoi.Margin = new System.Windows.Forms.Padding(4);
            this.ngaythimoi.Name = "ngaythimoi";
            this.ngaythimoi.Size = new System.Drawing.Size(387, 22);
            this.ngaythimoi.TabIndex = 63;
            this.ngaythimoi.Value = new System.DateTime(2021, 5, 8, 0, 0, 0, 0);
            // 
            // Chon_ngay_thi_cho_ky_thi_CCQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 778);
            this.Controls.Add(this.tabControlforChinhsuangaythi);
            this.Controls.Add(this.showlistkithiccqt_chinhsuangaythi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chinhsuangaythi_dskithiCCQT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.backTrangTaomoi);
            this.Controls.Add(this.label1);
            this.Name = "Chon_ngay_thi_cho_ky_thi_CCQT";
            this.Text = "Chon_ngay_thi_cho_ky_thi_CCQT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makithiccqt_quanli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhsuangaythi_dskithiCCQT)).EndInit();
            this.suangaythi.ResumeLayout(false);
            this.suangaythi.PerformLayout();
            this.xoangaythi.ResumeLayout(false);
            this.xoangaythi.PerformLayout();
            this.themngaythi.ResumeLayout(false);
            this.themngaythi.PerformLayout();
            this.tabControlforChinhsuangaythi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backTrangTaomoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView chinhsuangaythi_dskithiCCQT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button showlistkithiccqt_chinhsuangaythi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button timdscacngaythi_chinhsuangaythikithiccqt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage suangaythi;
        private System.Windows.Forms.Button suangaythi_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage xoangaythi;
        private System.Windows.Forms.Button xoangaythi_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage themngaythi;
        private System.Windows.Forms.Button themngaythi_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControlforChinhsuangaythi;
        private System.Windows.Forms.NumericUpDown makithiccqt_quanli;
        private System.Windows.Forms.DateTimePicker ngaythimoi_textbox;
        private System.Windows.Forms.DateTimePicker xoangaythi_txt;
        private System.Windows.Forms.DateTimePicker ngaythimoi;
        private System.Windows.Forms.DateTimePicker ngaythicu;
    }
}
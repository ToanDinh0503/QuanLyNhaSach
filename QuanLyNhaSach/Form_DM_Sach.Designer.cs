﻿namespace QuanLyNhaSach
{
    partial class Form_DM_Sach
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
            groupBox1 = new GroupBox();
            lsv_dssach = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            panel1 = new Panel();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txt_tl = new TextBox();
            txt_nxbb = new TextBox();
            btn_htmt = new Button();
            txt_ms = new TextBox();
            label3 = new Label();
            label7 = new Label();
            label4 = new Label();
            txt_nxb = new TextBox();
            label6 = new Label();
            txt_ts = new TextBox();
            txt_mt = new TextBox();
            label5 = new Label();
            txt_gia = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btn_htds = new Button();
            btn_search = new Button();
            txt_search = new TextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsv_dssach);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 398);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1158, 341);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Các Quyển Sách";
            // 
            // lsv_dssach
            // 
            lsv_dssach.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lsv_dssach.Dock = DockStyle.Fill;
            lsv_dssach.FullRowSelect = true;
            lsv_dssach.GridLines = true;
            lsv_dssach.Location = new Point(3, 21);
            lsv_dssach.Margin = new Padding(3, 4, 3, 4);
            lsv_dssach.Name = "lsv_dssach";
            lsv_dssach.Size = new Size(1152, 316);
            lsv_dssach.TabIndex = 0;
            lsv_dssach.UseCompatibleStateImageBehavior = false;
            lsv_dssach.View = View.Details;
            lsv_dssach.SelectedIndexChanged += lsv_dssach_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã Sách";
            columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên sách";
            columnHeader2.Width = 358;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Giá";
            columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Năm";
            columnHeader4.Width = 94;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nhà Xuất Bản";
            columnHeader5.Width = 245;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Thể Loại";
            columnHeader6.Width = 233;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aquamarine;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 49);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 71);
            panel1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(360, 18);
            label1.Name = "label1";
            label1.Size = new Size(393, 29);
            label1.TabIndex = 23;
            label1.Text = "DANH SÁCH CÁC QUYỂN SÁCH";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_tl);
            groupBox2.Controls.Add(txt_nxbb);
            groupBox2.Controls.Add(btn_htmt);
            groupBox2.Controls.Add(txt_ms);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_nxb);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_ts);
            groupBox2.Controls.Add(txt_mt);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_gia);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(12, 141);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1152, 212);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chung";
            // 
            // txt_tl
            // 
            txt_tl.Location = new Point(120, 159);
            txt_tl.Margin = new Padding(4, 3, 4, 3);
            txt_tl.MaxLength = 11;
            txt_tl.Name = "txt_tl";
            txt_tl.Size = new Size(211, 27);
            txt_tl.TabIndex = 18;
            // 
            // txt_nxbb
            // 
            txt_nxbb.Location = new Point(859, 107);
            txt_nxbb.Margin = new Padding(4, 3, 4, 3);
            txt_nxbb.MaxLength = 11;
            txt_nxbb.Name = "txt_nxbb";
            txt_nxbb.Size = new Size(227, 27);
            txt_nxbb.TabIndex = 17;
            // 
            // btn_htmt
            // 
            btn_htmt.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_htmt.Location = new Point(1100, 50);
            btn_htmt.Name = "btn_htmt";
            btn_htmt.Size = new Size(36, 28);
            btn_htmt.TabIndex = 16;
            btn_htmt.Text = "...";
            btn_htmt.UseVisualStyleBackColor = true;
            btn_htmt.Click += btn_htmt_Click;
            // 
            // txt_ms
            // 
            txt_ms.Location = new Point(121, 47);
            txt_ms.Margin = new Padding(4, 3, 4, 3);
            txt_ms.Name = "txt_ms";
            txt_ms.Size = new Size(210, 27);
            txt_ms.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 53);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã Sách:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 166);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 7;
            label7.Text = "Thể loại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 50);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 2;
            label4.Text = "Tên Sách:";
            // 
            // txt_nxb
            // 
            txt_nxb.Location = new Point(491, 104);
            txt_nxb.Margin = new Padding(4, 3, 4, 3);
            txt_nxb.MaxLength = 4;
            txt_nxb.Name = "txt_nxb";
            txt_nxb.Size = new Size(174, 27);
            txt_nxb.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 110);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 6;
            label6.Text = "Năm xuất bản:";
            // 
            // txt_ts
            // 
            txt_ts.Location = new Point(453, 47);
            txt_ts.Margin = new Padding(4, 3, 4, 3);
            txt_ts.MaxLength = 50;
            txt_ts.Name = "txt_ts";
            txt_ts.Size = new Size(335, 27);
            txt_ts.TabIndex = 9;
            // 
            // txt_mt
            // 
            txt_mt.Location = new Point(910, 51);
            txt_mt.Margin = new Padding(4, 3, 4, 3);
            txt_mt.MaxLength = 250;
            txt_mt.Multiline = true;
            txt_mt.Name = "txt_mt";
            txt_mt.Size = new Size(173, 24);
            txt_mt.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(733, 111);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 5;
            label5.Text = "Nhà xuất bản:";
            // 
            // txt_gia
            // 
            txt_gia.Location = new Point(121, 103);
            txt_gia.Margin = new Padding(4, 3, 4, 3);
            txt_gia.MaxLength = 11;
            txt_gia.Name = "txt_gia";
            txt_gia.Size = new Size(211, 27);
            txt_gia.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(839, 55);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 3;
            label8.Text = "Mô tả:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 110);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(36, 20);
            label9.TabIndex = 4;
            label9.Text = "Giá:";
            // 
            // btn_htds
            // 
            btn_htds.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_htds.Location = new Point(700, 364);
            btn_htds.Name = "btn_htds";
            btn_htds.Size = new Size(172, 36);
            btn_htds.TabIndex = 37;
            btn_htds.Text = "Hiển thị danh sách";
            btn_htds.UseVisualStyleBackColor = true;
            btn_htds.Click += btn_htds_Click;
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_search.Location = new Point(327, 368);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(81, 32);
            btn_search.TabIndex = 35;
            btn_search.Text = "Lọc";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_search.Location = new Point(415, 369);
            txt_search.Margin = new Padding(4, 3, 4, 3);
            txt_search.MaxLength = 50;
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(262, 27);
            txt_search.TabIndex = 36;
            // 
            // Form_DM_Sach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1182, 748);
            Controls.Add(btn_htds);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_DM_Sach";
            Text = "DANH MỤC CÁC QUYỂN SÁCH";
            FormClosing += Form_DM_Sach_FormClosing;
            Load += Form_DM_Sach_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lsv_dssach;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txt_tl;
        private TextBox txt_nxbb;
        private Button btn_htmt;
        private TextBox txt_ms;
        private Label label3;
        private Label label7;
        private Label label4;
        private TextBox txt_nxb;
        private Label label6;
        private TextBox txt_ts;
        private TextBox txt_mt;
        private Label label5;
        private TextBox txt_gia;
        private Label label8;
        private Label label9;
        private Button btn_htds;
        private Button btn_search;
        private TextBox txt_search;
    }
}
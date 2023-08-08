using System.Text.RegularExpressions;
using System;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    partial class Form_CTHD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_soluong = new TextBox();
            txt_thanhtien = new TextBox();
            txt_tinhtrang = new TextBox();
            btn_suachitiet = new Button();
            btn_xoachitiet = new Button();
            btn_thoatchitiet = new Button();
            groupBox1 = new GroupBox();
            btn_Luuchitiet = new Button();
            btn_LamMoichitiet = new Button();
            groupBox2 = new GroupBox();
            cmb_MaSach = new ComboBox();
            cmb_MaHD = new ComboBox();
            label8 = new Label();
            btn_searchchitiet = new Button();
            txt_searchMaHD = new TextBox();
            lsv_CTHD = new ListView();
            mahd = new ColumnHeader();
            masach = new ColumnHeader();
            tensach = new ColumnHeader();
            soluong = new ColumnHeader();
            thanhtien = new ColumnHeader();
            tinhtrang = new ColumnHeader();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 18);
            label1.TabIndex = 1;
            label1.Text = "Mã Hóa Đơn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(427, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 2;
            label2.Text = "Sách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 18);
            label3.TabIndex = 3;
            label3.Text = "Số Lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(427, 102);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 18);
            label4.TabIndex = 4;
            label4.Text = "Thành Tiền:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 175);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 18);
            label5.TabIndex = 5;
            label5.Text = "Tình Trạng:";
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(148, 96);
            txt_soluong.Margin = new Padding(4, 3, 4, 3);
            txt_soluong.MaxLength = 3;
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(173, 24);
            txt_soluong.TabIndex = 10;
            txt_soluong.TextChanged += txt_soluong_TextChanged;
            txt_soluong.KeyPress += txt_soluong_KeyPress;
            // 
            // txt_thanhtien
            // 
            txt_thanhtien.Location = new Point(555, 96);
            txt_thanhtien.Margin = new Padding(4, 3, 4, 3);
            txt_thanhtien.MaxLength = 8;
            txt_thanhtien.Name = "txt_thanhtien";
            txt_thanhtien.Size = new Size(173, 24);
            txt_thanhtien.TabIndex = 11;
            // 
            // txt_tinhtrang
            // 
            txt_tinhtrang.Location = new Point(149, 169);
            txt_tinhtrang.Margin = new Padding(4, 3, 4, 3);
            txt_tinhtrang.MaxLength = 50;
            txt_tinhtrang.Multiline = true;
            txt_tinhtrang.Name = "txt_tinhtrang";
            txt_tinhtrang.Size = new Size(579, 44);
            txt_tinhtrang.TabIndex = 12;
            // 
            // btn_suachitiet
            // 
            btn_suachitiet.Location = new Point(43, 72);
            btn_suachitiet.Margin = new Padding(4, 3, 4, 3);
            btn_suachitiet.Name = "btn_suachitiet";
            btn_suachitiet.Size = new Size(139, 48);
            btn_suachitiet.TabIndex = 17;
            btn_suachitiet.Text = "Sửa";
            btn_suachitiet.UseVisualStyleBackColor = true;
            btn_suachitiet.Click += btn_suachitiet_Click_1;
            // 
            // btn_xoachitiet
            // 
            btn_xoachitiet.Location = new Point(207, 72);
            btn_xoachitiet.Margin = new Padding(4, 3, 4, 3);
            btn_xoachitiet.Name = "btn_xoachitiet";
            btn_xoachitiet.Size = new Size(139, 48);
            btn_xoachitiet.TabIndex = 18;
            btn_xoachitiet.Text = "Xóa";
            btn_xoachitiet.UseVisualStyleBackColor = true;
            btn_xoachitiet.Click += btn_xoachitiet_Click_1;
            // 
            // btn_thoatchitiet
            // 
            btn_thoatchitiet.Location = new Point(369, 160);
            btn_thoatchitiet.Margin = new Padding(4, 3, 4, 3);
            btn_thoatchitiet.Name = "btn_thoatchitiet";
            btn_thoatchitiet.Size = new Size(139, 48);
            btn_thoatchitiet.TabIndex = 22;
            btn_thoatchitiet.Text = "Thoát";
            btn_thoatchitiet.UseVisualStyleBackColor = true;
            btn_thoatchitiet.Click += btn_thoatchitiet_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Luuchitiet);
            groupBox1.Controls.Add(btn_LamMoichitiet);
            groupBox1.Controls.Add(btn_thoatchitiet);
            groupBox1.Controls.Add(btn_suachitiet);
            groupBox1.Controls.Add(btn_xoachitiet);
            groupBox1.Location = new Point(786, 87);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(556, 254);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btn_Luuchitiet
            // 
            btn_Luuchitiet.Location = new Point(43, 160);
            btn_Luuchitiet.Margin = new Padding(4, 3, 4, 3);
            btn_Luuchitiet.Name = "btn_Luuchitiet";
            btn_Luuchitiet.Size = new Size(139, 48);
            btn_Luuchitiet.TabIndex = 20;
            btn_Luuchitiet.Text = "Lưu";
            btn_Luuchitiet.UseVisualStyleBackColor = true;
            btn_Luuchitiet.Click += btn_Luuchitiet_Click;
            // 
            // btn_LamMoichitiet
            // 
            btn_LamMoichitiet.Location = new Point(207, 160);
            btn_LamMoichitiet.Margin = new Padding(4, 3, 4, 3);
            btn_LamMoichitiet.Name = "btn_LamMoichitiet";
            btn_LamMoichitiet.Size = new Size(139, 48);
            btn_LamMoichitiet.TabIndex = 21;
            btn_LamMoichitiet.Text = "Làm Mới";
            btn_LamMoichitiet.UseVisualStyleBackColor = true;
            btn_LamMoichitiet.Click += btn_LamMoichitiet_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmb_MaSach);
            groupBox2.Controls.Add(cmb_MaHD);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txt_tinhtrang);
            groupBox2.Controls.Add(txt_soluong);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_thanhtien);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(23, 87);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(755, 254);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiêt hóa đơn";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // cmb_MaSach
            // 
            cmb_MaSach.FormattingEnabled = true;
            cmb_MaSach.Location = new Point(555, 40);
            cmb_MaSach.Name = "cmb_MaSach";
            cmb_MaSach.Size = new Size(173, 26);
            cmb_MaSach.TabIndex = 14;
            // 
            // cmb_MaHD
            // 
            cmb_MaHD.FormattingEnabled = true;
            cmb_MaHD.Location = new Point(150, 41);
            cmb_MaHD.Name = "cmb_MaHD";
            cmb_MaHD.Size = new Size(171, 26);
            cmb_MaHD.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(468, 31);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(446, 36);
            label8.TabIndex = 23;
            label8.Text = "QUẢN LÝ CHI TIẾT HÓA ĐƠN";
            // 
            // btn_searchchitiet
            // 
            btn_searchchitiet.Location = new Point(61, 358);
            btn_searchchitiet.Name = "btn_searchchitiet";
            btn_searchchitiet.Size = new Size(72, 28);
            btn_searchchitiet.TabIndex = 25;
            btn_searchchitiet.Text = "Lọc";
            btn_searchchitiet.UseVisualStyleBackColor = true;
            btn_searchchitiet.Click += btn_searchchitiet_Click_1;
            // 
            // txt_searchMaHD
            // 
            txt_searchMaHD.Location = new Point(269, 360);
            txt_searchMaHD.Margin = new Padding(4, 3, 4, 3);
            txt_searchMaHD.MaxLength = 1000;
            txt_searchMaHD.Name = "txt_searchMaHD";
            txt_searchMaHD.Size = new Size(180, 24);
            txt_searchMaHD.TabIndex = 15;
            // 
            // lsv_CTHD
            // 
            lsv_CTHD.Columns.AddRange(new ColumnHeader[] { mahd, masach, tensach, soluong, thanhtien, tinhtrang });
            lsv_CTHD.FullRowSelect = true;
            lsv_CTHD.GridLines = true;
            lsv_CTHD.Location = new Point(23, 407);
            lsv_CTHD.Name = "lsv_CTHD";
            lsv_CTHD.Size = new Size(1319, 218);
            lsv_CTHD.TabIndex = 26;
            lsv_CTHD.UseCompatibleStateImageBehavior = false;
            lsv_CTHD.View = View.Details;
            lsv_CTHD.SelectedIndexChanged += lsv_CTHD_SelectedIndexChanged;
            // 
            // mahd
            // 
            mahd.Text = "Mã Hóa Đơn";
            mahd.Width = 150;
            // 
            // masach
            // 
            masach.Text = "Mã Sách";
            masach.Width = 150;
            // 
            // tensach
            // 
            tensach.Text = "Tên Sách";
            tensach.Width = 300;
            // 
            // soluong
            // 
            soluong.Text = "Số Lượng";
            soluong.Width = 150;
            // 
            // thanhtien
            // 
            thanhtien.Text = "Thành tiền";
            thanhtien.Width = 250;
            // 
            // tinhtrang
            // 
            tinhtrang.Text = "Tình Trạng";
            tinhtrang.Width = 250;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(153, 364);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(108, 18);
            label7.TabIndex = 17;
            label7.Text = "Mã Hóa Đơn:";
            label7.Click += label7_Click;
            // 
            // Form_CTHD
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_thoatchitiet;
            ClientSize = new Size(1352, 643);
            Controls.Add(label7);
            Controls.Add(lsv_CTHD);
            Controls.Add(btn_searchchitiet);
            Controls.Add(txt_searchMaHD);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form_CTHD";
            Text = "QUẢN LÝ CHI TIẾT HÓA ĐƠN";
            FormClosing += Form_CTHD_FormClosing;
            Load += Form_CTHD_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_soluong;
        private TextBox txt_thanhtien;
        private TextBox txt_tinhtrang;
        private Button btn_suachitiet;
        private Button btn_xoachitiet;
        private Button btn_thoatchitiet;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private Button btn_searchchitiet;
        private TextBox txt_searchMaHD;
        private Button btn_LamMoichitiet;
        private Button btn_Luuchitiet;
        private ListView lsv_CTHD;
        private ColumnHeader mahd;
        private ColumnHeader masach;
        private ColumnHeader soluong;
        private ColumnHeader thanhtien;
        private ComboBox cmb_MaSach;
        private ComboBox cmb_MaHD;
        private ColumnHeader tinhtrang;
        private Label label7;
        private ColumnHeader tensach;
    }
}
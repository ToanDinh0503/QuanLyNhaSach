using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    partial class Form_banhang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_inHD = new Button();
            btn_luu = new Button();
            btn_huy = new Button();
            btn_thoat = new Button();
            btn_them = new Button();
            btn_xoa = new Button();
            groupBox2 = new GroupBox();
            btn_qlkh = new Button();
            dt_nlhd = new DateTimePicker();
            cmb_mnv = new ComboBox();
            cmb_mkh = new ComboBox();
            txt_mhd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_tongtien = new TextBox();
            label4 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            txt_Gia = new TextBox();
            label7 = new Label();
            cmb_MaSach = new ComboBox();
            label9 = new Label();
            txt_tinhtrang = new TextBox();
            txt_soluong = new TextBox();
            label12 = new Label();
            txt_thanhtien = new TextBox();
            label13 = new Label();
            label14 = new Label();
            lsv_CTHD = new ListView();
            masach = new ColumnHeader();
            tensach = new ColumnHeader();
            soluong = new ColumnHeader();
            gia = new ColumnHeader();
            thanhtien = new ColumnHeader();
            label15 = new Label();
            btn_searchchitiet = new Button();
            txt_search = new TextBox();
            btn_xoaSach = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_inHD
            // 
            btn_inHD.DialogResult = DialogResult.Cancel;
            btn_inHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inHD.Location = new Point(866, 674);
            btn_inHD.Margin = new Padding(4);
            btn_inHD.Name = "btn_inHD";
            btn_inHD.Size = new Size(139, 60);
            btn_inHD.TabIndex = 16;
            btn_inHD.Text = "In";
            btn_inHD.UseVisualStyleBackColor = true;
            btn_inHD.Click += btn_inHD_Click;
            // 
            // btn_luu
            // 
            btn_luu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_luu.Location = new Point(446, 674);
            btn_luu.Margin = new Padding(4);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(139, 60);
            btn_luu.TabIndex = 8;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // btn_huy
            // 
            btn_huy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_huy.Location = new Point(650, 674);
            btn_huy.Margin = new Padding(4);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(139, 60);
            btn_huy.TabIndex = 9;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            btn_huy.Click += btn_huy_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.DialogResult = DialogResult.Cancel;
            btn_thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_thoat.Location = new Point(1085, 674);
            btn_thoat.Margin = new Padding(4);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(139, 60);
            btn_thoat.TabIndex = 17;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_them.Location = new Point(49, 674);
            btn_them.Margin = new Padding(4);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(139, 60);
            btn_them.TabIndex = 10;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xoa.Location = new Point(245, 674);
            btn_xoa.Margin = new Padding(4);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(139, 60);
            btn_xoa.TabIndex = 11;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_qlkh);
            groupBox2.Controls.Add(dt_nlhd);
            groupBox2.Controls.Add(cmb_mnv);
            groupBox2.Controls.Add(cmb_mkh);
            groupBox2.Controls.Add(txt_mhd);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(24, 69);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1350, 172);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin hóa đơn";
            // 
            // btn_qlkh
            // 
            btn_qlkh.Location = new Point(1119, 45);
            btn_qlkh.Name = "btn_qlkh";
            btn_qlkh.Size = new Size(176, 35);
            btn_qlkh.TabIndex = 3;
            btn_qlkh.Text = "Quản Lý Khách Hàng";
            btn_qlkh.UseVisualStyleBackColor = true;
            btn_qlkh.Click += btn_qlkh_Click;
            // 
            // dt_nlhd
            // 
            dt_nlhd.Format = DateTimePickerFormat.Short;
            dt_nlhd.Location = new Point(150, 103);
            dt_nlhd.Margin = new Padding(3, 4, 3, 4);
            dt_nlhd.MaxDate = new DateTime(2023, 8, 5, 21, 9, 17, 15);
            dt_nlhd.Name = "dt_nlhd";
            dt_nlhd.Size = new Size(215, 24);
            dt_nlhd.TabIndex = 1;
            dt_nlhd.Value = new DateTime(2023, 8, 5, 21, 9, 17, 15);
            // 
            // cmb_mnv
            // 
            cmb_mnv.FormattingEnabled = true;
            cmb_mnv.Location = new Point(873, 97);
            cmb_mnv.Margin = new Padding(3, 4, 3, 4);
            cmb_mnv.Name = "cmb_mnv";
            cmb_mnv.Size = new Size(215, 26);
            cmb_mnv.TabIndex = 4;
            // 
            // cmb_mkh
            // 
            cmb_mkh.FormattingEnabled = true;
            cmb_mkh.Location = new Point(873, 50);
            cmb_mkh.Margin = new Padding(3, 4, 3, 4);
            cmb_mkh.Name = "cmb_mkh";
            cmb_mkh.Size = new Size(215, 26);
            cmb_mkh.TabIndex = 2;
            cmb_mkh.DisplayMemberChanged += cmb_mkh_DisplayMemberChanged;
            // 
            // txt_mhd
            // 
            txt_mhd.Location = new Point(150, 50);
            txt_mhd.Margin = new Padding(4);
            txt_mhd.MaxLength = 1000;
            txt_mhd.Name = "txt_mhd";
            txt_mhd.ReadOnly = true;
            txt_mhd.Size = new Size(215, 24);
            txt_mhd.TabIndex = 8;
            txt_mhd.TabStop = false;
            txt_mhd.TextChanged += txt_mhd_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 50);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 18);
            label2.TabIndex = 1;
            label2.Text = "Mã Hóa Đơn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 2;
            label3.Text = "Ngày Lập:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(728, 103);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 18);
            label5.TabIndex = 5;
            label5.Text = "Nhân Viên:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(728, 51);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 18);
            label6.TabIndex = 4;
            label6.Text = "Khách Hàng:";
            // 
            // txt_tongtien
            // 
            txt_tongtien.Location = new Point(948, 605);
            txt_tongtien.Margin = new Padding(4);
            txt_tongtien.MaxLength = 250;
            txt_tongtien.Multiline = true;
            txt_tongtien.Name = "txt_tongtien";
            txt_tongtien.ReadOnly = true;
            txt_tongtien.Size = new Size(215, 29);
            txt_tongtien.TabIndex = 10;
            txt_tongtien.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(825, 610);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Tổng Tiền:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(437, 29);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(509, 36);
            label8.TabIndex = 30;
            label8.Text = "QUẢN LÝ THÔNG TIN BÁN HÀNG";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_Gia);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(cmb_MaSach);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txt_tinhtrang);
            groupBox3.Controls.Add(txt_soluong);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txt_thanhtien);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(24, 262);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(1358, 157);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin chi tiêt hóa đơn";
            // 
            // txt_Gia
            // 
            txt_Gia.Location = new Point(540, 41);
            txt_Gia.Margin = new Padding(4, 3, 4, 3);
            txt_Gia.MaxLength = 11;
            txt_Gia.Name = "txt_Gia";
            txt_Gia.ReadOnly = true;
            txt_Gia.Size = new Size(199, 27);
            txt_Gia.TabIndex = 18;
            txt_Gia.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(413, 42);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 17;
            label7.Text = "Đơn Giá:";
            // 
            // cmb_MaSach
            // 
            cmb_MaSach.FormattingEnabled = true;
            cmb_MaSach.Location = new Point(149, 42);
            cmb_MaSach.Name = "cmb_MaSach";
            cmb_MaSach.Size = new Size(172, 28);
            cmb_MaSach.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(32, 45);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 2;
            label9.Text = "Mã Sách:";
            // 
            // txt_tinhtrang
            // 
            txt_tinhtrang.Location = new Point(919, 38);
            txt_tinhtrang.Margin = new Padding(4, 3, 4, 3);
            txt_tinhtrang.MaxLength = 100;
            txt_tinhtrang.Multiline = true;
            txt_tinhtrang.Name = "txt_tinhtrang";
            txt_tinhtrang.Size = new Size(351, 44);
            txt_tinhtrang.TabIndex = 7;
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(150, 92);
            txt_soluong.Margin = new Padding(4, 3, 4, 3);
            txt_soluong.MaxLength = 11;
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(175, 27);
            txt_soluong.TabIndex = 6;
            txt_soluong.TextChanged += txt_soluong_TextChanged;
            txt_soluong.KeyPress += txt_soluong_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(796, 44);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 20);
            label12.TabIndex = 5;
            label12.Text = "Tình Trạng:";
            // 
            // txt_thanhtien
            // 
            txt_thanhtien.Location = new Point(540, 91);
            txt_thanhtien.Margin = new Padding(4, 3, 4, 3);
            txt_thanhtien.MaxLength = 11;
            txt_thanhtien.Name = "txt_thanhtien";
            txt_thanhtien.ReadOnly = true;
            txt_thanhtien.Size = new Size(199, 27);
            txt_thanhtien.TabIndex = 11;
            txt_thanhtien.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(36, 98);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 3;
            label13.Text = "Số Lượng:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(413, 97);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(91, 20);
            label14.TabIndex = 4;
            label14.Text = "Thành Tiền:";
            // 
            // lsv_CTHD
            // 
            lsv_CTHD.Columns.AddRange(new ColumnHeader[] { masach, tensach, soluong, gia, thanhtien });
            lsv_CTHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lsv_CTHD.FullRowSelect = true;
            lsv_CTHD.GridLines = true;
            lsv_CTHD.Location = new Point(24, 425);
            lsv_CTHD.Name = "lsv_CTHD";
            lsv_CTHD.Size = new Size(1197, 153);
            lsv_CTHD.TabIndex = 12;
            lsv_CTHD.UseCompatibleStateImageBehavior = false;
            lsv_CTHD.View = View.Details;
            lsv_CTHD.SelectedIndexChanged += lsv_CTHD_SelectedIndexChanged;
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
            soluong.Width = 250;
            // 
            // gia
            // 
            gia.Text = "Đơn Giá";
            gia.Width = 250;
            // 
            // thanhtien
            // 
            thanhtien.Text = "Thành tiền";
            thanhtien.Width = 250;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(27, 605);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(100, 20);
            label15.TabIndex = 34;
            label15.Text = "Mã Hóa Đơn:";
            // 
            // btn_searchchitiet
            // 
            btn_searchchitiet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_searchchitiet.Location = new Point(350, 604);
            btn_searchchitiet.Name = "btn_searchchitiet";
            btn_searchchitiet.Size = new Size(72, 28);
            btn_searchchitiet.TabIndex = 15;
            btn_searchchitiet.Text = "Lọc";
            btn_searchchitiet.UseVisualStyleBackColor = true;
            btn_searchchitiet.Click += btn_searchchitiet_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(146, 607);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(189, 27);
            txt_search.TabIndex = 14;
            // 
            // btn_xoaSach
            // 
            btn_xoaSach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xoaSach.Location = new Point(1223, 425);
            btn_xoaSach.Name = "btn_xoaSach";
            btn_xoaSach.Size = new Size(151, 39);
            btn_xoaSach.TabIndex = 13;
            btn_xoaSach.Text = "Bỏ Chọn Sách";
            btn_xoaSach.UseVisualStyleBackColor = true;
            btn_xoaSach.Click += btn_xoaSach_Click;
            // 
            // Form_banhang
            // 
            AcceptButton = btn_them;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 779);
            Controls.Add(btn_inHD);
            Controls.Add(btn_xoaSach);
            Controls.Add(btn_luu);
            Controls.Add(txt_search);
            Controls.Add(btn_huy);
            Controls.Add(btn_thoat);
            Controls.Add(label15);
            Controls.Add(btn_them);
            Controls.Add(btn_searchchitiet);
            Controls.Add(btn_xoa);
            Controls.Add(lsv_CTHD);
            Controls.Add(groupBox3);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(txt_tongtien);
            Margin = new Padding(2);
            Name = "Form_banhang";
            Text = "QUẢN LÝ THÔNG TIN BÁN HÀNG";
            FormClosing += HoaDon_FormClosing;
            Load += HoaDon_Load_1;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_luu;
        private Button btn_huy;
        private Button btn_thoat;
        private Button btn_them;
        private Button btn_xoa;
        private GroupBox groupBox2;
        private TextBox txt_mhd;
        private Label label2;
        private Label label3;
        private TextBox txt_tongtien;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label8;
        private ComboBox cmb_mkh;
        private ComboBox cmb_mnv;
        private DateTimePicker dt_nlhd;
        private GroupBox groupBox3;
        private ComboBox cmb_MaSach;
        private Label label9;
        private TextBox txt_tinhtrang;
        private TextBox txt_soluong;
        private Label label12;
        private TextBox txt_thanhtien;
        private Label label13;
        private Label label14;
        private TextBox txt_Gia;
        private Label label7;
        private ListView lsv_CTHD;
        private ColumnHeader masach;
        private ColumnHeader tensach;
        private ColumnHeader soluong;
        private ColumnHeader thanhtien;
        private ColumnHeader gia;
        private Label label15;
        private Button btn_searchchitiet;
        private Button btn_inHD;
        private TextBox txt_search;
        private Button btn_xoaSach;
        private Button btn_qlkh;
    }
}
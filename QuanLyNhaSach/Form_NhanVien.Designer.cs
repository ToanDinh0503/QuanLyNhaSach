namespace QuanLyNhaSach
{
    partial class Form_NhanVien
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txb_hoten = new TextBox();
            txb_taikhoan = new TextBox();
            txb_diachi = new TextBox();
            txb_sdt = new TextBox();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_thoat = new Button();
            btn_Luu = new Button();
            btn_Huy = new Button();
            groupBox2 = new GroupBox();
            txb_manv = new TextBox();
            label1 = new Label();
            txb_matkhau = new TextBox();
            label12 = new Label();
            cbx_vaitro = new ComboBox();
            label11 = new Label();
            cld_ngaysinh = new DateTimePicker();
            chb_nu = new CheckBox();
            chb_nam = new CheckBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btn_search = new Button();
            txt_search = new TextBox();
            lsv_danhsach = new ListView();
            manv = new ColumnHeader();
            tennv = new ColumnHeader();
            gioitinh = new ColumnHeader();
            sdt = new ColumnHeader();
            ngaysinh = new ColumnHeader();
            diachi = new ColumnHeader();
            vaitro = new ColumnHeader();
            taikhoan = new ColumnHeader();
            matkhau = new ColumnHeader();
            btn_hiendanhsach = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 5;
            label2.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 85);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 8;
            label3.Text = "Tài khoản:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 139);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 18);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 139);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 18);
            label5.TabIndex = 5;
            label5.Text = "Mật khẩu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 222);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 18);
            label6.TabIndex = 6;
            label6.Text = "Ngày sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 222);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 18);
            label7.TabIndex = 7;
            // 
            // txb_hoten
            // 
            txb_hoten.Location = new Point(148, 31);
            txb_hoten.Margin = new Padding(4, 3, 4, 3);
            txb_hoten.MaxLength = 35;
            txb_hoten.Name = "txb_hoten";
            txb_hoten.Size = new Size(173, 24);
            txb_hoten.TabIndex = 1;
            // 
            // txb_taikhoan
            // 
            txb_taikhoan.Location = new Point(563, 79);
            txb_taikhoan.Margin = new Padding(4, 3, 4, 3);
            txb_taikhoan.MaxLength = 15;
            txb_taikhoan.Multiline = true;
            txb_taikhoan.Name = "txb_taikhoan";
            txb_taikhoan.Size = new Size(174, 24);
            txb_taikhoan.TabIndex = 8;
            // 
            // txb_diachi
            // 
            txb_diachi.Location = new Point(148, 139);
            txb_diachi.Margin = new Padding(4, 3, 4, 3);
            txb_diachi.MaxLength = 50;
            txb_diachi.Multiline = true;
            txb_diachi.Name = "txb_diachi";
            txb_diachi.Size = new Size(227, 47);
            txb_diachi.TabIndex = 4;
            // 
            // txb_sdt
            // 
            txb_sdt.Location = new Point(149, 318);
            txb_sdt.Margin = new Padding(4, 3, 4, 3);
            txb_sdt.MaxLength = 11;
            txb_sdt.Name = "txb_sdt";
            txb_sdt.Size = new Size(172, 24);
            txb_sdt.TabIndex = 6;
            txb_sdt.KeyPress += txb_sdt_KeyPress;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(846, 400);
            btn_them.Margin = new Padding(4, 3, 4, 3);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(139, 48);
            btn_them.TabIndex = 12;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(1019, 400);
            btn_sua.Margin = new Padding(4, 3, 4, 3);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(139, 48);
            btn_sua.TabIndex = 14;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_suasach_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(1193, 400);
            btn_xoa.Margin = new Padding(4, 3, 4, 3);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(139, 48);
            btn_xoa.TabIndex = 15;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(1193, 510);
            btn_thoat.Margin = new Padding(4, 3, 4, 3);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(139, 48);
            btn_thoat.TabIndex = 19;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_Luu
            // 
            btn_Luu.Location = new Point(846, 510);
            btn_Luu.Margin = new Padding(4, 3, 4, 3);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(139, 48);
            btn_Luu.TabIndex = 10;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            btn_Luu.Click += btn_Luu_Click_1;
            // 
            // btn_Huy
            // 
            btn_Huy.Location = new Point(1019, 510);
            btn_Huy.Margin = new Padding(4, 3, 4, 3);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(139, 48);
            btn_Huy.TabIndex = 11;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            btn_Huy.Click += btn_LamMoi_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txb_manv);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txb_matkhau);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(cbx_vaitro);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cld_ngaysinh);
            groupBox2.Controls.Add(chb_nu);
            groupBox2.Controls.Add(chb_nam);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txb_sdt);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txb_hoten);
            groupBox2.Controls.Add(txb_taikhoan);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txb_diachi);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(28, 94);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(755, 468);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin nhân viên";
            // 
            // txb_manv
            // 
            txb_manv.Location = new Point(563, 23);
            txb_manv.Margin = new Padding(4, 3, 4, 3);
            txb_manv.MaxLength = 250;
            txb_manv.Multiline = true;
            txb_manv.Name = "txb_manv";
            txb_manv.Size = new Size(174, 24);
            txb_manv.TabIndex = 23;
            txb_manv.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(426, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 18);
            label1.TabIndex = 22;
            label1.Text = "Mã nhân viên:";
            // 
            // txb_matkhau
            // 
            txb_matkhau.Location = new Point(564, 133);
            txb_matkhau.Margin = new Padding(4, 3, 4, 3);
            txb_matkhau.MaxLength = 10;
            txb_matkhau.Name = "txb_matkhau";
            txb_matkhau.Size = new Size(173, 24);
            txb_matkhau.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Enabled = false;
            label12.Location = new Point(148, 249);
            label12.Name = "label12";
            label12.Size = new Size(110, 18);
            label12.TabIndex = 21;
            label12.Text = "MM/DD/YYYY";
            // 
            // cbx_vaitro
            // 
            cbx_vaitro.FormattingEnabled = true;
            cbx_vaitro.Location = new Point(149, 395);
            cbx_vaitro.Name = "cbx_vaitro";
            cbx_vaitro.Size = new Size(172, 26);
            cbx_vaitro.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 398);
            label11.Name = "label11";
            label11.Size = new Size(62, 18);
            label11.TabIndex = 20;
            label11.Text = "Vai trò:";
            // 
            // cld_ngaysinh
            // 
            cld_ngaysinh.CustomFormat = "MM/dd/yyyy";
            cld_ngaysinh.Format = DateTimePickerFormat.Short;
            cld_ngaysinh.Location = new Point(148, 222);
            cld_ngaysinh.MaxDate = new DateTime(2023, 8, 8, 15, 21, 26, 928);
            cld_ngaysinh.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            cld_ngaysinh.Name = "cld_ngaysinh";
            cld_ngaysinh.Size = new Size(175, 24);
            cld_ngaysinh.TabIndex = 5;
            cld_ngaysinh.Value = new DateTime(2003, 7, 30, 0, 0, 0, 0);
            // 
            // chb_nu
            // 
            chb_nu.AutoSize = true;
            chb_nu.Location = new Point(270, 87);
            chb_nu.Name = "chb_nu";
            chb_nu.Size = new Size(51, 22);
            chb_nu.TabIndex = 3;
            chb_nu.Text = "Nữ";
            chb_nu.UseVisualStyleBackColor = true;
            chb_nu.CheckedChanged += chb_nu_CheckedChanged_1;
            // 
            // chb_nam
            // 
            chb_nam.AutoSize = true;
            chb_nam.Location = new Point(148, 87);
            chb_nam.Name = "chb_nam";
            chb_nam.Size = new Size(65, 22);
            chb_nam.TabIndex = 2;
            chb_nam.Text = "Nam";
            chb_nam.UseVisualStyleBackColor = true;
            chb_nam.CheckedChanged += chb_nam_CheckedChanged_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 85);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(76, 18);
            label10.TabIndex = 16;
            label10.Text = "Giới tính:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 318);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(89, 18);
            label9.TabIndex = 15;
            label9.Text = "Điện thoại:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(459, 33);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(517, 36);
            label8.TabIndex = 23;
            label8.Text = "QUẢN LÝ THÔNG TIN NHÂN VIÊN";
            // 
            // btn_search
            // 
            btn_search.Location = new Point(832, 103);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(72, 28);
            btn_search.TabIndex = 17;
            btn_search.Text = "Lọc";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click_1;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(911, 105);
            txt_search.Margin = new Padding(4, 3, 4, 3);
            txt_search.MaxLength = 35;
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(233, 24);
            txt_search.TabIndex = 16;
            // 
            // lsv_danhsach
            // 
            lsv_danhsach.Columns.AddRange(new ColumnHeader[] { manv, tennv, gioitinh, sdt, ngaysinh, diachi, vaitro, taikhoan, matkhau });
            lsv_danhsach.FullRowSelect = true;
            lsv_danhsach.GridLines = true;
            lsv_danhsach.Location = new Point(832, 149);
            lsv_danhsach.Name = "lsv_danhsach";
            lsv_danhsach.Size = new Size(500, 218);
            lsv_danhsach.TabIndex = 13;
            lsv_danhsach.UseCompatibleStateImageBehavior = false;
            lsv_danhsach.View = View.Details;
            lsv_danhsach.SelectedIndexChanged += lsv_danhsach_SelectedIndexChanged;
            // 
            // manv
            // 
            manv.Text = "Mã nhân viên";
            manv.Width = 120;
            // 
            // tennv
            // 
            tennv.Text = "Họ tên";
            tennv.Width = 200;
            // 
            // gioitinh
            // 
            gioitinh.Text = "Giới tính";
            gioitinh.Width = 0;
            // 
            // sdt
            // 
            sdt.Text = "Điện thoại";
            sdt.Width = 0;
            // 
            // ngaysinh
            // 
            ngaysinh.Text = "Ngày sinh";
            ngaysinh.Width = 0;
            // 
            // diachi
            // 
            diachi.Text = "Địa chỉ";
            diachi.Width = 0;
            // 
            // vaitro
            // 
            vaitro.Text = "Vai trò";
            vaitro.Width = 300;
            // 
            // taikhoan
            // 
            taikhoan.Text = "Tài khoản";
            taikhoan.Width = 0;
            // 
            // matkhau
            // 
            matkhau.Text = "Mật khẩu";
            matkhau.Width = 0;
            // 
            // btn_hiendanhsach
            // 
            btn_hiendanhsach.Location = new Point(1151, 105);
            btn_hiendanhsach.Name = "btn_hiendanhsach";
            btn_hiendanhsach.Size = new Size(133, 29);
            btn_hiendanhsach.TabIndex = 18;
            btn_hiendanhsach.Text = "Hiện danh sách";
            btn_hiendanhsach.UseVisualStyleBackColor = true;
            btn_hiendanhsach.Click += btn_hiendanhsach_Click;
            // 
            // Form_NhanVien
            // 
            AcceptButton = btn_them;
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_thoat;
            ClientSize = new Size(1412, 593);
            Controls.Add(btn_Luu);
            Controls.Add(txt_search);
            Controls.Add(lsv_danhsach);
            Controls.Add(btn_Huy);
            Controls.Add(label8);
            Controls.Add(btn_hiendanhsach);
            Controls.Add(btn_thoat);
            Controls.Add(groupBox2);
            Controls.Add(btn_search);
            Controls.Add(btn_them);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form_NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ THÔNG TIN NHÂN VIÊN";
            FormClosing += Form_NhanVien_FormClosing;
            Load += Form_data_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txb_hoten;
        private TextBox txb_taikhoan;
        private TextBox txb_diachi;
        private TextBox txb_sdt;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_thoat;
        private GroupBox groupBox2;
        private Label label8;
        private Button btn_search;
        private TextBox txt_search;
        private Button btn_Huy;
        private Button btn_Luu;
        private ListView lsv_danhsach;
        private ColumnHeader manv;
        private ColumnHeader tennv;
        private ColumnHeader gioitinh;
        private ColumnHeader sdt;
        private ColumnHeader taikhoan;
        private ColumnHeader matkhau;
        private ColumnHeader ngaysinh;
        private Label label9;
        private Label label10;
        private CheckBox chb_nu;
        private CheckBox chb_nam;
        private ColumnHeader vaitro;
        private ColumnHeader diachi;
        private DateTimePicker cld_ngaysinh;
        private ComboBox cbx_vaitro;
        private Label label11;
        private Button btn_hiendanhsach;
        private Label label12;
        private TextBox txb_matkhau;
        private TextBox txb_manv;
        private Label label1;
    }
}
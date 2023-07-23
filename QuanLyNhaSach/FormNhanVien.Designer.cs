namespace QuanLyNhaSach
{
    partial class FormNhanVien
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
            pannel_timkiem = new Panel();
            groupBox1 = new GroupBox();
            btn_tim = new Button();
            txb_timkiem = new TextBox();
            panel1 = new Panel();
            txb_matkhau = new TextBox();
            txb_taikhoan = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btn_thoat = new Button();
            btn_lammoi = new Button();
            btn_xoa = new Button();
            btn_capnhat = new Button();
            btn_them = new Button();
            txb_diachi = new TextBox();
            txb_dienthoai = new TextBox();
            txb_ngaysinh = new TextBox();
            txb_hoten = new TextBox();
            cbx_vaittro = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lsv_danhsachnv = new ListView();
            hoten = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            pannel_timkiem.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pannel_timkiem
            // 
            pannel_timkiem.Controls.Add(groupBox1);
            pannel_timkiem.Location = new Point(12, 12);
            pannel_timkiem.Name = "pannel_timkiem";
            pannel_timkiem.Size = new Size(580, 87);
            pannel_timkiem.TabIndex = 1;
            pannel_timkiem.Paint += panel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_tim);
            groupBox1.Controls.Add(txb_timkiem);
            groupBox1.Location = new Point(18, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 80);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // btn_tim
            // 
            btn_tim.Location = new Point(414, 26);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(94, 29);
            btn_tim.TabIndex = 1;
            btn_tim.Text = "Search";
            btn_tim.UseVisualStyleBackColor = true;
            btn_tim.Click += btn_tim_Click;
            // 
            // txb_timkiem
            // 
            txb_timkiem.Location = new Point(112, 26);
            txb_timkiem.Name = "txb_timkiem";
            txb_timkiem.Size = new Size(274, 27);
            txb_timkiem.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(txb_matkhau);
            panel1.Controls.Add(txb_taikhoan);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btn_thoat);
            panel1.Controls.Add(btn_lammoi);
            panel1.Controls.Add(btn_xoa);
            panel1.Controls.Add(btn_capnhat);
            panel1.Controls.Add(btn_them);
            panel1.Controls.Add(txb_diachi);
            panel1.Controls.Add(txb_dienthoai);
            panel1.Controls.Add(txb_ngaysinh);
            panel1.Controls.Add(txb_hoten);
            panel1.Controls.Add(cbx_vaittro);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 260);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 323);
            panel1.TabIndex = 3;
            // 
            // txb_matkhau
            // 
            txb_matkhau.Location = new Point(390, 88);
            txb_matkhau.Name = "txb_matkhau";
            txb_matkhau.Size = new Size(190, 27);
            txb_matkhau.TabIndex = 8;
            // 
            // txb_taikhoan
            // 
            txb_taikhoan.Location = new Point(390, 52);
            txb_taikhoan.Name = "txb_taikhoan";
            txb_taikhoan.Size = new Size(190, 27);
            txb_taikhoan.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(304, 91);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 12;
            label8.Text = "Mật khẩu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(304, 52);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 11;
            label7.Text = "Tài khoản:";
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(421, 275);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(94, 29);
            btn_thoat.TabIndex = 13;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_lammoi
            // 
            btn_lammoi.Location = new Point(321, 275);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(94, 29);
            btn_lammoi.TabIndex = 12;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(221, 275);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 11;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_capnhat
            // 
            btn_capnhat.Location = new Point(121, 275);
            btn_capnhat.Name = "btn_capnhat";
            btn_capnhat.Size = new Size(94, 29);
            btn_capnhat.TabIndex = 10;
            btn_capnhat.Text = "Cập nhật";
            btn_capnhat.UseVisualStyleBackColor = true;
            btn_capnhat.Click += btn_capnhat_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(21, 275);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 9;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // txb_diachi
            // 
            txb_diachi.Location = new Point(133, 91);
            txb_diachi.Name = "txb_diachi";
            txb_diachi.Size = new Size(125, 27);
            txb_diachi.TabIndex = 2;
            // 
            // txb_dienthoai
            // 
            txb_dienthoai.Location = new Point(133, 133);
            txb_dienthoai.Name = "txb_dienthoai";
            txb_dienthoai.Size = new Size(125, 27);
            txb_dienthoai.TabIndex = 3;
            // 
            // txb_ngaysinh
            // 
            txb_ngaysinh.Location = new Point(134, 172);
            txb_ngaysinh.Name = "txb_ngaysinh";
            txb_ngaysinh.Size = new Size(125, 27);
            txb_ngaysinh.TabIndex = 4;
            // 
            // txb_hoten
            // 
            txb_hoten.Location = new Point(133, 52);
            txb_hoten.Name = "txb_hoten";
            txb_hoten.Size = new Size(125, 27);
            txb_hoten.TabIndex = 1;
            // 
            // cbx_vaittro
            // 
            cbx_vaittro.FormattingEnabled = true;
            cbx_vaittro.Items.AddRange(new object[] { "Admin", "Quản lý sách", "Quản lý hóa đơn" });
            cbx_vaittro.Location = new Point(131, 217);
            cbx_vaittro.Name = "cbx_vaittro";
            cbx_vaittro.Size = new Size(151, 28);
            cbx_vaittro.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(45, 217);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 4;
            label6.Text = "Vai trò:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(45, 175);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 3;
            label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 133);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 2;
            label4.Text = "Điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 91);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 1;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 52);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ tên:";
            // 
            // lsv_danhsachnv
            // 
            lsv_danhsachnv.Columns.AddRange(new ColumnHeader[] { hoten, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lsv_danhsachnv.FullRowSelect = true;
            lsv_danhsachnv.Location = new Point(12, 105);
            lsv_danhsachnv.Name = "lsv_danhsachnv";
            lsv_danhsachnv.Size = new Size(903, 149);
            lsv_danhsachnv.TabIndex = 2;
            lsv_danhsachnv.UseCompatibleStateImageBehavior = false;
            lsv_danhsachnv.View = View.Details;
            lsv_danhsachnv.SelectedIndexChanged += lsv_danhsachnv_SelectedIndexChanged;
            // 
            // hoten
            // 
            hoten.Text = "Họ tên";
            hoten.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Địa chỉ";
            columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "SĐT";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ngày sinh";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tên vai trò";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tài khoản";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Mật khẩu";
            columnHeader7.Width = 120;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 593);
            Controls.Add(panel1);
            Controls.Add(lsv_danhsachnv);
            Controls.Add(pannel_timkiem);
            Name = "FormNhanVien";
            Text = "Thông tin nhân viên";
            FormClosing += FormNhanVien_FormClosing;
            Load += FormNhanVien_Load;
            pannel_timkiem.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pannel_timkiem;
        private GroupBox groupBox1;
        private TextBox txb_timkiem;
        private Button btn_tim;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private ComboBox cbx_vaittro;
        private TextBox txb_diachi;
        private TextBox txb_dienthoai;
        private TextBox txb_ngaysinh;
        private TextBox txb_hoten;
        private ListView lsv_danhsachnv;
        private Button btn_xoa;
        private Button btn_capnhat;
        private Button btn_them;
        private Button btn_lammoi;
        private Button btn_thoat;
        private ColumnHeader hoten;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TextBox txb_matkhau;
        private TextBox txb_taikhoan;
        private Label label8;
        private Label label7;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}
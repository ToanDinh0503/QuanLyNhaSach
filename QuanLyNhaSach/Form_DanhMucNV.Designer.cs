namespace QuanLyNhaSach
{
    partial class Form_DanhMucNV
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label17 = new Label();
            timer_dsqs = new System.Windows.Forms.Timer(components);
            lsv_dsnv = new ListView();
            manv = new ColumnHeader();
            tennv = new ColumnHeader();
            gioitinh = new ColumnHeader();
            sdt = new ColumnHeader();
            ngaysinh = new ColumnHeader();
            diachi = new ColumnHeader();
            vaitro = new ColumnHeader();
            taikhoan = new ColumnHeader();
            matkhau = new ColumnHeader();
            txt_search = new TextBox();
            btn_hiendanhsach = new Button();
            btn_search = new Button();
            groupBox2 = new GroupBox();
            txt_ns = new TextBox();
            txt_vt = new TextBox();
            txt_gt = new TextBox();
            txt_tnv = new TextBox();
            label1 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            txt_sdt = new TextBox();
            label2 = new Label();
            label6 = new Label();
            txt_mnv = new TextBox();
            txt_diachi = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aquamarine;
            panel1.Controls.Add(label17);
            panel1.Location = new Point(0, 15);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1425, 71);
            panel1.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Navy;
            label17.Location = new Point(537, 20);
            label17.Name = "label17";
            label17.Size = new Size(305, 29);
            label17.TabIndex = 0;
            label17.Text = "DANH SÁCH NHÂN VIÊN";
            label17.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer_dsqs
            // 
            timer_dsqs.Enabled = true;
            timer_dsqs.Interval = 5;
            // 
            // lsv_dsnv
            // 
            lsv_dsnv.BackColor = Color.White;
            lsv_dsnv.Columns.AddRange(new ColumnHeader[] { manv, tennv, gioitinh, sdt, ngaysinh, diachi, vaitro, taikhoan, matkhau });
            lsv_dsnv.FullRowSelect = true;
            lsv_dsnv.GridLines = true;
            lsv_dsnv.Location = new Point(0, 378);
            lsv_dsnv.Name = "lsv_dsnv";
            lsv_dsnv.Size = new Size(1408, 276);
            lsv_dsnv.TabIndex = 27;
            lsv_dsnv.UseCompatibleStateImageBehavior = false;
            lsv_dsnv.View = View.Details;
            lsv_dsnv.SelectedIndexChanged += lsv_dsnv_SelectedIndexChanged;
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
            // 
            // sdt
            // 
            sdt.Text = "Điện thoại";
            sdt.Width = 120;
            // 
            // ngaysinh
            // 
            ngaysinh.Text = "Ngày sinh";
            ngaysinh.Width = 300;
            // 
            // diachi
            // 
            diachi.Text = "Địa chỉ";
            diachi.Width = 300;
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
            // txt_search
            // 
            txt_search.Location = new Point(251, 323);
            txt_search.Margin = new Padding(4, 3, 4, 3);
            txt_search.MaxLength = 35;
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(262, 27);
            txt_search.TabIndex = 29;
            txt_search.TextChanged += txt_search_TextChanged;
            txt_search.KeyDown += txt_search_KeyDown;
            // 
            // btn_hiendanhsach
            // 
            btn_hiendanhsach.Location = new Point(573, 323);
            btn_hiendanhsach.Name = "btn_hiendanhsach";
            btn_hiendanhsach.Size = new Size(150, 29);
            btn_hiendanhsach.TabIndex = 31;
            btn_hiendanhsach.Text = "Hiện danh sách";
            btn_hiendanhsach.UseVisualStyleBackColor = true;
            btn_hiendanhsach.Click += btn_hiendanhsach_Click;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(150, 322);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(81, 28);
            btn_search.TabIndex = 30;
            btn_search.Text = "Lọc";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_ns);
            groupBox2.Controls.Add(txt_vt);
            groupBox2.Controls.Add(txt_gt);
            groupBox2.Controls.Add(txt_tnv);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txt_sdt);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_mnv);
            groupBox2.Controls.Add(txt_diachi);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(0, 110);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1408, 187);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chung";
            // 
            // txt_ns
            // 
            txt_ns.Location = new Point(167, 102);
            txt_ns.Name = "txt_ns";
            txt_ns.Size = new Size(217, 27);
            txt_ns.TabIndex = 26;
            // 
            // txt_vt
            // 
            txt_vt.Location = new Point(1115, 102);
            txt_vt.Name = "txt_vt";
            txt_vt.Size = new Size(199, 27);
            txt_vt.TabIndex = 25;
            // 
            // txt_gt
            // 
            txt_gt.Location = new Point(909, 38);
            txt_gt.Name = "txt_gt";
            txt_gt.Size = new Size(133, 27);
            txt_gt.TabIndex = 24;
            // 
            // txt_tnv
            // 
            txt_tnv.Location = new Point(453, 39);
            txt_tnv.Margin = new Padding(4, 3, 4, 3);
            txt_tnv.MaxLength = 250;
            txt_tnv.Multiline = true;
            txt_tnv.Name = "txt_tnv";
            txt_tnv.Size = new Size(310, 24);
            txt_tnv.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 22;
            label1.Text = "Mã nhân viên:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1023, 105);
            label11.Name = "label11";
            label11.Size = new Size(59, 20);
            label11.TabIndex = 20;
            label11.Text = "Vai trò:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(815, 42);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 16;
            label10.Text = "Giới tính:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1091, 45);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 15;
            label9.Text = "Điện thoại:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 222);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 7;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(1215, 41);
            txt_sdt.Margin = new Padding(4, 3, 4, 3);
            txt_sdt.MaxLength = 10;
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(172, 27);
            txt_sdt.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 42);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 5;
            label2.Text = "Họ tên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 105);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 6;
            label6.Text = "Ngày sinh:";
            // 
            // txt_mnv
            // 
            txt_mnv.Location = new Point(167, 38);
            txt_mnv.Margin = new Padding(4, 3, 4, 3);
            txt_mnv.MaxLength = 35;
            txt_mnv.Name = "txt_mnv";
            txt_mnv.Size = new Size(143, 27);
            txt_mnv.TabIndex = 1;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(537, 102);
            txt_diachi.Margin = new Padding(4, 3, 4, 3);
            txt_diachi.MaxLength = 50;
            txt_diachi.Multiline = true;
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(436, 30);
            txt_diachi.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 109);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ:";
            // 
            // Form_DanhMucNV
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1425, 662);
            Controls.Add(groupBox2);
            Controls.Add(txt_search);
            Controls.Add(btn_hiendanhsach);
            Controls.Add(btn_search);
            Controls.Add(lsv_dsnv);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_DanhMucNV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DANH MỤC NHÂN VIÊN";
            FormClosing += Form5_FormClosing;
            Load += Form_DanhMucNV_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_DNT;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel_7TN;
        private Label label1;
        private Label label4;
        private Panel panel_QQ;
        private Label label6;
        private Panel panel_cachsong;
        private Label label7;
        private Label label8;
        private Panel panel_tuoitre;
        private Label label10;
        private Panel panel_DN;
        private Label label11;
        private Label label25;
        private PictureBox pictureBox3;
        private Label label26;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label label27;
        private PictureBox pictureBox4;
        private Label label28;
        private Label label9;
        private Label label29;
        private Label label30;
        private Panel panel_matbiec;
        private Label label18;
        private Label label19;
        private Panel panel_tiengem;
        private Label label23;
        private Label label24;
        private Label label31;
        private Panel panel_ntn;
        private Label label33;
        private Label label34;
        private Panel panel_doda;
        private Label label35;
        private Label label36;
        private PictureBox pictureBox12;
        private Label label37;
        private Panel panel_doibuoncuoi;
        private Label label42;
        private Label label44;
        private Label label45;
        private PictureBox pictureBox14;
        private PictureBox pictureBox10;
        private PictureBox pictureBox8;
        private PictureBox pictureBox11;
        private Panel panel1;
        private Label label17;
        private System.Windows.Forms.Timer timer_dsqs;
        private ListView lsv_dsnv;
        private ColumnHeader manv;
        private ColumnHeader tennv;
        private ColumnHeader gioitinh;
        private ColumnHeader sdt;
        private ColumnHeader ngaysinh;
        private ColumnHeader diachi;
        private ColumnHeader vaitro;
        private ColumnHeader taikhoan;
        private ColumnHeader matkhau;
        private TextBox txt_search;
        private Button btn_hiendanhsach;
        private Button btn_search;
        private GroupBox groupBox2;
        private TextBox txt_tnv;
        private TextBox txt_sdt;
        private TextBox txt_mnv;
        private TextBox txt_diachi;
        private TextBox txt_vt;
        private TextBox txt_gt;
        private TextBox txt_ns;
    }
}
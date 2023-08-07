namespace QuanLyNhaSach
{
    partial class Form_DanhMuckh
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
            lsv_khach = new ListView();
            makh = new ColumnHeader();
            tenkh = new ColumnHeader();
            diachi = new ColumnHeader();
            sdt = new ColumnHeader();
            email = new ColumnHeader();
            btn_searchKhach = new Button();
            txt_searchKhach = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            txt_mkh = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_tkh = new TextBox();
            txt_email = new TextBox();
            txt_dchi = new TextBox();
            label5 = new Label();
            txt_sdt = new TextBox();
            label3 = new Label();
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
            panel1.Size = new Size(1318, 71);
            panel1.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Navy;
            label17.Location = new Point(453, 21);
            label17.Name = "label17";
            label17.Size = new Size(333, 29);
            label17.TabIndex = 0;
            label17.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // timer_dsqs
            // 
            timer_dsqs.Enabled = true;
            timer_dsqs.Interval = 5;
            // 
            // lsv_khach
            // 
            lsv_khach.Columns.AddRange(new ColumnHeader[] { makh, tenkh, diachi, sdt, email });
            lsv_khach.FullRowSelect = true;
            lsv_khach.GridLines = true;
            lsv_khach.Location = new Point(8, 328);
            lsv_khach.Name = "lsv_khach";
            lsv_khach.Size = new Size(1297, 263);
            lsv_khach.TabIndex = 27;
            lsv_khach.UseCompatibleStateImageBehavior = false;
            lsv_khach.View = View.Details;
            lsv_khach.SelectedIndexChanged += lsv_khach_SelectedIndexChanged;
            // 
            // makh
            // 
            makh.Text = "Mã Khách Hàng";
            makh.Width = 200;
            // 
            // tenkh
            // 
            tenkh.Text = "Tên Khách Hàng";
            tenkh.Width = 320;
            // 
            // diachi
            // 
            diachi.Text = "Địa Chỉ";
            diachi.Width = 320;
            // 
            // sdt
            // 
            sdt.Text = "Số Điện Thoại";
            sdt.Width = 200;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 250;
            // 
            // btn_searchKhach
            // 
            btn_searchKhach.Location = new Point(12, 283);
            btn_searchKhach.Name = "btn_searchKhach";
            btn_searchKhach.Size = new Size(81, 32);
            btn_searchKhach.TabIndex = 1;
            btn_searchKhach.Text = "Lọc";
            btn_searchKhach.UseVisualStyleBackColor = true;
            btn_searchKhach.Click += btn_searchKhach_Click;
            // 
            // txt_searchKhach
            // 
            txt_searchKhach.Location = new Point(108, 286);
            txt_searchKhach.Margin = new Padding(4, 3, 4, 3);
            txt_searchKhach.MaxLength = 35;
            txt_searchKhach.Name = "txt_searchKhach";
            txt_searchKhach.Size = new Size(262, 27);
            txt_searchKhach.TabIndex = 2;
            txt_searchKhach.KeyDown += txt_searchKhach_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(377, 281);
            button1.Name = "button1";
            button1.Size = new Size(172, 36);
            button1.TabIndex = 30;
            button1.Text = "Hiển thị danh sách";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_mkh);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txt_tkh);
            groupBox2.Controls.Add(txt_email);
            groupBox2.Controls.Add(txt_dchi);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_sdt);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(13, 105);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1292, 161);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chung";
            // 
            // txt_mkh
            // 
            txt_mkh.Location = new Point(149, 50);
            txt_mkh.Margin = new Padding(4, 3, 4, 3);
            txt_mkh.MaxLength = 1000;
            txt_mkh.Name = "txt_mkh";
            txt_mkh.Size = new Size(182, 27);
            txt_mkh.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Khách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Khách Hàng:";
            // 
            // txt_tkh
            // 
            txt_tkh.Location = new Point(521, 50);
            txt_tkh.Margin = new Padding(4, 3, 4, 3);
            txt_tkh.MaxLength = 50;
            txt_tkh.Name = "txt_tkh";
            txt_tkh.Size = new Size(243, 27);
            txt_tkh.TabIndex = 9;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(521, 108);
            txt_email.Margin = new Padding(4, 3, 4, 3);
            txt_email.MaxLength = 50;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(243, 27);
            txt_email.TabIndex = 12;
            // 
            // txt_dchi
            // 
            txt_dchi.Location = new Point(913, 51);
            txt_dchi.Margin = new Padding(4, 3, 4, 3);
            txt_dchi.MaxLength = 250;
            txt_dchi.Multiline = true;
            txt_dchi.Name = "txt_dchi";
            txt_dchi.Size = new Size(359, 24);
            txt_dchi.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(380, 114);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 5;
            label5.Text = "Email:";
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(154, 109);
            txt_sdt.Margin = new Padding(4, 3, 4, 3);
            txt_sdt.MaxLength = 11;
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(177, 27);
            txt_sdt.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(816, 57);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 4;
            label4.Text = "Số Điện Thoại:";
            // 
            // Form_DanhMuckh
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1317, 603);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(btn_searchKhach);
            Controls.Add(txt_searchKhach);
            Controls.Add(lsv_khach);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_DanhMuckh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DANH MỤC KHÁCH HÀNG";
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
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel_7TN;
        private Label label1;
        private Label label4;
        private Panel panel_QQ;
        private Label label5;
        private Label label6;
        private Panel panel_cachsong;
        private Label label7;
        private Label label8;
        private Panel panel_tuoitre;
        private Label label10;
        private Panel panel_DN;
        private Label label11;
        private Label label12;
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
        private ListView lsv_danhsach;
        private ColumnHeader manv;
        private ColumnHeader tennv;
        private ColumnHeader gioitinh;
        private ColumnHeader sdt;
        private ColumnHeader ngaysinh;
        private ColumnHeader diachi;
        private ColumnHeader vaitro;
        private ColumnHeader taikhoan;
        private ColumnHeader matkhau;
        private ListView lsv_khach;
        private ColumnHeader makh;
        private ColumnHeader tenkh;
        private ColumnHeader email;
        private Button btn_searchKhach;
        private TextBox txt_searchKhach;
        private Button button1;
        private GroupBox groupBox2;
        private TextBox txt_mkh;
        private TextBox txt_tkh;
        private TextBox txt_email;
        private TextBox txt_dchi;
        private TextBox txt_sdt;
    }
}
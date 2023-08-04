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
            panel1.SuspendLayout();
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
            label17.Location = new Point(450, 15);
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
            lsv_khach.Location = new Point(8, 163);
            lsv_khach.Name = "lsv_khach";
            lsv_khach.Size = new Size(1297, 437);
            lsv_khach.TabIndex = 27;
            lsv_khach.UseCompatibleStateImageBehavior = false;
            lsv_khach.View = View.Details;
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
            btn_searchKhach.Location = new Point(14, 113);
            btn_searchKhach.Name = "btn_searchKhach";
            btn_searchKhach.Size = new Size(81, 28);
            btn_searchKhach.TabIndex = 1;
            btn_searchKhach.Text = "Lọc";
            btn_searchKhach.UseVisualStyleBackColor = true;
            btn_searchKhach.Click += btn_searchKhach_Click;
            // 
            // txt_searchKhach
            // 
            txt_searchKhach.Location = new Point(102, 113);
            txt_searchKhach.Margin = new Padding(4, 3, 4, 3);
            txt_searchKhach.Name = "txt_searchKhach";
            txt_searchKhach.Size = new Size(262, 27);
            txt_searchKhach.TabIndex = 2;
            txt_searchKhach.KeyDown += txt_searchKhach_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(372, 113);
            button1.Name = "button1";
            button1.Size = new Size(172, 28);
            button1.TabIndex = 30;
            button1.Text = "Hiển thị danh sách";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form_DanhMuckh
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1317, 603);
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
            Text = "DANH SÁCH KHÁCH HÀNG";
            FormClosing += Form5_FormClosing;
            Load += Form_DanhMucNV_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
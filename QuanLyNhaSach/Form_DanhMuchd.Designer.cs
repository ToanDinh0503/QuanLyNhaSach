namespace QuanLyNhaSach
{
    partial class Form_DanhMucHD
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
            lsv_dmhd = new ListView();
            mahd = new ColumnHeader();
            nlhd = new ColumnHeader();
            tt = new ColumnHeader();
            kh = new ColumnHeader();
            nv = new ColumnHeader();
            btn_searchHoaDon = new Button();
            txt_searchHoaDon = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            txt_nv = new TextBox();
            txt_kh = new TextBox();
            txt_nlhd = new TextBox();
            txt_mhd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_tt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aquamarine;
            panel1.Controls.Add(label17);
            panel1.Location = new Point(0, 11);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1285, 73);
            panel1.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Navy;
            label17.Location = new Point(443, 20);
            label17.Name = "label17";
            label17.Size = new Size(344, 29);
            label17.TabIndex = 0;
            label17.Text = "DANH SÁCH CÁC HÓA ĐƠN";
            // 
            // timer_dsqs
            // 
            timer_dsqs.Enabled = true;
            timer_dsqs.Interval = 5;
            // 
            // lsv_dmhd
            // 
            lsv_dmhd.Columns.AddRange(new ColumnHeader[] { mahd, nlhd, tt, kh, nv });
            lsv_dmhd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lsv_dmhd.FullRowSelect = true;
            lsv_dmhd.GridLines = true;
            lsv_dmhd.Location = new Point(12, 352);
            lsv_dmhd.Name = "lsv_dmhd";
            lsv_dmhd.Size = new Size(1258, 290);
            lsv_dmhd.TabIndex = 27;
            lsv_dmhd.UseCompatibleStateImageBehavior = false;
            lsv_dmhd.View = View.Details;
            lsv_dmhd.SelectedIndexChanged += lsv_dmhd_SelectedIndexChanged;
            // 
            // mahd
            // 
            mahd.Text = "Mã Hóa Đơn";
            mahd.Width = 150;
            // 
            // nlhd
            // 
            nlhd.Text = "Ngày Lập ";
            nlhd.Width = 200;
            // 
            // tt
            // 
            tt.Text = "Tổng Tiền";
            tt.Width = 200;
            // 
            // kh
            // 
            kh.Text = "Khách Hàng";
            kh.Width = 350;
            // 
            // nv
            // 
            nv.Text = "Nhân Viên";
            nv.Width = 350;
            // 
            // btn_searchHoaDon
            // 
            btn_searchHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_searchHoaDon.Location = new Point(182, 307);
            btn_searchHoaDon.Name = "btn_searchHoaDon";
            btn_searchHoaDon.Size = new Size(72, 28);
            btn_searchHoaDon.TabIndex = 1;
            btn_searchHoaDon.Text = "Lọc";
            btn_searchHoaDon.UseVisualStyleBackColor = true;
            btn_searchHoaDon.Click += btn_searchHoaDon_Click;
            btn_searchHoaDon.KeyDown += btn_searchHoaDon_KeyDown;
            // 
            // txt_searchHoaDon
            // 
            txt_searchHoaDon.Location = new Point(274, 307);
            txt_searchHoaDon.Margin = new Padding(4, 3, 4, 3);
            txt_searchHoaDon.Name = "txt_searchHoaDon";
            txt_searchHoaDon.Size = new Size(233, 27);
            txt_searchHoaDon.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(529, 306);
            button1.Name = "button1";
            button1.Size = new Size(153, 28);
            button1.TabIndex = 30;
            button1.Text = "Hiển thị danh sách";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_nv);
            groupBox2.Controls.Add(txt_kh);
            groupBox2.Controls.Add(txt_nlhd);
            groupBox2.Controls.Add(txt_mhd);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_tt);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 102);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1258, 184);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chung";
            // 
            // txt_nv
            // 
            txt_nv.Location = new Point(653, 111);
            txt_nv.Name = "txt_nv";
            txt_nv.Size = new Size(314, 24);
            txt_nv.TabIndex = 22;
            // 
            // txt_kh
            // 
            txt_kh.Location = new Point(156, 110);
            txt_kh.Name = "txt_kh";
            txt_kh.Size = new Size(292, 24);
            txt_kh.TabIndex = 21;
            // 
            // txt_nlhd
            // 
            txt_nlhd.Location = new Point(536, 48);
            txt_nlhd.Name = "txt_nlhd";
            txt_nlhd.Size = new Size(235, 24);
            txt_nlhd.TabIndex = 18;
            // 
            // txt_mhd
            // 
            txt_mhd.Location = new Point(156, 51);
            txt_mhd.Margin = new Padding(4);
            txt_mhd.MaxLength = 1000;
            txt_mhd.Name = "txt_mhd";
            txt_mhd.Size = new Size(215, 24);
            txt_mhd.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 18);
            label2.TabIndex = 1;
            label2.Text = "Mã Hóa Đơn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 52);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 2;
            label3.Text = "Ngày Lập:";
            // 
            // txt_tt
            // 
            txt_tt.Location = new Point(963, 46);
            txt_tt.Margin = new Padding(4);
            txt_tt.MaxLength = 250;
            txt_tt.Multiline = true;
            txt_tt.Name = "txt_tt";
            txt_tt.Size = new Size(235, 26);
            txt_tt.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 115);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 18);
            label5.TabIndex = 5;
            label5.Text = "Nhân Viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(842, 52);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 3;
            label4.Text = "Tổng Tiền:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 114);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 18);
            label6.TabIndex = 4;
            label6.Text = "Khách Hàng:";
            // 
            // Form_DanhMucHD
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1282, 654);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(btn_searchHoaDon);
            Controls.Add(txt_searchHoaDon);
            Controls.Add(lsv_dmhd);
            Controls.Add(panel1);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_DanhMucHD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DANH SÁCH HÓA ĐƠN";
            FormClosing += FormHD_FormClosing;
            Load += Form_DanhMucHD_Load;
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
        private Label label4;
        private Panel panel_QQ;
        private Label label5;
        private Label label6;
        private Panel panel_cachsong;
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
        private ColumnHeader tt;
        private ColumnHeader tennv;
        private ColumnHeader gioitinh;
        private ColumnHeader ngaysinh;
        private ColumnHeader diachi;
        private ColumnHeader vaitro;
        private ColumnHeader taikhoan;
        private ColumnHeader matkhau;
        private ListView lsv_dmhd;
        private ColumnHeader mahd;
        private ColumnHeader nlhd;
        private ColumnHeader kh;
        private Button btn_searchHoaDon;
        private TextBox txt_searchHoaDon;
        private Button button1;
        private ColumnHeader nv;
        private GroupBox groupBox2;
        private TextBox txt_nlhd;
        private TextBox txt_mhd;
        private TextBox txt_tt;
        private TextBox txt_nv;
        private TextBox txt_kh;
    }
}
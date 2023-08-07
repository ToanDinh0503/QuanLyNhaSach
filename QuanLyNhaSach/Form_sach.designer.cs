using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    partial class Form_sach
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
            label6 = new Label();
            label7 = new Label();
            txt_ms = new TextBox();
            txt_ts = new TextBox();
            txt_mt = new TextBox();
            txt_gia = new TextBox();
            btn_themsach = new Button();
            btn_suasach = new Button();
            btn_xoasach = new Button();
            btn_thoat = new Button();
            groupBox1 = new GroupBox();
            btn_Luu = new Button();
            btn_Huy = new Button();
            groupBox2 = new GroupBox();
            btn_htts = new Button();
            btn_htmt = new Button();
            comboBoxNXB = new ComboBox();
            comboBoxTheLoai = new ComboBox();
            label8 = new Label();
            btn_search = new Button();
            txt_search = new TextBox();
            lsv_sach = new ListView();
            masach = new ColumnHeader();
            tensach = new ColumnHeader();
            gia = new ColumnHeader();
            nam1 = new ColumnHeader();
            manxb = new ColumnHeader();
            matl = new ColumnHeader();
            mota = new ColumnHeader();
            button1 = new Button();
            txt_nxb = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 18);
            label1.TabIndex = 1;
            label1.Text = "Mã Sách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 18);
            label2.TabIndex = 2;
            label2.Text = "Tên Sách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 3;
            label3.Text = "Mô tả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 109);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 18);
            label4.TabIndex = 4;
            label4.Text = "Giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 164);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 18);
            label5.TabIndex = 5;
            label5.Text = "Nhà xuất bản:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 158);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 18);
            label6.TabIndex = 6;
            label6.Text = "Năm xuất bản:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 222);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 18);
            label7.TabIndex = 7;
            label7.Text = "Thể loại:";
            // 
            // txt_ms
            // 
            txt_ms.Location = new Point(147, 47);
            txt_ms.Margin = new Padding(4, 3, 4, 3);
            txt_ms.Name = "txt_ms";
            txt_ms.Size = new Size(173, 24);
            txt_ms.TabIndex = 8;
            // 
            // txt_ts
            // 
            txt_ts.Location = new Point(556, 50);
            txt_ts.Margin = new Padding(4, 3, 4, 3);
            txt_ts.MaxLength = 50;
            txt_ts.Name = "txt_ts";
            txt_ts.Size = new Size(173, 24);
            txt_ts.TabIndex = 9;
            // 
            // txt_mt
            // 
            txt_mt.Location = new Point(147, 103);
            txt_mt.Margin = new Padding(4, 3, 4, 3);
            txt_mt.MaxLength = 250;
            txt_mt.Multiline = true;
            txt_mt.Name = "txt_mt";
            txt_mt.Size = new Size(173, 24);
            txt_mt.TabIndex = 10;
            // 
            // txt_gia
            // 
            txt_gia.Location = new Point(556, 103);
            txt_gia.Margin = new Padding(4, 3, 4, 3);
            txt_gia.MaxLength = 8;
            txt_gia.Name = "txt_gia";
            txt_gia.Size = new Size(174, 24);
            txt_gia.TabIndex = 11;
            txt_gia.KeyPress += txt_gia_KeyPress;
            // 
            // btn_themsach
            // 
            btn_themsach.Location = new Point(43, 62);
            btn_themsach.Margin = new Padding(4, 3, 4, 3);
            btn_themsach.Name = "btn_themsach";
            btn_themsach.Size = new Size(139, 48);
            btn_themsach.TabIndex = 15;
            btn_themsach.Text = "Thêm";
            btn_themsach.UseVisualStyleBackColor = true;
            btn_themsach.Click += btn_themsach_Click;
            // 
            // btn_suasach
            // 
            btn_suasach.Location = new Point(207, 62);
            btn_suasach.Margin = new Padding(4, 3, 4, 3);
            btn_suasach.Name = "btn_suasach";
            btn_suasach.Size = new Size(139, 48);
            btn_suasach.TabIndex = 17;
            btn_suasach.Text = "Sửa";
            btn_suasach.UseVisualStyleBackColor = true;
            btn_suasach.Click += btn_suasach_Click;
            // 
            // btn_xoasach
            // 
            btn_xoasach.Location = new Point(369, 62);
            btn_xoasach.Margin = new Padding(4, 3, 4, 3);
            btn_xoasach.Name = "btn_xoasach";
            btn_xoasach.Size = new Size(139, 48);
            btn_xoasach.TabIndex = 18;
            btn_xoasach.Text = "Xóa";
            btn_xoasach.UseVisualStyleBackColor = true;
            btn_xoasach.Click += btn_xoasach_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.DialogResult = DialogResult.Cancel;
            btn_thoat.Location = new Point(369, 160);
            btn_thoat.Margin = new Padding(4, 3, 4, 3);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(139, 48);
            btn_thoat.TabIndex = 22;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Luu);
            groupBox1.Controls.Add(btn_Huy);
            groupBox1.Controls.Add(btn_thoat);
            groupBox1.Controls.Add(btn_themsach);
            groupBox1.Controls.Add(btn_suasach);
            groupBox1.Controls.Add(btn_xoasach);
            groupBox1.Location = new Point(825, 90);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(556, 254);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btn_Luu
            // 
            btn_Luu.Location = new Point(43, 160);
            btn_Luu.Margin = new Padding(4, 3, 4, 3);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(139, 48);
            btn_Luu.TabIndex = 20;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            btn_Luu.Click += btn_Luu_Click;
            // 
            // btn_Huy
            // 
            btn_Huy.Location = new Point(207, 160);
            btn_Huy.Margin = new Padding(4, 3, 4, 3);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(139, 48);
            btn_Huy.TabIndex = 21;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            btn_Huy.Click += btn_Huy_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_htts);
            groupBox2.Controls.Add(btn_htmt);
            groupBox2.Controls.Add(comboBoxNXB);
            groupBox2.Controls.Add(comboBoxTheLoai);
            groupBox2.Controls.Add(txt_ms);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txt_nxb);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_ts);
            groupBox2.Controls.Add(txt_mt);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_gia);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(23, 90);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(794, 254);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sách";
            // 
            // btn_htts
            // 
            btn_htts.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_htts.Location = new Point(751, 53);
            btn_htts.Name = "btn_htts";
            btn_htts.Size = new Size(36, 23);
            btn_htts.TabIndex = 17;
            btn_htts.Text = "...";
            btn_htts.UseVisualStyleBackColor = true;
            btn_htts.Click += btn_htts_Click;
            // 
            // btn_htmt
            // 
            btn_htmt.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_htmt.Location = new Point(334, 107);
            btn_htmt.Name = "btn_htmt";
            btn_htmt.Size = new Size(36, 23);
            btn_htmt.TabIndex = 16;
            btn_htmt.Text = "...";
            btn_htmt.UseVisualStyleBackColor = true;
            btn_htmt.Click += btn_htmt_Click;
            // 
            // comboBoxNXB
            // 
            comboBoxNXB.FormattingEnabled = true;
            comboBoxNXB.Location = new Point(147, 161);
            comboBoxNXB.Name = "comboBoxNXB";
            comboBoxNXB.Size = new Size(173, 26);
            comboBoxNXB.TabIndex = 15;
            // 
            // comboBoxTheLoai
            // 
            comboBoxTheLoai.FormattingEnabled = true;
            comboBoxTheLoai.Location = new Point(147, 215);
            comboBoxTheLoai.Name = "comboBoxTheLoai";
            comboBoxTheLoai.Size = new Size(173, 26);
            comboBoxTheLoai.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(494, 27);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(430, 36);
            label8.TabIndex = 23;
            label8.Text = "QUẢN LÝ THÔNG TIN SÁCH";
            // 
            // btn_search
            // 
            btn_search.Location = new Point(23, 354);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(72, 28);
            btn_search.TabIndex = 25;
            btn_search.Text = "Lọc";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(102, 358);
            txt_search.Margin = new Padding(4, 3, 4, 3);
            txt_search.MaxLength = 50;
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(233, 24);
            txt_search.TabIndex = 15;
            // 
            // lsv_sach
            // 
            lsv_sach.Columns.AddRange(new ColumnHeader[] { masach, tensach, gia, nam1, manxb, matl, mota });
            lsv_sach.FullRowSelect = true;
            lsv_sach.GridLines = true;
            lsv_sach.Location = new Point(23, 398);
            lsv_sach.Name = "lsv_sach";
            lsv_sach.Size = new Size(1358, 218);
            lsv_sach.TabIndex = 26;
            lsv_sach.UseCompatibleStateImageBehavior = false;
            lsv_sach.View = View.Details;
            lsv_sach.SelectedIndexChanged += lsv_sach_SelectedIndexChanged;
            // 
            // masach
            // 
            masach.Text = "Mã Sách";
            masach.Width = 150;
            // 
            // tensach
            // 
            tensach.Text = "Tên Sách";
            tensach.Width = 350;
            // 
            // gia
            // 
            gia.Text = "Giá";
            gia.Width = 200;
            // 
            // nam1
            // 
            nam1.Text = "Năm";
            nam1.Width = 140;
            // 
            // manxb
            // 
            manxb.Text = "Nhà Xuất Bản";
            manxb.Width = 259;
            // 
            // matl
            // 
            matl.Text = "Thể Loại";
            matl.Width = 180;
            // 
            // mota
            // 
            mota.Text = "Mô Tả";
            mota.Width = 0;
            // 
            // button1
            // 
            button1.Location = new Point(357, 354);
            button1.Name = "button1";
            button1.Size = new Size(178, 34);
            button1.TabIndex = 27;
            button1.Text = "Hiển Thị Danh Sách";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_nxb
            // 
            txt_nxb.Location = new Point(556, 155);
            txt_nxb.Margin = new Padding(4, 3, 4, 3);
            txt_nxb.MaxLength = 4;
            txt_nxb.Name = "txt_nxb";
            txt_nxb.Size = new Size(174, 24);
            txt_nxb.TabIndex = 13;
            txt_nxb.KeyPress += txt_nxb_KeyPress;
            // 
            // Form_sach
            // 
            AcceptButton = btn_themsach;
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_thoat;
            ClientSize = new Size(1412, 628);
            Controls.Add(button1);
            Controls.Add(lsv_sach);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form_sach";
            Text = "QUẢN LÝ THÔNG TIN SÁCH";
            FormClosing += Form_sach_FormClosing;
            Load += Form_sach_Load;
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
        private Label label6;
        private Label label7;
        private TextBox txt_ms;
        private TextBox txt_ts;
        private TextBox txt_mt;
        private TextBox txt_gia;
        private Button btn_themsach;
        private Button btn_suasach;
        private Button btn_xoasach;
        private Button btn_thoat;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private Button btn_search;
        private TextBox txt_search;
        private Button btn_Huy;
        private Button btn_Luu;
        private ListView lsv_sach;
        private ColumnHeader masach;
        private ColumnHeader tensach;
        private ColumnHeader gia;
        private ColumnHeader nam1;
        private ColumnHeader manxb;
        private ColumnHeader matl;
        private ColumnHeader mota;
        private ComboBox comboBoxTheLoai;
        private ComboBox comboBoxNXB;
        private Button button1;
        private Button btn_htmt;
        private Button btn_htts;
        private TextBox txt_nxb;
    }
}
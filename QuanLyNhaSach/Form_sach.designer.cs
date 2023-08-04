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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ms = new System.Windows.Forms.TextBox();
            this.txt_ts = new System.Windows.Forms.TextBox();
            this.txt_mt = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_nxb = new System.Windows.Forms.TextBox();
            this.btn_themsach = new System.Windows.Forms.Button();
            this.btn_suasach = new System.Windows.Forms.Button();
            this.btn_xoasach = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_htmt = new System.Windows.Forms.Button();
            this.comboBoxNXB = new System.Windows.Forms.ComboBox();
            this.comboBoxTheLoai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lsv_sach = new System.Windows.Forms.ListView();
            this.masach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tensach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nam1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manxb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.matl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhà xuất bản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Năm xuất bản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Thể loại:";
            // 
            // txt_ms
            // 
            this.txt_ms.Location = new System.Drawing.Point(147, 47);
            this.txt_ms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ms.Name = "txt_ms";
            this.txt_ms.Size = new System.Drawing.Size(173, 24);
            this.txt_ms.TabIndex = 8;
            // 
            // txt_ts
            // 
            this.txt_ts.Location = new System.Drawing.Point(556, 50);
            this.txt_ts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ts.MaxLength = 50;
            this.txt_ts.Name = "txt_ts";
            this.txt_ts.Size = new System.Drawing.Size(173, 24);
            this.txt_ts.TabIndex = 9;
            // 
            // txt_mt
            // 
            this.txt_mt.Location = new System.Drawing.Point(147, 103);
            this.txt_mt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_mt.MaxLength = 250;
            this.txt_mt.Multiline = true;
            this.txt_mt.Name = "txt_mt";
            this.txt_mt.Size = new System.Drawing.Size(173, 24);
            this.txt_mt.TabIndex = 10;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(556, 103);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_gia.MaxLength = 11;
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(174, 24);
            this.txt_gia.TabIndex = 11;
            this.txt_gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gia_KeyPress);
            // 
            // txt_nxb
            // 
            this.txt_nxb.Location = new System.Drawing.Point(556, 152);
            this.txt_nxb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_nxb.MaxLength = 4;
            this.txt_nxb.Name = "txt_nxb";
            this.txt_nxb.Size = new System.Drawing.Size(174, 24);
            this.txt_nxb.TabIndex = 13;
            this.txt_nxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nxb_KeyPress);
            // 
            // btn_themsach
            // 
            this.btn_themsach.Location = new System.Drawing.Point(43, 62);
            this.btn_themsach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_themsach.Name = "btn_themsach";
            this.btn_themsach.Size = new System.Drawing.Size(139, 48);
            this.btn_themsach.TabIndex = 15;
            this.btn_themsach.Text = "Thêm";
            this.btn_themsach.UseVisualStyleBackColor = true;
            this.btn_themsach.Click += new System.EventHandler(this.btn_themsach_Click);
            // 
            // btn_suasach
            // 
            this.btn_suasach.Location = new System.Drawing.Point(207, 62);
            this.btn_suasach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_suasach.Name = "btn_suasach";
            this.btn_suasach.Size = new System.Drawing.Size(139, 48);
            this.btn_suasach.TabIndex = 17;
            this.btn_suasach.Text = "Sửa";
            this.btn_suasach.UseVisualStyleBackColor = true;
            this.btn_suasach.Click += new System.EventHandler(this.btn_suasach_Click);
            // 
            // btn_xoasach
            // 
            this.btn_xoasach.Location = new System.Drawing.Point(369, 62);
            this.btn_xoasach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_xoasach.Name = "btn_xoasach";
            this.btn_xoasach.Size = new System.Drawing.Size(139, 48);
            this.btn_xoasach.TabIndex = 18;
            this.btn_xoasach.Text = "Xóa";
            this.btn_xoasach.UseVisualStyleBackColor = true;
            this.btn_xoasach.Click += new System.EventHandler(this.btn_xoasach_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Location = new System.Drawing.Point(369, 160);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(139, 48);
            this.btn_thoat.TabIndex = 22;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.btn_Huy);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_themsach);
            this.groupBox1.Controls.Add(this.btn_suasach);
            this.groupBox1.Controls.Add(this.btn_xoasach);
            this.groupBox1.Location = new System.Drawing.Point(825, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(556, 254);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(43, 160);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(139, 48);
            this.btn_Luu.TabIndex = 20;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(207, 160);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(139, 48);
            this.btn_Huy.TabIndex = 21;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_htmt);
            this.groupBox2.Controls.Add(this.comboBoxNXB);
            this.groupBox2.Controls.Add(this.comboBoxTheLoai);
            this.groupBox2.Controls.Add(this.txt_ms);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_nxb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_ts);
            this.groupBox2.Controls.Add(this.txt_mt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_gia);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(23, 90);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(755, 254);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // btn_htmt
            // 
            this.btn_htmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_htmt.Location = new System.Drawing.Point(334, 107);
            this.btn_htmt.Name = "btn_htmt";
            this.btn_htmt.Size = new System.Drawing.Size(36, 23);
            this.btn_htmt.TabIndex = 16;
            this.btn_htmt.Text = "...";
            this.btn_htmt.UseVisualStyleBackColor = true;
            this.btn_htmt.Click += new System.EventHandler(this.btn_htmt_Click);
            // 
            // comboBoxNXB
            // 
            this.comboBoxNXB.FormattingEnabled = true;
            this.comboBoxNXB.Location = new System.Drawing.Point(147, 161);
            this.comboBoxNXB.Name = "comboBoxNXB";
            this.comboBoxNXB.Size = new System.Drawing.Size(173, 26);
            this.comboBoxNXB.TabIndex = 15;
            // 
            // comboBoxTheLoai
            // 
            this.comboBoxTheLoai.FormattingEnabled = true;
            this.comboBoxTheLoai.Location = new System.Drawing.Point(147, 215);
            this.comboBoxTheLoai.Name = "comboBoxTheLoai";
            this.comboBoxTheLoai.Size = new System.Drawing.Size(173, 26);
            this.comboBoxTheLoai.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(494, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(430, 36);
            this.label8.TabIndex = 23;
            this.label8.Text = "QUẢN LÝ THÔNG TIN SÁCH";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(23, 354);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(72, 28);
            this.btn_search.TabIndex = 25;
            this.btn_search.Text = "Lọc";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(102, 358);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(233, 24);
            this.txt_search.TabIndex = 15;
            // 
            // lsv_sach
            // 
            this.lsv_sach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.masach,
            this.tensach,
            this.gia,
            this.nam1,
            this.manxb,
            this.matl,
            this.mota});
            this.lsv_sach.FullRowSelect = true;
            this.lsv_sach.GridLines = true;
            this.lsv_sach.HideSelection = false;
            this.lsv_sach.Location = new System.Drawing.Point(23, 398);
            this.lsv_sach.Name = "lsv_sach";
            this.lsv_sach.Size = new System.Drawing.Size(1358, 218);
            this.lsv_sach.TabIndex = 26;
            this.lsv_sach.UseCompatibleStateImageBehavior = false;
            this.lsv_sach.View = System.Windows.Forms.View.Details;
            this.lsv_sach.SelectedIndexChanged += new System.EventHandler(this.lsv_sach_SelectedIndexChanged);
            // 
            // masach
            // 
            this.masach.Text = "Mã Sách";
            this.masach.Width = 150;
            // 
            // tensach
            // 
            this.tensach.Text = "Tên Sách";
            this.tensach.Width = 350;
            // 
            // gia
            // 
            this.gia.Text = "Giá";
            this.gia.Width = 200;
            // 
            // nam1
            // 
            this.nam1.Text = "Năm";
            this.nam1.Width = 140;
            // 
            // manxb
            // 
            this.manxb.Text = "Nhà Xuất Bản";
            this.manxb.Width = 259;
            // 
            // matl
            // 
            this.matl.Text = "Thể Loại";
            this.matl.Width = 180;
            // 
            // mota
            // 
            this.mota.Text = "Mô Tả";
            this.mota.Width = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "Hiển Thị Danh Sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_sach
            // 
            this.AcceptButton = this.btn_themsach;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_thoat;
            this.ClientSize = new System.Drawing.Size(1412, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsv_sach);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_sach";
            this.Text = "QUẢN LÝ THÔNG TIN SÁCH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_sach_FormClosing);
            this.Load += new System.EventHandler(this.Form_sach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox txt_nxb;
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
    }
}
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    partial class Form_hd
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
            lsv_hd = new ListView();
            mahd = new ColumnHeader();
            nlhd = new ColumnHeader();
            tt = new ColumnHeader();
            makh = new ColumnHeader();
            manv = new ColumnHeader();
            groupBox1 = new GroupBox();
            btn_luu = new Button();
            btn_huy = new Button();
            btn_thoat = new Button();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            groupBox2 = new GroupBox();
            btn_cthd = new Button();
            label7 = new Label();
            label1 = new Label();
            dt_nlhd = new DateTimePicker();
            cbo_nv = new ComboBox();
            cbo_kh = new ComboBox();
            txt_mhd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_tt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lsv_hd
            // 
            lsv_hd.Columns.AddRange(new ColumnHeader[] { mahd, nlhd, tt, makh, manv });
            lsv_hd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lsv_hd.FullRowSelect = true;
            lsv_hd.GridLines = true;
            lsv_hd.Location = new Point(24, 461);
            lsv_hd.Margin = new Padding(3, 4, 3, 4);
            lsv_hd.Name = "lsv_hd";
            lsv_hd.Size = new Size(1358, 302);
            lsv_hd.TabIndex = 27;
            lsv_hd.UseCompatibleStateImageBehavior = false;
            lsv_hd.View = View.Details;
            lsv_hd.SelectedIndexChanged += lsv_hd_SelectedIndexChanged;
            // 
            // mahd
            // 
            mahd.Text = "Mã Hóa Đơn";
            mahd.Width = 159;
            // 
            // nlhd
            // 
            nlhd.Text = "Ngày Lập Hóa Đơn";
            nlhd.Width = 320;
            // 
            // tt
            // 
            tt.Text = "Tổng Tiền";
            tt.Width = 320;
            // 
            // makh
            // 
            makh.Text = "Khách Hàng";
            makh.Width = 264;
            // 
            // manv
            // 
            manv.Text = "Nhân Viên";
            manv.Width = 290;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_luu);
            groupBox1.Controls.Add(btn_huy);
            groupBox1.Controls.Add(btn_thoat);
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Controls.Add(btn_xoa);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(826, 105);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(556, 284);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(43, 200);
            btn_luu.Margin = new Padding(4);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(139, 60);
            btn_luu.TabIndex = 20;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // btn_huy
            // 
            btn_huy.Location = new Point(207, 200);
            btn_huy.Margin = new Padding(4);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(139, 60);
            btn_huy.TabIndex = 21;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            btn_huy.Click += btn_huy_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.DialogResult = DialogResult.Cancel;
            btn_thoat.Location = new Point(369, 200);
            btn_thoat.Margin = new Padding(4);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(139, 60);
            btn_thoat.TabIndex = 22;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(43, 78);
            btn_them.Margin = new Padding(4);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(139, 60);
            btn_them.TabIndex = 15;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(207, 78);
            btn_sua.Margin = new Padding(4);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(139, 60);
            btn_sua.TabIndex = 17;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(369, 78);
            btn_xoa.Margin = new Padding(4);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(139, 60);
            btn_xoa.TabIndex = 18;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_cthd);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dt_nlhd);
            groupBox2.Controls.Add(cbo_nv);
            groupBox2.Controls.Add(cbo_kh);
            groupBox2.Controls.Add(txt_mhd);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_tt);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(24, 105);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(794, 284);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sách";
            // 
            // btn_cthd
            // 
            btn_cthd.Location = new Point(575, 200);
            btn_cthd.Name = "btn_cthd";
            btn_cthd.Size = new Size(39, 29);
            btn_cthd.TabIndex = 17;
            btn_cthd.Text = "...";
            btn_cthd.UseVisualStyleBackColor = true;
            btn_cthd.Click += btn_cthd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(413, 204);
            label7.Name = "label7";
            label7.Size = new Size(143, 18);
            label7.TabIndex = 16;
            label7.Text = "Chi Tiết Hóa Đơn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(562, 98);
            label1.Name = "label1";
            label1.Size = new Size(110, 18);
            label1.TabIndex = 15;
            label1.Text = "MM/DD/YYYY";
            // 
            // dt_nlhd
            // 
            dt_nlhd.Format = DateTimePickerFormat.Short;
            dt_nlhd.Location = new Point(556, 64);
            dt_nlhd.Margin = new Padding(3, 4, 3, 4);
            dt_nlhd.MaxDate = new DateTime(2023, 8, 6, 0, 0, 0, 0);
            dt_nlhd.Name = "dt_nlhd";
            dt_nlhd.Size = new Size(215, 24);
            dt_nlhd.TabIndex = 14;
            dt_nlhd.Value = new DateTime(2023, 8, 6, 0, 0, 0, 0);
            // 
            // cbo_nv
            // 
            cbo_nv.FormattingEnabled = true;
            cbo_nv.Location = new Point(149, 200);
            cbo_nv.Margin = new Padding(3, 4, 3, 4);
            cbo_nv.Name = "cbo_nv";
            cbo_nv.Size = new Size(215, 26);
            cbo_nv.TabIndex = 13;
            // 
            // cbo_kh
            // 
            cbo_kh.FormattingEnabled = true;
            cbo_kh.Location = new Point(556, 140);
            cbo_kh.Margin = new Padding(3, 4, 3, 4);
            cbo_kh.Name = "cbo_kh";
            cbo_kh.Size = new Size(215, 26);
            cbo_kh.TabIndex = 12;
            // 
            // txt_mhd
            // 
            txt_mhd.Location = new Point(149, 70);
            txt_mhd.Margin = new Padding(4);
            txt_mhd.MaxLength = 1000;
            txt_mhd.Name = "txt_mhd";
            txt_mhd.Size = new Size(215, 24);
            txt_mhd.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 18);
            label2.TabIndex = 1;
            label2.Text = "Mã Hóa Đơn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 66);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 2;
            label3.Text = "Ngày Lập:";
            // 
            // txt_tt
            // 
            txt_tt.Location = new Point(149, 135);
            txt_tt.Margin = new Padding(4);
            txt_tt.MaxLength = 250;
            txt_tt.Multiline = true;
            txt_tt.Name = "txt_tt";
            txt_tt.Size = new Size(215, 29);
            txt_tt.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 209);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 18);
            label5.TabIndex = 5;
            label5.Text = "Nhân Viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 140);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 3;
            label4.Text = "Tổng Tiền:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(411, 141);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 18);
            label6.TabIndex = 4;
            label6.Text = "Khách Hàng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(437, 29);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(487, 36);
            label8.TabIndex = 30;
            label8.Text = "QUẢN LÝ THÔNG TIN HÓA ĐƠN";
            // 
            // Form_hoadon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 779);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lsv_hd);
            Margin = new Padding(2);
            Name = "Form_hoadon";
            Text = "Hóa Đơn";
            FormClosing += HoaDon_FormClosing;
            Load += HoaDon_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lsv_hd;
        private ColumnHeader mahd;
        private ColumnHeader nlhd;
        private ColumnHeader tt;
        private ColumnHeader makh;
        private ColumnHeader manv;
        private GroupBox groupBox1;
        private Button btn_luu;
        private Button btn_huy;
        private Button btn_thoat;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private GroupBox groupBox2;
        private TextBox txt_mhd;
        private Label label2;
        private Label label3;
        private TextBox txt_tt;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label8;
        private ComboBox cbo_kh;
        private ComboBox cbo_nv;
        private DateTimePicker dt_nlhd;
        private Label label1;
        private Button btn_cthd;
        private Label label7;
    }
}
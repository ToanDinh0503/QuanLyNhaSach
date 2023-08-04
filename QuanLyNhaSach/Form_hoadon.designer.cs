using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    partial class Form_hoadon
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
            this.lsv_hd = new System.Windows.Forms.ListView();
            this.mahd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nlhd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.makh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dt_nlhd = new System.Windows.Forms.DateTimePicker();
            this.cbo_nv = new System.Windows.Forms.ComboBox();
            this.cbo_kh = new System.Windows.Forms.ComboBox();
            this.txt_mhd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsv_hd
            // 
            this.lsv_hd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mahd,
            this.nlhd,
            this.tt,
            this.makh,
            this.manv});
            this.lsv_hd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_hd.FullRowSelect = true;
            this.lsv_hd.GridLines = true;
            this.lsv_hd.HideSelection = false;
            this.lsv_hd.Location = new System.Drawing.Point(24, 369);
            this.lsv_hd.Name = "lsv_hd";
            this.lsv_hd.Size = new System.Drawing.Size(1358, 242);
            this.lsv_hd.TabIndex = 27;
            this.lsv_hd.UseCompatibleStateImageBehavior = false;
            this.lsv_hd.View = System.Windows.Forms.View.Details;
            this.lsv_hd.SelectedIndexChanged += new System.EventHandler(this.lsv_hd_SelectedIndexChanged);
            // 
            // mahd
            // 
            this.mahd.Text = "Mã Hóa Đơn";
            this.mahd.Width = 159;
            // 
            // nlhd
            // 
            this.nlhd.Text = "Ngày Lập Hóa Đơn";
            this.nlhd.Width = 320;
            // 
            // tt
            // 
            this.tt.Text = "Tổng Tiền";
            this.tt.Width = 320;
            // 
            // makh
            // 
            this.makh.Text = "Khách Hàng";
            this.makh.Width = 264;
            // 
            // manv
            // 
            this.manv.Text = "Nhân Viên";
            this.manv.Width = 290;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(826, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(556, 227);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(43, 160);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(139, 48);
            this.btn_luu.TabIndex = 20;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(207, 160);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(139, 48);
            this.btn_huy.TabIndex = 21;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
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
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(43, 62);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(139, 48);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(207, 62);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(139, 48);
            this.btn_sua.TabIndex = 17;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(369, 62);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(139, 48);
            this.btn_xoa.TabIndex = 18;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dt_nlhd);
            this.groupBox2.Controls.Add(this.cbo_nv);
            this.groupBox2.Controls.Add(this.cbo_kh);
            this.groupBox2.Controls.Add(this.txt_mhd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_tt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(794, 227);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // dt_nlhd
            // 
            this.dt_nlhd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_nlhd.Location = new System.Drawing.Point(556, 51);
            this.dt_nlhd.Name = "dt_nlhd";
            this.dt_nlhd.Size = new System.Drawing.Size(215, 24);
            this.dt_nlhd.TabIndex = 14;
            // 
            // cbo_nv
            // 
            this.cbo_nv.FormattingEnabled = true;
            this.cbo_nv.Location = new System.Drawing.Point(149, 160);
            this.cbo_nv.Name = "cbo_nv";
            this.cbo_nv.Size = new System.Drawing.Size(215, 26);
            this.cbo_nv.TabIndex = 13;
            // 
            // cbo_kh
            // 
            this.cbo_kh.FormattingEnabled = true;
            this.cbo_kh.Location = new System.Drawing.Point(556, 108);
            this.cbo_kh.Name = "cbo_kh";
            this.cbo_kh.Size = new System.Drawing.Size(215, 26);
            this.cbo_kh.TabIndex = 12;
            // 
            // txt_mhd
            // 
            this.txt_mhd.Location = new System.Drawing.Point(149, 56);
            this.txt_mhd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_mhd.MaxLength = 1000;
            this.txt_mhd.Name = "txt_mhd";
            this.txt_mhd.Size = new System.Drawing.Size(215, 24);
            this.txt_mhd.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Lập:";
            // 
            // txt_tt
            // 
            this.txt_tt.Location = new System.Drawing.Point(149, 108);
            this.txt_tt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tt.MaxLength = 250;
            this.txt_tt.Multiline = true;
            this.txt_tt.Name = "txt_tt";
            this.txt_tt.Size = new System.Drawing.Size(215, 24);
            this.txt_tt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhân Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng Tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Khách Hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(437, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(487, 36);
            this.label8.TabIndex = 30;
            this.label8.Text = "QUẢN LÝ THÔNG TIN HÓA ĐƠN";
            // 
            // Form_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 623);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsv_hd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_hoadon";
            this.Text = "Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HoaDon_FormClosing);
            this.Load += new System.EventHandler(this.HoaDon_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
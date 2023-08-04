using System.Text.RegularExpressions;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace QuanLyNhaSach
{
    partial class Form_khachhang
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
            this.txt_mkh = new System.Windows.Forms.TextBox();
            this.txt_tkh = new System.Windows.Forms.TextBox();
            this.txt_dchi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_themkhach = new System.Windows.Forms.Button();
            this.btn_suakhach = new System.Windows.Forms.Button();
            this.btn_xoakhach = new System.Windows.Forms.Button();
            this.btn_thoatkhach = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_LuuKhach = new System.Windows.Forms.Button();
            this.btn_LamMoiKhach = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_searchKhach = new System.Windows.Forms.Button();
            this.txt_searchKhach = new System.Windows.Forms.TextBox();
            this.lsv_khach = new System.Windows.Forms.ListView();
            this.makh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenkh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Điện Thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // txt_mkh
            // 
            this.txt_mkh.Location = new System.Drawing.Point(149, 50);
            this.txt_mkh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_mkh.MaxLength = 1000;
            this.txt_mkh.Name = "txt_mkh";
            this.txt_mkh.Size = new System.Drawing.Size(173, 24);
            this.txt_mkh.TabIndex = 8;
            this.txt_mkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mkh_KeyPress);
            // 
            // txt_tkh
            // 
            this.txt_tkh.Location = new System.Drawing.Point(556, 50);
            this.txt_tkh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tkh.MaxLength = 50;
            this.txt_tkh.Name = "txt_tkh";
            this.txt_tkh.Size = new System.Drawing.Size(182, 24);
            this.txt_tkh.TabIndex = 9;
            // 
            // txt_dchi
            // 
            this.txt_dchi.Location = new System.Drawing.Point(149, 106);
            this.txt_dchi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_dchi.MaxLength = 250;
            this.txt_dchi.Multiline = true;
            this.txt_dchi.Name = "txt_dchi";
            this.txt_dchi.Size = new System.Drawing.Size(233, 24);
            this.txt_dchi.TabIndex = 10;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(556, 103);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_sdt.MaxLength = 11;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(182, 24);
            this.txt_sdt.TabIndex = 11;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(150, 161);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_email.MaxLength = 50;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(232, 24);
            this.txt_email.TabIndex = 12;
            // 
            // btn_themkhach
            // 
            this.btn_themkhach.Location = new System.Drawing.Point(43, 62);
            this.btn_themkhach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_themkhach.Name = "btn_themkhach";
            this.btn_themkhach.Size = new System.Drawing.Size(139, 48);
            this.btn_themkhach.TabIndex = 15;
            this.btn_themkhach.Text = "Thêm";
            this.btn_themkhach.UseVisualStyleBackColor = true;
            this.btn_themkhach.Click += new System.EventHandler(this.btn_themkhach_Click);
            // 
            // btn_suakhach
            // 
            this.btn_suakhach.Location = new System.Drawing.Point(207, 62);
            this.btn_suakhach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_suakhach.Name = "btn_suakhach";
            this.btn_suakhach.Size = new System.Drawing.Size(139, 48);
            this.btn_suakhach.TabIndex = 17;
            this.btn_suakhach.Text = "Sửa";
            this.btn_suakhach.UseVisualStyleBackColor = true;
            this.btn_suakhach.Click += new System.EventHandler(this.btn_suakhach_Click);
            // 
            // btn_xoakhach
            // 
            this.btn_xoakhach.Location = new System.Drawing.Point(369, 62);
            this.btn_xoakhach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_xoakhach.Name = "btn_xoakhach";
            this.btn_xoakhach.Size = new System.Drawing.Size(139, 48);
            this.btn_xoakhach.TabIndex = 18;
            this.btn_xoakhach.Text = "Xóa";
            this.btn_xoakhach.UseVisualStyleBackColor = true;
            this.btn_xoakhach.Click += new System.EventHandler(this.btn_xoakhach_Click);
            // 
            // btn_thoatkhach
            // 
            this.btn_thoatkhach.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoatkhach.Location = new System.Drawing.Point(369, 160);
            this.btn_thoatkhach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_thoatkhach.Name = "btn_thoatkhach";
            this.btn_thoatkhach.Size = new System.Drawing.Size(139, 48);
            this.btn_thoatkhach.TabIndex = 22;
            this.btn_thoatkhach.Text = "Thoát";
            this.btn_thoatkhach.UseVisualStyleBackColor = true;
            this.btn_thoatkhach.Click += new System.EventHandler(this.btn_thoatkhach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_LuuKhach);
            this.groupBox1.Controls.Add(this.btn_LamMoiKhach);
            this.groupBox1.Controls.Add(this.btn_thoatkhach);
            this.groupBox1.Controls.Add(this.btn_themkhach);
            this.groupBox1.Controls.Add(this.btn_suakhach);
            this.groupBox1.Controls.Add(this.btn_xoakhach);
            this.groupBox1.Location = new System.Drawing.Point(825, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(556, 227);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_LuuKhach
            // 
            this.btn_LuuKhach.Location = new System.Drawing.Point(43, 160);
            this.btn_LuuKhach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_LuuKhach.Name = "btn_LuuKhach";
            this.btn_LuuKhach.Size = new System.Drawing.Size(139, 48);
            this.btn_LuuKhach.TabIndex = 20;
            this.btn_LuuKhach.Text = "Lưu";
            this.btn_LuuKhach.UseVisualStyleBackColor = true;
            this.btn_LuuKhach.Click += new System.EventHandler(this.btn_LuuKhach_Click);
            // 
            // btn_LamMoiKhach
            // 
            this.btn_LamMoiKhach.Location = new System.Drawing.Point(207, 160);
            this.btn_LamMoiKhach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_LamMoiKhach.Name = "btn_LamMoiKhach";
            this.btn_LamMoiKhach.Size = new System.Drawing.Size(139, 48);
            this.btn_LamMoiKhach.TabIndex = 21;
            this.btn_LamMoiKhach.Text = "Hủy";
            this.btn_LamMoiKhach.UseVisualStyleBackColor = true;
            this.btn_LamMoiKhach.Click += new System.EventHandler(this.btn_LamMoiKhach_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_mkh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_tkh);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.txt_dchi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(23, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(755, 227);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(455, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(552, 36);
            this.label8.TabIndex = 23;
            this.label8.Text = "QUẢN LÝ THÔNG TIN KHÁCH HÀNG";
            // 
            // btn_searchKhach
            // 
            this.btn_searchKhach.Location = new System.Drawing.Point(23, 330);
            this.btn_searchKhach.Name = "btn_searchKhach";
            this.btn_searchKhach.Size = new System.Drawing.Size(72, 28);
            this.btn_searchKhach.TabIndex = 25;
            this.btn_searchKhach.Text = "Lọc";
            this.btn_searchKhach.UseVisualStyleBackColor = true;
            this.btn_searchKhach.Click += new System.EventHandler(this.btn_searchKhach_Click);
            // 
            // txt_searchKhach
            // 
            this.txt_searchKhach.Location = new System.Drawing.Point(102, 334);
            this.txt_searchKhach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_searchKhach.Name = "txt_searchKhach";
            this.txt_searchKhach.Size = new System.Drawing.Size(233, 24);
            this.txt_searchKhach.TabIndex = 15;
            // 
            // lsv_khach
            // 
            this.lsv_khach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.makh,
            this.tenkh,
            this.diachi,
            this.sdt,
            this.email});
            this.lsv_khach.FullRowSelect = true;
            this.lsv_khach.GridLines = true;
            this.lsv_khach.HideSelection = false;
            this.lsv_khach.Location = new System.Drawing.Point(23, 373);
            this.lsv_khach.Name = "lsv_khach";
            this.lsv_khach.Size = new System.Drawing.Size(1358, 218);
            this.lsv_khach.TabIndex = 26;
            this.lsv_khach.UseCompatibleStateImageBehavior = false;
            this.lsv_khach.View = System.Windows.Forms.View.Details;
            this.lsv_khach.SelectedIndexChanged += new System.EventHandler(this.lsv_khach_SelectedIndexChanged);
            // 
            // makh
            // 
            this.makh.Text = "Mã Khách Hàng";
            this.makh.Width = 200;
            // 
            // tenkh
            // 
            this.tenkh.Text = "Tên Khách Hàng";
            this.tenkh.Width = 320;
            // 
            // diachi
            // 
            this.diachi.Text = "Địa Chỉ";
            this.diachi.Width = 320;
            // 
            // sdt
            // 
            this.sdt.Text = "Số Điện Thoại";
            this.sdt.Width = 250;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 250;
            // 
            // Form_khachhang
            // 
            this.AcceptButton = this.btn_themkhach;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_thoatkhach;
            this.ClientSize = new System.Drawing.Size(1412, 603);
            this.Controls.Add(this.lsv_khach);
            this.Controls.Add(this.btn_searchKhach);
            this.Controls.Add(this.txt_searchKhach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_khachhang";
            this.Text = "QUẢN LÝ THÔNG TIN KHÁCH HÀNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_KhachHang_FormClosing);
            this.Load += new System.EventHandler(this.Form_khachhang_Load);
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
        private TextBox txt_mkh;
        private TextBox txt_tkh;
        private TextBox txt_dchi;
        private TextBox txt_sdt;
        private TextBox txt_email;
        private Button btn_themkhach;
        private Button btn_suakhach;
        private Button btn_xoakhach;
        private Button btn_thoatkhach;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private Button btn_searchKhach;
        private TextBox txt_searchKhach;
        private Button btn_LamMoiKhach;
        private Button btn_LuuKhach;
        private ListView lsv_khach;
        private ColumnHeader makh;
        private ColumnHeader tenkh;
        private ColumnHeader diachi;
        private ColumnHeader sdt;
        private ColumnHeader email;
    }
}
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_mkh = new TextBox();
            txt_tkh = new TextBox();
            txt_dchi = new TextBox();
            txt_sdt = new TextBox();
            txt_email = new TextBox();
            btn_themkhach = new Button();
            btn_suakhach = new Button();
            btn_xoakhach = new Button();
            btn_thoatkhach = new Button();
            btn_LuuKhach = new Button();
            btn_LamMoiKhach = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            btn_searchKhach = new Button();
            txt_searchKhach = new TextBox();
            lsv_khach = new ListView();
            makh = new ColumnHeader();
            tenkh = new ColumnHeader();
            diachi = new ColumnHeader();
            sdt = new ColumnHeader();
            email = new ColumnHeader();
            btn_htds = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(433, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 18);
            label1.TabIndex = 1;
            label1.Text = "Mã Khách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 2;
            label2.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 112);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 3;
            label3.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 109);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 18);
            label4.TabIndex = 4;
            label4.Text = "Số Điện Thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 166);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 18);
            label5.TabIndex = 5;
            label5.Text = "Email:";
            // 
            // txt_mkh
            // 
            txt_mkh.Location = new Point(556, 49);
            txt_mkh.Margin = new Padding(4, 3, 4, 3);
            txt_mkh.MaxLength = 1000;
            txt_mkh.Name = "txt_mkh";
            txt_mkh.Size = new Size(173, 24);
            txt_mkh.TabIndex = 8;
            txt_mkh.TabStop = false;
            txt_mkh.KeyPress += txt_mkh_KeyPress;
            // 
            // txt_tkh
            // 
            txt_tkh.Location = new Point(102, 58);
            txt_tkh.Margin = new Padding(4, 3, 4, 3);
            txt_tkh.MaxLength = 35;
            txt_tkh.Name = "txt_tkh";
            txt_tkh.Size = new Size(218, 24);
            txt_tkh.TabIndex = 1;
            // 
            // txt_dchi
            // 
            txt_dchi.Location = new Point(102, 109);
            txt_dchi.Margin = new Padding(4, 3, 4, 3);
            txt_dchi.MaxLength = 50;
            txt_dchi.Multiline = true;
            txt_dchi.Name = "txt_dchi";
            txt_dchi.Size = new Size(218, 24);
            txt_dchi.TabIndex = 2;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(556, 103);
            txt_sdt.Margin = new Padding(4, 3, 4, 3);
            txt_sdt.MaxLength = 11;
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(218, 24);
            txt_sdt.TabIndex = 3;
            txt_sdt.KeyPress += txt_sdt_KeyPress;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(102, 163);
            txt_email.Margin = new Padding(4, 3, 4, 3);
            txt_email.MaxLength = 35;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(218, 24);
            txt_email.TabIndex = 4;
            // 
            // btn_themkhach
            // 
            btn_themkhach.Location = new Point(882, 130);
            btn_themkhach.Margin = new Padding(4, 3, 4, 3);
            btn_themkhach.Name = "btn_themkhach";
            btn_themkhach.Size = new Size(139, 48);
            btn_themkhach.TabIndex = 5;
            btn_themkhach.Text = "Thêm";
            btn_themkhach.UseVisualStyleBackColor = true;
            btn_themkhach.Click += btn_themkhach_Click;
            // 
            // btn_suakhach
            // 
            btn_suakhach.Location = new Point(1046, 130);
            btn_suakhach.Margin = new Padding(4, 3, 4, 3);
            btn_suakhach.Name = "btn_suakhach";
            btn_suakhach.Size = new Size(139, 48);
            btn_suakhach.TabIndex = 8;
            btn_suakhach.Text = "Sửa";
            btn_suakhach.UseVisualStyleBackColor = true;
            btn_suakhach.Click += btn_suakhach_Click;
            // 
            // btn_xoakhach
            // 
            btn_xoakhach.Location = new Point(1208, 130);
            btn_xoakhach.Margin = new Padding(4, 3, 4, 3);
            btn_xoakhach.Name = "btn_xoakhach";
            btn_xoakhach.Size = new Size(139, 48);
            btn_xoakhach.TabIndex = 9;
            btn_xoakhach.Text = "Xóa";
            btn_xoakhach.UseVisualStyleBackColor = true;
            btn_xoakhach.Click += btn_xoakhach_Click;
            // 
            // btn_thoatkhach
            // 
            btn_thoatkhach.DialogResult = DialogResult.Cancel;
            btn_thoatkhach.Location = new Point(1208, 228);
            btn_thoatkhach.Margin = new Padding(4, 3, 4, 3);
            btn_thoatkhach.Name = "btn_thoatkhach";
            btn_thoatkhach.Size = new Size(139, 48);
            btn_thoatkhach.TabIndex = 13;
            btn_thoatkhach.Text = "Thoát";
            btn_thoatkhach.UseVisualStyleBackColor = true;
            btn_thoatkhach.Click += btn_thoatkhach_Click;
            // 
            // btn_LuuKhach
            // 
            btn_LuuKhach.Location = new Point(882, 228);
            btn_LuuKhach.Margin = new Padding(4, 3, 4, 3);
            btn_LuuKhach.Name = "btn_LuuKhach";
            btn_LuuKhach.Size = new Size(139, 48);
            btn_LuuKhach.TabIndex = 5;
            btn_LuuKhach.Text = "Lưu";
            btn_LuuKhach.UseVisualStyleBackColor = true;
            btn_LuuKhach.Click += btn_LuuKhach_Click;
            // 
            // btn_LamMoiKhach
            // 
            btn_LamMoiKhach.Location = new Point(1046, 228);
            btn_LamMoiKhach.Margin = new Padding(4, 3, 4, 3);
            btn_LamMoiKhach.Name = "btn_LamMoiKhach";
            btn_LamMoiKhach.Size = new Size(139, 48);
            btn_LamMoiKhach.TabIndex = 6;
            btn_LamMoiKhach.Text = "Hủy";
            btn_LamMoiKhach.UseVisualStyleBackColor = true;
            btn_LamMoiKhach.Click += btn_LamMoiKhach_Click;
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
            groupBox2.Location = new Point(23, 92);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(794, 227);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(455, 33);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(552, 36);
            label8.TabIndex = 23;
            label8.Text = "QUẢN LÝ THÔNG TIN KHÁCH HÀNG";
            // 
            // btn_searchKhach
            // 
            btn_searchKhach.Location = new Point(23, 330);
            btn_searchKhach.Name = "btn_searchKhach";
            btn_searchKhach.Size = new Size(72, 28);
            btn_searchKhach.TabIndex = 11;
            btn_searchKhach.Text = "Lọc";
            btn_searchKhach.UseVisualStyleBackColor = true;
            btn_searchKhach.Click += btn_searchKhach_Click;
            // 
            // txt_searchKhach
            // 
            txt_searchKhach.Location = new Point(102, 334);
            txt_searchKhach.Margin = new Padding(4, 3, 4, 3);
            txt_searchKhach.MaxLength = 35;
            txt_searchKhach.Name = "txt_searchKhach";
            txt_searchKhach.Size = new Size(233, 24);
            txt_searchKhach.TabIndex = 10;
            // 
            // lsv_khach
            // 
            lsv_khach.Columns.AddRange(new ColumnHeader[] { makh, tenkh, diachi, sdt, email });
            lsv_khach.FullRowSelect = true;
            lsv_khach.GridLines = true;
            lsv_khach.Location = new Point(23, 373);
            lsv_khach.Name = "lsv_khach";
            lsv_khach.Size = new Size(1358, 218);
            lsv_khach.TabIndex = 7;
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
            sdt.Width = 250;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 250;
            // 
            // btn_htds
            // 
            btn_htds.Location = new Point(363, 330);
            btn_htds.Name = "btn_htds";
            btn_htds.Size = new Size(178, 34);
            btn_htds.TabIndex = 12;
            btn_htds.Text = "Hiển Thị Danh Sách";
            btn_htds.UseVisualStyleBackColor = true;
            btn_htds.Click += btn_htds_Click;
            // 
            // Form_khachhang
            // 
            AcceptButton = btn_themkhach;
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_thoatkhach;
            ClientSize = new Size(1412, 603);
            Controls.Add(btn_LuuKhach);
            Controls.Add(btn_suakhach);
            Controls.Add(btn_xoakhach);
            Controls.Add(btn_htds);
            Controls.Add(btn_LamMoiKhach);
            Controls.Add(lsv_khach);
            Controls.Add(btn_themkhach);
            Controls.Add(btn_searchKhach);
            Controls.Add(btn_thoatkhach);
            Controls.Add(txt_searchKhach);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form_khachhang";
            Text = "QUẢN LÝ THÔNG TIN KHÁCH HÀNG";
            FormClosing += Form_KhachHang_FormClosing;
            Load += Form_khachhang_Load;
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
        private TextBox txt_mkh;
        private TextBox txt_tkh;
        private TextBox txt_dchi;
        private TextBox txt_sdt;
        private TextBox txt_email;
        private Button btn_themkhach;
        private Button btn_suakhach;
        private Button btn_xoakhach;
        private Button btn_thoatkhach;
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
        private Button btn_htds;
    }
}
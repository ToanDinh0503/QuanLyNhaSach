﻿namespace QuanLyNhaSach
{
    partial class Form_Menu_temp
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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            mnt_hethong = new ToolStripMenuItem();
            mntt_sach = new ToolStripMenuItem();
            mntt_nv = new ToolStripMenuItem();
            mntt_kh = new ToolStripMenuItem();
            mntt_tl = new ToolStripMenuItem();
            mntt_nxb = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            mntt_dx = new ToolStripMenuItem();
            mnt_dm = new ToolStripMenuItem();
            mntt_loaisach = new ToolStripMenuItem();
            mntt_dms = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            mntt_dmkh = new ToolStripMenuItem();
            mntt_dmnxb = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem1 = new ToolStripMenuItem();
            nghiệpVụToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            mntt_tk = new ToolStripMenuItem();
            tToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(164, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1219, 57);
            panel1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Lavender;
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnt_hethong, mnt_dm, nghiệpVụToolStripMenuItem, tToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.Size = new Size(1219, 57);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mnt_hethong
            // 
            mnt_hethong.BackColor = Color.Lavender;
            mnt_hethong.DropDownItems.AddRange(new ToolStripItem[] { mntt_sach, mntt_nv, mntt_kh, mntt_tl, mntt_nxb, đổiMậtKhẩuToolStripMenuItem, mntt_dx });
            mnt_hethong.Name = "mnt_hethong";
            mnt_hethong.Padding = new Padding(30, 30, 30, 0);
            mnt_hethong.Size = new Size(152, 57);
            mnt_hethong.Text = "Hệ Thống";
            // 
            // mntt_sach
            // 
            mntt_sach.BackColor = Color.Bisque;
            mntt_sach.Name = "mntt_sach";
            mntt_sach.Size = new Size(273, 28);
            mntt_sach.Text = "Quản Lý Sách";
            mntt_sach.Click += mntt_sach_Click;
            // 
            // mntt_nv
            // 
            mntt_nv.BackColor = Color.Bisque;
            mntt_nv.Name = "mntt_nv";
            mntt_nv.Size = new Size(273, 28);
            mntt_nv.Text = "Quản Lý Nhân Viên";
            mntt_nv.Click += mntt_nv_Click;
            // 
            // mntt_kh
            // 
            mntt_kh.BackColor = Color.Bisque;
            mntt_kh.Name = "mntt_kh";
            mntt_kh.Size = new Size(273, 28);
            mntt_kh.Text = "Quản Lý Khách Hàng";
            mntt_kh.Click += mntt_kh_Click;
            // 
            // mntt_tl
            // 
            mntt_tl.BackColor = Color.Bisque;
            mntt_tl.Name = "mntt_tl";
            mntt_tl.Size = new Size(273, 28);
            mntt_tl.Text = "Quản Lý Thể Loại ";
            mntt_tl.Click += mntt_tl_Click;
            // 
            // mntt_nxb
            // 
            mntt_nxb.BackColor = Color.Bisque;
            mntt_nxb.Name = "mntt_nxb";
            mntt_nxb.Size = new Size(273, 28);
            mntt_nxb.Text = "Quản Lý Nhà Xuất Bản";
            mntt_nxb.Click += mntt_nxb_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.BackColor = Color.Bisque;
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(273, 28);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            // 
            // mntt_dx
            // 
            mntt_dx.BackColor = Color.Bisque;
            mntt_dx.Name = "mntt_dx";
            mntt_dx.Size = new Size(273, 28);
            mntt_dx.Text = "Đăng Xuất";
            mntt_dx.Click += mntt_dx_Click;
            // 
            // mnt_dm
            // 
            mnt_dm.DropDownItems.AddRange(new ToolStripItem[] { mntt_loaisach, mntt_dms, nhânViênToolStripMenuItem, mntt_dmkh, mntt_dmnxb, hóaĐơnToolStripMenuItem1 });
            mnt_dm.Name = "mnt_dm";
            mnt_dm.Padding = new Padding(30, 30, 30, 0);
            mnt_dm.Size = new Size(155, 57);
            mnt_dm.Text = "Danh Mục";
            // 
            // mntt_loaisach
            // 
            mntt_loaisach.BackColor = Color.Bisque;
            mntt_loaisach.Name = "mntt_loaisach";
            mntt_loaisach.Size = new Size(224, 28);
            mntt_loaisach.Text = "Loại Sách";
            mntt_loaisach.Click += mntt_loaisach_Click;
            // 
            // mntt_dms
            // 
            mntt_dms.BackColor = Color.Bisque;
            mntt_dms.Name = "mntt_dms";
            mntt_dms.Size = new Size(224, 28);
            mntt_dms.Text = "Sách";
            mntt_dms.Click += mntt_dms_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.BackColor = Color.Bisque;
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(224, 28);
            nhânViênToolStripMenuItem.Text = "Nhân Viên";
            // 
            // mntt_dmkh
            // 
            mntt_dmkh.BackColor = Color.Bisque;
            mntt_dmkh.Name = "mntt_dmkh";
            mntt_dmkh.Size = new Size(224, 28);
            mntt_dmkh.Text = "Khách Hàng";
            mntt_dmkh.Click += mntt_dmkh_Click;
            // 
            // mntt_dmnxb
            // 
            mntt_dmnxb.BackColor = Color.Bisque;
            mntt_dmnxb.Name = "mntt_dmnxb";
            mntt_dmnxb.Size = new Size(224, 28);
            mntt_dmnxb.Text = "Nhà Xuất Bản";
            mntt_dmnxb.Click += mntt_dmnxb_Click;
            // 
            // hóaĐơnToolStripMenuItem1
            // 
            hóaĐơnToolStripMenuItem1.BackColor = Color.Bisque;
            hóaĐơnToolStripMenuItem1.Name = "hóaĐơnToolStripMenuItem1";
            hóaĐơnToolStripMenuItem1.Size = new Size(224, 28);
            hóaĐơnToolStripMenuItem1.Text = "Hóa Đơn";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hóaĐơnToolStripMenuItem, mntt_tk });
            nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            nghiệpVụToolStripMenuItem.Padding = new Padding(30, 30, 30, 0);
            nghiệpVụToolStripMenuItem.Size = new Size(159, 57);
            nghiệpVụToolStripMenuItem.Text = "Nghiệp Vụ";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.BackColor = Color.Bisque;
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(235, 28);
            hóaĐơnToolStripMenuItem.Text = "Quản Lý Hóa Đơn";
            // 
            // mntt_tk
            // 
            mntt_tk.BackColor = Color.Bisque;
            mntt_tk.Name = "mntt_tk";
            mntt_tk.Size = new Size(235, 28);
            mntt_tk.Text = "Thống Kê";
            mntt_tk.Click += mntt_tk_Click;
            // 
            // tToolStripMenuItem
            // 
            tToolStripMenuItem.Name = "tToolStripMenuItem";
            tToolStripMenuItem.Padding = new Padding(30, 30, 30, 0);
            tToolStripMenuItem.Size = new Size(144, 57);
            tToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled1;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aquamarine;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(165, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(1217, 103);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(259, 35);
            label1.Name = "label1";
            label1.Size = new Size(580, 38);
            label1.TabIndex = 0;
            label1.Text = "CHÀO MỪNG ĐẾN VỚI NHÀ SÁCH 4STARS";
            // 
            // Form_Menu_temp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1382, 703);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form_Menu_temp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU";
            FormClosing += Form_Menu_temp_FormClosing;
            Load += Form_Menu_Load;
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnt_hethong;
        private ToolStripMenuItem mntt_sach;
        private ToolStripMenuItem mntt_nv;
        private ToolStripMenuItem mntt_kh;
        private ToolStripMenuItem mntt_tl;
        private PictureBox pictureBox1;
        private Panel panel2;
        private ToolStripMenuItem mntt_nxb;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem mntt_dx;
        private ToolStripMenuItem mnt_dm;
        private ToolStripMenuItem mntt_loaisach;
        private ToolStripMenuItem mntt_dms;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem mntt_dmkh;
        private ToolStripMenuItem mntt_dmnxb;
        private ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem mntt_tk;
        private Label label1;
        private ToolStripMenuItem tToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem1;
    }
}
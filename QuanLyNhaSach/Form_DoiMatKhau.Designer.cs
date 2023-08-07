namespace QuanLyNhaSach
{
    partial class Form_DoiMatKhau
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
            panel1 = new Panel();
            txt_htmk = new CheckBox();
            btn_thoat = new Button();
            btn_xacnhan = new Button();
            txt_mkm = new TextBox();
            txt_nlmk = new TextBox();
            txt_mkc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(233, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(219, 37);
            label1.TabIndex = 1;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_htmk);
            panel1.Controls.Add(btn_thoat);
            panel1.Controls.Add(btn_xacnhan);
            panel1.Controls.Add(txt_mkm);
            panel1.Controls.Add(txt_nlmk);
            panel1.Controls.Add(txt_mkc);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(10, 66);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 404);
            panel1.TabIndex = 2;
            // 
            // txt_htmk
            // 
            txt_htmk.AutoSize = true;
            txt_htmk.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txt_htmk.Location = new Point(270, 276);
            txt_htmk.Margin = new Padding(2, 2, 2, 2);
            txt_htmk.Name = "txt_htmk";
            txt_htmk.Size = new Size(181, 27);
            txt_htmk.TabIndex = 21;
            txt_htmk.Text = "Hiển Thị Mật Khẩu";
            txt_htmk.UseVisualStyleBackColor = true;
            txt_htmk.CheckedChanged += txt_htmk_CheckedChanged;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_thoat.Location = new Point(419, 321);
            btn_thoat.Margin = new Padding(2, 2, 2, 2);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(140, 65);
            btn_thoat.TabIndex = 20;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_xacnhan
            // 
            btn_xacnhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xacnhan.Location = new Point(62, 321);
            btn_xacnhan.Margin = new Padding(2, 2, 2, 2);
            btn_xacnhan.Name = "btn_xacnhan";
            btn_xacnhan.Size = new Size(139, 65);
            btn_xacnhan.TabIndex = 18;
            btn_xacnhan.Text = "Xác Nhận";
            btn_xacnhan.UseVisualStyleBackColor = true;
            // 
            // txt_mkm
            // 
            txt_mkm.Location = new Point(270, 146);
            txt_mkm.Margin = new Padding(2, 2, 2, 2);
            txt_mkm.Name = "txt_mkm";
            txt_mkm.PasswordChar = '*';
            txt_mkm.Size = new Size(357, 27);
            txt_mkm.TabIndex = 17;
            // 
            // txt_nlmk
            // 
            txt_nlmk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_nlmk.Location = new Point(270, 246);
            txt_nlmk.Margin = new Padding(2, 2, 2, 2);
            txt_nlmk.Name = "txt_nlmk";
            txt_nlmk.PasswordChar = '*';
            txt_nlmk.Size = new Size(357, 27);
            txt_nlmk.TabIndex = 16;
            // 
            // txt_mkc
            // 
            txt_mkc.Location = new Point(270, 41);
            txt_mkc.Margin = new Padding(2, 2, 2, 2);
            txt_mkc.Name = "txt_mkc";
            txt_mkc.PasswordChar = '*';
            txt_mkc.Size = new Size(357, 27);
            txt_mkc.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(34, 240);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(238, 32);
            label5.TabIndex = 13;
            label5.Text = "Nhập Lại Mật Khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 140);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(183, 32);
            label4.TabIndex = 12;
            label4.Text = "Mật Khẩu Mới:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 34);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 32);
            label3.TabIndex = 11;
            label3.Text = "Mật Khẩu Cũ:";
            // 
            // Form_DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 480);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form_DoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐỔi MẬT KHẨU";
            FormClosing += Form_DoiMatKhau_FormClosing;
            Load += Form_DoiMatKhau_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Button btn_thoat;
        private Button btn_xacnhan;
        private TextBox txt_mkm;
        private TextBox txt_nlmk;
        private TextBox txt_mkc;
        private Label label5;
        private Label label4;
        private Label label3;
        private CheckBox txt_htmk;
    }
}
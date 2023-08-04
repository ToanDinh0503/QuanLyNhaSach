namespace QuanLyNhaSach
{
    partial class Form_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangNhap));
            panel1 = new Panel();
            btn_thoat = new Button();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            txb_matkhau = new TextBox();
            btn_Login = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            txb_taikhoan = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_thoat);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(17, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 361);
            panel1.TabIndex = 0;
            // 
            // btn_thoat
            // 
            btn_thoat.Image = (Image)resources.GetObject("btn_thoat.Image");
            btn_thoat.ImageAlign = ContentAlignment.MiddleLeft;
            btn_thoat.Location = new Point(225, 274);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(172, 64);
            btn_thoat.TabIndex = 5;
            btn_thoat.Text = "         Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Location = new Point(26, 149);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 119);
            panel3.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(txb_matkhau);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(16, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 113);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mật khẩu:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(0, 78);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 21);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txb_matkhau
            // 
            txb_matkhau.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txb_matkhau.Location = new Point(16, 37);
            txb_matkhau.Name = "txb_matkhau";
            txb_matkhau.Size = new Size(307, 38);
            txb_matkhau.TabIndex = 2;
            txb_matkhau.UseSystemPasswordChar = true;
            txb_matkhau.KeyDown += txb_matkhau_KeyDown;
            // 
            // btn_Login
            // 
            btn_Login.Image = (Image)resources.GetObject("btn_Login.Image");
            btn_Login.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Login.Location = new Point(26, 274);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(172, 64);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "         Đăng nhập";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(26, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(371, 107);
            panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txb_taikhoan);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(16, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 101);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài khoản:";
            // 
            // txb_taikhoan
            // 
            txb_taikhoan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txb_taikhoan.Location = new Point(16, 37);
            txb_taikhoan.Name = "txb_taikhoan";
            txb_taikhoan.Size = new Size(307, 38);
            txb_taikhoan.TabIndex = 1;
            txb_taikhoan.KeyDown += txb_taikhoan_KeyDown;
            // 
            // Form_DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(451, 406);
            Controls.Add(panel1);
            Name = "Form_DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += DangNhap_FormClosing;
            Load += Form_DangNhap_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txb_taikhoan;
        private Button btn_Login;
        private GroupBox groupBox1;
        private Panel panel3;
        private GroupBox groupBox2;
        private TextBox txb_matkhau;
        private Button btn_thoat;
        private CheckBox checkBox1;
    }
}
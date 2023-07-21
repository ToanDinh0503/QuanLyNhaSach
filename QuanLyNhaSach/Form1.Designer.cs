namespace QuanLyNhaSach
{
    partial class DangNhap
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            txb_PassWord = new TextBox();
            lb_PasssWord = new Label();
            panel2 = new Panel();
            txb_UserName = new TextBox();
            lb_UserName = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(17, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 361);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(786, 265);
            button2.Name = "button2";
            button2.Size = new Size(113, 48);
            button2.TabIndex = 3;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(654, 265);
            button1.Name = "button1";
            button1.Size = new Size(113, 48);
            button1.TabIndex = 2;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(txb_PassWord);
            panel3.Controls.Add(lb_PasssWord);
            panel3.Location = new Point(17, 130);
            panel3.Name = "panel3";
            panel3.Size = new Size(907, 107);
            panel3.TabIndex = 1;
            // 
            // txb_PassWord
            // 
            txb_PassWord.Location = new Point(245, 20);
            txb_PassWord.Name = "txb_PassWord";
            txb_PassWord.Size = new Size(637, 27);
            txb_PassWord.TabIndex = 1;
            txb_PassWord.UseSystemPasswordChar = true;
            // 
            // lb_PasssWord
            // 
            lb_PasssWord.AutoSize = true;
            lb_PasssWord.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_PasssWord.Location = new Point(84, 11);
            lb_PasssWord.Name = "lb_PasssWord";
            lb_PasssWord.Size = new Size(155, 35);
            lb_PasssWord.TabIndex = 0;
            lb_PasssWord.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txb_UserName);
            panel2.Controls.Add(lb_UserName);
            panel2.Location = new Point(17, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 107);
            panel2.TabIndex = 0;
            // 
            // txb_UserName
            // 
            txb_UserName.Location = new Point(245, 20);
            txb_UserName.Name = "txb_UserName";
            txb_UserName.Size = new Size(637, 27);
            txb_UserName.TabIndex = 1;
            txb_UserName.TextChanged += textBox1_TextChanged;
            // 
            // lb_UserName
            // 
            lb_UserName.AutoSize = true;
            lb_UserName.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_UserName.Location = new Point(3, 12);
            lb_UserName.Name = "lb_UserName";
            lb_UserName.Size = new Size(236, 35);
            lb_UserName.TabIndex = 0;
            lb_UserName.Text = "Tên đăng nhập:";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(975, 406);
            Controls.Add(panel1);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txb_UserName;
        private Label lb_UserName;
        private Panel panel3;
        private TextBox txb_PassWord;
        private Label lb_PasssWord;
        private Button button1;
        private Button button2;
    }
}
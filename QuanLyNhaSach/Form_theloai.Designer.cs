namespace QuanLyNhaSach
{
    partial class Form_theloai
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
            groupBox1 = new GroupBox();
            txt_ttl = new TextBox();
            txt_mtl = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btn_luu = new Button();
            btn_themtl = new Button();
            btn_huy = new Button();
            btn_suatl = new Button();
            btn_thoat = new Button();
            btn_xoatl = new Button();
            groupBox3 = new GroupBox();
            lsv_tl = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            txt_search = new TextBox();
            btn_search = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(347, 46);
            label1.Name = "label1";
            label1.Size = new Size(313, 29);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÍ THỂ LOẠI SÁCH";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_ttl);
            groupBox1.Controls.Add(txt_mtl);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 138);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(436, 211);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Thể Loại";
            // 
            // txt_ttl
            // 
            txt_ttl.Location = new Point(138, 121);
            txt_ttl.Margin = new Padding(3, 4, 3, 4);
            txt_ttl.MaxLength = 35;
            txt_ttl.Name = "txt_ttl";
            txt_ttl.Size = new Size(266, 24);
            txt_ttl.TabIndex = 3;
            // 
            // txt_mtl
            // 
            txt_mtl.Location = new Point(138, 48);
            txt_mtl.Margin = new Padding(3, 4, 3, 4);
            txt_mtl.Name = "txt_mtl";
            txt_mtl.Size = new Size(266, 24);
            txt_mtl.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 129);
            label3.Name = "label3";
            label3.Size = new Size(103, 16);
            label3.TabIndex = 1;
            label3.Text = "Tên Thể Loại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 54);
            label2.Name = "label2";
            label2.Size = new Size(97, 16);
            label2.TabIndex = 0;
            label2.Text = "Mã Thể Loại:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_luu);
            groupBox2.Controls.Add(btn_themtl);
            groupBox2.Controls.Add(btn_huy);
            groupBox2.Controls.Add(btn_suatl);
            groupBox2.Controls.Add(btn_thoat);
            groupBox2.Controls.Add(btn_xoatl);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(454, 138);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(526, 211);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_luu
            // 
            btn_luu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_luu.Location = new Point(42, 134);
            btn_luu.Margin = new Padding(4);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(116, 60);
            btn_luu.TabIndex = 32;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // btn_themtl
            // 
            btn_themtl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_themtl.Location = new Point(42, 54);
            btn_themtl.Margin = new Padding(4);
            btn_themtl.Name = "btn_themtl";
            btn_themtl.Size = new Size(116, 60);
            btn_themtl.TabIndex = 31;
            btn_themtl.Text = "Thêm";
            btn_themtl.UseVisualStyleBackColor = true;
            btn_themtl.Click += btn_themtl_Click;
            // 
            // btn_huy
            // 
            btn_huy.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_huy.Location = new Point(214, 134);
            btn_huy.Margin = new Padding(4);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(113, 60);
            btn_huy.TabIndex = 30;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            btn_huy.Click += btn_huy_Click;
            // 
            // btn_suatl
            // 
            btn_suatl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_suatl.Location = new Point(214, 54);
            btn_suatl.Margin = new Padding(4);
            btn_suatl.Name = "btn_suatl";
            btn_suatl.Size = new Size(113, 60);
            btn_suatl.TabIndex = 29;
            btn_suatl.Text = "Sửa";
            btn_suatl.UseVisualStyleBackColor = true;
            btn_suatl.Click += btn_suatl_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.DialogResult = DialogResult.Cancel;
            btn_thoat.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_thoat.Location = new Point(387, 134);
            btn_thoat.Margin = new Padding(4);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(114, 60);
            btn_thoat.TabIndex = 28;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_xoatl
            // 
            btn_xoatl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xoatl.Location = new Point(387, 54);
            btn_xoatl.Margin = new Padding(4);
            btn_xoatl.Name = "btn_xoatl";
            btn_xoatl.Size = new Size(114, 60);
            btn_xoatl.TabIndex = 25;
            btn_xoatl.Text = "Xóa";
            btn_xoatl.UseVisualStyleBackColor = true;
            btn_xoatl.Click += btn_xoatl_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lsv_tl);
            groupBox3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 411);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(968, 221);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Các Thể Loại";
            // 
            // lsv_tl
            // 
            lsv_tl.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lsv_tl.Dock = DockStyle.Fill;
            lsv_tl.FullRowSelect = true;
            lsv_tl.GridLines = true;
            lsv_tl.Location = new Point(3, 21);
            lsv_tl.Margin = new Padding(3, 4, 3, 4);
            lsv_tl.Name = "lsv_tl";
            lsv_tl.Size = new Size(962, 196);
            lsv_tl.TabIndex = 0;
            lsv_tl.UseCompatibleStateImageBehavior = false;
            lsv_tl.View = View.Details;
            lsv_tl.SelectedIndexChanged += lsv_tl_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã Thể Loại";
            columnHeader1.Width = 372;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên Thể Loại";
            columnHeader2.Width = 585;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_search.Location = new Point(364, 368);
            txt_search.Margin = new Padding(3, 4, 3, 4);
            txt_search.MaxLength = 35;
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(180, 24);
            txt_search.TabIndex = 5;
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_search.Location = new Point(283, 365);
            btn_search.Margin = new Padding(3, 4, 3, 4);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(63, 36);
            btn_search.TabIndex = 6;
            btn_search.Text = "Lọc";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(560, 361);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(207, 42);
            button1.TabIndex = 28;
            button1.Text = "Hiển Thị Danh Sách";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form_theloai
            // 
            AcceptButton = btn_themtl;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 653);
            Controls.Add(button1);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_theloai";
            Text = "QUẢN LÝ THỂ LOẠI SÁCH";
            FormClosing += Form7_FormClosing;
            Load += Form7_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txt_ttl;
        private TextBox txt_mtl;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Button btn_thoat;
        private Button btn_xoatl;
        private GroupBox groupBox3;
        private ListView lsv_tl;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btn_suatl;
        private Button btn_luu;
        private Button btn_themtl;
        private Button btn_huy;
        private TextBox txt_search;
        private Button btn_search;
        private Button button1;
    }
}
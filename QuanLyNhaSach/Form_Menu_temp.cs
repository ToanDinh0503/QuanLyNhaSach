using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class Form_Menu_temp : Form
    {
        bool isThoatChuongTrinh = true;

        public Form_Menu_temp()
        {
            InitializeComponent();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            //Gan gia tri "vai tro" vao Const.loaiTaiKhoan de phan loai tai khoan
            if (Const.loaiTaiKhoan == 1)
            {
                mntt_sach.Enabled = true;
                mntt_nv.Enabled = true;
                mntt_kh.Enabled = true;
                mntt_tl.Enabled = true;
                mntt_nxb.Enabled = true;
            }
            else if (Const.loaiTaiKhoan == 2)
            {
                mntt_sach.Enabled = false;
                mntt_nv.Enabled = false;
                mntt_kh.Enabled = false;
                mntt_tl.Enabled = false;
                mntt_nxb.Enabled = false;
            }
        }

        private void Form_Menu_temp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoatChuongTrinh)
            {

                if (MessageBox.Show("Bạn có muốn thoát chướng trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }

        }

        private void quảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void mntt_dx_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chướng trình ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                isThoatChuongTrinh = false;
                this.Close();
                Form_DangNhap f = new Form_DangNhap();
                f.Show();
            }
        }

        private void mntt_sach_Click(object sender, EventArgs e)
        {
            Form_sach f = new Form_sach();
            f.Show();
        }

        private void mntt_nv_Click(object sender, EventArgs e)
        {
            Form_NhanVien f = new Form_NhanVien();
            f.Show();
        }

        private void mntt_kh_Click(object sender, EventArgs e)
        {
            Form_khachhang f = new Form_khachhang();
            f.Show();
        }

        private void mntt_tl_Click(object sender, EventArgs e)
        {
            Form_theloai f = new Form_theloai();
            f.Show();
        }

        private void mntt_nxb_Click(object sender, EventArgs e)
        {
            Form_nxb f = new Form_nxb();
            f.Show();
        }

        private void mntt_loaisach_Click(object sender, EventArgs e)
        {
            Form_LoaiSach f = new Form_LoaiSach();
            f.Show();
        }

        private void mntt_dms_Click(object sender, EventArgs e)
        {
            Form_DM_Sach f = new Form_DM_Sach();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mntt_dmkh_Click(object sender, EventArgs e)
        {
            Form_DanhMuckh f = new Form_DanhMuckh();
            f.Show();
        }

        private void mntt_dmnxb_Click(object sender, EventArgs e)
        {
            Form_DM_nxb f = new Form_DM_nxb();
            f.Show();
        }

        private void mntt_tk_Click(object sender, EventArgs e)
        {
            Form_Report f = new Form_Report();
            f.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

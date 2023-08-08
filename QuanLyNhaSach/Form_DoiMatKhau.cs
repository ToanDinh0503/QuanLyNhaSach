using Microsoft.ReportingServices.Diagnostics.Internal;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class Form_DoiMatKhau : Form
    {
        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection? connpg = null;
        public Form_DoiMatKhau()
        {
            InitializeComponent();
        }

        public static bool chuanHoaTaiKhoanMatKhau(string str)
        {
            foreach (char c in str)
            {
                if (c == ' ' || !((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9')))
                {
                    return false;
                }
            }

            return true;
        }
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (connpg == null)
            {
                connpg = new NpgsqlConnection(connectionString);
            }
            if (connpg.State == ConnectionState.Closed)
            {
                connpg.Open(); // Đóng thì mở
            }

            if (KiemTra())
            {
                if (chuanHoaTaiKhoanMatKhau(txt_mkm.Text) == false || chuanHoaTaiKhoanMatKhau(txt_nlmk.Text) == false)
                {
                    MessageBox.Show("Mật khẩu không được chứa ký tự đặc biệt hoặc có dấu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    string sql = "UPDATE nhan_vien SET matkhau = @matkhau WHERE taikhoan = @taikhoan";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connpg))
                    {
                        command.Parameters.AddWithValue("@matkhau", txt_mkm.Text);
                        command.Parameters.AddWithValue("@taikhoan", LuuDN.taikhoan);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mật khẩu đã được đổi thành công!");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Không thể đổi mật khẩu!");
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện sửa dữ liệu: " + ex.Message);
                }
                finally
                {
                    connpg.Close();


                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void txt_htmk_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_htmk.Checked)
            {
                txt_mkc.PasswordChar = (char)0;
                txt_mkm.PasswordChar = (char)0;
                txt_nlmk.PasswordChar = (char)0;
            }
            else
            {
                txt_mkc.PasswordChar = '*';
                txt_mkm.PasswordChar = '*';
                txt_nlmk.PasswordChar = '*';
            }
        }
        public bool KiemTra()
        {
            if (txt_mkc.Text == "")
            {

                MessageBox.Show("Vui lòng nhập mật khẫu hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mkc.Focus();
                return false;
            }
            else if (txt_mkm.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mkm.Focus();
                return false;
            }
            else if (txt_nlmk.Text == "")
            {

                MessageBox.Show("Vui lòng nhập lại mật khẩu mới !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nlmk.Focus();
                return false;
            }
            else if (txt_mkm.Text != txt_nlmk.Text)
            {

                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nlmk.Focus();
                txt_nlmk.SelectAll();
                return false;
            }
            return true;
        }

        private void Form_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }


    }
}

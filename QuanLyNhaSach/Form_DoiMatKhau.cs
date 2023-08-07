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
        public Form_DoiMatKhau()
        {
            InitializeComponent();
        }

        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection? connpg = null;
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                try
                {


                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_Update_Pass";
                    cmd.Parameters.Add("@Matkhaucu", NpgsqlTypes.NpgsqlDbType.Char).Value = txt_mkc.Text;
                    cmd.Parameters.Add("@Matkhaumoi", NpgsqlTypes.NpgsqlDbType.Char).Value = txt_mkm.Text;
                    cmd.Connection = connpg;
                    NpgsqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.GetInt32(0) == 1)
                    {
                        txt_nlmk.ForeColor = System.Drawing.Color.Blue;
                        txt_nlmk.Text = dr.GetString(1);
                        txt_nlmk.Text = "";
                        txt_mkc.Text = "";
                        txt_mkm.Text = "";
                        txt_mkc.Focus();
                    }
                    else
                    {
                        txt_nlmk.ForeColor = System.Drawing.Color.Red;
                        txt_nlmk.Text = dr.GetString(1);
                        txt_mkc.Focus();
                        txt_mkc.SelectAll();
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form_DoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
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
                txt_mkc.ForeColor = System.Drawing.Color.Red;
                txt_mkc.Text = "Vui lòng nhập mật khẩu hiện tại !!";
                txt_mkc.Focus();
                return false;
            }
            else if (txt_mkm.Text == "")
            {
                txt_mkm.ForeColor = System.Drawing.Color.Red;
                txt_mkm.Text = "Vui lòng nhập mật khẩu mới !!";
                txt_mkm.Focus();
                return false;
            }
            else if (txt_nlmk.Text == "")
            {
                txt_nlmk.ForeColor = System.Drawing.Color.Red;
                txt_nlmk.Text = "Vui lòng xác nhận mật khẩu !!";
                txt_nlmk.Focus();
                return false;
            }
            else if (txt_mkm.Text != txt_nlmk.Text)
            {
                txt_nlmk.ForeColor = System.Drawing.Color.Red;
                txt_nlmk.Text = "Mật khẩu mới và mật khẩu xác nhận không trùng khớp";
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

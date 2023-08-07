using QuanLyNhaSach;
using Npgsql;
using System.Data;

namespace QuanLyNhaSach
{
    public partial class Form_DangNhap : Form
    {

        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection connpg = null;
        public Form_DangNhap()
        {

            InitializeComponent();
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }



        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (connpg == null)
            {
                connpg = new NpgsqlConnection(connectionString);
            }
            if (connpg.State == ConnectionState.Closed)
            {
                connpg.Open(); // Đóng thì mở
            }
            try
            {
                string sql = "SELECT * FROM nhan_vien WHERE taikhoan = '" + txb_taikhoan.Text + "' AND matkhau = '" + txb_matkhau.Text + "'";
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sql, connpg);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                //Phan loai tai khoan
                NpgsqlCommand command = new NpgsqlCommand(sql, connpg);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // nếu trong datatable có dữ liêu thì đăng nhập thành công
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        Form_Menu_temp f = new Form_Menu_temp();
                        Const.loaiTaiKhoan = reader.GetInt32(6);
                        Const.nhanvien = reader.GetString(3);
                        f.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connpg.Close();
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txb_matkhau.UseSystemPasswordChar = !txb_matkhau.UseSystemPasswordChar;

        }

        private void txb_taikhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_matkhau.Focus();
            }
        }

        private void txb_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login.PerformClick();
            }
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
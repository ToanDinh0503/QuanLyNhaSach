using Npgsql;
using System.Data;

namespace QuanLyNhaSach
{
    public partial class DangNhap : Form
    {

        private static string connectionString = "Host=localhost;Database=QuanLyNhaSach2;Username=postgres;Password=123456";
        NpgsqlConnection connpg = null;
        public DangNhap()
        {
            
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }







        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chướng trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            string sql = "SELECT * FROM nhan_vien WHERE taikhoan = '" + txb_taikhoan.Text + "' AND matkhau = '" + txb_matkhau.Text + "'";
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sql, connpg);
            DataTable dt = new DataTable();
            adp.Fill(dt);


            // nếu trong datatable có dữ liêu thì đăng nhập thành công
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                Form_NhanVien f = new Form_NhanVien();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }

        } 

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txb_matkhau.UseSystemPasswordChar = !txb_matkhau.UseSystemPasswordChar;

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks.Sources;

namespace QuanLyNhaSach
{
    public partial class FormNhanVien : Form
    {

        string connectionString = "Host=localhost;Database=QuanLyNhaSach2;Username=postgres;Password=123456";
        NpgsqlConnection connpg = null;
        public FormNhanVien()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            if (connpg == null)
            {
                connpg = new NpgsqlConnection(connectionString);
            }
            if (connpg.State == ConnectionState.Closed)
            {
                connpg.Open(); // Đóng thì mở
            }
            // Đối tượng thực thi truy vấn 
            NpgsqlCommand sqlCmd = new NpgsqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select manv,tennv, diachi, sdt, ngaythangnamsinh, tenvt, taikhoan, matkhau\r\n" +
                "from nhan_vien  t " +
                "inner join vai_tro vt " +
                "on t.mavt = vt.mavt\r\n";

            sqlCmd.Connection = connpg;

            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            lsv_danhsachnv.Items.Clear();
            while (reader.Read())
            {
                int manv = reader.GetInt32(0);
                string tennv = reader.GetString(1);
                string diachi = reader.GetString(2);
                int sdt = reader.GetInt32(3);

                var ngaysinh = reader.GetDateTime(4);

                string tenvt = reader.GetString(5);
                string taikhoan = reader.GetString(6);
                string matkhau = reader.GetString(7);


                ListViewItem newitem = new ListViewItem(manv.ToString());
                newitem.SubItems.Add(tennv.ToString());
                newitem.SubItems.Add(diachi);
                newitem.SubItems.Add(sdt.ToString());
                newitem.SubItems.Add(ngaysinh.ToString());

                newitem.SubItems.Add(tenvt.ToString());
                newitem.SubItems.Add(taikhoan.ToString());
                newitem.SubItems.Add(matkhau.ToString());

                lsv_danhsachnv.Items.Add(newitem);
            }
            reader.Close();
        }

        private void themDuLieuChoComboBox()
        {
            
            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (connpg == null)
            {
                connpg = new NpgsqlConnection(connectionString);
            }
            if (connpg.State == ConnectionState.Closed)
            {
                connpg.Open(); // Đóng thì mở
            }
            // Đối tượng thực thi truy vấn 
            NpgsqlCommand sqlCmd = new NpgsqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT tenvt FROM vai_tro";

            sqlCmd.Connection = connpg;

            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            lsv_danhsachnv.Items.Clear();
            while (reader.Read())
            {

                string tennv = reader.GetString(0);
                string diachi = reader.GetString(1);
                int sdt = reader.GetInt32(2);

                var ngaysinh = reader.GetDateTime(3);

                string tenvt = reader.GetString(4);
                string taikhoan = reader.GetString(5);
                string matkhau = reader.GetString(6);


                ListViewItem newitem = new ListViewItem(tennv.ToString());

                newitem.SubItems.Add(diachi);
                newitem.SubItems.Add(sdt.ToString());
                newitem.SubItems.Add(ngaysinh.ToString());

                newitem.SubItems.Add(tenvt.ToString());
                newitem.SubItems.Add(taikhoan.ToString());
                newitem.SubItems.Add(matkhau.ToString());

                lsv_danhsachnv.Items.Add(newitem);
            }
            reader.Close();
        }

        private void lsv_danhsachnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_danhsachnv.SelectedItems.Count == 0) return;
            // Lấy phần tử được chọn trên listview
            ListViewItem lvi = lsv_danhsachnv.SelectedItems[0];

            //hoten = lvi.SubItems[0].Text;

            // Hiển thị thông tin từ listView sang các TextBox
            txb_hoten.Text = lvi.SubItems[1].Text;
            txb_diachi.Text = lvi.SubItems[2].Text;
            txb_dienthoai.Text = lvi.SubItems[3].Text;
            txb_ngaysinh.Text = lvi.SubItems[4].Text;
            cbx_vaittro.Text = lvi.SubItems[5].Text;
            txb_taikhoan.Text = lvi.SubItems[6].Text;
            txb_matkhau.Text = lvi.SubItems[7].Text;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();


        }




        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (connpg == null)
                {
                    connpg = new NpgsqlConnection(connectionString);
                }
                if (connpg.State == ConnectionState.Closed)
                {
                    connpg.Open(); // Đóng thì mở
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thêm dữ liệu: " + ex.Message);
            }
            finally
            {
                connpg.Close();
            }
            string sql = "INSERT INTO nhan_vien (tennv, diachi, sdt, mavt, ngaythangnamsinh, taikhoan, matkhau) VALUES (@tennv, @diachi, @sdt,@mvt, @ns, @taikhoan, @mk)";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connpg))
            {
                command.Parameters.AddWithValue("@tennv", txb_hoten.Text);
                command.Parameters.AddWithValue("@diachi", txb_diachi.Text);
                int sdt = int.Parse(txb_dienthoai.Text);
                command.Parameters.AddWithValue("@sdt", sdt);

                command.Parameters.AddWithValue("@diachi", txb_diachi.Text);

                int mavt = 1;

                switch (cbx_vaittro.Text)
                {
                    case "Admin": mavt = 1; break;
                    case "Quản lý sach": mavt = 2; break;
                    case "Quản lý hóa đơn": mavt = 3; break;

                }
                command.Parameters.AddWithValue("@mvt", mavt);
                DateTime ngaysinh = DateTime.Parse(txb_ngaysinh.Text);
                command.Parameters.AddWithValue("@ns", ngaysinh);
                command.Parameters.AddWithValue("@taikhoan", txb_taikhoan.Text);
                command.Parameters.AddWithValue("@mk", txb_matkhau.Text);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Dữ liệu đã được thêm thành công!");
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Không thể thêm dữ liệu!");
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {

            try
            {
                if (connpg == null)
                {
                    connpg = new NpgsqlConnection(connectionString);
                }
                if (connpg.State == ConnectionState.Closed)
                {
                    connpg.Open(); // Đóng thì mở
                }

                string sql = "UPDATE nhan_vien SET tennv = @tennv, diachi = @diachi, " +
                    "sdt = @sdt, mavt = @mavt, ngaythangnamsinh = @ngaythangnamsinh, taikhoan = @taikhoan, matkhau = @matkhau WHERE manv = @manv";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connpg))
                {

                    command.Parameters.AddWithValue("@tennv", txb_hoten.Text);
                    command.Parameters.AddWithValue("@diachi", txb_diachi.Text);
                    int sdt = int.Parse(txb_dienthoai.Text);
                    command.Parameters.AddWithValue("@sdt", sdt);
                    command.Parameters.AddWithValue("@diachi", txb_diachi.Text);
                    int mavt = 1;

                    switch (cbx_vaittro.Text)
                    {
                        case "Admin": mavt = 1; break;
                        case "Quản lý sach": mavt = 2; break;
                        case "Quản lý hóa đơn": mavt = 3; break;

                    }
                    command.Parameters.AddWithValue("@mavt", mavt);
                    DateTime ngaysinh = DateTime.Parse(txb_ngaysinh.Text);
                    command.Parameters.AddWithValue("@ngaythangnamsinh", ngaysinh);
                    command.Parameters.AddWithValue("@taikhoan", txb_taikhoan.Text);
                    command.Parameters.AddWithValue("@matkhau", txb_matkhau.Text);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected >= 0)
                    {
                        MessageBox.Show("Dữ liệu đã được cập nhật thành công!");
                        HienThiDanhSach();
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật dữ liệu!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện cập nhật dữ liệu: " + ex.Message);
            }
            finally
            {
                connpg.Close();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    if (connpg == null)
                    {
                        connpg = new NpgsqlConnection(connectionString);
                    }
                    if (connpg.State == ConnectionState.Closed)
                    {
                        connpg.Open(); // Đóng thì mở
                    }

                    string sql = "DELETE FROM nhan_vien WHERE tennv = @tennv";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connpg))
                    {
                        command.Parameters.AddWithValue("@tennv", txb_hoten.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dữ liệu đã được xóa thành công!");
                            HienThiDanhSach();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu cần xóa!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện xóa dữ liệu: " + ex.Message);
                }
                finally
                {
                    connpg.Close();
                }
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txb_hoten.Text = string.Empty;
            txb_diachi.Text = string.Empty;
            txb_dienthoai.Text = string.Empty;
            txb_ngaysinh.Text = string.Empty;
            cbx_vaittro.Text = string.Empty;
            txb_taikhoan.Text = string.Empty;
            txb_matkhau.Text = string.Empty;
        }

        private void FormNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txb_hoten.Text != string.Empty ||
                txb_diachi.Text != string.Empty ||
                txb_dienthoai.Text != string.Empty ||
                txb_matkhau.Text != string.Empty ||
                txb_taikhoan.Text != string.Empty ||
                txb_ngaysinh.Text != string.Empty ||
                cbx_vaittro.Text != string.Empty)
            {




                if (MessageBox.Show("Bạn chưa lưu thay đổi ! Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                }


            }


            else if (MessageBox.Show("Bạn có muốn thoát chướng trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txb_matkhau_TextChanged(object sender, EventArgs e)
        {

        }



        private void txb_dienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_capnhat_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {

        }
    }
}

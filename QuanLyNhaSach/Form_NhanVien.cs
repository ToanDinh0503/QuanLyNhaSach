using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaSach
{
    public partial class Form_NhanVien : Form
    {

        private class NhanVien
        {

            public int manv;
            public string taikhoan;
            public string matkhau;
            public string tennv;
            public string diachi;
            public int sdt;
            public string tenvt;
            public DateOnly ngaysinh;
            public bool gioitinh;
        }

        public Form_NhanVien()
        {
            InitializeComponent();
        }
        private static string connectionString = "Host=localhost;Database=QuanLyNhaSach2;Username=postgres;Password=123456";
        NpgsqlConnection connpg = null;

        private void trangThaiCacTextBox(bool true_false)
        {
            txb_diachi.Enabled = true_false;
            txb_hoten.Enabled = true_false;
            txb_manv.Enabled = true_false;
            txb_matkhau.Enabled = true_false;
            txb_taikhoan.Enabled = true_false;
            cld_ngaysinh.Enabled = true_false;
            chb_nam.Enabled = true_false;
            chb_nu.Enabled = true_false;
            cbx_vaitro.Enabled = true_false;
        }

        private void lamTrongCacTextBox()
        {
            txb_diachi.Text = string.Empty;
            txb_hoten.Text = string.Empty;
            txb_manv.Text = string.Empty;
            txb_matkhau.Text = string.Empty;
            txb_sdt.Text = string.Empty;
            txb_taikhoan.Text = string.Empty;
            cbx_vaitro.Text = string.Empty;
            chb_nam.Checked = false;
            chb_nu.Checked = false;
            cld_ngaysinh.Value = DateTime.Now;

        }
        private void HienThiDanhSach()
        {
            NhanVien nv = new NhanVien();
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
            sqlCmd.CommandText = "select manv, taikhoan, matkhau, tennv, diachi, sdt, tenvt, ngaythangnamsinh,gioitinh from nhan_vien nv inner join vai_tro vt on nv.mavt = vt.mavt";

            sqlCmd.Connection = connpg;

            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            lsv_danhsach.Items.Clear();
            while (reader.Read())
            {
                nv.manv = reader.GetInt32(0);
                nv.taikhoan = reader.GetString(1);
                nv.matkhau = reader.GetString(2);
                nv.tennv = reader.GetString(3);

                nv.diachi = reader.GetString(4);
                nv.sdt = reader.GetInt32(5);
                nv.tenvt = reader.GetString(6);
                nv.ngaysinh = DateOnly.FromDateTime(reader.GetDateTime(7));


                ListViewItem newitem = new ListViewItem(nv.manv.ToString());

                newitem.SubItems.Add(nv.tennv.ToString());
                newitem.SubItems.Add(nv.gioitinh.ToString());
                newitem.SubItems.Add(nv.sdt.ToString());
                newitem.SubItems.Add(nv.diachi.ToString());
                newitem.SubItems.Add(nv.tenvt.ToString());
                newitem.SubItems.Add(nv.taikhoan.ToString());
                newitem.SubItems.Add(nv.ngaysinh.ToString());
                newitem.SubItems.Add(nv.matkhau.ToString());
          
                

                lsv_danhsach.Items.Add(newitem);
            }
            reader.Close();
        }


        private void Form_data_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            //ban dau thi tat ca cac textbox deu la read het
            trangThaiCacTextBox(false);
            btn_LamMoi.Enabled = false;
            btn_Luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }


        /*private void button2_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        string sql = "DELETE FROM sach WHERE masach = @ms";

                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@ms", Convert.ToInt32(txb_manv.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Dữ liệu đã được xóa thành công!");
                                Form_data_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa dữ liệu!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thực hiện xóa dữ liệu: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }*/





        private void btn_suasach_Click(object sender, EventArgs e)
        {
            //ban dau thi cac txt deu la readonly
            trangThaiCacTextBox(false);

            btn_Luu.Enabled = true;
            btn_LamMoi.Enabled = true;
            //phai chon truoc moi sua duoc



            //sua
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = "UPDATE nhan_vien SET tennv = @tennv, taikhoan = @taikhoan, matkhau = @matkhau, sdt = @sdt, diachi = @ diachi, gioitinh = @gioitinh, ngaythangnamsinh = @ngaysinh WHERE manv = @manv";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@tennv", txb_hoten.Text);
                        command.Parameters.AddWithValue("@taikhoan", txb_taikhoan.Text);
                        command.Parameters.AddWithValue("@diachi", txb_diachi.Text);
                        command.Parameters.AddWithValue("@sdt", Convert.ToInt32(txb_matkhau.Text));
                        command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(cld_ngaysinh.Value));
                        command.Parameters.AddWithValue("@manv", Convert.ToInt32(txb_manv.Text));


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dữ liệu đã được cập nhật thành công!");
                            Form_data_Load(sender, e);
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
                    connection.Close();
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            // DialogResult dg = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // if (dg == DialogResult.Yes)
            // {
            // Application.Exit();
            // }
            Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchString = txt_search.Text.Trim(); // Giá trị tìm kiếm từ TextBox
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = "SELECT * FROM sach WHERE tensach LIKE @search";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@search", "%" + searchString + "%");

                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm dữ liệu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void txt_ts_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void txt_tnxb_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txt_mtl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void Form_datagrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_KhongLuu_Click(object sender, EventArgs e)
        {
            //dua ra thong bao
            DialogResult result = MessageBox.Show("Bạn chắc chắn không lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // reset các text


                // dat readonly bang true
                trangThaiCacTextBox(true);

                //cho tat ca cac nut enable = true
                Form_data_Load(sender, e);

            }
        }

        private void txt_ts_TextChanged(object sender, EventArgs e)
        {

        }

        private void lsv_sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_danhsach.SelectedItems.Count == 0) return;

            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            // Lấy phần tử được chọn trên listview
            ListViewItem lvi = lsv_danhsach.SelectedItems[0];

            //hoten = lvi.SubItems[0].Text;

            // Hiển thị thông tin từ listView sang các TextBox
            txb_manv.Text = lvi.SubItems[0].Text;
            txb_hoten.Text = lvi.SubItems[1].Text;
            txb_diachi.Text = lvi.SubItems[2].Text;
            txb_matkhau.Text = lvi.SubItems[3].Text;

            txb_sdt.Text = lvi.SubItems[5].Text;
            txb_taikhoan.Text = lvi.SubItems[6].Text;

        }

        private void btn_themsach_Click(object sender, EventArgs e)
        {
            trangThaiCacTextBox(false);
            btn_LamMoi.Enabled = true;
            btn_Luu.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = "INSERT INTO sach (tensach, mota, gia, tennxb, nam, matl) VALUES (@ts, @mt, @g, @tnxb, @n, @mtl)";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ts", txb_hoten.Text);
                        command.Parameters.AddWithValue("@mt", txb_taikhoan.Text);
                        command.Parameters.AddWithValue("@g", Convert.ToInt32(txb_diachi.Text));
                        command.Parameters.AddWithValue("@tnxb", txb_matkhau.Text);

                        command.Parameters.AddWithValue("@mtl", Convert.ToInt32(txb_sdt.Text));

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dữ liệu đã được thêm thành công!");
                            Form_data_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm dữ liệu!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện thêm dữ liệu: " + ex.Message);
                }
                finally
                {
                    connection.Close();


                }

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}

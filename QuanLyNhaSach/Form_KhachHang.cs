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

namespace QuanLyNhaSach
{
    public partial class Form_khachhang : Form
    {
        public Form_khachhang()
        {
            InitializeComponent();
        }
        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection connpg = null;

        private bool isThemSachButtonClicked = false;
        private bool isSuaSachButtonClicked = false;

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
            sqlCmd.CommandText = "select makh,tenkh,diachi,sdt,email" +
                " from khach_hang";

            sqlCmd.Connection = connpg;

            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            lsv_khach.Items.Clear();
            while (reader.Read())
            {
                int makh = reader.GetInt32(0);
                string tenkh = reader.GetString(1);
                string diachi = reader.GetString(2);
                long sdt = reader.GetInt64(3);
                string email = reader.GetString(4);

                ListViewItem newitem = new ListViewItem(makh.ToString());

                newitem.SubItems.Add(tenkh.ToString());
                newitem.SubItems.Add(diachi);
                newitem.SubItems.Add(sdt.ToString());
                newitem.SubItems.Add(email);

                lsv_khach.Items.Add(newitem);
            }
            reader.Close();
        }
        private void btn_themkhach_Click(object sender, EventArgs e)
        {
            isThemSachButtonClicked = true;
            isSuaSachButtonClicked = false;
            hamtrong(true);
            btn_LamMoiKhach.Enabled = true;
            btn_LuuKhach.Enabled = true;
            btn_suakhach.Enabled = false;
            btn_xoakhach.Enabled = false;

            txt_mkh.Text = "";
            txt_tkh.Text = "";
            txt_sdt.Text = "";
            txt_dchi.Text = "";
            txt_email.Text = "";
            txt_tkh.Focus();
        }
        private void Form_khachhang_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txt_mkh.Enabled = false;
            hamtrong(false);
            btn_themkhach.Enabled = true;
            btn_LamMoiKhach.Enabled = false;
            btn_LuuKhach.Enabled = false;
            btn_suakhach.Enabled = false;
            btn_xoakhach.Enabled = false;
        }
        private void hamtrong(bool true_false)
        {
            txt_tkh.Enabled = true_false;
            txt_dchi.Enabled = true_false;
            txt_sdt.Enabled = true_false;
            txt_email.Enabled = true_false;
        }
        private void btn_suakhach_Click(object sender, EventArgs e)
        {
            isThemSachButtonClicked = false;
            isSuaSachButtonClicked = true;
            txt_mkh.Enabled = false;
            hamtrong(true);
            btn_themkhach.Enabled = false;
            btn_xoakhach.Enabled = false;
            btn_LuuKhach.Enabled = true;
            btn_LamMoiKhach.Enabled = true;
            txt_tkh.Focus();
        }

        private void btn_xoakhach_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        string sql = "DELETE FROM khach_hang WHERE makh = @mkh";

                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@mkh", Convert.ToInt32(txt_mkh.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Dữ liệu đã được xóa thành công!");
                                Form_khachhang_Load(sender, e);
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
                        txt_mkh.Text = "";
                        txt_tkh.Text = "";
                        txt_sdt.Text = "";
                        txt_dchi.Text = "";
                        txt_email.Text = "";
                        Form_khachhang_Load(sender, e);
                    }
                }
            }
        }

        private void btn_LamMoiKhach_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn không lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // reset các text
                txt_mkh.Text = "";
                txt_tkh.Text = "";
                txt_sdt.Text = "";
                txt_dchi.Text = "";
                txt_email.Text = "";
                //cho tat ca cac nut enable = true
                Form_khachhang_Load(sender, e);

            }
        }

        private void btn_LuuKhach_Click(object sender, EventArgs e)
        {
            if (txt_tkh.Text == "" || txt_sdt.Text == "" || txt_dchi.Text == "" || txt_email.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !");
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (isThemSachButtonClicked) // Kiểm tra nút "Thêm sách" đã được chọn
                    {
                        ThemKhachHang(connection);
                    }
                    else if (isSuaSachButtonClicked) // Kiểm tra nút "Sửa sách" đã được chọn
                    {
                        SuaKhachHang(connection);
                    }

                    // Cập nhật giao diện hoặc dữ liệu cần thiết
                    Form_khachhang_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện thao tác với cơ sở dữ liệu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    txt_mkh.Text = "";
                    txt_tkh.Text = "";
                    txt_sdt.Text = "";
                    txt_dchi.Text = "";
                    txt_email.Text = "";
                }
            }
        }

        private void ThemKhachHang(NpgsqlConnection connection)
        {
            try
            {
                string sql = "INSERT INTO khach_hang(tenkh,diachi,sdt,email) VALUES(@tkh,@dchi,@sdtkh,@emailkh)";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@tkh", txt_tkh.Text);
                    command.Parameters.AddWithValue("@dchi", txt_dchi.Text);
                    command.Parameters.AddWithValue("@sdtkh", Convert.ToInt64(txt_sdt.Text));
                    command.Parameters.AddWithValue("@emailkh", txt_email.Text);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dữ liệu đã được thêm thành công!");
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

        private void SuaKhachHang(NpgsqlConnection connection)
        {
            //sua
            try
            {
                string sql = "UPDATE khach_hang SET tenkh = @tkh, diachi = @dchi, sdt = @sdtkh, email = @emailkh WHERE makh = @mkh";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@tkh", txt_tkh.Text);
                    command.Parameters.AddWithValue("@dchi", txt_dchi.Text);
                    command.Parameters.AddWithValue("@sdtkh", Convert.ToInt64(txt_sdt.Text));
                    command.Parameters.AddWithValue("@emailkh", txt_email.Text);
                    command.Parameters.AddWithValue("@mkh", Convert.ToInt32(txt_mkh.Text));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dữ liệu đã được cập nhật thành công!");
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
                txt_mkh.Text = "";
                txt_tkh.Text = "";
                txt_sdt.Text = "";
                txt_dchi.Text = "";
                txt_email.Text = "";
            }

        }

        private void lsv_khach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_khach.SelectedItems.Count == 0) return;
            btn_LamMoiKhach.Enabled = false;
            btn_LuuKhach.Enabled = false;
            btn_xoakhach.Enabled = true;
            btn_suakhach.Enabled = true;
            // Lấy phần tử được chọn trên listview
            ListViewItem lvi = lsv_khach.SelectedItems[0];

            //hoten = lvi.SubItems[0].Text;

            // Hiển thị thông tin từ listView sang các TextBox
            txt_mkh.Text = lvi.SubItems[0].Text;
            txt_tkh.Text = lvi.SubItems[1].Text;
            txt_dchi.Text = lvi.SubItems[2].Text;
            txt_sdt.Text = lvi.SubItems[3].Text;
            txt_email.Text = lvi.SubItems[4].Text;
        }

        private void btn_searchKhach_Click(object sender, EventArgs e)
        {
            string searchString = txt_searchKhach.Text.Trim(); // Giá trị tìm kiếm từ TextBox
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = "SELECT * FROM khach_hang WHERE tenkh LIKE @search";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@search", "%" + searchString + "%");

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {

                            lsv_khach.Items.Clear();
                            while (reader.Read())
                            {
                                int makh = reader.GetInt32(0);
                                string tenkh = reader.GetString(1);
                                string diachi = reader.GetString(2);
                                long sdt = reader.GetInt64(3);
                                string email = reader.GetString(4);

                                ListViewItem newitem = new ListViewItem(makh.ToString());

                                newitem.SubItems.Add(tenkh.ToString());
                                newitem.SubItems.Add(diachi);
                                newitem.SubItems.Add(sdt.ToString());
                                newitem.SubItems.Add(email);

                                lsv_khach.Items.Add(newitem);
                            }
                            reader.Close();
                        }


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

        private void btn_thoatkhach_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_KhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void txt_mkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void btn_htds_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txt_searchKhach.Text = "";
        }
    }
}

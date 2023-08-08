using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaSach
{
    public partial class Form_CTHD : Form
    {
        public Form_CTHD()
        {
            InitializeComponent();
        }
        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection connpg = null;

        private bool isSuaChiTietButtonClicked = false;

        private void LayDuLieuComboboxmaHD()
        {
            string query = "SELECT mahd FROM hoa_don order by mahd";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connpg);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);


            //do du lieu va combobox
            cmb_MaHD.ValueMember = "mahd";
            cmb_MaHD.DataSource = dataTable;
        }

        private void LayDuLieuComboboxmaTL()
        {
            string query = "SELECT masach,tensach FROM sach order by masach";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connpg);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);


            //do du lieu va combobox
            cmb_MaSach.DisplayMember = "tensach";
            cmb_MaSach.ValueMember = "masach";
            cmb_MaSach.DataSource = dataTable;
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
            sqlCmd.CommandText = "select c.mahd,c.masach,s.tensach,c.soluong,c.thanhtien,c.tinhtrang from chi_tiet_hoa_don c,sach s WHERE c.masach = s.masach order by mahd";
            sqlCmd.Connection = connpg;

            //lay du lieu vao combobox
            LayDuLieuComboboxmaHD();
            LayDuLieuComboboxmaTL();

            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            lsv_CTHD.Items.Clear();
            while (reader.Read())
            {
                int mahd = reader.GetInt32(0);
                int masach = reader.GetInt32(1);
                string tensach = reader.GetString(2);
                int soluong = reader.GetInt32(3);
                string thanhtien = DataHelpers.GetNonNullInt(reader.GetValue(4), "");
                //kiem tra coi no co null khong co thi tra ve null
                string tinhtrang = DataHelpers.GetNonNullString(reader.GetValue(5), "");

                ListViewItem newitem = new ListViewItem(mahd.ToString());

                newitem.SubItems.Add(masach.ToString());
                newitem.SubItems.Add(tensach.ToString());
                newitem.SubItems.Add(soluong.ToString());
                newitem.SubItems.Add(thanhtien.ToString());
                newitem.SubItems.Add(tinhtrang);

                lsv_CTHD.Items.Add(newitem);
            }
            reader.Close();
        }


        private void SuaCTHD(NpgsqlConnection connection)
        {
            //sua
            try
            {
                string sql = "UPDATE chi_tiet_hoa_don SET mahd = @mhd, masach = @msach, soluong = @sl, thanhtien = @tien,tinhtrang=@tt WHERE mahd = @mhd and masach=@msach";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@mhd", Convert.ToInt32(cmb_MaHD.Text));
                    command.Parameters.AddWithValue("@msach", Convert.ToInt32(cmb_MaSach.SelectedValue));
                    command.Parameters.AddWithValue("@sl", Convert.ToInt32(txt_soluong.Text));
                    command.Parameters.AddWithValue("@tien", Convert.ToInt32(txt_thanhtien.Text));
                    command.Parameters.AddWithValue("@tt", txt_tinhtrang.Text);

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

                txt_thanhtien.Text = "";
                txt_soluong.Text = "";
                txt_tinhtrang.Text = "";
            }

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Form_CTHD_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            //ban dau thi tat ca cac textbox deu la read het
            cmb_MaHD.Enabled = false;
            cmb_MaSach.Enabled = false;
            txt_soluong.ReadOnly = true;
            txt_thanhtien.ReadOnly = true;
            txt_tinhtrang.ReadOnly = true;

            btn_LamMoichitiet.Enabled = false;
            btn_Luuchitiet.Enabled = false;
            btn_suachitiet.Enabled = false;
            btn_xoachitiet.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private int LayGiaTien(int masach)
        {
            int giaTien = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = "SELECT gia FROM sach WHERE masach = @msach";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@msach", masach);
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            giaTien = Convert.ToInt32(result);
                        }

                        // Đóng kết nối
                        connection.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                return giaTien;

            }
        }


        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem TextBox số lượng có rỗng hay không
            if (!string.IsNullOrEmpty(txt_soluong.Text))
            {
                // Lấy giá trị số lượng từ TextBox số lượng
                if (int.TryParse(txt_soluong.Text, out int soLuong))
                {
                    // Kiểm tra xem có dữ liệu được chọn trong ComboBox hay không
                    if (cmb_MaSach.SelectedItem != null)
                    {
                        //lay du lieu tu combobox
                        DataRowView selectedRow = cmb_MaSach.SelectedItem as DataRowView;
                        // Lấy giá trị id sách từ ComboBox
                       int masach = Convert.ToInt32(selectedRow["masach"].ToString());
                        

                        // Lấy giá tiền của sách từ cơ sở dữ liệu 
                        int giaTien = LayGiaTien(masach);

                        // Tính toán thành tiền và cập nhật vào TextBox thành tiền
                        int thanhTien = soLuong * giaTien;
                        txt_thanhtien.Text = thanhTien.ToString();
                    }
                }
            }
            else
            {
                // Nếu TextBox số lượng rỗng, đặt TextBox thành tiền thành rỗng
                txt_soluong.Text = string.Empty;
            }
        }

        private void btn_LamMoichitiet_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn không lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // reset các text

                txt_thanhtien.Text = "";
                txt_soluong.Text = "";
                txt_tinhtrang.Text = "";



                //cho tat ca cac nut enable = true
                Form_CTHD_Load(sender, e);

            }
        }

        private void btn_Luuchitiet_Click(object sender, EventArgs e)
        {
            if (txt_thanhtien.Text == "" || txt_soluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !");
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (isSuaChiTietButtonClicked) // Kiểm tra nút "Sửa sách" đã được chọn
                    {
                        SuaCTHD(connection);
                    }
                    HienThiDanhSach();
                    int tongtienmoi = TinhTongTien();
                    // Cap nhat tong tien vao database
                    CapNhatTongTien(connection, tongtienmoi);
                    // Cập nhật giao diện hoặc dữ liệu cần thiết

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện thao tác với cơ sở dữ liệu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    Form_CTHD_Load(sender, e);
                    txt_thanhtien.Text = "";
                    txt_soluong.Text = "";
                    txt_tinhtrang.Text = "";
                }
            }
        }

        private void btn_searchchitiet_Click_1(object sender, EventArgs e)
        {
            
            string keyword = txt_searchMaHD.Text.Trim();
            if(keyword == "")
            {
                HienThiDanhSach();
                return;
            }
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("select c.mahd,c.masach,s.tensach,c.soluong,c.thanhtien,c.tinhtrang from chi_tiet_hoa_don c,sach s WHERE c.masach = s.masach AND c.mahd = @keyword order by mahd", conn);
                    cmd.Parameters.AddWithValue("@keyword", Convert.ToInt32(keyword));
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    lsv_CTHD.Items.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["mahd"].ToString());
                        item.SubItems.Add(row["masach"].ToString());
                        item.SubItems.Add(row["tensach"].ToString());
                        item.SubItems.Add(row["soluong"].ToString());
                        item.SubItems.Add(row["thanhtien"].ToString());
                        item.SubItems.Add(row["tinhtrang"].ToString());


                        lsv_CTHD.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm hóa đơn: " + ex.Message);
                }
            }
        }

        private void btn_suachitiet_Click_1(object sender, EventArgs e)
        {
            
            isSuaChiTietButtonClicked = true;
            //ban dau thi cac txt deu la readonly

            cmb_MaSach.Enabled = true;
            txt_soluong.ReadOnly = false;
            txt_thanhtien.ReadOnly = true;
            txt_tinhtrang.ReadOnly = false;

            
            btn_xoachitiet.Enabled = false;
            btn_Luuchitiet.Enabled = true;
            btn_LamMoichitiet.Enabled = true;

        }

        private void lsv_CTHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_CTHD.SelectedItems.Count == 0) return;

            btn_xoachitiet.Enabled = true;
            btn_suachitiet.Enabled = true;
            cmb_MaSach.Enabled = false;
            cmb_MaHD.Enabled = false;
            txt_soluong.ReadOnly = true;
            txt_thanhtien.ReadOnly = true;
            txt_tinhtrang.ReadOnly = true;
            // Lấy phần tử được chọn trên listview
            ListViewItem lvi = lsv_CTHD.SelectedItems[0];

            // Hiển thị thông tin từ listView sang các TextBox
            cmb_MaHD.Text = lvi.SubItems[0].Text;
            cmb_MaSach.Text = lvi.SubItems[2].Text;
            txt_soluong.Text = lvi.SubItems[3].Text;
            txt_thanhtien.Text = lvi.SubItems[4].Text;
            txt_tinhtrang.Text = lvi.SubItems[5].Text;
        }

        private void btn_thoatchitiet_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void Form_CTHD_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void CapNhatTongTien(NpgsqlConnection connection, int ttienmoi)
        {
            //sua
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                string sql = "UPDATE hoa_don SET tongtien = @ttien WHERE mahd = @mhd";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@mhd", Convert.ToInt32(cmb_MaHD.SelectedValue));
                    command.Parameters.AddWithValue("@ttien", Convert.ToInt32(ttienmoi));


                    int rowsAffected = command.ExecuteNonQuery();

                    
                    if(rowsAffected<=0)
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

        private int TinhTongTien()
        {
            int tong = 0;

            //dua vao moi dong trong listview
            foreach (ListViewItem item in lsv_CTHD.Items)
            {
                //lay tien tung cai roi cong vao
                int thanhtien = int.Parse(item.SubItems[4].Text);
                tong += thanhtien;
            }
            return tong;
        }

        private int LaySoLuong(int masach, int mahd)
        {
            int soluong = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = "SELECT soluong FROM chi_tiet_hoa_don WHERE masach = @msach and mahd = @mhd";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@msach", masach);
                        command.Parameters.AddWithValue("@mhd", mahd);
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            soluong = Convert.ToInt32(result);
                        }

                        // Đóng kết nối
                        connection.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                return soluong;

            }
        }

        private void btn_xoachitiet_Click_1(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        string sql = "DELETE FROM chi_tiet_hoa_don WHERE mahd = @mhd and masach=@msach";

                        //lay tien cua sach bị xóa
                        int thanhtienxoa = LayGiaTien(Convert.ToInt32(cmb_MaSach.SelectedValue));
                        int soluongxoa = LaySoLuong(Convert.ToInt32(cmb_MaSach.SelectedValue), Convert.ToInt32(cmb_MaHD.Text));

                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            DataRowView selectedRowMS = cmb_MaSach.SelectedItem as DataRowView;
                            command.Parameters.AddWithValue("@mhd", Convert.ToInt32(cmb_MaHD.SelectedValue));
                            command.Parameters.AddWithValue("@msach", Convert.ToInt32(cmb_MaSach.SelectedValue));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Dữ liệu đã được xóa thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa dữ liệu!");
                            }
                        }

                        //tinh tong tien  
                        int tongtiencu = TinhTongTien();
                        int tongtienmoi = tongtiencu - (thanhtienxoa * soluongxoa); 

                        // Cap nhat tong tien vao database
                        CapNhatTongTien(connection, tongtienmoi);
                        HienThiDanhSach();
                        

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
        }
    }
}


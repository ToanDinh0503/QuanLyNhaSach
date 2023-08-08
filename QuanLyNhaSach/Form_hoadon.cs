using Microsoft.VisualBasic;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaSach
{
    public partial class Form_banhang : Form
    {

        public Form_banhang()
        {
            InitializeComponent();
        }
        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection connpg = null;


        private bool isThemSachButtonClicked = false;
        private void LayDuLieuComboboxMKH()
        {
            string query = "SELECT makh,tenkh FROM khach_hang order by makh";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connpg);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            //do du lieu va combobox
            cmb_mkh.ValueMember = "makh";
            cmb_mkh.DisplayMember = "tenkh";
            cmb_mkh.DataSource = dataTable;
        }
        private void LayDuLieuComboboxMNV()
        {
            string query = "SELECT manv,tennv FROM nhan_vien order by manv";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connpg);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);


            cmb_mnv.ValueMember = "manv";
            cmb_mnv.DisplayMember = "tennv";
            cmb_mnv.DataSource = dataTable;
        }
        private void LayDuLieuComboboxMaSach()
        {
            string query = "SELECT masach,tensach FROM sach order by masach";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connpg);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);


            //do du lieu va combobox
            cmb_MaSach.ValueMember = "masach";
            cmb_MaSach.DisplayMember = "tensach";
            cmb_MaSach.DataSource = dataTable;
        }
        private string GetTenKhachHangTuDataBase(string selectedMakh)
        {
            string query = "SELECT tenkhachhang FROM khachhang WHERE makh = @makh";
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@makh", selectedMakh);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            // tra ve ten khach hang trong databse
                            return result.ToString();
                        }
                        else
                        {
                            //tra ve khong tim thay neu ko co
                            return "No data found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //neu co exception
                return "Error";
            }
        }
        private void CapnhatdisplayText()
        {
            string tenKHmoi = GetTenKhachHangTuDataBase(cmb_mkh.Text);
        }

        private void loadInfoHoaDon()
        {
            try
            {
                int mahdValue; //tao bien kieu int

                // Vxac thuc va chuyen txt.Text qua mahdValue
                if (int.TryParse(txt_search.Text, out mahdValue))
                {
                    string query = "SELECT mahd,makh,manv,ngaylap,tongtien FROM hoa_don WHERE mahd = @mahd";
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connpg);

                    // gan mahd parameter 
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@mahd", mahdValue);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    //dat cac thong tin vao cac textbox
                    txt_mhd.Text = dataTable.Rows[0]["mahd"].ToString();
                    cmb_mkh.Text = dataTable.Rows[0]["makh"].ToString();
                    dt_nlhd.Text = dataTable.Rows[0]["ngaylap"].ToString();
                    cmb_mnv.Text = dataTable.Rows[0]["manv"].ToString();
                    txt_tongtien.Text = dataTable.Rows[0]["tongtien"].ToString();


                }
                else
                {

                    Console.WriteLine("Mã hóa đơn không hợp lệ.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void HienThiDanhSach()
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

                if (int.TryParse(txt_mhd.Text, out int mahdValue))
                {
                    NpgsqlCommand sqlCmd = new NpgsqlCommand();
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "select s.masach, s.tensach, c.soluong, s.gia, c.thanhtien from chi_tiet_hoa_don c, sach s where c.masach = s.masach and c.mahd = @mahd";
                    sqlCmd.Parameters.AddWithValue("@mahd", NpgsqlDbType.Integer, mahdValue);


                    sqlCmd.Connection = connpg;
                    NpgsqlDataReader reader = sqlCmd.ExecuteReader();

                    lsv_CTHD.Items.Clear();

                    while (reader.Read())
                    {
                        int masach = reader.GetInt32(0);
                        string tensach = reader.GetString(1);
                        int soluong = reader.GetInt32(2);
                        int gia = reader.GetInt32(3);
                        int thanhtien = reader.GetInt32(4);

                        ListViewItem newitem = new ListViewItem(masach.ToString());
                        newitem.SubItems.Add(tensach.ToString());
                        newitem.SubItems.Add(soluong.ToString());
                        newitem.SubItems.Add(gia.ToString());
                        newitem.SubItems.Add(thanhtien.ToString());

                        lsv_CTHD.Items.Add(newitem);
                    }

                    reader.Close();
                }
                else
                {

                    Console.WriteLine("Mã hóa đơn không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void HoaDon_Load_1(object sender, EventArgs e)
        {
            HienThiDanhSach();
            LayDuLieuComboboxMKH();
            LayDuLieuComboboxMNV();
            LayDuLieuComboboxMaSach();

            //ban dau thi tat ca cac textbox deu la read het
            hamtrong(false);
            txt_mhd.Text = "";
            LamMoiGiaTri();

            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_inHD.Enabled = false;

            //hien thi thong tin hoa don dc goi


        }
        private void hamtrong(bool true_false)
        {
            txt_mhd.Enabled = true_false;
            dt_nlhd.Enabled = true_false;
            cmb_mkh.Enabled = true_false;
            cmb_mnv.Enabled = true_false;
            btn_qlkh.Enabled = true_false;
            cmb_MaSach.Enabled = true_false;
            txt_soluong.Enabled = true_false;
            txt_Gia.Enabled = true_false;
            txt_thanhtien.Enabled = true_false;
            txt_tinhtrang.Enabled = true_false;
        }

        private int TaomaHD()
        {
            int maHDmoi = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = "SELECT MAX(mahd) FROM hoa_don";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            maHDmoi = Convert.ToInt32(result);
                        }

                        // Đóng kết nối
                        connection.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

                return maHDmoi + 1;
            }
        }

        private void LamMoiGiaTri()
        {
            txt_mhd.Text = "";
            cmb_mnv.Text = "";
            cmb_mkh.Text = "";
            txt_tongtien.Text = "0";

            cmb_MaSach.Text = "";
            txt_soluong.Text = "";
            txt_thanhtien.Text = "0";
        }
        private void LamMoiCTHD()
        {
            cmb_MaSach.Text = "";
            txt_soluong.Text = "";
            txt_thanhtien.Text = "0";
            txt_Gia.Text = "0";
            txt_tinhtrang.Text = "";
        }


        private void ThemCTHD(NpgsqlConnection connection)
        {

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                string sql = "INSERT INTO chi_tiet_hoa_don(mahd,masach,soluong,thanhtien,tinhtrang) VALUES(@mhd,@msach,@sl,@tien,@tt)";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@mhd", Convert.ToInt32(txt_mhd.Text));
                    command.Parameters.AddWithValue("@msach", Convert.ToInt32(cmb_MaSach.SelectedValue));
                    command.Parameters.AddWithValue("@sl", Convert.ToInt32(txt_soluong.Text));
                    command.Parameters.AddWithValue("@tien", Convert.ToInt32(txt_thanhtien.Text));
                    command.Parameters.AddWithValue("@tt", txt_tinhtrang.Text);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected <= 0)
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
                    command.Parameters.AddWithValue("@mhd", Convert.ToInt32(txt_mhd.Text));
                    command.Parameters.AddWithValue("@ttien", Convert.ToInt32(ttienmoi));


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected <= 0)
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
                txt_Gia.Text = giaTien.ToString();
                return giaTien;

            }
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
            }
            return soluong;
        }

        private int CheckMaHD(int mahd)
        {
            int kq = -1;
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = "SELECT mahd FROM hoa_don WHERE mahd = @mhd";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@mhd", mahd);
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            kq = Convert.ToInt32(result);
                        }

                        // Đóng kết nối
                        connection.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                return kq;

            }
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            isThemSachButtonClicked = true;
            btn_them.Enabled = false;
            btn_huy.Enabled = true;
            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_inHD.Enabled = false;
            hamtrong(true);
            LamMoiGiaTri();
            txt_mhd.Text = TaomaHD().ToString();
            HienThiDanhSach();
            dt_nlhd.Focus();
        }
        private void xoaAllCTHD()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = "DELETE FROM chi_tiet_hoa_don WHERE mahd = @mhd";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@mhd", Convert.ToInt32(txt_mhd.Text));
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected <= 0)
                        {
                            MessageBox.Show("Không thể cập nhật dữ liệu!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện xóa dữ liệu: " + ex.Message);
                }

            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa Hóa Đơn hay không?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        xoaAllCTHD();
                        string sql = "DELETE FROM hoa_don WHERE mahd = @mhd";

                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@mhd", Convert.ToInt32(txt_mhd.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Dữ liệu đã được xóa thành công!");
                                HoaDon_Load_1(sender, e);
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
                        LamMoiGiaTri();
                        HienThiDanhSach();
                        lsv_CTHD.Items.Clear();
                        btn_xoa.Enabled = false;
                        btn_inHD.Enabled = false;
                        btn_huy.Enabled = false;
                    }
                }
            }
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            //dua ra thong bao
            DialogResult result = MessageBox.Show("Bạn chắc chắn không điều chỉnh Hóa Đơn này nữa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LamMoiGiaTri();
                lsv_CTHD.Items.Clear();
                HoaDon_Load_1(sender, e);
            }

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

        private void HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void btn_luu_Click(object sender, EventArgs e)
        {

            if (txt_mhd.Text.Length == 0 || dt_nlhd.Text.Length == 0 || cmb_mkh.Text.Length == 0 || cmb_mnv.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !");
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    if (CheckMaHD(Convert.ToInt32(txt_mhd.Text)) == -1)
                    {
                        if (txt_mhd.Text.Length == 0 || dt_nlhd.Text.Length == 0 || cmb_mkh.Text.Length == 0 || cmb_mnv.Text.Length == 0)
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !");
                            return;

                        }
                        else
                        {
                            //neu chua co ma hoa don do thi them vao
                            //luu hoa don
                            ThemHoaDon(connection);
                        }
                    }



                    //luu thong tin chi tiet hoa don
                    if (cmb_MaSach.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if ((txt_soluong.Text.Trim().Length == 0) || (txt_soluong.Text == "0"))
                    {
                        MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_soluong.Text = "";
                        return;
                    }

                    ThemCTHD(connection);
                    HienThiDanhSach();
                    int tongtiencu = LayTongTien(Convert.ToInt32(txt_mhd.Text));
                    int tongtienmoi = tongtiencu + Convert.ToInt32(txt_thanhtien.Text);

                    // Cap nhat tong tien vao database
                    CapNhatTongTien(connection, tongtienmoi);

                    // Cap nhat tong tien
                    txt_tongtien.Text = tongtienmoi.ToString();

                    // Cập nhật giao diện 
                    LamMoiCTHD();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện thao tác với cơ sở dữ liệu: " + ex.Message);
                }
                finally
                {
                    btn_luu.Enabled = true;
                    btn_xoa.Enabled = true;
                    btn_them.Enabled = true;
                    btn_inHD.Enabled = true;
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    cmb_MaSach.Focus();
                }
            }
        }

        private void ThemHoaDon(NpgsqlConnection connection)
        {
            try
            {
                string sql = "INSERT INTO hoa_don ( mahd,tongtien, makh, manv,ngaylap ) VALUES (@mhd, @tt, @mkh, @mnv,@nlhd)";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@mhd", Convert.ToInt32(txt_mhd.Text));
                    command.Parameters.AddWithValue("@nlhd", Convert.ToDateTime(dt_nlhd.Text));
                    command.Parameters.AddWithValue("@tt", Convert.ToInt32(txt_tongtien.Text));
                    command.Parameters.AddWithValue("@mkh", Convert.ToInt32(cmb_mkh.SelectedValue));
                    command.Parameters.AddWithValue("@mnv", Convert.ToInt32(cmb_mnv.SelectedValue));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected <= 0)
                    {
                        MessageBox.Show("Không thể thêm dữ liệu!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thêm dữ liệu: " + ex.Message);
            }

        }


        /*private int TinhTongTien()
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
        }*/

        private int LayTongTien(int mahd)
        {
            int tongtien = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = "SELECT tongtien FROM hoa_don WHERE mahd = @mhd";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@mhd", mahd);
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            tongtien = Convert.ToInt32(result);
                        }

                        // Đóng kết nối
                        connection.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                return tongtien;

            }
        }

        private void lsv_CTHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_CTHD.SelectedItems.Count == 0) return;

            btn_xoa.Enabled = true;
            btn_luu.Enabled = true;
            btn_huy.Enabled = false;
            // Lấy phần tử được chọn trên listview
            ListViewItem lvi = lsv_CTHD.SelectedItems[0];

            // Hiển thị thông tin từ listView sang các TextBox
            cmb_MaSach.Text = lvi.SubItems[1].Text;
            txt_soluong.Text = lvi.SubItems[2].Text;
            txt_Gia.Text = lvi.SubItems[3].Text;
            txt_thanhtien.Text = lvi.SubItems[4].Text;
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
                        int masach = Convert.ToInt32(selectedRow["masach"]);

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

        private void cmb_mkh_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_searchchitiet_Click(object sender, EventArgs e)
        {
            txt_mhd.Text = txt_search.Text;
            loadInfoHoaDon();
            HienThiDanhSach();
            btn_xoa.Enabled = true;
            btn_inHD.Enabled = true;
            btn_luu.Enabled = true;
        }





        private void btn_xoaSach_Click(object sender, EventArgs e)
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
                        int giaxoa = LayGiaTien(Convert.ToInt32(cmb_MaSach.SelectedValue));
                        int soluongxoa = LaySoLuong(Convert.ToInt32(cmb_MaSach.SelectedValue), Convert.ToInt32(txt_mhd.Text));

                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@mhd", Convert.ToInt32(txt_mhd.Text));
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
                        int tongtiencu = LayTongTien(Convert.ToInt32(txt_mhd.Text));
                        int tongtienmoi = tongtiencu - (giaxoa * soluongxoa);

                        // Cap nhat tong tien vao database
                        CapNhatTongTien(connection, tongtienmoi);

                        // Cap nhat tong tien vao textbox
                        txt_tongtien.Text = tongtienmoi.ToString();


                        HienThiDanhSach();
                        btn_luu.Enabled = true;
                        btn_huy.Enabled = true;
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

        private void btn_inHD_Click(object sender, EventArgs e)
        {
            Form_Report_2 form_Report = new Form_Report_2(Convert.ToInt32(txt_mhd.Text));
            form_Report.ShowDialog();
        }

        private void txt_mhd_TextChanged(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
        }

        private void btn_qlkh_Click(object sender, EventArgs e)
        {
            Form_khachhang f = new Form_khachhang();
            f.ShowDialog();
        }
    }
}
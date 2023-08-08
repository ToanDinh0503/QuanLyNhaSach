using Microsoft.VisualBasic;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaSach
{
    public partial class Form_hd : Form
    {
        public Form_hd()
        {
            InitializeComponent();
        }
        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection connpg = null;

        private bool isSuaSachButtonClicked = false;
        private void LayDuLieuComboboxKH()
        {
            string query = "SELECT makh,tenkh FROM khach_hang order by makh";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connpg);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            //do du lieu va combobox
            cbo_kh.ValueMember = "makh";
            cbo_kh.DisplayMember = "tenkh";
            cbo_kh.DataSource = dataTable;
        }
        private void LayDuLieuComboboxNV()
        {
            string query = "SELECT manv,tennv FROM nhan_vien order by manv";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connpg);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);


            //do du lieu va combobox
            cbo_nv.ValueMember = "manv";
            cbo_nv.DisplayMember = "tennv";
            cbo_nv.DataSource = dataTable;
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
            sqlCmd.CommandText = "select mahd,ngaylap,tongtien,tenkh, tennv from hoa_don h, khach_hang k, nhan_vien n where h.makh = k.makh and h.manv = n.manv order by mahd";
            LayDuLieuComboboxKH();
            LayDuLieuComboboxNV();
            sqlCmd.Connection = connpg;
            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            lsv_hd.Items.Clear();
            while (reader.Read())
            {
                int mahd = reader.GetInt32(0);
                DateOnly nlhd = DateOnly.FromDateTime(reader.GetDateTime(1));
                int tongtien = reader.GetInt32(2);
                string tenkh = reader.GetString(3);
                string tennv = reader.GetString(4);


                ListViewItem newitem = new ListViewItem(mahd.ToString());

                newitem.SubItems.Add(nlhd.ToString("MM/dd/yyyy"));
                newitem.SubItems.Add(tongtien.ToString());
                newitem.SubItems.Add(tenkh.ToString());
                newitem.SubItems.Add(tennv.ToString());

                lsv_hd.Items.Add(newitem);
            }
            reader.Close();
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

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dữ liệu đã được xóa thành công!");
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

            }

        }

        private void HoaDon_Load_1(object sender, EventArgs e)
        {
            HienThiDanhSach();
            //ban dau thi tat ca cac textbox deu la read het
            hamtrong(false);
            txt_mhd.Enabled = false;
            txt_mhd.Text = "";
            dt_nlhd.Text = "";
            txt_tt.Text = "";
            cbo_kh.Text = "";
            cbo_nv.Text = "";
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;

            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }
        private void hamtrong(bool true_false)
        {
            dt_nlhd.Enabled = true_false;
            txt_tt.Enabled = true_false;
            cbo_kh.Enabled = true_false;
            cbo_nv.Enabled = true_false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
            isSuaSachButtonClicked = true;
            //ban dau thi cac txt deu la readonly
            hamtrong(true);
            txt_mhd.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            dt_nlhd.Focus();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                        txt_mhd.Text = "";
                        dt_nlhd.Text = "";
                        txt_tt.Text = "";
                        cbo_kh.Text = "";
                        cbo_nv.Text = "";
                        HoaDon_Load_1(sender, e);
                    }
                }
            }
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            //dua ra thong bao
            DialogResult result = MessageBox.Show("Bạn chắc chắn không lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txt_mhd.Text = "";
                dt_nlhd.Text = "";
                txt_tt.Text = "";
                cbo_kh.Text = "";
                cbo_nv.Text = "";
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
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_mhd.Text == "" || dt_nlhd.Text == "" || txt_tt.Text == "" || cbo_kh.Text == "" || cbo_nv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !");
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (isSuaSachButtonClicked) // Kiểm tra nút "Sửa sách" đã được chọn
                    {
                        SuaHoaDon(connection);
                    }
                    txt_tt.Text = tongtien.tongtienmoi.ToString();
                    // Cập nhật giao diện hoặc dữ liệu cần thiết
                    HoaDon_Load_1(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện thao tác với cơ sở dữ liệu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    txt_mhd.Text = "";
                    dt_nlhd.Text = "";
                    txt_tt.Text = "";
                    cbo_kh.Text = "";
                    cbo_nv.Text = "";
                }
            }
        }
        private void SuaHoaDon(NpgsqlConnection connection)
        {
            try
            {
                string sql = "UPDATE hoa_don SET ngaylap = @nlhd, tongtien = @tt, makh = @mkh, manv = @mnv WHERE mahd = @mhd";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@mhd", Convert.ToInt32(txt_mhd.Text));
                    command.Parameters.AddWithValue("@nlhd", Convert.ToDateTime(dt_nlhd.Text));
                    command.Parameters.AddWithValue("@tt", Convert.ToInt32(txt_tt.Text));
                    command.Parameters.AddWithValue("@mkh", Convert.ToInt32(cbo_kh.SelectedValue));
                    command.Parameters.AddWithValue("@mnv", Convert.ToInt32(cbo_nv.SelectedValue));

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
        }



        private void lsv_hd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_hd.SelectedItems.Count == 0) return;

            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            // Lấy phần tử được chọn trên listview
            ListViewItem lvi = lsv_hd.SelectedItems[0];


            // Hiển thị thông tin từ listView sang các TextBox
            txt_mhd.Text = lvi.SubItems[0].Text;
            dt_nlhd.Value = Convert.ToDateTime(lvi.SubItems[1].Text);
            txt_tt.Text = lvi.SubItems[2].Text;
            cbo_kh.Text = lvi.SubItems[3].Text;
            cbo_nv.Text = lvi.SubItems[4].Text;
        }

        private void btn_cthd_Click(object sender, EventArgs e)
        {
            Form_CTHD f = new Form_CTHD();
            f.ShowDialog();
        }



        private void btn_searchchitiet_Click(object sender, EventArgs e)
        {
            try
            {
                int mahdValue; //tao bien kieu int

                // Vxac thuc va chuyen txt.Text qua mahdValue
                if (int.TryParse(txt_search.Text, out mahdValue))
                {
                    if (CheckMaHD(mahdValue) == -1)
                    {
                        MessageBox.Show("Mã Hóa Đơn không hợp lệ");
                        return;
                    }

                    string query = "select mahd,ngaylap,tongtien,tenkh, tennv from hoa_don h, khach_hang k, nhan_vien n where h.makh = k.makh and h.manv = n.manv and h.mahd =@mhd";
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connpg);

                    // gan mahd parameter 
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@mhd", mahdValue);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    //dat cac thong tin vao cac textbox
                    txt_mhd.Text = dataTable.Rows[0]["mahd"].ToString();
                    cbo_kh.Text = dataTable.Rows[0]["tenkh"].ToString();
                    dt_nlhd.Text = dataTable.Rows[0]["ngaylap"].ToString();
                    cbo_nv.Text = dataTable.Rows[0]["tennv"].ToString();
                    txt_tt.Text = dataTable.Rows[0]["tongtien"].ToString();
                    HienThiDanhSach();
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
    }
}
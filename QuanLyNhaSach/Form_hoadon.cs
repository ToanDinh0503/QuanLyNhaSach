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
    public partial class Form_hoadon : Form
    {
        public Form_hoadon()
        {
            InitializeComponent();
        }
        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection connpg = null;

        private bool isThemSachButtonClicked = false;
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
            cbo_nv.DisplayMember = "tenv";
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
            sqlCmd.CommandText = "select mahd,ngaylap,tongtien,tenkh, tennv from hoa_don h, khach_hang k, nhan_vien n where h.makh = k.makh and h.manv = n.manv";
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
        private void HoaDon_Load_1(object sender, EventArgs e)
        {
            HienThiDanhSach();
            //ban dau thi tat ca cac textbox deu la read het
            hamtrong(false);
            txt_mhd.Text = "";
            dt_nlhd.Text = "";
            txt_tt.Text = "";
            cbo_kh.Text = "";
            cbo_nv.Text = "";
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }
        private void hamtrong(bool true_false)
        {
            txt_mhd.Enabled = true_false;
            dt_nlhd.Enabled = true_false;
            txt_tt.Enabled = true_false;
            cbo_kh.Enabled = true_false;
            cbo_nv.Enabled = true_false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            isThemSachButtonClicked = true;
            isSuaSachButtonClicked = false;
            hamtrong(true);
            btn_huy.Enabled = true;
            btn_luu.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

            txt_mhd.Text = "";
            dt_nlhd.Text = "";
            txt_tt.Text = "";
            cbo_kh.Text = "";
            cbo_nv.Text = "";
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {

            isThemSachButtonClicked = false;
            isSuaSachButtonClicked = true;
            //ban dau thi cac txt deu la readonly
            hamtrong(true);

            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
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

                    if (isThemSachButtonClicked) // Kiểm tra nút "Thêm sách" đã được chọn
                    {
                        ThemHoaDon(connection);
                    }
                    else if (isSuaSachButtonClicked) // Kiểm tra nút "Sửa sách" đã được chọn
                    {
                        SuaHoaDon(connection);
                    }

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
                    command.Parameters.AddWithValue("@mahd", txt_mhd.Text);
                    command.Parameters.AddWithValue("@nlhd", dt_nlhd.Text);
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

        private void ThemHoaDon(NpgsqlConnection connection)
        {
            try
            {

                // Tìm mã thể loại dựa trên tên thể loại được chọn
                string sql = "INSERT INTO hoa_don ( ngaylap, tongtien, makh, manv ) VALUES (@nlhd, @tt, @mkh, @mnv)";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@mahd", txt_mhd.Text);
                    command.Parameters.AddWithValue("@nlhd", Convert.ToDateTime(dt_nlhd.Text));
                    command.Parameters.AddWithValue("@tt", Convert.ToInt32(txt_tt.Text));
                    command.Parameters.AddWithValue("@mkh", Convert.ToInt32(cbo_kh.SelectedValue));
                    command.Parameters.AddWithValue("@mnv", Convert.ToInt32(cbo_nv.SelectedValue));

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
                txt_mhd.Text = "";
                dt_nlhd.Text = "";
                txt_tt.Text = "";
                cbo_kh.Text = "";
                cbo_nv.Text = "";
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

            //hoten = lvi.SubItems[0].Text;

            // Hiển thị thông tin từ listView sang các TextBox
            txt_mhd.Text = lvi.SubItems[0].Text;
            dt_nlhd.Value = Convert.ToDateTime(lvi.SubItems[1].Text);
            txt_tt.Text = lvi.SubItems[2].Text;
            cbo_kh.Text = lvi.SubItems[3].Text;
            cbo_nv.Text = lvi.SubItems[4].Text;
        }
    }
}
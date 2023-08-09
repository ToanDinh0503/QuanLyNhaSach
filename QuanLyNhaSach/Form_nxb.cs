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
    public partial class Form_nxb : Form
    {
        public Form_nxb()
        {
            InitializeComponent();
        }
        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection connpg = null;
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
            sqlCmd.CommandText = "select * from nha_xuat_ban order by manxb";
            sqlCmd.Connection = connpg;

            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            lsv_nxb.Items.Clear();
            while (reader.Read())
            {
                int manxb = reader.GetInt32(0);
                string tennxb = reader.GetString(1);

                ListViewItem newitem = new ListViewItem(manxb.ToString());

                newitem.SubItems.Add(tennxb.ToString());

                lsv_nxb.Items.Add(newitem);
            }
            reader.Close();
        }
        private void Form_nxb_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txt_mnxb.Enabled = false;
            hamtrong(false);
            btn_themnxb.Enabled = true;
            btn_suanxb.Enabled = false;
            btn_xoanxb.Enabled = false;
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
        }
        private void hamtrong(bool true_false)
        {
            txt_tnxb.Enabled = true_false;
        }

        private void lsv_nxb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_nxb.SelectedItems.Count == 0) return;

            btn_xoanxb.Enabled = true;
            btn_suanxb.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            // Lấy phần tử được chọn trên listview
            ListViewItem lvi = lsv_nxb.SelectedItems[0];

            //hoten = lvi.SubItems[0].Text;

            // Hiển thị thông tin từ listView sang các TextBox
            txt_mnxb.Text = lvi.SubItems[0].Text;
            txt_tnxb.Text = lvi.SubItems[1].Text;
        }
        private bool isThemNXBButtonClicked = false;
        private bool isSuaNXBButtonClicked = false;
        private void btn_themnxb_Click(object sender, EventArgs e)
        {
            isThemNXBButtonClicked = true;
            isSuaNXBButtonClicked = false;
            txt_mnxb.Enabled = false;
            hamtrong(true);
            btn_suanxb.Enabled = false;
            btn_xoanxb.Enabled = false;
            btn_huy.Enabled = true;
            btn_luu.Enabled = true;

            txt_mnxb.Text = "";
            txt_tnxb.Text = "";
            txt_tnxb.Focus();
        }
        private void btn_suanxb_Click(object sender, EventArgs e)
        {
            isThemNXBButtonClicked = false;
            isSuaNXBButtonClicked = true;
            txt_mnxb.Enabled = false;
            hamtrong(true);
            btn_themnxb.Enabled = false;
            btn_xoanxb.Enabled = false;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            txt_tnxb.Focus();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            //dua ra thong bao
            DialogResult result = MessageBox.Show("Bạn chắc chắn không lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // reset các text
                txt_mnxb.Text = "";
                txt_tnxb.Text = "";

                //cho tat ca cac nut enable = true
                Form_nxb_Load(sender, e);
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

        private void Form_nxb_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_xoanxb_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        string sql = "DELETE FROM nha_xuat_ban WHERE manxb = @mnxb";

                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@mnxb", Convert.ToInt32(txt_mnxb.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Dữ liệu đã được xóa thành công!");
                                Form_nxb_Load(sender, e);
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
                        txt_mnxb.Text = "";
                        txt_tnxb.Text = "";
                        Form_nxb_Load(sender, e);
                    }
                }
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_tnxb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !");
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (isThemNXBButtonClicked) // Kiểm tra nút "Thêm thể loại" đã được chọn
                    {
                        ThemNXB(connection);
                    }
                    else if (isSuaNXBButtonClicked) // Kiểm tra nút "Sửa thể loại" đã được chọn
                    {
                        SuaNXB(connection);
                    }
                    // Cập nhật giao diện hoặc dữ liệu cần thiết
                    Form_nxb_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện thao tác với cơ sở dữ liệu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    txt_mnxb.Text = "";
                    txt_tnxb.Text = "";
                }
            }
        }
        private void ThemNXB(NpgsqlConnection connection)
        {
            try
            {
                string sql = "INSERT INTO nha_xuat_ban (tennxb) VALUES (@tnxb)";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@tnxb", txt_tnxb.Text);

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
                txt_mnxb.Text = "";
                txt_tnxb.Text = "";
            }
        }
        private void SuaNXB(NpgsqlConnection connection)
        {
            try
            {
                string sql = "UPDATE nha_xuat_ban SET tennxb = @tnxb WHERE manxb = @mnxb";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@mnxb", Convert.ToInt32(txt_mnxb.Text));
                    command.Parameters.AddWithValue("@tnxb", txt_tnxb.Text);

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

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_search.Text;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("select manxb, tennxb from nha_xuat_ban where tennxb LIKE  @keyword ", conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    lsv_nxb.Items.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["manxb"].ToString());
                        item.SubItems.Add(row["tennxb"].ToString());

                        lsv_nxb.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm sách: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txt_search.Text = "";
        }
    }
}

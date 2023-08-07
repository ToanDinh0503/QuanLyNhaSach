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
    public partial class Form_theloai : Form
    {
        public Form_theloai()
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
            sqlCmd.CommandText = "select * from the_loai order by matl";
            sqlCmd.Connection = connpg;

            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            lsv_tl.Items.Clear();
            while (reader.Read())
            {
                int matl = reader.GetInt32(0);
                string tentl = reader.GetString(1);

                ListViewItem newitem = new ListViewItem(matl.ToString());

                newitem.SubItems.Add(tentl.ToString());

                lsv_tl.Items.Add(newitem);
            }
            reader.Close();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txt_mtl.Enabled = false;
            hamtrong(false);
            btn_themtl.Enabled = true;
            btn_suatl.Enabled = false;
            btn_xoatl.Enabled = false;
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
        }
        private void hamtrong(bool true_false)
        {
            txt_ttl.Enabled = true_false;
        }

        private void lsv_tl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_tl.SelectedItems.Count == 0) return;

            btn_xoatl.Enabled = true;
            btn_suatl.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            // Lấy phần tử được chọn trên listview
            ListViewItem lvi = lsv_tl.SelectedItems[0];

            //hoten = lvi.SubItems[0].Text;

            // Hiển thị thông tin từ listView sang các TextBox
            txt_mtl.Text = lvi.SubItems[0].Text;
            txt_ttl.Text = lvi.SubItems[1].Text;
        }
        private bool isThemTLButtonClicked = false;
        private bool isSuaTLButtonClicked = false;
        private void btn_themtl_Click(object sender, EventArgs e)
        {
            isThemTLButtonClicked = true;
            isSuaTLButtonClicked = false;
            txt_mtl.Enabled = false;
            hamtrong(true);
            btn_suatl.Enabled = false;
            btn_xoatl.Enabled = false;
            btn_huy.Enabled = true;
            btn_luu.Enabled = true;

            txt_mtl.Text = "";
            txt_ttl.Text = "";
        }

        private void btn_suatl_Click(object sender, EventArgs e)
        {
            isThemTLButtonClicked = false;
            isSuaTLButtonClicked = true;
            txt_mtl.Enabled = false;
            hamtrong(true);

            btn_themtl.Enabled = false;
            btn_xoatl.Enabled = false;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            //dua ra thong bao
            DialogResult result = MessageBox.Show("Bạn chắc chắn không lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // reset các text
                txt_mtl.Text = "";
                txt_ttl.Text = "";

                //cho tat ca cac nut enable = true
                Form7_Load(sender, e);
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

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_xoatl_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        string sql = "DELETE FROM the_loai WHERE matl = @mtl";

                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@mtl", Convert.ToInt32(txt_mtl.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Dữ liệu đã được xóa thành công!");
                                Form7_Load(sender, e);
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
                        txt_mtl.Text = "";
                        txt_ttl.Text = "";
                        Form7_Load(sender, e);
                    }
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_ttl.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !");
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (isThemTLButtonClicked) // Kiểm tra nút "Thêm thể loại" đã được chọn
                    {
                        ThemTL(connection);
                    }
                    else if (isSuaTLButtonClicked) // Kiểm tra nút "Sửa thể loại" đã được chọn
                    {
                        SuaTL(connection);
                    }

                    // Cập nhật giao diện hoặc dữ liệu cần thiết
                    Form7_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện thao tác với cơ sở dữ liệu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    txt_mtl.Text = "";
                    txt_ttl.Text = "";
                }
            }
        }
        private void ThemTL(NpgsqlConnection connection)
        {
            try
            {
                string sql = "INSERT INTO the_loai (tentl) VALUES (@ttl)";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ttl", txt_ttl.Text);

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
                txt_mtl.Text = "";
                txt_ttl.Text = "";
            }
        }
        private void SuaTL(NpgsqlConnection connection)
        {
            try
            {
                string sql = "UPDATE the_loai SET tentl = @ttl WHERE matl = @mtl";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@mtl", Convert.ToInt32(txt_mtl.Text));
                    command.Parameters.AddWithValue("@ttl", txt_ttl.Text);

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
                    NpgsqlCommand cmd = new NpgsqlCommand("select matl, tentl from the_loai where tentl LIKE  @keyword ", conn);
                    cmd.Parameters.AddWithValue("@keyword", keyword);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    lsv_tl.Items.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["matl"].ToString());
                        item.SubItems.Add(row["tentl"].ToString());

                        lsv_tl.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm sách: " + ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txt_search.Text = "";
        }
    }
}

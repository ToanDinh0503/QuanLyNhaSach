using Npgsql;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaSach;

public partial class Form_sach : Form
{

    public Form_sach()
    {
        InitializeComponent();
    }
    private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
    NpgsqlConnection connpg = null;

    private void LayDuLieuComboboxmaTL()
    {
        string query = "SELECT * FROM the_loai order by matl";
        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connpg);
        DataTable dataTable = new DataTable();
        dataAdapter.Fill(dataTable);


        //do du lieu va combobox
        comboBoxTheLoai.ValueMember = "matl";
        comboBoxTheLoai.DisplayMember = "tentl";
        comboBoxTheLoai.DataSource = dataTable;
    }

    private void LayDuLieuComboboxmaNXB()
    {
        string query = "SELECT * FROM nha_xuat_ban order by manxb";
        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connpg);
        DataTable dataTable = new DataTable();
        dataAdapter.Fill(dataTable);


        //do du lieu va combobox
        comboBoxNXB.ValueMember = "manxb";
        comboBoxNXB.DisplayMember = "tennxb";
        comboBoxNXB.DataSource = dataTable;
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
        sqlCmd.CommandText = "select masach,tensach,gia,nam,tennxb,tentl,mota from sach s, the_loai t, nha_xuat_ban n where s.manxb = n.manxb and s.matl = t.matl order by masach";
        LayDuLieuComboboxmaNXB();
        LayDuLieuComboboxmaTL();
        sqlCmd.Connection = connpg;

        NpgsqlDataReader reader = sqlCmd.ExecuteReader();
        lsv_sach.Items.Clear();
        while (reader.Read())
        {
            int masach = reader.GetInt32(0);
            string tensach = reader.GetString(1);
            int gia = reader.GetInt32(2);
            int nam = reader.GetInt32(3);
            string tennxb = reader.GetString(4);
            string tentl = reader.GetString(5);
            string mota = reader.GetString(6);

            ListViewItem newitem = new ListViewItem(masach.ToString());

            newitem.SubItems.Add(tensach.ToString());
            newitem.SubItems.Add(gia.ToString());
            newitem.SubItems.Add(nam.ToString());
            newitem.SubItems.Add(tennxb.ToString());
            newitem.SubItems.Add(tentl.ToString());
            newitem.SubItems.Add(mota.ToString());

            lsv_sach.Items.Add(newitem);
        }
        reader.Close();
    }
    
    private void Form_sach_Load(object sender, EventArgs e)
    {
        HienThiDanhSach();
        //ban dau thi tat ca cac textbox deu la read het
        hamtrong(false);
        comboBoxNXB.Text = "";
        comboBoxTheLoai.Text = "";
        btn_Huy.Enabled = false;
        btn_Luu.Enabled = false;
        btn_themsach.Enabled = true;
        btn_suasach.Enabled = false;
        btn_xoasach.Enabled = false;
    }
    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }
    private bool isThemSachButtonClicked = false;
    private bool isSuaSachButtonClicked = false;
    private void btn_themsach_Click(object sender, EventArgs e)
    {
        isThemSachButtonClicked = true;
        isSuaSachButtonClicked = false;
        hamtrong(true);
        btn_Huy.Enabled = true;
        btn_Luu.Enabled = true;
        btn_suasach.Enabled = false;
        btn_xoasach.Enabled = false;

        txt_ms.Text = "";
        txt_gia.Text = "";
        txt_mt.Text = "";
        txt_nxb.Text = "";
        txt_ts.Text = "";
        comboBoxNXB.Text = "";
        comboBoxTheLoai.Text = "";
    }

    private void btn_suasach_Click(object sender, EventArgs e)
    {
        isThemSachButtonClicked = false;
        isSuaSachButtonClicked = true;
        //ban dau thi cac txt deu la readonly
        hamtrong(true);

        btn_themsach.Enabled = false;
        btn_xoasach.Enabled = false;
        btn_Luu.Enabled = true;
        btn_Huy.Enabled = true;
    }

    private void hamtrong(bool true_false) {
        txt_ms.Enabled = true_false;
        txt_gia.Enabled = true_false;
        txt_mt.Enabled = true_false;
        txt_nxb.Enabled = true_false;
        comboBoxTheLoai.Enabled = true_false;
        txt_ts.Enabled = true_false;
        comboBoxNXB.Enabled = true_false;
    }


    private void btn_xoasach_Click(object sender, EventArgs e)
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
                        command.Parameters.AddWithValue("@ms", Convert.ToInt32(txt_ms.Text));

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dữ liệu đã được xóa thành công!");
                            Form_sach_Load(sender, e);
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
                    txt_ms.Text = "";
                    txt_gia.Text = "";
                    txt_mt.Text = "";
                    txt_nxb.Text = "";
                    txt_ts.Text = "";
                    comboBoxNXB.Text = "";
                    comboBoxTheLoai.Text = "";
                    Form_sach_Load(sender, e);
                }
            }
        }
    }

    private void btn_Luu_Click(object sender, EventArgs e)
    {
        if (txt_ms.Text == "" || txt_ts.Text == "" || txt_mt.Text == "" || txt_gia.Text == "" || txt_nxb.Text == "")
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
                    ThemSach(connection);
                }
                else if (isSuaSachButtonClicked) // Kiểm tra nút "Sửa sách" đã được chọn
                {
                    SuaSach(connection);
                }

                // Cập nhật giao diện hoặc dữ liệu cần thiết
                Form_sach_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thao tác với cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                connection.Close();
                txt_ms.Text = "";
                txt_gia.Text = "";
                txt_mt.Text = "";
                txt_nxb.Text = "";
                txt_ts.Text = "";
                comboBoxNXB.Text = "";
                comboBoxTheLoai.Text = "";
            }
        }
    }

    private void SuaSach(NpgsqlConnection connection)
    {
        try
        {
            string sql = "UPDATE sach SET tensach = @ts, mota = @mt, gia = @g, nam = @n, manxb = @mnxb, matl = @mtl WHERE masach = @ms";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@ms", Convert.ToInt32(txt_ms.Text));
                command.Parameters.AddWithValue("@ts", txt_ts.Text);
                command.Parameters.AddWithValue("@mt", txt_mt.Text);
                command.Parameters.AddWithValue("@g", Convert.ToInt32(txt_gia.Text));
                command.Parameters.AddWithValue("@n", Convert.ToInt32(txt_nxb.Text));
                command.Parameters.AddWithValue("@mnxb", Convert.ToInt32(comboBoxNXB.SelectedValue));
                command.Parameters.AddWithValue("@mtl", Convert.ToInt32(comboBoxTheLoai.SelectedValue));

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

    private void ThemSach(NpgsqlConnection connection)
    {
        try
        {
            string selectedTheLoai = comboBoxTheLoai.SelectedItem.ToString();
            // Tìm mã thể loại dựa trên tên thể loại được chọn
            string sql = "INSERT INTO sach (tensach, mota, gia, nam, manxb, matl) VALUES (@ts, @mt, @g, @n, @mnxb, @mtl)";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@ms", Convert.ToInt32(txt_ms.Text));
                command.Parameters.AddWithValue("@ts", txt_ts.Text);
                command.Parameters.AddWithValue("@mt", txt_mt.Text);
                command.Parameters.AddWithValue("@g", Convert.ToInt32(txt_gia.Text));
                command.Parameters.AddWithValue("@n", Convert.ToInt32(txt_nxb.Text));
                command.Parameters.AddWithValue("@mnxb", Convert.ToInt32(comboBoxNXB.SelectedValue));
                command.Parameters.AddWithValue("@mtl", Convert.ToInt32(comboBoxTheLoai.SelectedValue));

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
            txt_ms.Text = "";
            txt_gia.Text = "";
            txt_mt.Text = "";
            txt_nxb.Text = "";
            txt_ts.Text = "";
            comboBoxNXB.Text = "";
            comboBoxTheLoai.Text = "";
        }  
    }

    private void btn_Huy_Click(object sender, EventArgs e)
    {
        //dua ra thong bao
        DialogResult result = MessageBox.Show("Bạn chắc chắn không lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            // reset các text
            txt_ms.Text = "";
            txt_gia.Text = "";
            txt_mt.Text = "";
            txt_nxb.Text = "";
            txt_ts.Text = "";
            comboBoxNXB.Text = "";
            comboBoxTheLoai.Text = "";

            //cho tat ca cac nut enable = true
            Form_sach_Load(sender, e);
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

    private void lsv_sach_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lsv_sach.SelectedItems.Count == 0) return;

        btn_xoasach.Enabled = true;
        btn_suasach.Enabled = true;
        btn_Luu.Enabled = false;
        btn_Huy.Enabled = false;
        // Lấy phần tử được chọn trên listview
        ListViewItem lvi = lsv_sach.SelectedItems[0];

        //hoten = lvi.SubItems[0].Text;

        // Hiển thị thông tin từ listView sang các TextBox
        txt_ms.Text = lvi.SubItems[0].Text;
        txt_ts.Text = lvi.SubItems[1].Text;
        txt_gia.Text = lvi.SubItems[2].Text;
        txt_nxb.Text = lvi.SubItems[3].Text;
        comboBoxNXB.Text = lvi.SubItems[4].Text;
        comboBoxTheLoai.Text = lvi.SubItems[5].Text;
        txt_mt.Text = lvi.SubItems[6].Text;
    }

    private void btn_search_Click(object sender, EventArgs e)
    {
        string keyword = txt_search.Text;
        using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
        {
            conn.Open();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("select masach,tensach,gia,nam,tennxb,tentl, mota from sach s, the_loai t, nha_xuat_ban n where s.manxb = n.manxb and s.matl = t.matl and tensach LIKE  @keyword ", conn);
                cmd.Parameters.AddWithValue("@keyword", keyword);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                lsv_sach.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["masach"].ToString());
                    item.SubItems.Add(row["tensach"].ToString());
                    item.SubItems.Add(row["gia"].ToString());
                    item.SubItems.Add(row["nam"].ToString());
                    item.SubItems.Add(row["tennxb"].ToString());
                    item.SubItems.Add(row["tentl"].ToString());
                    item.SubItems.Add(row["mota"].ToString());


                    lsv_sach.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm sách: " + ex.Message);
            }
        }
    }

    private void txt_nxb_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            e.Handled = true;
    }

    private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            e.Handled = true;
    }

    private void Form_sach_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
                e.Cancel = true;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        HienThiDanhSach();
        txt_search.Text = "";
        comboBoxNXB.Text = "";
        comboBoxTheLoai.Text = "";
    }
    private void btn_htmt_Click(object sender, EventArgs e)
    {
        if(txt_mt.Text == "")
        {
            return;
        }
        else
        {
            MessageBox.Show(txt_mt.Text);
            // Form f = new Form();
            // f.Text = txt_mt.Text;
            // Application.Run(new f());
        }
    }
}

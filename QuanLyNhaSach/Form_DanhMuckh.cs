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
    public partial class Form_DanhMuckh : Form
    {
        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection connpg = null;
        public Form_DanhMuckh()
        {
            InitializeComponent();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
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
            sqlCmd.CommandText = "select makh,tenkh,diachi,sdt,email" +
                " from khach_hang";

            sqlCmd.Connection = connpg;

            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            lsv_khach.Items.Clear();
            while (reader.Read())
            {
                int makh = reader.GetInt32(0);
                string tenkh = reader.GetString(1);
                string diachi = DataHelpers.GetNonNullString(reader.GetValue(2), "");
                string sdt = DataHelpers.GetNonNullLong(reader.GetValue(3), "");
                //kiem tra coi no co null khong co thi tra ve null
                string email = DataHelpers.GetNonNullString(reader.GetValue(4), "");

                ListViewItem newitem = new ListViewItem(makh.ToString());

                newitem.SubItems.Add(tenkh.ToString());
                newitem.SubItems.Add(diachi);
                newitem.SubItems.Add(sdt.ToString());
                newitem.SubItems.Add(email);

                lsv_khach.Items.Add(newitem);
            }
            reader.Close();
        }
        private void Form_DanhMucNV_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txt_mkh.ReadOnly = true;
            txt_tkh.ReadOnly = true;
            txt_dchi.ReadOnly = true;
            txt_sdt.ReadOnly = true;
            txt_email.ReadOnly = true;
            btn_searchKhach.Focus();
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
                                string diachi = DataHelpers.GetNonNullString(reader.GetValue(2), "");
                                string sdt = DataHelpers.GetNonNullLong(reader.GetValue(3), "");
                                //kiem tra coi no co null khong co thi tra ve null
                                string email = DataHelpers.GetNonNullString(reader.GetValue(4), "");

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

        private void enter(object sender, KeyPressEventArgs e)
        {
            btn_searchKhach_Click(sender, e);
        }

        private void txt_searchKhach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_searchKhach.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txt_mkh.Text = "";
            txt_tkh.Text = "";
            txt_dchi.Text = "";
            txt_sdt.Text = "";
            txt_email.Text = "";
            txt_searchKhach.Text = "";
        }

        private void lsv_khach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_khach.SelectedItems.Count == 0) return;
            ListViewItem lvi = lsv_khach.SelectedItems[0];
            txt_mkh.Text = lvi.SubItems[0].Text;
            txt_tkh.Text = lvi.SubItems[1].Text;
            txt_dchi.Text = lvi.SubItems[2].Text;
            txt_sdt.Text = lvi.SubItems[3].Text;
            txt_email.Text = lvi.SubItems[4].Text;
        }
    }
}

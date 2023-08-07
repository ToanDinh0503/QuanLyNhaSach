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
    public partial class Form_DM_Sach : Form
    {
        public Form_DM_Sach()
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
            sqlCmd.CommandText = "select masach,tensach,gia,nam,tennxb,tentl,mota from sach s, the_loai t, nha_xuat_ban n where s.manxb = n.manxb and s.matl = t.matl order by masach";
            sqlCmd.Connection = connpg;

            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            lsv_dssach.Items.Clear();
            while (reader.Read())
            {
                int masach = reader.GetInt32(0);
                string tensach = reader.GetString(1);
                int gia = reader.GetInt32(2);
                int nam = reader.GetInt32(3);
                string tennxb = reader.GetString(4);
                string tentl = reader.GetString(5);
                String mota = reader.GetString(6);

                ListViewItem newitem = new ListViewItem(masach.ToString());

                newitem.SubItems.Add(tensach.ToString());
                newitem.SubItems.Add(gia.ToString());
                newitem.SubItems.Add(nam.ToString());
                newitem.SubItems.Add(tennxb.ToString());
                newitem.SubItems.Add(tentl.ToString());
                newitem.SubItems.Add(mota.ToString());

                lsv_dssach.Items.Add(newitem);
            }
            reader.Close();
        }
        private void Form_DM_Sach_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txt_ms.ReadOnly = true;
            txt_ts.ReadOnly = true;
            txt_gia.ReadOnly = true;
            txt_nxb.ReadOnly = true;
            txt_nxbb.ReadOnly = true;
            txt_tl.ReadOnly = true;
            txt_mt.ReadOnly = true;
            txt_search.Text = "";
        }

        private void lsv_dssach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_dssach.SelectedItems.Count == 0) return;
            ListViewItem lvi = lsv_dssach.SelectedItems[0];
            txt_ms.Text = lvi.SubItems[0].Text;
            txt_ts.Text = lvi.SubItems[1].Text;
            txt_gia.Text = lvi.SubItems[2].Text;
            txt_nxb.Text = lvi.SubItems[3].Text;
            txt_nxbb.Text = lvi.SubItems[4].Text;
            txt_tl.Text = lvi.SubItems[5].Text;
            txt_mt.Text = lvi.SubItems[6].Text;
        }

        private void btn_htmt_Click(object sender, EventArgs e)
        {
            if (txt_mt.Text == "")
            {
                return;
            }
            else
            {
                MessageBox.Show(txt_mt.Text);
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
                    NpgsqlCommand cmd = new NpgsqlCommand("select masach,tensach,gia,nam,tennxb,tentl, mota from sach s, the_loai t, nha_xuat_ban n where s.manxb = n.manxb and s.matl = t.matl and tensach LIKE  @keyword ", conn);
                    cmd.Parameters.AddWithValue("@keyword", keyword);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    lsv_dssach.Items.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["masach"].ToString());
                        item.SubItems.Add(row["tensach"].ToString());
                        item.SubItems.Add(row["gia"].ToString());
                        item.SubItems.Add(row["nam"].ToString());
                        item.SubItems.Add(row["tennxb"].ToString());
                        item.SubItems.Add(row["tentl"].ToString());
                        item.SubItems.Add(row["mota"].ToString());


                        lsv_dssach.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm sách: " + ex.Message);
                }
            }
        }

        private void btn_htds_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txt_ms.Text = "";
            txt_ts.Text = "";
            txt_gia.Text = "";
            txt_nxb.Text = "";
            txt_nxbb.Text = "";
            txt_tl.Text = "";
            txt_mt.Text = "";
            txt_search.Text = "";
        }

        private void Form_DM_Sach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

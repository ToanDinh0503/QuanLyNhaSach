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

namespace QuanLyNhaSach
{
    public partial class Form_LoaiSach : Form
    {
        public Form_LoaiSach()
        {
            InitializeComponent();
        }
        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection connpg = null;
        private void Form_LoaiSach_Load(object sender, EventArgs e)
        {
            txt_ms.ReadOnly = true;
            txt_ts.ReadOnly = true;
            txt_gia.ReadOnly = true;
            txt_nxb.ReadOnly = true;
            txt_nxbb.ReadOnly = true;
            txt_tl.ReadOnly = true;
            txt_mt.ReadOnly = true;
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

            // thực thi
            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            cbo_nhomsach.Items.Clear();
            while (reader.Read())
            {
                int matl = reader.GetInt32(0);
                string tentl = reader.GetString(1);

                String line = matl + "  /  " + tentl;
                cbo_nhomsach.Items.Add(line);
            }
            reader.Close();
        }
        int matl;
        private void cbo_nhomsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_nhomsach.SelectedIndex == -1) return;

            string line = cbo_nhomsach.SelectedItem.ToString();
            string[] arr = line.Split('/');
            matl = Convert.ToInt32(arr[0]);

            // Hiển thị thông tin sách theo nhóm
            HienThiThongTinSach(matl);
        }

        private void HienThiThongTinSach(int matl)
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
            sqlCmd.CommandText = "SELECT s.masach, s.tensach, s.gia, s.nam, n.tennxb, t.tentl, mota FROM sach s, the_loai t, nha_xuat_ban n WHERE s.matl = t.matl AND s.manxb = n.manxb AND s.matl = '" + matl + "'";
            sqlCmd.Connection = connpg;

            // thực thi
            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            lsv_nhomsach.Items.Clear();
            while (reader.Read())
            {
                int masach = reader.GetInt32(0);
                string tensach = reader.GetString(1);
                int gia = reader.GetInt32(2);
                int nam = reader.GetInt32(3);
                string tennxb = reader.GetString(4);
                string tentl = reader.GetString(5);
                string mota = reader.GetString(6);

                ListViewItem lvi = new ListViewItem(masach.ToString());
                lvi.SubItems.Add(tensach);
                lvi.SubItems.Add(gia.ToString());
                lvi.SubItems.Add(nam.ToString());
                lvi.SubItems.Add(tennxb);
                lvi.SubItems.Add(tentl);
                lvi.SubItems.Add(mota);

                lsv_nhomsach.Items.Add(lvi);
            }
            reader.Close();
        }
        int idmasach;
        private void lsv_nhomsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_nhomsach.SelectedItems.Count == 0) return;
            ListViewItem lvi = lsv_nhomsach.SelectedItems[0];
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

        private void btn_htds_Click(object sender, EventArgs e)
        {
            Form_LoaiSach_Load(sender, e);
            txt_ms.Text = "";
            txt_ts.Text = "";
            txt_gia.Text = "";
            txt_nxb.Text = "";
            txt_nxbb.Text = "";
            txt_tl.Text = "";
            txt_mt.Text = "";
            cbo_nhomsach.Text = "";
        }

        private void Form_LoaiSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

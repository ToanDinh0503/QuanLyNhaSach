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
            sqlCmd.CommandText = "SELECT s.masach, s.tensach, s.gia, s.nam, n.tennxb, t.tentl FROM sach s, the_loai t, nha_xuat_ban n WHERE s.matl = t.matl AND s.manxb = n.manxb AND s.matl = '" + matl + "'";
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

                ListViewItem lvi = new ListViewItem(masach.ToString());
                lvi.SubItems.Add(tensach);
                lvi.SubItems.Add(gia.ToString());
                lvi.SubItems.Add(nam.ToString());
                lvi.SubItems.Add(tennxb);
                lvi.SubItems.Add(tentl);

                lsv_nhomsach.Items.Add(lvi);
            }
            reader.Close();
        }
        int idmasach;
        private void lsv_nhomsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_nhomsach.SelectedItems.Count == 0) return;
            // Lấy phần tử được chọn trên listview
            ListViewItem lvi = lsv_nhomsach.SelectedItems[0];

            idmasach = int.Parse(lvi.SubItems[0].Text);

            // Hiển thị thông tin từ listView sang các TextBox
            MessageBox.Show("                       THÔNG TIN SÁCH" + "\n" + "\n" + 
                "Mã sách: " + lvi.SubItems[0].Text + "\n" + "\n" +
                "Tên sách: " + lvi.SubItems[1].Text + "\n" + "\n" +
                "Giá: " + lvi.SubItems[2].Text + "\n" + "\n" +
                "Năm: " + lvi.SubItems[3].Text + "\n" + "\n" +
                "Nhà Xuất Bản: " + lvi.SubItems[4].Text + "\n" + "\n" +
                "Thể Loại: " + lvi.SubItems[5].Text + "\n" + "\n");
        }
    }
}

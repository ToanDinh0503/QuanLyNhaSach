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
            sqlCmd.CommandText = "select masach,tensach,gia,nam,tennxb,tentl from sach s, the_loai t, nha_xuat_ban n where s.manxb = n.manxb and s.matl = t.matl order by masach";
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

                ListViewItem newitem = new ListViewItem(masach.ToString());

                newitem.SubItems.Add(tensach.ToString());
                newitem.SubItems.Add(gia.ToString());
                newitem.SubItems.Add(nam.ToString());
                newitem.SubItems.Add(tennxb.ToString());
                newitem.SubItems.Add(tentl.ToString());

                lsv_dssach.Items.Add(newitem);
            }
            reader.Close();
        }
        private void Form_DM_Sach_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void lsv_dssach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_dssach.SelectedItems.Count == 0) return;
            // Lấy phần tử được chọn trên listview
            ListViewItem lvi = lsv_dssach.SelectedItems[0];

            // Hiển thị thông tin từ listView sang các messageBox
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

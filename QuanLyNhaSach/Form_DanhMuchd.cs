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
    public partial class Form_DanhMucHD : Form
    {
        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection connpg = null;
        public Form_DanhMucHD()
        {
            InitializeComponent();
        }
        private void FormHD_FormClosing(object sender, FormClosingEventArgs e)
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
            sqlCmd.CommandText = "select mahd,ngaylap,tongtien,tenkh,tennv from hoa_don h, nhan_vien n, khach_hang k where h.manv = n.manv and h.makh = k.makh";

            sqlCmd.Connection = connpg;

            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            lsv_dmhd.Items.Clear();
            while (reader.Read())
            {
                int mahd = reader.GetInt32(0);
                DateOnly nlhd = DateOnly.FromDateTime(reader.GetDateTime(1));
                //kiem tra coi no co null khong co thi tra ve null
                int tongtien = reader.GetInt32(2);
                string tenkh = reader.GetString(3);
                string tennv = reader.GetString(4);

                ListViewItem newitem = new ListViewItem(mahd.ToString());
                newitem.SubItems.Add(nlhd.ToString("MM/dd/yyyy"));
                newitem.SubItems.Add(tongtien.ToString());
                newitem.SubItems.Add(tenkh);
                newitem.SubItems.Add(tennv);

                lsv_dmhd.Items.Add(newitem);
            }
            reader.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txt_mhd.Text = "";
            txt_nlhd.Text = "";
            txt_tt.Text = "";
            txt_kh.Text = "";
            txt_nv.Text = "";
        }

        private void Form_DanhMucHD_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txt_mhd.ReadOnly = true;
            txt_nlhd.ReadOnly = true;
            txt_tt.ReadOnly = true;
            txt_kh.ReadOnly = true;
            txt_nv.ReadOnly = true;
        }

        private void lsv_dmhd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_dmhd.SelectedItems.Count == 0) return;

            ListViewItem lvi = lsv_dmhd.SelectedItems[0];
            txt_mhd.Text = lvi.SubItems[0].Text;
            txt_nlhd.Text = lvi.SubItems[1].Text;
            txt_tt.Text = lvi.SubItems[2].Text;
            txt_kh.Text = lvi.SubItems[3].Text;
            txt_nv.Text = lvi.SubItems[4].Text;
        }
    }
}

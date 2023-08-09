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
    public partial class Form_DanhMucNV : Form
    {
        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection connpg = null;
        public Form_DanhMucNV()
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
            NhanVien nv = new NhanVien();
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
            sqlCmd.CommandText = "select manv, taikhoan, matkhau, tennv, diachi, sdt, tenvt, ngaythangnamsinh,gioitinh from nhan_vien nv inner join vai_tro vt on nv.mavt = vt.mavt";

            sqlCmd.Connection = connpg;

            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            lsv_dsnv.Items.Clear();
            while (reader.Read())
            {
                nv.manv = reader.GetInt32(0);
                nv.taikhoan = reader.GetString(1);
                nv.matkhau = reader.GetString(2);
                nv.tennv = reader.GetString(3);

                nv.diachi = reader.GetString(4);
                nv.sdt = reader.GetInt64(5);
                nv.tenvt = reader.GetString(6);
                nv.ngaysinh = DateOnly.FromDateTime(reader.GetDateTime(7));
                nv.gioitinh = reader.GetBoolean(8);

                ListViewItem newitem = new ListViewItem(nv.manv.ToString());

                newitem.SubItems.Add(nv.tennv.ToString());

                if (nv.gioitinh == true)
                {
                    newitem.SubItems.Add("Nam");
                }
                else
                {
                    newitem.SubItems.Add("Nữ");
                }
                newitem.SubItems.Add(nv.sdt.ToString());
                newitem.SubItems.Add(nv.ngaysinh.ToString("MM/dd/yyyy"));
                newitem.SubItems.Add(nv.diachi.ToString());
                newitem.SubItems.Add(nv.tenvt.ToString());
                newitem.SubItems.Add(nv.taikhoan.ToString());

                newitem.SubItems.Add(nv.matkhau.ToString());



                lsv_dsnv.Items.Add(newitem);
            }
            reader.Close();
        }
        private void Form_DanhMucNV_Load(object sender, EventArgs e)
        {

            HienThiDanhSach();
            txt_mnv.ReadOnly = true;
            txt_tnv.ReadOnly = true;
            txt_gt.ReadOnly = true;
            txt_sdt.ReadOnly = true;
            txt_ns.ReadOnly = true;
            txt_diachi.ReadOnly = true;
            txt_vt.ReadOnly = true;
            txt_search.Focus();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            string searchString = txt_search.Text.Trim(); // Giá trị tìm kiếm từ TextBox
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = "SELECT manv, taikhoan, matkhau, tennv, diachi, sdt, tenvt, ngaythangnamsinh,gioitinh FROM nhan_vien nv inner join vai_tro vt on nv.mavt = vt.mavt  WHERE tennv LIKE @search";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@search", "%" + searchString + "%");
                        NpgsqlDataReader reader = command.ExecuteReader();
                        lsv_dsnv.Items.Clear();
                        while (reader.Read())
                        {
                            nv.manv = reader.GetInt32(0);
                            nv.taikhoan = reader.GetString(1);
                            nv.matkhau = reader.GetString(2);
                            nv.tennv = reader.GetString(3);

                            nv.diachi = reader.GetString(4);
                            nv.sdt = reader.GetInt64(5);
                            nv.tenvt = reader.GetString(6);
                            nv.ngaysinh = DateOnly.FromDateTime(reader.GetDateTime(7));
                            nv.gioitinh = reader.GetBoolean(8);

                            ListViewItem newitem = new ListViewItem(nv.manv.ToString());

                            newitem.SubItems.Add(nv.tennv.ToString());

                            if (nv.gioitinh == true)
                            {
                                newitem.SubItems.Add("Nam");
                            }
                            else
                            {
                                newitem.SubItems.Add("Nữ");
                            }
                            newitem.SubItems.Add(nv.sdt.ToString());
                            newitem.SubItems.Add(nv.ngaysinh.ToString());
                            newitem.SubItems.Add(nv.diachi.ToString());
                            newitem.SubItems.Add(nv.tenvt.ToString());
                            newitem.SubItems.Add(nv.taikhoan.ToString());

                            newitem.SubItems.Add(nv.matkhau.ToString());



                            lsv_dsnv.Items.Add(newitem);
                        }
                        reader.Close();



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

        private void btn_hiendanhsach_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txt_mnv.Text = "";
            txt_tnv.Text = "";
            txt_gt.Text = "";
            txt_sdt.Text = "";
            txt_ns.Text = "";
            txt_diachi.Text = "";
            txt_vt.Text = "";
            txt_search.Text = "";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }

        private void lsv_dsnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_dsnv.SelectedItems.Count == 0) return;

            ListViewItem lvi = lsv_dsnv.SelectedItems[0];

            //hoten = lvi.SubItems[0].Text;

            // Hiển thị thông tin từ listView sang các TextBox
            txt_mnv.Text = lvi.SubItems[0].Text;
            txt_tnv.Text = lvi.SubItems[1].Text;
            txt_gt.Text = lvi.SubItems[2].Text;

            txt_sdt.Text = lvi.SubItems[3].Text;
            txt_ns.Text = lvi.SubItems[4].Text;

            txt_diachi.Text = lvi.SubItems[5].Text;
            txt_vt.Text = lvi.SubItems[6].Text;
        }
    }
}

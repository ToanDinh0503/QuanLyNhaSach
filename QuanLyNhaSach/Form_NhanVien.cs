using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaSach
{
    public partial class Form_NhanVien : Form
    {
        private bool isThemNhanVienButtonClicked = false;
        private bool isSuaNhanVienButtonClicked = false;
        private class NhanVien
        {

            public int manv;
            public string taikhoan;
            public string matkhau;
            public string tennv;
            public string diachi;
            public int sdt;
            public string tenvt;
            public DateOnly ngaysinh;
            public bool gioitinh;
        }

        public Form_NhanVien()
        {
            InitializeComponent();
            hienThiDuLieuVao_Combobox_VaiTro();
        }
        private static string connectionString = "Host=localhost;Database=QuanLyNhaSach2;Username=postgres;Password=123456";
        NpgsqlConnection connpg = null;

        private void trangThaiCacTextBox(bool true_false)
        {
            txb_diachi.Enabled = true_false;
            txb_hoten.Enabled = true_false;
            txb_manv.Enabled = true_false;
            txb_matkhau.Enabled = true_false;
            txb_taikhoan.Enabled = true_false;
            cld_ngaysinh.Enabled = true_false;
            chb_nam.Enabled = true_false;
            chb_nu.Enabled = true_false;
            cbx_vaitro.Enabled = true_false;
            txb_sdt.Enabled = true_false;
        }

        private void lamTrongCacTextBox()
        {
            txb_diachi.Text = string.Empty;
            txb_hoten.Text = string.Empty;
            txb_manv.Text = string.Empty;
            txb_matkhau.Text = string.Empty;
            txb_sdt.Text = string.Empty;
            txb_taikhoan.Text = string.Empty;
            cbx_vaitro.Text = string.Empty;
            chb_nam.Checked = false;
            chb_nu.Checked = false;
            cld_ngaysinh.Value = Convert.ToDateTime("01/01/2000");

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
            lsv_danhsach.Items.Clear();
            while (reader.Read())
            {
                nv.manv = reader.GetInt32(0);
                nv.taikhoan = reader.GetString(1);
                nv.matkhau = reader.GetString(2);
                nv.tennv = reader.GetString(3);

                nv.diachi = reader.GetString(4);
                nv.sdt = reader.GetInt32(5);
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



                lsv_danhsach.Items.Add(newitem);
            }
            reader.Close();
        }


        private void hienThiDuLieuVao_Combobox_VaiTro()
        {
            if (connpg == null)
            {
                connpg = new NpgsqlConnection(connectionString);
            }
            if (connpg.State == ConnectionState.Closed)
            {
                connpg.Open(); // Đóng thì mở
            }

            string sql = "SELECT * FROM vai_tro ORDER BY mavt";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connpg))
            {
                NpgsqlDataReader reader;
                try
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string tenVaiTro = reader.GetString("tenvt");
                        cbx_vaitro.Items.Add(tenVaiTro);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connpg.Close();
                }
            }
        }

        private void Form_data_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            //ban dau thi tat ca cac textbox deu la read het
            lamTrongCacTextBox();
            trangThaiCacTextBox(false);
            btn_them.Enabled = true;
            btn_LamMoi.Enabled = false;
            btn_Luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }


        /*private void button2_Click(object sender, EventArgs e)
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
                            command.Parameters.AddWithValue("@ms", Convert.ToInt32(txb_manv.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Dữ liệu đã được xóa thành công!");
                                Form_data_Load(sender, e);
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
                    }
                }
            }
        }*/





        private void btn_suasach_Click(object sender, EventArgs e)
        {
            isThemNhanVienButtonClicked = false;
            isSuaNhanVienButtonClicked = true;
            //ban dau thi cac txt deu la disable
            trangThaiCacTextBox(false);

            btn_Luu.Enabled = true;
            btn_LamMoi.Enabled = true;
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            //phai chon truoc moi sua duoc
            trangThaiCacTextBox(true);

        }
        //sua


        private void btn_thoat_Click(object sender, EventArgs e)
        {

            Close();
        }
        private void Form_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchString = txt_search.Text.Trim(); // Giá trị tìm kiếm từ TextBox
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sql = "SELECT * FROM sach WHERE tensach LIKE @search";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@search", "%" + searchString + "%");

                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);


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



        // private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        // {
        //     if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
        //       e.Handled = true;
        ///}









        private void lsv_danhsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_danhsach.SelectedItems.Count == 0) return;

            trangThaiCacTextBox(false);

            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_Luu.Enabled = false;
            // Lấy phần tử được chọn trên listview
            ListViewItem lvi = lsv_danhsach.SelectedItems[0];

            //hoten = lvi.SubItems[0].Text;

            // Hiển thị thông tin từ listView sang các TextBox
            txb_manv.Text = lvi.SubItems[0].Text;
            txb_hoten.Text = lvi.SubItems[1].Text;
            if (lvi.SubItems[2].Text == "Nam")
            {
                chb_nam.Checked = true;
            }
            else if (lvi.SubItems[2].Text == "Nữ")
            {
                chb_nu.Checked = true;
            }

            txb_sdt.Text = lvi.SubItems[3].Text;
            cld_ngaysinh.Value = Convert.ToDateTime(lvi.SubItems[4].Text);

            txb_diachi.Text = lvi.SubItems[5].Text;
            cbx_vaitro.Text = lvi.SubItems[6].Text;
            txb_taikhoan.Text = lvi.SubItems[7].Text;
            txb_matkhau.Text = lvi.SubItems[8].Text;


        }


        private void suaNhanVien(NpgsqlConnection connection)
        {
            try
            {
                string sql = "UPDATE nhan_vien SET tennv = @tennv,taikhoan = @taikhoan, matkhau = @matkhau, diachi = @diachi, sdt = @sdt, mavt = @mavt, ngaythangnamsinh = @ngaythangnamsinh, gioitinh = @gioitinh WHERE manv = @manv";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@manv", Convert.ToInt32(txb_manv.Text));
                    command.Parameters.AddWithValue("@tennv", txb_hoten.Text);
                    command.Parameters.AddWithValue("@taikhoan", txb_taikhoan.Text);
                    command.Parameters.AddWithValue("@matkhau", txb_matkhau.Text);
                    command.Parameters.AddWithValue("@diachi", txb_diachi.Text);
                    command.Parameters.AddWithValue("@sdt", Convert.ToInt32(txb_sdt.Text));
                    if (cbx_vaitro.Text == "Nhân viên bán sách")
                    {
                        command.Parameters.AddWithValue("@mavt", 2);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@mavt", 1);
                    }
                    command.Parameters.AddWithValue("@ngaythangnamsinh", cld_ngaysinh.Value);
                    if (chb_nam.Checked)
                    {
                        command.Parameters.AddWithValue("@gioitinh", true);
                    }
                    else if (chb_nu.Checked)
                    {
                        command.Parameters.AddWithValue("@gioitinh", false);
                    }

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dữ liệu đã được sửa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa dữ liệu!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện sửa dữ liệu: " + ex.Message);
            }
            finally
            {
                connection.Close();
                lamTrongCacTextBox();
            }
        }
        private void themNhanVien(NpgsqlConnection connection)
        {
            try
            {
                string sql = "INSERT INTO nhan_vien(tennv,taikhoan,matkhau,diachi,sdt,mavt,ngaythangnamsinh,gioitinh)" +
                    " VALUES (@tennv,@taikhoan,@matkhau,@diachi,@sdt,@mavt,@ngaythangnamsinh,@gioitinh)";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@tennv", txb_hoten.Text);
                    command.Parameters.AddWithValue("@taikhoan", txb_taikhoan.Text);
                    command.Parameters.AddWithValue("@matkhau", txb_matkhau.Text);
                    command.Parameters.AddWithValue("@diachi", txb_diachi.Text);
                    command.Parameters.AddWithValue("@sdt", Convert.ToInt32(txb_sdt.Text));

                    if (cbx_vaitro.Text == "Nhân viên bán sách")
                    {
                        command.Parameters.AddWithValue("@mavt", 2);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@mavt", 1);
                    }
                    command.Parameters.AddWithValue("@ngaythangnamsinh", cld_ngaysinh.Value);
                    if (chb_nam.Checked)
                    {
                        command.Parameters.AddWithValue("@gioitinh", true);
                    }
                    else if (chb_nu.Checked)
                    {
                        command.Parameters.AddWithValue("@gioitinh", false);
                    }

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

            }
            lamTrongCacTextBox();
        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {


            if (txb_diachi.Text == "" || txb_hoten.Text == "" || txb_matkhau.Text == "" || txb_sdt.Text == ""
                || txb_taikhoan.Text == "" || (chb_nam.Checked == false && chb_nu.Checked == false) || cld_ngaysinh.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !");
                return;
            }



            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {

                try
                {
                    connection.Open();

                    if (isThemNhanVienButtonClicked)
                    {
                        themNhanVien(connection);
                    }
                    else if (isSuaNhanVienButtonClicked)
                    {
                        suaNhanVien(connection);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện thao tác với dữ liệu: " + ex.Message);
                    return;

                }
                finally
                {
                    connection.Close();



                }
                btn_LamMoi_Click(sender, e);

                HienThiDanhSach();

            }

        }






        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Form_data_Load(sender, e);
        }

        private void chb_nam_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chb_nam.Checked)
            {
                chb_nu.Checked = false;
            }
        }

        private void chb_nu_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chb_nu.Checked)
            {
                chb_nam.Checked = false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txb_diachi.TabIndex = 0;
            isThemNhanVienButtonClicked = true;
            isSuaNhanVienButtonClicked = false;
            lamTrongCacTextBox();
            trangThaiCacTextBox(true);
            btn_LamMoi.Enabled = true;
            btn_Luu.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {

                if (connpg == null)
                {
                    connpg = new NpgsqlConnection(connectionString);
                }
                if (connpg.State == ConnectionState.Closed)
                {
                    connpg.Open(); // Đóng thì mở
                }


                try
                {

                    string sql = "DELETE FROM nhan_vien WHERE manv = @manv";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connpg))
                    {
                        command.Parameters.AddWithValue("@manv", Convert.ToInt32(txb_manv.Text));

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện thao tác với dữ liệu: " + ex.Message);
                }
                finally
                {
                    HienThiDanhSach();
                    connpg.Close();

                }
            }
        }

        private void btn_search_Click_1(object sender, EventArgs e)
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
                        lsv_danhsach.Items.Clear();
                        while (reader.Read())
                        {
                            nv.manv = reader.GetInt32(0);
                            nv.taikhoan = reader.GetString(1);
                            nv.matkhau = reader.GetString(2);
                            nv.tennv = reader.GetString(3);

                            nv.diachi = reader.GetString(4);
                            nv.sdt = reader.GetInt32(5);
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



                            lsv_danhsach.Items.Add(newitem);
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
        }

        private void txb_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }


    }
}

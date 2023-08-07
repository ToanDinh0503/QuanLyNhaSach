using Microsoft.Reporting.WinForms;
using Npgsql;
using NpgsqlTypes;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QuanLyNhaSach
{
    public partial class Form_Report_2 : Form
    {
        int mahd = 0;
        public Form_Report_2(int mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }
        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection connpg = null;

        private DataTable TongTienInfo()
        {
            DataTable dt = new DataTable();
            if (connpg == null)
            {
                connpg = new NpgsqlConnection(connectionString);
            }

            if (connpg.State == ConnectionState.Closed)
            {
                connpg.Open(); // Đóng thì mở
            }
       
            NpgsqlCommand sqlCmd = new NpgsqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM hoa_don Where mahd = @mhd";
            sqlCmd.Parameters.AddWithValue("@mhd", mahd);
            sqlCmd.Connection = connpg;
            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            dt.Load(reader);

            return dt;
        }

        private DataTable CTHDInfo()
        {
            DataTable dt = new DataTable();
            if (connpg == null)
            {
                connpg = new NpgsqlConnection(connectionString);
            }

            if (connpg.State == ConnectionState.Closed)
            {
                connpg.Open(); // Đóng thì mở
            }

            NpgsqlCommand sqlCmd = new NpgsqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT c.mahd,c.masach,s.tensach,s.gia,c.soluong,c.thanhtien FROM chi_tiet_hoa_don c inner join sach s on c.masach=s.masach Where c.mahd = @mhd";
            sqlCmd.Parameters.AddWithValue("@mhd", mahd);
            sqlCmd.Connection = connpg;
            NpgsqlDataReader reader = sqlCmd.ExecuteReader();
            dt.Load(reader);

            return dt;
        }

        private void Form_Report_BanHang_Load(object sender, EventArgs e)
        {
            try
            {
                if (connpg == null)
                {
                    connpg = new NpgsqlConnection(connectionString);
                }
                if (connpg.State == ConnectionState.Closed)
                {
                    connpg.Open(); // Đóng thì mở
                }

                //them cai source cua cai report
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaSach.ReportDestination.Report_HoaDon.rdlc";


                ReportDataSource cthdinf = new ReportDataSource("DataSet1", CTHDInfo());
                ReportDataSource tongtieninf = new ReportDataSource("DataSet2", TongTienInfo());

                reportViewer1.LocalReport.DataSources.Add(cthdinf);
                reportViewer1.LocalReport.DataSources.Add(tongtieninf);

                // dong ket noi
                connpg.Close();

                // lam moi report de hien thi du lieu
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

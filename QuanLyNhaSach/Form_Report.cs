using Microsoft.Reporting.WinForms;
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
    public partial class Form_Report : Form
    {
        public Form_Report()
        {
            InitializeComponent();
        }
        private static string connectionString = "Host=localhost;Database=QLNS;Username=postgres;Password=12345";
        NpgsqlConnection connpg = null;

        private void Form_Report_Load_1(object sender, EventArgs e)
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
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaSach.ReportDestination.Report_Tien.rdlc";


                // lay data va dua vao data table
                string query = "SELECT c.mahd,c.masach,s.tensach,s.gia,c.soluong,c.thanhtien FROM chi_tiet_hoa_don c inner join sach s on c.masach=s.masach";
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connpg);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                //xoa data soucre dang ton tai
                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource reportDataSource = new ReportDataSource("DataSet2", dataTable);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

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
    }
}

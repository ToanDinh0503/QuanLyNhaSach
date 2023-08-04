using QuanLyNhaSach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            // Application.Run(new Form_datagrid());
            // Application.Run(new Form_theloai());
            // Application.Run(new Form_sach());
            // Application.Run(new Form_nxb());
            // Application.Run(new Form4());
            // Application.Run(new Form_LoaiSach());
            // Application.Run(new Form_DM_Sach());
            // Application.Run(new Form_DM_nxb());
            // Application.Run(new Form_khachhang());
            Application.Run(new Form_DangNhap());
        }
    }
}

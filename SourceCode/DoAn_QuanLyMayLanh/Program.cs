using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//DO AN MON CONG NGHE .NET DUOC THUC HIEN BOI:
//TRAN HUU LOI - 2001181186
//KAN BICH SUONG - 2001181300
namespace DoAn_QuanLyMayLanh
{
    static class Program
    {
        public static XuLy data = new XuLy();
        public static int MaNV = -1;
        public static int LoaiNV = -1;
        public static string TenNV = string.Empty;
        public static string MaNhap = string.Empty;
        public static string MaHD = string.Empty;
        public static string MK = string.Empty;
        public static Main mainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new Main();
            Application.Run(mainForm);
        }
    }
}

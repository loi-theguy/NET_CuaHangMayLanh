using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn_QuanLyMayLanh
{
    public partial class XuLy
    {
        DataSet ds;
        string connectionString="Data Source=RURI-PC\\SQLEXPRESS;Initial Catalog=QL_MAYLANH2;Integrated Security=true";
        SqlConnection connection;
        int MAX_ID_SP = -1;
        int MAX_ID_NSX = -1;
        int MAX_ID_NV = -1;
        int MAX_ID_NK = -1;
        int MAX_ID_KH = -1;
        public XuLy()
        {
            ds = new DataSet();
            connection = new SqlConnection(connectionString);
            InitSanPham();
            InitKhachHang();
            InitNhanVien();
            InitNhapKho();
            InitHoaDon();
        }
        public static bool isNumber(string s)
        {
            try
            {
                int.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void RefreshAll()
        {
            RefreshSanPham();
            RefreshNSX();
            RefreshNhapKho();
            RefreshNhanVien();
            RefreshKhachHang();
            RefreshHoaDon();
        }
        public bool DangNhap(string user, string mk)
        { 
            DataRow row=null;
            for(int i=0;i<DS_NhanVien.Rows.Count;i++)
                if (DS_NhanVien.Rows[i]["USERNAME"].ToString() == user)
                {
                    row = DS_NhanVien.Rows[i];
                    break;
                }
            if (row == null) return false;
            if (row["MATKHAU"].ToString() != mk) return false;
            Program.LoaiNV = (int)row["LOAI"];
            Program.MaNV = (int)row["MANV"];
            Program.TenNV=row["HOTEN"].ToString();
            Program.MK = mk;
            return true;
        }
        public void DoiMatKhau(string mk)
        {
            for (int i = 0; i < DS_NhanVien.Rows.Count; i++)
                if ((int)DS_NhanVien.Rows[i]["MANV"] == Program.MaNV)
                {
                    DS_NhanVien.Rows[i]["MATKHAU"] = mk ;
                    SaveChanges_NhanVien();
                    RefreshNhanVien();
                    break;
                }

        }
        
        public bool Can_NhanVien_Be_Deleted(int maNV)
        {

            for (int i = 0; i < DS_HoaDon.Rows.Count; i++)
                if ((int)DS_HoaDon.Rows[i]["MANV"] == maNV)
                {
                    return false;
                }
            for (int i = 0; i < DS_NhapKho.Rows.Count; i++)
                if ((int)DS_NhapKho.Rows[i]["MANV"] == maNV)
                {
                    return false;
                }
            return true;
        }
        public bool Can_NSX_Be_Deleted(int maNSX)
        {

            for (int i = 0; i < DS_SanPham.Rows.Count; i++)
                if ((int)DS_SanPham.Rows[i]["MANSX"] == maNSX)
                {
                    return false;
                }
            return true;
        }
        public bool Can_SanPham_Be_Deleted(int maSP)
        {

            for (int i = 0; i < DS_ChiTiet_HoaDon.Rows.Count; i++)
                if ((int)DS_ChiTiet_HoaDon.Rows[i]["MASP"] == maSP)
                {
                    return false;
                }
            for (int i = 0; i < DS_ChiTiet_NhapKho.Rows.Count; i++)
                if ((int)DS_ChiTiet_NhapKho.Rows[i]["MASP"] == maSP)
                {
                    return false;
                }
            return true;
        }
        public bool Can_KhachHang_Be_Deleted(int maKH)
        {
            for (int i = 0; i < DS_HoaDon.Rows.Count; i++)
                if ((int)DS_HoaDon.Rows[i]["MAKH"] == maKH)
                {
                    return false;
                }
            return true;
        }
        public bool IsUsernameUsable(string user)
        {
            for (int i = 0; i < DS_NhanVien.Rows.Count; i++)
                if (DS_NhanVien.Rows[i]["USERNAME"].ToString() == user)
                {
                    return false;
                }
            return true;
        }
    }
}

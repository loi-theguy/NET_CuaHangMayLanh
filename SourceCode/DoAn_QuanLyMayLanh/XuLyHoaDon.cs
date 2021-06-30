using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QuanLyMayLanh
{
    public partial class XuLy
    {
        public DataTable DS_HoaDon
        {
            get { return ds.Tables["HoaDon"]; }
        }
        public DataTable DS_HoaDon_DuocHienThi
        {
            get { return ds.Tables["HoaDon_HienThi"]; }
        }
        public DataTable DS_ChiTiet_HoaDon
        {
            get { return ds.Tables["ChiTiet_HoaDon"]; }
        }
        public DataTable DS_ChiTiet_HoaDon_DuocHienThi
        {
            get { return ds.Tables["ChiTiet_HoaDon_HienThi"]; }
        }
        public void RefreshHoaDon()
        {
            DS_HoaDon.AcceptChanges();
            DS_ChiTiet_HoaDon.AcceptChanges();
        }
        public void InitHoaDon()
        {
            loadHoaDon();
            loadHoaDon_DuocHienThi();
            loadChiTietHoaDon();
            loadChiTietHoaDon_DuocHienThi();
        }

        //tra ve -1 khi trong kho khong co san pham can ban, tra ve 0 khi kho khong co du san pham, tra ve 1 khi co the ban
        public int CanProductBeSold(int maSP, int soLuong)
        {
            DataRow row = DS_SanPham.Rows.Find(maSP);
            if (row == null) return -1;
            if ((int)row["SOLUONG"] < soLuong) return 0;
            return 1;
        }
        
        public void loadHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from HoaDon", connection);
            try
            {
                try
                {
                    //xoa du lieu da duoc dua vao tu lan truoc
                    DS_NhapKho.Clear();
                }
                catch { }
                da.Fill(ds, "HoaDon");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void loadHoaDon_DuocHienThi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MAHD,k.HOTEN as TENKH,n.HOTEN as TENNV,h.NGAYLAP, TONGTIEN from hoadon h, nhanvien n, KhachHang k where h.MANV=n.MANV and k.MAKH=h.MAKH", connection);
            try
            {
                try
                {
                    //xoa du lieu da duoc dua vao tu lan truoc
                    DS_HoaDon_DuocHienThi.Clear();
                }
                catch { }
                da.Fill(ds, "HoaDon_HienThi");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddHoaDon(string maKH)
        {
            DataRow row = DS_HoaDon.NewRow();
            row["MANV"] = Program.MaNV;
            row["MAKH"] = int.Parse(maKH);
            row["NGAYLAP"] = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            row["TONGTIEN"] = 0;
            DS_HoaDon.Rows.Add(row);
        }

        public void RemoveHoaDon(List<DataGridViewRow> rows)
        {
            //duyet tren tung phieu nhap da duoc chon de xoa
            foreach (DataGridViewRow row in rows)
            {
                //xoa tung phieu nhap
                int maHD = int.Parse(row.Cells[0].Value.ToString());
                for (int i = 0; i < DS_HoaDon.Rows.Count; i++)
                    if (DS_HoaDon.Rows[i].RowState != DataRowState.Deleted)
                    {
                        int t = (int)DS_HoaDon.Rows[i][0];
                        if (t == maHD)
                        {
                            DS_HoaDon.Rows[i].Delete();
                            break;
                        }
                    }
            }
        }

        public void SaveChanges_HoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from HoaDon", connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(DS_HoaDon);
            loadHoaDon();
            loadHoaDon_DuocHienThi();
        }
        //////////Xu ly chi tiet nhap kho
        public void loadChiTietHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from View_ChiTietHoaDon", connection);
            try
            {
                try
                {
                    //xoa du lieu da duoc dua vao tu lan truoc
                    DS_ChiTiet_HoaDon.Clear();
                }
                catch { }
                da.Fill(ds, "ChiTiet_HoaDon");
                DataColumn[] keys = new DataColumn[2];
                keys[0] = DS_ChiTiet_HoaDon.Columns[0];
                keys[1] = DS_ChiTiet_HoaDon.Columns[1];
                DS_ChiTiet_HoaDon.PrimaryKey=keys;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void loadChiTietHoaDon_DuocHienThi()
        {
            string maHD = Program.MaHD;
            string cmd = "select * from View_ChiTietHoaDon where MAHD=" + maHD;
            SqlDataAdapter da = new SqlDataAdapter(cmd , connection);
            try
            {
                try
                {
                    //xoa du lieu da duoc dua vao tu lan truoc
                    DS_ChiTiet_HoaDon_DuocHienThi.Clear();
                }
                catch { }
                da.Fill(ds, "ChiTiet_HoaDon_HienThi");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddChiTietHoaDon(string maSP,string soLuong)
        {
            DataRow row = DS_ChiTiet_HoaDon.NewRow();
            row["MAHD"] = int.Parse(Program.MaHD);
            row["MASP"] = int.Parse(maSP);
            row["SOLUONG"] = int.Parse(soLuong);
            try
            {
                DS_ChiTiet_HoaDon.Rows.Add(row);
                SaveChanges_ChiTietHoaDon();
            }
            catch
            {
                MessageBox.Show("Sản phẩm này đã có trong hóa đơn, vui lòng xóa chi tiết về sản phẩm này trước nếu bạn muốn thay đổi thông tin của sản phẩm này trong hóa đơn!");
            }
        }

        public void RemoveChiTietHoaDon(List<DataGridViewRow> rows)
        {
            //duyet tren tung phieu nhap da duoc chon de xoa
            foreach (DataGridViewRow row in rows)
            {
                //xoa tung phieu nhap
                int maHD = int.Parse(row.Cells[0].Value.ToString());
                int maSP = int.Parse(row.Cells[1].Value.ToString());
                for (int i = 0; i < DS_ChiTiet_HoaDon.Rows.Count; i++)
                    if (DS_ChiTiet_HoaDon.Rows[i].RowState != DataRowState.Deleted)
                    {
                        int t = (int)DS_ChiTiet_HoaDon.Rows[i][0];
                        int t2 = (int)DS_ChiTiet_HoaDon.Rows[i][1];
                        if (t == maHD&&t2==maSP)
                        {
                            DS_ChiTiet_HoaDon.Rows[i].Delete();
                            break;
                        }
                    }
            }
        }

        public void SaveChanges_ChiTietHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from ChiTietHoaDon", connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(DS_ChiTiet_HoaDon);
            loadHoaDon();
            loadHoaDon_DuocHienThi();
            loadChiTietHoaDon();
            loadChiTietHoaDon_DuocHienThi();
        }
    }
}

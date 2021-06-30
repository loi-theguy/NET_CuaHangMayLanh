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
        public DataTable DS_NhapKho
        {
            get { return ds.Tables["NhapKho"]; }
        }
        public DataTable DS_NhapKho_DuocHienThi
        {
            get { return ds.Tables["NhapKho_HienThi"]; }
        }
        public DataTable DS_ChiTiet_NhapKho
        {
            get { return ds.Tables["ChiTiet_NhapKho"]; }
        }
        public DataTable DS_ChiTiet_NhapKho_DuocHienThi
        {
            get { return ds.Tables["ChiTiet_NhapKho_HienThi"]; }
        }
        public void RefreshNhapKho()
        {
            DS_NhapKho.AcceptChanges();
            DS_ChiTiet_NhapKho.AcceptChanges();
        }
        public void InitNhapKho()
        {
            loadNhapKho();
            loadNhapKho_DuocHienThi();
            loadChiTietNhapKho();
            loadChiTietNhapKho_DuocHienThi();
        }
        public void loadNhapKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from NhapKho", connection);
            try
            {
                try
                {
                    //xoa du lieu da duoc dua vao tu lan truoc
                    DS_NhapKho.Clear();
                }
                catch { }
                da.Fill(ds, "NhapKho");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            getMaxID_NhapKho();
        }
        public void loadNhapKho_DuocHienThi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MANHAP,HOTEN,NGAYNHAP,TONGTIEN from NhapKho nk, nhanvien n where nk.MANV=n.MANV", connection);
            try
            {
                try
                {
                    //xoa du lieu da duoc dua vao tu lan truoc
                    DS_NhapKho_DuocHienThi.Clear();
                }
                catch { }
                da.Fill(ds, "NhapKho_HienThi");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddNhapKho()
        {
            DataRow row = DS_NhapKho.NewRow();
            MAX_ID_NK++;
            row["MANHAP"] = MAX_ID_NK;
            row["MANV"] = Program.MaNV;
            row["NGAYNHAP"] = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            row["TONGTIEN"] = 0;
            DS_NhapKho.Rows.Add(row);

            //DataRow row2 = DS_NhapKho_DuocHienThi.NewRow();
            //row2["MANHAP"] = MAX_ID_NK;
            //row2["HOTEN"] = Program.TenNV;
            //row2["NGAYNHAP"] = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            //row2["TONGTIEN"] = 0;
            //DS_NhapKho_DuocHienThi.Rows.Add(row2);
        }

        public void RemoveNhapKho(List<DataGridViewRow> rows)
        {
            //duyet tren tung phieu nhap da duoc chon de xoa
            foreach (DataGridViewRow row in rows)
            {
                //xoa tung phieu nhap
                int maPN = int.Parse(row.Cells[0].Value.ToString());
                for (int i = 0; i < DS_NhapKho.Rows.Count; i++)
                    if (DS_NhapKho.Rows[i].RowState != DataRowState.Deleted)
                    {
                        int t = (int)DS_NhapKho.Rows[i][0];
                        if (t == maPN)
                        {
                            DS_NhapKho.Rows[i].Delete();
                            DS_NhapKho_DuocHienThi.Rows[i].Delete();
                            break;
                        }
                    }
            }
        }

        public void SaveChanges_NhapKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from NhapKho", connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(DS_NhapKho);
            loadNhapKho();
            loadNhapKho_DuocHienThi();
        }
        void getMaxID_NhapKho()
        {
            for (int i = 0; i < DS_NhapKho.Rows.Count; i++)
            {
                int t = (int)DS_NhapKho.Rows[i]["MANHAP"];
                if (MAX_ID_NK < t) MAX_ID_NK = t;
            }
        }
        //////////Xu ly chi tiet nhap kho
        public void loadChiTietNhapKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietNhapKho", connection);
            try
            {
                try
                {
                    //xoa du lieu da duoc dua vao tu lan truoc
                    DS_ChiTiet_NhapKho.Clear();
                }
                catch { }
                da.Fill(ds, "ChiTiet_NhapKho");
                DataColumn[] keys = new DataColumn[2];
                keys[0] = DS_ChiTiet_NhapKho.Columns[0];
                keys[1] = DS_ChiTiet_NhapKho.Columns[1];
                DS_ChiTiet_NhapKho.PrimaryKey = keys;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void loadChiTietNhapKho_DuocHienThi()
        {
            string maNhap = Program.MaNhap;
            string cmd = "select * from View_CT_NHAPKHO where MANHAP=" + maNhap;
            SqlDataAdapter da = new SqlDataAdapter(cmd , connection);
            try
            {
                try
                {
                    //xoa du lieu da duoc dua vao tu lan truoc
                    DS_ChiTiet_NhapKho_DuocHienThi.Clear();
                }
                catch { }
                da.Fill(ds, "ChiTiet_NhapKho_HienThi");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddChiTietNhapKho(string maSP,string soLuong, string donGia)
        {
            DataRow row = DS_ChiTiet_NhapKho.NewRow();
            row["MANHAP"] = Program.MaNhap;
            row["MASP"] = int.Parse(maSP);
            row["SOLUONG"] = int.Parse(soLuong);
            row["DONGIA"] = int.Parse(donGia);
            try
            {
                DS_ChiTiet_NhapKho.Rows.Add(row);
            }
            catch {
                MessageBox.Show("Sản phẩm này đã có trong phiếu nhập, vui lòng xóa chi tiết về sản phẩm này trước nếu bạn muốn thay đổi thông tin của sản phẩm này trong phiếu nhập!");
            }
        }

        public void RemoveChiTietNhapKho(List<DataGridViewRow> rows)
        {
            //duyet tren tung phieu nhap da duoc chon de xoa
            foreach (DataGridViewRow row in rows)
            {
                //xoa tung phieu nhap
                int maPN = int.Parse(row.Cells[0].Value.ToString());
                int maSP = int.Parse(row.Cells[1].Value.ToString());
                for (int i = 0; i < DS_ChiTiet_NhapKho.Rows.Count; i++)
                    if (DS_ChiTiet_NhapKho.Rows[i].RowState != DataRowState.Deleted)
                    {
                        int t = (int)DS_ChiTiet_NhapKho.Rows[i][0];
                        int t2 = (int)DS_ChiTiet_NhapKho.Rows[i][1];
                        if (t == maPN&&t2==maSP)
                        {
                            DS_ChiTiet_NhapKho.Rows[i].Delete();
                            break;
                        }
                    }
            }
        }

        public void SaveChanges_ChiTietNhapKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from ChiTietNhapKho", connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(DS_ChiTiet_NhapKho);
            loadNhapKho();
            loadNhapKho_DuocHienThi();
            loadChiTietNhapKho();
            loadChiTietNhapKho_DuocHienThi();
        }
    }
}

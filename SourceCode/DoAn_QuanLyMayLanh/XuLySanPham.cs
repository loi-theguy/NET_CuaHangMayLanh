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
        public void InitSanPham()
        {
            loadSanPham();
            loadSanPham_DuocHienThi();
        }
        public void RefreshSanPham()
        {
            DS_SanPham.AcceptChanges();
        }
        public DataTable DS_SanPham_DuocHienThi
        {
            get { return ds.Tables["SanPhamHienThi"]; }
        }

        public DataTable DS_SanPham
        {
            get { return ds.Tables["SanPham"]; }
        }

        public DataTable DS_NSX
        {
            get { return ds.Tables["NSX"]; }
        }
        public void loadSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from sanpham", connection);
            try
            {
                try
                {
                    DS_SanPham.Clear();
                }
                catch { }
                da.Fill(ds, "SanPham");
                DataColumn[] key = new DataColumn[1];
                key[0] = DS_SanPham.Columns[0];
                DS_SanPham.PrimaryKey = key;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            loadSanPham_DuocHienThi();
        }

        public void loadSanPham_DuocHienThi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MASP,TENSP,TENNSX,SOLUONG,DONGIA from sanpham s, NhaSanXuat n where s.MANSX=n.MANSX", connection);
            try
            {
                try
                {
                    DS_SanPham_DuocHienThi.Clear();
                }
                catch { }
                da.Fill(ds, "SanPhamHienThi");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            getMaxID_SanPham();
        }
        public void getMaxID_SanPham()
        {
            for (int i = 0; i < DS_SanPham_DuocHienThi.Rows.Count; i++)
            {
                int t = (int)DS_SanPham_DuocHienThi.Rows[i]["MASP"];
                if (MAX_ID_SP < t) MAX_ID_SP = t;
            }
        }

        public void AddSanPham(string tenSP, int soLuong, int donGia, string maNSX, string tenNSX)
        {
            DataRow row = DS_SanPham.NewRow();
            MAX_ID_SP++;
            row["MASP"] = MAX_ID_SP;
            row["TENSP"] = tenSP;
            row["MANSX"] = int.Parse(maNSX);
            row["SOLUONG"] = soLuong;
            row["DONGIA"] = donGia;
            DS_SanPham.Rows.Add(row);

            DataRow row2 = DS_SanPham_DuocHienThi.NewRow();
            row2["TENSP"] = tenSP;
            row2["MASP"] = MAX_ID_SP;
            row2["TENNSX"] = tenNSX;
            row2["SOLUONG"] = soLuong;
            row2["DONGIA"] = donGia;
            DS_SanPham_DuocHienThi.Rows.Add(row2);

        }

        public void RemoveSanPham(List<DataGridViewRow> rows)
        {
            foreach (DataGridViewRow row in rows)
            {
                int maSP = int.Parse(row.Cells[0].Value.ToString());
                for (int i = 0; i < DS_SanPham_DuocHienThi.Rows.Count; i++)
                    if (DS_SanPham_DuocHienThi.Rows[i].RowState != DataRowState.Deleted)
                    {
                        int t = (int)DS_SanPham_DuocHienThi.Rows[i][0];
                        if (t == maSP)
                        {
                            DS_SanPham_DuocHienThi.Rows[i].Delete();
                            DS_SanPham.Rows[i].Delete();
                            break;
                        }
                    }
            }
        }

        public void SaveChanges_SanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from SanPham", connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(DS_SanPham);
            loadSanPham();
        }
    }
}

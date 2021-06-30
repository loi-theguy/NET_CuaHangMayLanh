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
        public DataTable DS_NhanVien
        {
            get { return ds.Tables["NhanVien"]; }
        }
        public DataTable DS_NhanVien_DuocHienThi
        {
            get { return ds.Tables["NhanVien_HienThi"]; }
        }
        public DataTable DS_LoaiNV
        {
            get { return ds.Tables["LoaiNV"]; }
        }
        public void RefreshNhanVien()
        {
            DS_NhanVien.AcceptChanges();
        }
        public void InitNhanVien()
        {
            loadNhanVien();
            loadNhanVien_DuocHienThi();
            loadLoaiNV();
        }
        public void loadLoaiNV()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from LoaiNhanVien", connection);
            try
            {
                try
                {
                    //xoa du lieu da duoc dua vao tu lan truoc
                    DS_LoaiNV.Clear();
                }
                catch { }
                da.Fill(ds, "LoaiNV");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void loadNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MANV, HOTEN, NGAYSINH, NGAYVL,LOAI,USERNAME,MATKHAU from NHANVIEN", connection);
            try
            {
                try
                {
                    //xoa du lieu da duoc dua vao tu lan truoc
                    DS_NhanVien.Clear();
                }
                catch { }
                da.Fill(ds, "NhanVien");
                DataColumn[] key = new DataColumn[1];
                key[0] = DS_NhanVien.Columns[0];
                DS_NhanVien.PrimaryKey = key;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            getMaxID_NhanVien();
        }
        public void loadNhanVien_DuocHienThi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MANV, HOTEN, NGAYSINH, NGAYVL,TENLOAI,USERNAME from NhanVien n, LoaiNhanVien l where n.LOAI=l.LOAI", connection);
            try
            {
                try
                {
                    //xoa du lieu da duoc dua vao tu lan truoc
                    DS_NhanVien_DuocHienThi.Clear();
                }
                catch { }
                da.Fill(ds, "NhanVien_HienThi");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddNhanVien(string tenNV, string ngaySinh, string ngayVL, string username, string matKhau, string loai, string tenLoai)
        {
            //them vao table trong csdl
            DataRow row = DS_NhanVien.NewRow();
            MAX_ID_NV++;
            row["MANV"] = MAX_ID_NV;
            row["HOTEN"] = tenNV;
            row["NGAYVL"] = ngayVL;
            row["NGAYSINH"] = ngaySinh;
            row["LOAI"] = int.Parse(loai);
            row["USERNAME"] = username;
            row["MATKHAU"] = matKhau;
            DS_NhanVien.Rows.Add(row);
            //them vao table duoc hien thi
            DataRow row2 = DS_NhanVien_DuocHienThi.NewRow();
            row2["MANV"] = MAX_ID_NV;
            row2["HOTEN"] = tenNV;
            row2["NGAYVL"] = ngayVL;
            row2["NGAYSINH"] = ngaySinh;
            row2["TENLOAI"] = tenLoai;
            row2["USERNAME"] = username;
            DS_NhanVien_DuocHienThi.Rows.Add(row2);
        }

        public void UpdateNhanVien(string maNV, string tenNV, string ngaySinh, string ngayVL, string username, string loai)
        {
            DataRow row = DS_NhanVien.Rows.Find(maNV);
            row["HOTEN"] = tenNV;
            row["NGAYVL"] = ngayVL;
            row["NGAYSINH"] = ngaySinh;
            row["LOAI"] = int.Parse(loai);
            row["USERNAME"] = username;
        }

        public void RemoveNhanVien(List<DataGridViewRow> rows)
        {
            //duyet tren tung nsx da duoc chon de xoa
            foreach (DataGridViewRow row in rows)
            {
                //xoa tung nsx
                int maNV = int.Parse(row.Cells[0].Value.ToString());
                for (int i = 0; i < DS_NhanVien.Rows.Count; i++)
                    if (DS_NhanVien.Rows[i].RowState != DataRowState.Deleted)
                    {
                        int t = (int)DS_NhanVien.Rows[i][0];
                        if (t == maNV)
                        {
                            DS_NhanVien.Rows[i].Delete();
                            DS_NhanVien_DuocHienThi.Rows[i].Delete();
                            break;
                        }
                    }
            }
        }

        public void SaveChanges_NhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select MANV, HOTEN, NGAYSINH, NGAYVL,LOAI,USERNAME,MATKHAU from NhanVien", connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(DS_NhanVien);
            loadNhanVien();
            loadNhanVien_DuocHienThi();
        }
        void getMaxID_NhanVien()
        {
            for (int i = 0; i < DS_NhanVien.Rows.Count; i++)
            {
                int t = (int)DS_NhanVien.Rows[i]["MANV"];
                if (MAX_ID_NV < t) MAX_ID_NV = t;
            }
        }
    }
}

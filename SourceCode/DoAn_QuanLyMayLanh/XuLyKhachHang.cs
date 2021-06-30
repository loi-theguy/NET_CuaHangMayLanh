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
        public void InitKhachHang()
        {
            loadKhachHang();
            //loadKhachHang_DuocHienThi();
        }
        //public DataTable DS_KhachHang_DuocHienThi
        //{
        //    get { return ds.Tables["KhachHangHienThi"]; }
        //}

        public DataTable DS_KhachHang
        {
            get { return ds.Tables["KhachHang"]; }
        }
        public void RefreshKhachHang()
        {
            DS_KhachHang.AcceptChanges();
        }
        public void loadKhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang", connection);
            try
            {
                try
                {
                    //xoa du lieu da duoc dua vao tu lan truoc
                    DS_KhachHang.Clear();
                }
                catch { }
                da.Fill(ds, "KhachHang");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void getMaxID_KhachHang()
        {
            for (int i = 0; i < DS_KhachHang.Rows.Count; i++)
            {
                int t = (int)DS_KhachHang.Rows[i]["MAKH"];
                if (MAX_ID_KH < t) MAX_ID_SP = t;
            }
        }

        public void AddKhachHang(string hoTen, string ngaySinh, string ngayLap)
        {
            DataRow row = DS_KhachHang.NewRow();
            MAX_ID_KH++;
            row["MAKH"] = MAX_ID_KH;
            row["HOTEN"] = hoTen;
            row["NGAYSINH"] = ngaySinh;
            row["NGAYLAP"] = ngayLap;
            DS_KhachHang.Rows.Add(row);

        }

        public void RemoveKhachHang(List<DataGridViewRow> rows)
        {
            foreach (DataGridViewRow row in rows)
            {
                int maSP = int.Parse(row.Cells[0].Value.ToString());
                for (int i = 0; i < DS_KhachHang.Rows.Count; i++)
                    if (DS_KhachHang.Rows[i].RowState != DataRowState.Deleted)
                    {
                        int t = (int)DS_KhachHang.Rows[i][0];
                        if (t == maSP)
                        {
                            DS_KhachHang.Rows[i].Delete();
                            break;
                        }
                    }
            }
        }

        public void SaveChanges_KhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from KhachHang", connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(DS_KhachHang);
            loadKhachHang();
        }
    }
}

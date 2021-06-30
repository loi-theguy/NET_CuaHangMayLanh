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
        public void RefreshNSX()
        {
            DS_NSX.AcceptChanges();
        }
        public void loadNSX()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from nhasanxuat", connection);
            try
            {
                try
                {
                    //xoa du lieu da duoc dua vao tu lan truoc
                    DS_NSX.Clear();
                }
                catch { }
                da.Fill(ds, "NSX");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            getMaxID_NSX();
        }
        public void AddNSX(string tenNSX)
        {
            DataRow row = DS_NSX.NewRow();
            MAX_ID_NSX++;
            row["MANSX"] = MAX_ID_NSX;
            row["TENNSX"] = tenNSX;
            DS_NSX.Rows.Add(row);
        }

        public void RemoveNSX(List<DataGridViewRow> rows)
        {
            //duyet tren tung nsx da duoc chon de xoa
            foreach (DataGridViewRow row in rows)
            {
                //xoa tung nsx
                int maNSX = int.Parse(row.Cells[0].Value.ToString());
                for (int i = 0; i < DS_NSX.Rows.Count; i++)
                    if (DS_NSX.Rows[i].RowState != DataRowState.Deleted)
                    {
                        int t = (int)DS_NSX.Rows[i][0];
                        if (t == maNSX)
                        {
                            DS_NSX.Rows[i].Delete();
                            break;
                        }
                    }
            }
        }

        public void SaveChanges_NSX()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from nhasanxuat", connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(DS_NSX);
            loadNSX();
        }
        void getMaxID_NSX()
        {
            for (int i = 0; i < DS_NSX.Rows.Count; i++)
            {
                int t = (int)DS_NSX.Rows[i]["MANSX"];
                if (MAX_ID_NSX < t) MAX_ID_NSX = t;
            }
        }
    }
}

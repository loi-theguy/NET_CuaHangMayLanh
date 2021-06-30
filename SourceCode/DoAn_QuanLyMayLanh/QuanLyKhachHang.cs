using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyMayLanh
{
    public partial class QuanLyKhachHang : Form
    {
        XuLy getData = Program.data;
        bool isAdding = false, isEditting = false;
        string tempTen=string.Empty, tempNS=string.Empty, tempNL=string.Empty;
        public QuanLyKhachHang()
        {
            InitializeComponent();
            dataGridViewKH.DataSource = getData.DS_KhachHang;
            DisableControls();
        }
        void CancelBinding()
        {
            txtHoTen.DataBindings.Clear();
            mtxtNgaySinh.DataBindings.Clear();
            mtxtNgayLap.DataBindings.Clear();
        }
        void DataBinding()
        {
            CancelBinding();
            txtHoTen.DataBindings.Add("Text", getData.DS_KhachHang, "HOTEN");
            mtxtNgaySinh.DataBindings.Add("Text", getData.DS_KhachHang, "NGAYSINH");
            mtxtNgayLap.DataBindings.Add("Text", getData.DS_KhachHang, "NGAYLAP");
        }
        void EnableControls()
        {
            txtHoTen.Enabled = true;
            mtxtNgayLap.Enabled = true;
            mtxtNgaySinh.Enabled = true;
            btnXacNhan.Show();
        }
        void DisableControls()
        {
            txtHoTen.Enabled = false;
            mtxtNgaySinh.Enabled = false;
            mtxtNgayLap.Enabled = false;
            btnXacNhan.Hide();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isEditting) btnSua_Click(null, null);
            if (isAdding)
            {
                isAdding = false;
                btnThem.Text = "Thêm khách hàng";
                DataBinding();
                DisableControls();
            }
            else
            {
                
                isAdding = true;
                btnThem.Text = "Hủy thêm khách hàng";
                CancelBinding();
                txtHoTen.Text = string.Empty;
                mtxtNgaySinh.Text = string.Empty;
                mtxtNgayLap.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
                EnableControls();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Program.LoaiNV > 2)
            {
                MessageBox.Show("Bạn không có quyền sửa thông tin khách hàng, vui lòng thử lại!");
                return;
            }
            if (isAdding) btnThem_Click(null, null);
            if (isEditting)
            {
                isEditting = false;
                btnSua.Text = "Sửa khách hàng";
                DataBinding();
                DisableControls();
            }
            else
            {
                
                isEditting = true;
                btnSua.Text = "Hủy sửa khách hàng";
                CancelBinding();
                EnableControls();
            }
            
        }

        private void dataGridViewKH_Click(object sender, EventArgs e)
        {
            if (isAdding) btnThem_Click(null, null);
            if (isEditting) btnSua_Click(null, null);
            DataBinding();
            DisableControls();
        }
        bool IsDateValid(string dateStr)
        {
            try
            {
                DateTime.ParseExact(dateStr, "dd/MM/yyyy", null);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                if (txtHoTen.Text == string.Empty)
                {
                    MessageBox.Show("Không bỏ trống họ tên, vui lòng kiểm tra lại!");
                    return;
                }
                if (!IsDateValid(mtxtNgaySinh.Text))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ, vui lòng kiểm tra lại!");
                    return;
                }
                if (!IsDateValid(mtxtNgayLap.Text))
                {
                    MessageBox.Show("Ngày lập không hợp lệ, vui lòng kiểm tra lại!");
                    return;
                }
                getData.AddKhachHang(txtHoTen.Text, mtxtNgaySinh.Text, mtxtNgayLap.Text);
                btnThem_Click(null, null);
            }
            else
            {
                if (txtHoTen.Text == string.Empty)
                {
                    MessageBox.Show("Không bỏ trống họ tên, vui lòng kiểm tra lại!");
                    return;
                }
                if (!IsDateValid(mtxtNgaySinh.Text))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ, vui lòng kiểm tra lại!");
                    return;
                }
                if (!IsDateValid(mtxtNgayLap.Text))
                {
                    MessageBox.Show("Ngày lập không hợp lệ, vui lòng kiểm tra lại!");
                    return;
                }
                tempTen = txtHoTen.Text;
                tempNS = mtxtNgaySinh.Text;
                tempNL = mtxtNgayLap.Text;
                DataBinding();
                txtHoTen.Text = tempTen;
                mtxtNgaySinh.Text = tempNS;
                mtxtNgayLap.Text = tempNL;
                int i = dataGridViewKH.CurrentCell.RowIndex+1;
                i %= dataGridViewKH.Rows.Count;
                dataGridViewKH.CurrentCell = dataGridViewKH.Rows[i].Cells[0];
                btnSua_Click(null, null);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Program.LoaiNV > 2)
            {
                MessageBox.Show("Bạn không có quyền xóa thông tin khách hàng, vui lòng thử lại!");
                return;
            }
            if (isAdding) btnThem_Click(null, null);
            if (isEditting) btnSua_Click(null, null);
            List<DataGridViewRow> list = dataGridViewKH.SelectedRows.Cast<DataGridViewRow>().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (!getData.Can_KhachHang_Be_Deleted((int)list[i].Cells[0].Value))
                {
                    MessageBox.Show("Có khách hàng đã có dữ liệu liên quan đến những bảng dữ liệu khác, không thể xóa các khách hàng này. Vui lòng xóa dữ liệu liên quan đến họ trước khi xóa!");
                    return;
                }
            }
            getData.RemoveKhachHang(list);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            getData.SaveChanges_KhachHang();
        }
    }
}

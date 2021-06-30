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
    public partial class QuanLyNhanVien : Form
    {
        XuLy getData = Program.data;
        bool isAdding = false, isEditting = false;
        string tempTen, tempUsername, tempLoai, tempTenLoai, tempNgaySinh, tempNgayVL;
        public QuanLyNhanVien()
        {
            InitializeComponent();
            dataGridViewNhanVien.DataSource = getData.DS_NhanVien_DuocHienThi;
            DataBinding();
            comboBoxLoaiNV.DataSource = getData.DS_LoaiNV;
            comboBoxLoaiNV.DisplayMember = "TENLOAI";
            comboBoxLoaiNV.ValueMember = "LOAI";
            txtMatKhau.Hide();
            txtMatKhau_XacNhan.Hide();
            lblMatKhau.Hide();
            lblXacNhanMK.Hide();
            DisableControls();
        }
        void DataBinding()
        {
            CancelBinding();

            txtTen.DataBindings.Add("Text", getData.DS_NhanVien_DuocHienThi, "HOTEN");
            txtUsername.DataBindings.Add("Text", getData.DS_NhanVien_DuocHienThi, "USERNAME");
            comboBoxLoaiNV.DataBindings.Add("Text", getData.DS_NhanVien_DuocHienThi, "TENLOAI");
            mtxtNgaySinh.DataBindings.Add("Text", getData.DS_NhanVien_DuocHienThi, "NGAYSINH");
            mtxtNgayVaoLam.DataBindings.Add("Text", getData.DS_NhanVien_DuocHienThi, "NGAYVL");
        }
        void DisableControls()
        {
            txtTen.Enabled = false;
            txtUsername.Enabled = false;
            comboBoxLoaiNV.Enabled = false;
            mtxtNgaySinh.Enabled = false;
            mtxtNgayVaoLam.Enabled = false;
            btnXacNhan.Hide();
        }
        void EnableControls()
        {
            txtTen.Enabled = true;
            txtUsername.Enabled = true;
            comboBoxLoaiNV.Enabled = true;
            mtxtNgaySinh.Enabled = true;
            mtxtNgayVaoLam.Enabled = true;
            btnXacNhan.Show();
        }
        void CancelBinding()
        {
            txtTen.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            comboBoxLoaiNV.DataBindings.Clear();
            mtxtNgaySinh.DataBindings.Clear();
            mtxtNgayVaoLam.DataBindings.Clear();
        }
        bool isDateValid(string dateStr)
        {
            try
            {
                DateTime d = DateTime.ParseExact(dateStr, "dd/MM/yyyy", null);
                return true;
            }
            catch
            {
                return false;
            }
        }
        bool isComboBoxValid()
        {
            int result=comboBoxLoaiNV.FindString(comboBoxLoaiNV.Text);
            return result != -1;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                if ((int)comboBoxLoaiNV.SelectedValue == 1 && Program.LoaiNV >= 2)
                {
                    MessageBox.Show("Bạn không có quyền thêm một Chủ quản lý mới, vui lòng thử lại!");
                    return;
                }
                if (!isDateValid(mtxtNgaySinh.Text))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!");
                    return;
                }
                if (!isDateValid(mtxtNgayVaoLam.Text))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!");
                    return;
                }
                if (txtTen.Text == string.Empty)
                {
                    MessageBox.Show("Không bỏ trống tên!");
                    return;
                }
                if (txtUsername.Text == string.Empty)
                {
                    MessageBox.Show("Không bỏ trống tên đăng nhập!");
                    return;
                }
                if (!isPasswordValid())
                {
                    MessageBox.Show("Mật khẩu không hợp lệ, vui lòng kiểm tra lại!");
                    return;
                }
                if (!isComboBoxValid())
                {
                    MessageBox.Show("Vui lòng chọn loại nhân viên phù hợp!");
                    return;
                }
                if (!getData.IsUsernameUsable(txtUsername.Text))
                {
                    MessageBox.Show("Trùng Username! Vui lòng chọn lại Username phù hợp!");
                    return;
                }
                getData.AddNhanVien(txtTen.Text, mtxtNgaySinh.Text, mtxtNgayVaoLam.Text, txtUsername.Text, txtMatKhau.Text, comboBoxLoaiNV.SelectedValue.ToString(), comboBoxLoaiNV.Text);
                btnThem_Click(sender, e);
            }
            else 
            {
                if (!isDateValid(mtxtNgaySinh.Text))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!");
                    return;
                }
                if (!isDateValid(mtxtNgayVaoLam.Text))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!");
                    return;
                }
                if (txtTen.Text == string.Empty)
                {
                    MessageBox.Show("Không bỏ trống tên!");
                    return;
                }
                if (txtUsername.Text == string.Empty)
                {
                    MessageBox.Show("Không bỏ trống tên đăng nhập!");
                    return;
                }
                if (!isComboBoxValid())
                {
                    MessageBox.Show("Vui lòng chọn loại nhân viên phù hợp!");
                    return;
                }
                tempTen = txtTen.Text;
                tempLoai = comboBoxLoaiNV.SelectedValue.ToString();
                tempNgaySinh = mtxtNgaySinh.Text;
                tempNgayVL = mtxtNgayVaoLam.Text;
                tempTenLoai = comboBoxLoaiNV.Text;
                tempUsername = txtUsername.Text;
                //update lai du lieu cua csdl
                getData.UpdateNhanVien(dataGridViewNhanVien.CurrentRow.Cells["MANV"].Value.ToString(), tempTen, tempNgaySinh, tempNgayVL, tempUsername, tempLoai);
                //update lai du lieu duoc hien thi
                DataBinding();
                txtTen.Text = tempTen;
                txtUsername.Text = tempUsername;
                comboBoxLoaiNV.Text = tempTenLoai;
                mtxtNgayVaoLam.Text = tempNgayVL;
                mtxtNgaySinh.Text = tempNgaySinh;
                int i = dataGridViewNhanVien.CurrentCell.RowIndex + 1;
                i %= dataGridViewNhanVien.Rows.Count;
                dataGridViewNhanVien.CurrentCell = dataGridViewNhanVien.Rows[i].Cells[0];
                btnSua_Click(sender, e);
            }
        }
        bool isPasswordValid()
        {
            return !(txtMatKhau.Text == string.Empty || txtMatKhau_XacNhan.Text == string.Empty || txtMatKhau_XacNhan.Text != txtMatKhau.Text);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isEditting) btnSua_Click(sender, e);
            if (isAdding)
            {
                btnThem.Text = "Thêm nhân viên";
                isAdding = false;
                txtMatKhau.Hide();
                txtMatKhau_XacNhan.Hide();
                lblMatKhau.Hide();
                lblXacNhanMK.Hide();
                DataBinding();
                DisableControls();
            }
            else
            {
                isAdding = true;
                lblMatKhau.Show();
                lblXacNhanMK.Show();
                txtMatKhau.Show();
                txtMatKhau_XacNhan.Show();
                txtMatKhau.Text = string.Empty;
                txtMatKhau_XacNhan.Text = string.Empty;
                btnThem.Text = "Hủy thêm";
                EnableControls();
                CancelBinding();
                txtTen.Text = string.Empty;
                txtUsername.Text = string.Empty;
                mtxtNgaySinh.Text = string.Empty;
                mtxtNgayVaoLam.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            }
        }

        private void dataGridViewNhanVien_Click(object sender, EventArgs e)
        {
            if (isAdding) btnThem_Click(sender, e);
            if (isEditting) btnSua_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Program.LoaiNV >= 2)
            {
                MessageBox.Show("Bạn không có quyền sửa thông tin nhân viên, vui lòng thử lại!");
                return;
            }
            if (isAdding) btnThem_Click(sender, e);
            if (isEditting)
            {
                isEditting = false;
                btnSua.Text = "Sửa nhân viên";
                DisableControls();
                DataBinding();
            }
            else
            {
                isEditting = true;
                btnSua.Text = "Hủy sửa";
                EnableControls();
                CancelBinding();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            getData.SaveChanges_NhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Program.LoaiNV >= 2)
            {
                MessageBox.Show("Bạn không có quyền xóa nhân viên, vui lòng thử lại!");
                return;
            }
            List<DataGridViewRow> list = dataGridViewNhanVien.SelectedRows.Cast<DataGridViewRow>().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (!getData.Can_NhanVien_Be_Deleted((int)list[i].Cells[0].Value))
                {
                    MessageBox.Show("Có nhân viên có dữ liệu liên quan đến những bảng dữ liệu khác, không thể xóa các nhân viên này. Vui lòng xóa dũ liệu liên quan đến họ trước khi xóa!");
                    return;
                }
            }
            getData.RemoveNhanVien(list);
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnXacNhan_Click(sender, new EventArgs());
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnXacNhan_Click(sender, new EventArgs());
            }
        }

        private void comboBoxLoaiNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnXacNhan_Click(sender, new EventArgs());
            }
        }

        private void mtxtNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnXacNhan_Click(sender, new EventArgs());
            }
        }

        private void mtxtNgayVaoLam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnXacNhan_Click(sender, new EventArgs());
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnXacNhan_Click(sender, new EventArgs());
            }
        }

        private void txtMatKhau_XacNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnXacNhan_Click(sender, new EventArgs());
            }
        }

    }
}

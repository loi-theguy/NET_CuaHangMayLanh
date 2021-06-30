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
    public partial class QuanLyHoaDon : Form
    {
        XuLy getData = Program.data;
        public QuanLyHoaDon()
        {
            InitializeComponent();
            dataGridViewHoaDon.DataSource = getData.DS_HoaDon_DuocHienThi;
            comboBoxMaKH.DataSource = getData.DS_KhachHang;
            comboBoxMaKH.DisplayMember = "HOTEN";
            comboBoxMaKH.ValueMember = "MAKH";
            comboBoxSanPham.DataSource = getData.DS_SanPham;
            comboBoxSanPham.ValueMember = "MASP";
            comboBoxSanPham.DisplayMember = "TENSP";
            comboBoxMaKH.DataBindings.Clear();
            comboBoxMaKH.DataBindings.Add("Text", getData.DS_HoaDon_DuocHienThi, "TENKH");

        }

        bool isValidNumber(string s)
        {
            int t;
            return int.TryParse(s, out t);
        }

        private void dataGridViewHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaHD.Text = dataGridViewHoaDon.CurrentRow.Cells[0].Value.ToString();
            }
            catch {
                return;
            }
            Program.MaHD = txtMaHD.Text;
            getData.loadChiTietHoaDon_DuocHienThi();
            getData.loadChiTietHoaDon();
            dataGridViewChiTietHD.DataSource = getData.DS_ChiTiet_HoaDon_DuocHienThi;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            getData.AddHoaDon(comboBoxMaKH.SelectedValue.ToString());
            getData.SaveChanges_HoaDon();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (dataGridViewChiTietHD.Rows.Count == 0)
            {
                List<DataGridViewRow> list = dataGridViewHoaDon.SelectedRows.Cast<DataGridViewRow>().ToList();
                getData.RemoveHoaDon(list);
                getData.SaveChanges_HoaDon();
            }
            else
            {
                MessageBox.Show("Bạn chỉ có thể xóa trực tiếp những hóa đơn chưa có thông tin. Vui lòng xóa thông tin của hóa đơn này trước nếu bạn thật sự muốn xóa hóa đơn này!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isValidNumber(txtSoLuong.Text))
            {
                if (int.Parse(txtSoLuong.Text) < 1)
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ(Số nguyên lớn hơn 0)!");
                    return;
                }
                int t = getData.CanProductBeSold((int)comboBoxSanPham.SelectedValue, int.Parse(txtSoLuong.Text));
                if (t == -1)
                {
                    MessageBox.Show("Trong kho không có sản phẩm này, vui lòng thử lại!");
                    return;
                }
                else if (t == 0)
                {
                    MessageBox.Show("Trong kho không có đủ sản phẩm này, vui lòng nhập lại số lượng ít hơn!");
                    return;
                }
                getData.AddChiTietHoaDon(comboBoxSanPham.SelectedValue.ToString(), txtSoLuong.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ(Số nguyên lớn hơn 0)!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> list = dataGridViewChiTietHD.SelectedRows.Cast<DataGridViewRow>().ToList();
            getData.RemoveChiTietHoaDon(list);
            getData.SaveChanges_ChiTietHoaDon();
            dataGridViewHoaDon.DataSource = getData.DS_HoaDon_DuocHienThi;
        }
    }
}

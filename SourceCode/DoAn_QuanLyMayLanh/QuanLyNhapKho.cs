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
    public partial class QuanLyNhapKho : Form
    {
        XuLy getData = Program.data;
        public QuanLyNhapKho()
        {
            InitializeComponent();
            dataGridViewPhieuNhap.DataSource = getData.DS_NhapKho_DuocHienThi;
            comboBoxSanPham.DataSource = getData.DS_SanPham;
            comboBoxSanPham.DisplayMember = "TENSP";
            comboBoxSanPham.ValueMember = "MASP";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            getData.AddNhapKho();
            getData.SaveChanges_NhapKho();
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            if (dataGridViewChiTiet.Rows.Count == 0)
            {
                List<DataGridViewRow> list = dataGridViewPhieuNhap.SelectedRows.Cast<DataGridViewRow>().ToList();
                getData.RemoveNhapKho(list);
                getData.SaveChanges_NhapKho();
            }
            else
            {
                MessageBox.Show("Bạn chỉ có thể xóa trực tiếp những phiếu nhập kho chưa có thông tin. Vui lòng xóa thông tin của phiếu trước nếu bạn thật sự muốn xóa phiếu này!");
            }
        }

        private void dataGridViewPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaPN.Text = dataGridViewPhieuNhap.CurrentRow.Cells[0].Value.ToString();
                Program.MaNhap = txtMaPN.Text;
                getData.loadChiTietNhapKho_DuocHienThi();
                dataGridViewChiTiet.DataSource = getData.DS_ChiTiet_NhapKho_DuocHienThi;
            }
            catch { }
        }
        bool IsNumber(string s)
        { 
            int t;
            return int.TryParse(s, out t); 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!IsNumber(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá hợp lệ(Số nguyên lớn hơn 0)!");
                return;
            }
            if (int.Parse(txtDonGia.Text) <= 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá hợp lệ(Số nguyên lớn hơn 0)!");
                return;
            }
            if (!IsNumber(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ(Số nguyên lớn hơn 0)!");
                return;
            }
            if (int.Parse(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ(Số nguyên lớn hơn 0)!");
                return;
            }
            getData.AddChiTietNhapKho(comboBoxSanPham.SelectedValue.ToString(), txtSoLuong.Text, txtDonGia.Text);
            getData.SaveChanges_ChiTietNhapKho();
        }

        private void dataGridViewPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewPhieuNhap_CellClick(sender, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> list = dataGridViewChiTiet.SelectedRows.Cast<DataGridViewRow>().ToList();
            getData.RemoveChiTietNhapKho(list);
            getData.SaveChanges_ChiTietNhapKho();
            dataGridViewPhieuNhap.DataSource = getData.DS_NhapKho_DuocHienThi;
        }
    }
}

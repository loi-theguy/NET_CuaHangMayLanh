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
    public partial class QuanLySanPham : Form
    {
        XuLy getData = Program.data;
        int mode = 0;
        bool isAdding = false, isEditting = false;
        string tempTen, tempSoLuong, tempNSX, tempDonGia;
        public QuanLySanPham()
        {
            InitializeComponent();
            LoadData();
            DataTable dsSanPham = getData.DS_SanPham_DuocHienThi;
            btnConfirmThem.Enabled = false;
            dataGridView_SanPham.DataSource = dsSanPham;
            comboBoxNSX.DataSource = getData.DS_NSX;
            comboBoxNSX.DisplayMember = "TENNSX";
            comboBoxNSX.ValueMember = "MANSX";
            DataBinding();
        }
        void LoadData()
        {
            getData.loadSanPham();
            getData.loadSanPham_DuocHienThi();
            getData.loadNSX();
        }
        void DataBinding()
        {
            DataTable dsSanPham = getData.DS_SanPham_DuocHienThi;
            txtDonGia.DataBindings.Clear();
            txtSoLuongSP.DataBindings.Clear();
            txtTenSP.DataBindings.Clear();
            comboBoxNSX.DataBindings.Clear();
            
            txtTenSP.DataBindings.Add("Text", dsSanPham, "TENSP");
            txtSoLuongSP.DataBindings.Add("Text", dsSanPham, "SOLUONG");
            txtDonGia.DataBindings.Add("Text", dsSanPham, "DONGIA");
            comboBoxNSX.DataBindings.Add("Text", dsSanPham, "TENNSX");
        }
        void CancelBinding()
        {
            txtDonGia.DataBindings.Clear();
            txtSoLuongSP.DataBindings.Clear();
            txtTenSP.DataBindings.Clear();
            comboBoxNSX.DataBindings.Clear();
        }
        bool is_NSX_Valid()
        {
            try
            {
                string s = comboBoxNSX.SelectedValue.ToString() ;
                return true;
            }catch
            {
                return false;
            }
        }

        private void btnThemNSX_Click(object sender, EventArgs e)
        {
            bool isCreated = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
                if (Application.OpenForms[i].Name == "QuanLyNSX")
                {
                    isCreated = true;
                    Application.OpenForms[i].BringToFront();
                }
            if (!isCreated)
            {
                QuanLyNSX form = new QuanLyNSX();
                form.MdiParent = Program.mainForm;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
            //QuanLyNSX form = new QuanLyNSX();
            //form.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Huy viec them
            if (isAdding)
            {
                btnThem.Text = "Thêm sản phẩm";
                dataGridView_SanPham_Click(sender, e);
                isAdding = false;
            }
            else
            {
                if (isEditting) btnUpdate_Click(sender, e);
                mode = 1;
                isAdding = true;
                btnThem.Text = "Hủy thêm";
                CancelBinding();
                btnConfirmThem.Enabled = true;
                txtTenSP.Enabled = true;
                txtSoLuongSP.Enabled = true;
                txtDonGia.Enabled = true;
                comboBoxNSX.Enabled = true;
                btnThemNSX.Enabled = true;
                txtTenSP.Text = "";
                txtSoLuongSP.Text = "";
                txtDonGia.Text = "";
            }
        }

        private bool areFieldsValid()
        {
            return XuLy.isNumber(txtSoLuongSP.Text) && txtTenSP.Text != string.Empty && XuLy.isNumber(txtDonGia.Text) && is_NSX_Valid();
        }
        private void txtTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter) {
                if (areFieldsValid())
                {
                    if (mode == 1)
                        getData.AddSanPham(txtTenSP.Text, int.Parse(txtSoLuongSP.Text), int.Parse(txtDonGia.Text), comboBoxNSX.SelectedValue.ToString(), comboBoxNSX.Text);
                    else
                    {
                        tempTen = txtTenSP.Text;
                        tempSoLuong = txtSoLuongSP.Text;
                        tempDonGia = txtDonGia.Text;
                        tempNSX = comboBoxNSX.Text;

                        btnUpdate_Click(sender, new EventArgs());
                        comboBoxNSX.Text = tempNSX;
                        txtTenSP.Text = tempTen;
                        txtSoLuongSP.Text = tempSoLuong;
                        txtDonGia.Text = tempDonGia;
                        int i = dataGridView_SanPham.CurrentCell.RowIndex;
                        i=(i+1)%(dataGridView_SanPham.Rows.Count);
                        dataGridView_SanPham.CurrentCell = dataGridView_SanPham.Rows[i].Cells[0];
                        dataGridView_SanPham_Click(sender, new EventArgs());
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (isEditting)
                btnUpdate_Click(sender,e);
            if (isAdding)
                btnThem_Click(sender, e);
            List<DataGridViewRow> rows = dataGridView_SanPham.SelectedRows.Cast<DataGridViewRow>().ToList();
            for (int i = 0; i < rows.Count; i++)
            {
                if (!getData.Can_SanPham_Be_Deleted((int)rows[i].Cells[0].Value))
                {
                    MessageBox.Show("Có sản phẩm có dữ liệu liên quan đến những bảng dữ liệu khác, không thể xóa các sản phẩm này. Vui lòng xóa dũ liệu liên quan đến chúng trước khi xóa!");
                    return;
                }
            }
            if (rows != null)
            {
                getData.RemoveSanPham(rows);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            getData.SaveChanges_SanPham();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isEditting)
            {
                isEditting = false;
                btnUpdate.Text = "Cập nhật sản phẩm";
                DataBinding();
                dataGridView_SanPham_Click(sender, e);
            }
            else {
                if (isAdding) btnThem_Click(sender, e);
                mode = 0;
                isEditting = true;
                btnUpdate.Text = "Hủy cập nhật sản phẩm";
                CancelBinding();
                txtTenSP.Enabled = true;
                txtSoLuongSP.Enabled = true;
                txtDonGia.Enabled = true;
                comboBoxNSX.Enabled = true;
                btnThemNSX.Enabled = true;
            }
        }

        private void dataGridView_SanPham_Click(object sender, EventArgs e)
        {
            DataBinding();
            isEditting = false;
            isAdding = false;
            btnUpdate.Text = "Cập nhật sản phẩm";
            btnThem.Text = "Thêm sản phẩm";
            txtTenSP.Enabled = false;
            txtDonGia.Enabled = false;
            txtSoLuongSP.Enabled = false;
            comboBoxNSX.Enabled = false;
            btnThemNSX.Enabled = false;
            btnConfirmThem.Enabled = false;
        }

        private void btnConfirmThem_Click(object sender, EventArgs e)
        {
            txtTenSP_KeyPress(sender, new KeyPressEventArgs((char)Keys.Enter));
        }
    }
}

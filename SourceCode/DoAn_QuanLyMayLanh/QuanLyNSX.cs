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
    public partial class QuanLyNSX : Form
    {
        XuLy getData = Program.data;
        bool isAdding = false, isEditting=false;
        string tempTen = string.Empty;
        public QuanLyNSX()
        {
            InitializeComponent();
            getData.loadNSX();
            dataGridViewNSX.DataSource = getData.DS_NSX;
            DataBinding();
            txtTen.Enabled = false;
            btnXacNhan.Hide();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                if (txtTen.Text != string.Empty)
                {
                    getData.AddNSX(txtTen.Text);
                }
                btnThem_Click(sender, e);
            }
            else
            {
                tempTen = txtTen.Text;
                btnSua_Click(sender, e);
                txtTen.Text = tempTen;
                int i = dataGridViewNSX.CurrentCell.RowIndex;
                i = (i + 1) % (dataGridViewNSX.Rows.Count);
                dataGridViewNSX.CurrentCell = dataGridViewNSX.Rows[i].Cells[0];
            }
        }

        void DataBinding()
        {
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", getData.DS_NSX, "TENNSX");
        }
        void CancelBinding()
        {
            txtTen.DataBindings.Clear();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> list = dataGridViewNSX.SelectedRows.Cast<DataGridViewRow>().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (!getData.Can_NSX_Be_Deleted((int)list[i].Cells[0].Value))
                {
                    MessageBox.Show("Có nhà sản xuất đã có dữ liệu liên quan đến những bảng dữ liệu khác, không thể xóa các nhà sản xuất này. Vui lòng xóa dữ liệu liên quan đến họ trước khi xóa!");
                    return;
                }
            }
            getData.RemoveNSX(list);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                isAdding = false;
                btnThem.Text = "Thêm nhà sản xuất";
                btnXacNhan.Hide();
                txtTen.Enabled = false;
                DataBinding();
            }
            else
            {
                CancelBinding();
                txtTen.Text = string.Empty;
                isAdding = true;
                btnThem.Text = "Hủy thêm";
                btnXacNhan.Show();
                txtTen.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isAdding) btnThem_Click(sender, e);
            if (isEditting)
            {
                isEditting = false;
                btnXacNhan.Hide();
                btnSua.Text = "Sửa nhà sản xuất";
                txtTen.Enabled = false;
                DataBinding();
            }
            else 
            {
                isEditting = true;
                CancelBinding();
                btnXacNhan.Show();
                txtTen.Enabled = true;
                btnSua.Text = "Hủy sửa";
            }
        }

        private void dataGridViewNSX_Click(object sender, EventArgs e)
        {
            if (isAdding) btnThem_Click(sender, e);
            if (isEditting) btnSua_Click(sender, e);
            btnXacNhan.Hide();
            txtTen.Enabled = false;
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnXacNhan_Click(sender, new EventArgs());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            getData.SaveChanges_NSX();
        }
    }
}

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
    public partial class DoiMatKhau : Form
    {
        XuLy getData = Program.data;
        public DoiMatKhau()
        {
            InitializeComponent();
            btnXacNhan.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMKMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMKMoi_XacNhan_TextChanged(object sender, EventArgs e)
        {
            if (txtMKMoi.Text != txtMKMoi_XacNhan.Text)
            {
                errorProvider2.SetError(txtMKMoi_XacNhan, "Mật khẩu không trùng khớp!");
                btnXacNhan.Enabled = false;
            }
            else
            {
                errorProvider2.Clear();
                btnXacNhan.Enabled = true;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text != Program.MK)
            {
                errorProvider1.SetError(txtMKCu, "Sai mật khẩu cũ!");
            }
            else
            {
                errorProvider1.Clear();
                getData.DoiMatKhau(txtMKMoi_XacNhan.Text);
                Close();
            }
        }
    }
}

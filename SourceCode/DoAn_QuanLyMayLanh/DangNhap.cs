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
    public partial class DangNhap : Form
    {
        XuLy getData = Program.data;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (!getData.DangNhap(txtUsr.Text, txtMK.Text))
                errorProvider1.SetError(this.txtMK, "Sai mật khẩu hoặc tên đăng nhập");
            else Close();
        }
    }
}

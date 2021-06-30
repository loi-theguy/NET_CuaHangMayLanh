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
    public partial class Main : Form
    {
        XuLy getData = Program.data;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DangNhap form = new DangNhap();
            form.ShowDialog();
            this.Text = "Trang chủ - Xin chào, " + Program.TenNV;
            if (Program.MaNV == -1) Close();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            if (Program.LoaiNV == 3)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này, vui lòng chọn chức năng khác!");
                return;
            }
            bool isCreated = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
                if (Application.OpenForms[i].Name == "QuanLySanPham")
                {
                    isCreated = true;
                    Application.OpenForms[i].BringToFront();
                }
            if (!isCreated)
            {
                QuanLySanPham form = new QuanLySanPham();
                form.MdiParent = this;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            if (Program.LoaiNV == 3)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này, vui lòng chọn chức năng khác!");
                return;
            }
            bool isCreated = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
                if (Application.OpenForms[i].Name == "QuanLyNhanVien")
                {
                    isCreated = true;
                    Application.OpenForms[i].BringToFront();
                }
            if (!isCreated)
            {
                QuanLyNhanVien form = new QuanLyNhanVien();
                form.MdiParent = this;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            bool isCreated = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
                if (Application.OpenForms[i].Name == "QuanLyKhachHang")
                {
                    isCreated = true;
                    Application.OpenForms[i].BringToFront();
                }
            if (!isCreated)
            {
                QuanLyKhachHang form = new QuanLyKhachHang();
                form.MdiParent = this;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            bool isCreated = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
                if (Application.OpenForms[i].Name == "QuanLyHoaDon")
                {
                    isCreated = true;
                    Application.OpenForms[i].BringToFront();
                }
            if (!isCreated)
            {
                QuanLyHoaDon form = new QuanLyHoaDon();
                form.MdiParent = this;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

        private void btnQLNSX_Click(object sender, EventArgs e)
        {
            if (Program.LoaiNV == 3)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này, vui lòng chọn chức năng khác!");
                return;
            }
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
                form.MdiParent = this;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

        private void btnQLNK_Click(object sender, EventArgs e)
        {
            if (Program.LoaiNV == 3)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này, vui lòng chọn chức năng khác!");
                return;
            }
            bool isCreated = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
                if (Application.OpenForms[i].Name == "QuanLyNhapKho")
                {
                    isCreated = true;
                    Application.OpenForms[i].BringToFront();
                }
            if (!isCreated)
            {
                QuanLyNhapKho form = new QuanLyNhapKho();
                form.MdiParent = this;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
            Program.MaNV = -1;
            Main_Load(null, null);
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            bool isCreated = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
                if (Application.OpenForms[i].Name == "DoiMatKhau")
                {
                    isCreated = true;
                    Application.OpenForms[i].BringToFront();
                }
            if (!isCreated)
            {
                DoiMatKhau form = new DoiMatKhau();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnThongKeNV_Click(object sender, EventArgs e)
        {
            bool isCreated = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
                if (Application.OpenForms[i].Name == "Form_Report_NhanVien")
                {
                    isCreated = true;
                    Application.OpenForms[i].BringToFront();
                }
            if (!isCreated)
            {
                Form_Report_NhanVien form = new Form_Report_NhanVien();
                form.MdiParent = this;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

        private void btnThonKeHD_Click(object sender, EventArgs e)
        {
            bool isCreated = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
                if (Application.OpenForms[i].Name == "Form_Report_HoaDon")
                {
                    isCreated = true;
                    Application.OpenForms[i].BringToFront();
                }
            if (!isCreated)
            {
                Form_Report_HoaDon form = new Form_Report_HoaDon();
                form.MdiParent = this;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

        private void btnThongKeNK_Click(object sender, EventArgs e)
        {
            bool isCreated = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
                if (Application.OpenForms[i].Name == "Form_Report_NhapKho")
                {
                    isCreated = true;
                    Application.OpenForms[i].BringToFront();
                }
            if (!isCreated)
            {
                Form_Report_NhapKho form = new Form_Report_NhapKho();
                form.MdiParent = this;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

        private void btnThongKeKH_Click(object sender, EventArgs e)
        {
            bool isCreated = false;
            for (int i = 0; i < Application.OpenForms.Count; i++)
                if (Application.OpenForms[i].Name == "Form_Report_KhachHang")
                {
                    isCreated = true;
                    Application.OpenForms[i].BringToFront();
                }
            if (!isCreated)
            {
                Form_Report_KhachHang form = new Form_Report_KhachHang();
                form.MdiParent = this;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

    }
}

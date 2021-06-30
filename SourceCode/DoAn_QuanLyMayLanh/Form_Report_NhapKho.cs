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
    public partial class Form_Report_NhapKho : Form
    {
        public Form_Report_NhapKho()
        {
            InitializeComponent();
        }

        private void Form_Report_NhapKho_Load(object sender, EventArgs e)
        {
            Report_NhapKho rp = new Report_NhapKho();
            crystalReportViewer1.ReportSource = rp;
        }
    }
}

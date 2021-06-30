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
    public partial class Form_Report_HoaDon : Form
    {
        public Form_Report_HoaDon()
        {
            InitializeComponent();
        }

        private void Form_Report_HoaDon_Load(object sender, EventArgs e)
        {
            Report_HoaDon rp = new Report_HoaDon();
            crystalReportViewer1.ReportSource = rp;
        }
    }
}

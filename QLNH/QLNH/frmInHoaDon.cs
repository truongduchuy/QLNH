using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
        }

     
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = CTHD_BLL.Instance.CTHD_HDBH(frmCTHD.MaHoaDon);
            HoaDonBanHang rp = new HoaDonBanHang();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}

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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DataTable dt = HoaDonBLL.Instance.ThongKeDoanhThu(dtpkNgayBatDau.Value, dtpkNgayKetThuc.Value);
            foreach (DataRow row in dt.Rows)
            {
                dtgvDoanhThu.Rows.Add(row[0].ToString(), row[1].ToString(),
                    row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
            }
        }
    }
}

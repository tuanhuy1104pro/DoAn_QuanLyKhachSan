using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Application
{
    public partial class EditChucVu : Form
    {
        public static EditChucVu instanceEditChucVu = new EditChucVu();
        public EditChucVu()
        {
            InitializeComponent();
            instanceEditChucVu = this;
        }

        private void EditChucVu_Load(object sender, EventArgs e)
        {
           txtTenCV.Text = NhanSu.rowFlag["TenCV"].ToString();
            txtPhuCap.Text = NhanSu.rowFlag["PhuCap"].ToString();
        }

        private void btnEditChucVu_Click(object sender, EventArgs e)
        {
           
                this.Close();
        }
    }
}

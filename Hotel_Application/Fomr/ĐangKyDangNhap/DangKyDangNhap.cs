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
    public partial class DangKyDangNhap : Form
    {
        public Form formmisspass { get; set; } //
        public DangKyDangNhap()
        {
            InitializeComponent();
        }

        private void llbFindPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.Location = this.Location;   
            formmisspass = quenMatKhau;
            quenMatKhau.FormClosing += delegate { this.Show(); };
            this.Hide();
            quenMatKhau.Show();
        }

        
        
    }
}

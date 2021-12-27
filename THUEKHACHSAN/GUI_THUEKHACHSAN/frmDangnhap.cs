using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_THUEKHACHSAN;

namespace GUI_THUEKHACHSAN
{
    public partial class frmDangnhap : Form
    {
        BUS_Nhanvien busnhanvien = new BUS_Nhanvien();
        public frmDangnhap()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Username or Password is empty!", "Thông báo");
            else if (busnhanvien.ktdn(txtUsername.Text, txtPassword.Text).Rows.Count > 0)
            {
                mySave.KT = !mySave.KT;
                DataTable user = busnhanvien.ktdn(txtUsername.Text, txtPassword.Text);
                nhanvien.ID = (long)user.Rows[0]["idnhanvien"];
                nhanvien.TEN = (string)user.Rows[0]["hoten"];
                MessageBox.Show("Login Successful!", "Thông báo");
                Close();
            }
            else MessageBox.Show("Username or Password is not correct!", "Thông báo");
        }
    }
}

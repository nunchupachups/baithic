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

    public partial class frmLichsuthue : Form
    {

        BUS_Thuephong busThuephong = new BUS_Thuephong();
        BUS_Phong busphong = new BUS_Phong();
        public frmLichsuthue()
        {
            InitializeComponent();
            dgvThuephong.DataSource = busThuephong.getListThuephong(1);
            tkTenphong.Focus();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (tkTenphong.Text.Equals("") && tkTenkhach.Text.Equals("")) dgvThuephong.DataSource = busThuephong.getListThuephong(1);
            else if (!tkTenphong.Text.Equals("") && tkTenkhach.Text.Equals("")) dgvThuephong.DataSource = busThuephong.timkiemBytenphong(tkTenphong.Text,1);
            else if (tkTenphong.Text.Equals("") && !tkTenkhach.Text.Equals("")) dgvThuephong.DataSource = busThuephong.timkiemBytenkhach(tkTenkhach.Text,1);
            else if (!tkTenphong.Text.Equals("") && !tkTenkhach.Text.Equals("")) dgvThuephong.DataSource = busThuephong.timkiem(tkTenphong.Text, tkTenkhach.Text,1);
        }

        private void dgvThuephong_Click(object sender, EventArgs e)
        {
            int i = dgvThuephong.CurrentRow.Index;
            if ((i <= dgvThuephong.Rows.Count - 2) && dgvThuephong.Rows.Count > 1)
            {
                DataTable tt = busThuephong.getThongtinthuephong((long)dgvThuephong[0, i].Value);
                txtMaphong.Text = tt.Rows[0]["maphong"].ToString();
                txtTenphong.Text = tt.Rows[0]["tenphong"].ToString();
                txtTang.Text = tt.Rows[0]["tang"].ToString();
                txtLoaiphong.Text = tt.Rows[0]["loaiphong"].ToString();
                txtGiathuephong.Text = tt.Rows[0]["dongia"].ToString();
                txtHotenkhach.Text = tt.Rows[0]["tenkhach"].ToString();
                txtSoCMND.Text = tt.Rows[0]["soCMND"].ToString();
                txtSoluonguoi.Text = tt.Rows[0]["songuoi"].ToString();
                txtThuephong.Text = tt.Rows[0]["ngaythue"].ToString();
                txtManhanvien.Text = tt.Rows[0]["idnhanvien"].ToString();
                txtTennhanvien.Text = tt.Rows[0]["hoten"].ToString();
                txtMahoadon.Text = tt.Rows[0]["mahoadon"].ToString();
                txtTraphong.Text = tt.Rows[0]["ngaytra"].ToString();
                lblTongtien.Text = tt.Rows[0]["tongtien"].ToString() + "đ";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

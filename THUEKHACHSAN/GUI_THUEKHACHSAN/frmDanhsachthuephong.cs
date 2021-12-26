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
    public partial class frmDanhsachthuephong : Form
    {
        BUS_Thuephong busThuephong = new BUS_Thuephong();
        BUS_Phong busphong = new BUS_Phong();
        public frmDanhsachthuephong()
        {
            InitializeComponent();
            dgvThuephong.DataSource = busThuephong.getListThuephong(0);
            tkTenphong.Focus();
            btnHuyphong.Enabled = btnDoiphong.Enabled = btnTraphong.Enabled = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (tkTenphong.Text == null && tkTenkhach.Text == null) dgvThuephong.DataSource = busThuephong.getListThuephong(0);
            else if (tkTenphong.Text != null && tkTenkhach.Text == null) dgvThuephong.DataSource = busThuephong.timkiemBytenphong(tkTenphong.Text,0);
            else if (tkTenphong.Text == null && tkTenkhach.Text != null) dgvThuephong.DataSource = busThuephong.timkiemBytenkhach(tkTenkhach.Text,0);
            else if (tkTenphong.Text != null && tkTenkhach.Text != null) dgvThuephong.DataSource = busThuephong.timkiem(tkTenphong.Text, tkTenkhach.Text,0);
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
                dtThuephong.Text = tt.Rows[0]["ngaythue"].ToString();
                txtManhanvien.Text = tt.Rows[0]["idnhanvien"].ToString();
                txtTennhanvien.Text = tt.Rows[0]["hoten"].ToString();
                txtMahoadon.Text = tt.Rows[0]["mahoadon"].ToString();
                dtTraphong.Text = DateTime.Now.ToString();
                int day = DateTime.Now.Subtract(DateTime.Parse(dtThuephong.Text)).Days;
                if (DateTime.Now.Subtract(DateTime.Parse(dtThuephong.Text)).Hours > 1) day++;
                lblTongtien.Text = (day * int.Parse(txtSoluonguoi.Text) * float.Parse(txtGiathuephong.Text)).ToString() + "đ";
                btnHuyphong.Enabled = btnDoiphong.Enabled = btnTraphong.Enabled = true;
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvThuephong.DataSource = busThuephong.getListThuephong(0);
            tkTenphong.Focus();
            btnHuyphong.Enabled = btnDoiphong.Enabled = btnTraphong.Enabled = false;
            txtMaphong.Text = "";
            txtTenphong.Text = "";
            txtTang.Text = "";
            txtLoaiphong.Text = "";
            txtGiathuephong.Text = "";
            txtHotenkhach.Text = "";
            txtSoCMND.Text = "";
            txtSoluonguoi.Text = "";
            dtThuephong.Text = "";
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            txtMahoadon.Text = "";
            dtTraphong.Text = "";
            lblTongtien.Text = "";
        }

        private void btnHuyphong_Click(object sender, EventArgs e)
        {
            busThuephong.deleteThuephong(long.Parse(txtMahoadon.Text));
            dgvThuephong.DataSource = busThuephong.getListThuephong(0);
            tkTenphong.Focus();
            btnHuyphong.Enabled = btnDoiphong.Enabled = btnTraphong.Enabled = false;
            txtMaphong.Text = "";
            txtTenphong.Text = "";
            txtTang.Text = "";
            txtLoaiphong.Text = "";
            txtGiathuephong.Text = "";
            txtHotenkhach.Text = "";
            txtSoCMND.Text = "";
            txtSoluonguoi.Text = "";
            dtThuephong.Text = "";
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            txtMahoadon.Text = "";
            dtTraphong.Text = "";
            lblTongtien.Text = "";
        }

        private void btnTraphong_Click(object sender, EventArgs e)
        {
            busphong.updateTinhtrangPhong(long.Parse(txtMaphong.Text), 2);
            busThuephong.traPhong(long.Parse(txtMahoadon.Text), nhanvien.ID);
            dgvThuephong.DataSource = busThuephong.getListThuephong(0);
            tkTenphong.Focus();
            btnHuyphong.Enabled = btnDoiphong.Enabled = btnTraphong.Enabled = false;
            txtMaphong.Text = "";
            txtTenphong.Text = "";
            txtTang.Text = "";
            txtLoaiphong.Text = "";
            txtGiathuephong.Text = "";
            txtHotenkhach.Text = "";
            txtSoCMND.Text = "";
            txtSoluonguoi.Text = "";
            dtThuephong.Text = "";
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            txtMahoadon.Text = "";
            dtTraphong.Text = "";
            lblTongtien.Text = "";
        }

        private void btnDoiphong_Click(object sender, EventArgs e)
        {
            mahoadondoi.MAHOADON = long.Parse(txtMahoadon.Text);
            frmDoiphong dp = new frmDoiphong();
            dp.Show();
            
        }

        private void frmDanhsachthuephong_Activated(object sender, EventArgs e)
        {
            dgvThuephong.DataSource = busThuephong.getListThuephong(0);
            tkTenphong.Focus();
            btnHuyphong.Enabled = btnDoiphong.Enabled = btnTraphong.Enabled = false;
            txtMaphong.Text = "";
            txtTenphong.Text = "";
            txtTang.Text = "";
            txtLoaiphong.Text = "";
            txtGiathuephong.Text = "";
            txtHotenkhach.Text = "";
            txtSoCMND.Text = "";
            txtSoluonguoi.Text = "";
            dtThuephong.Text = "";
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            txtMahoadon.Text = "";
            dtTraphong.Text = "";
            lblTongtien.Text = "";
        }
    }
}

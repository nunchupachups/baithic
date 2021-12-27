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
    public partial class frmChitietphong : Form
    {
        BUS_Phong busphong = new BUS_Phong();
        public frmChitietphong()
        {
            InitializeComponent();
            LoadChitietphong();
            
        }

        public void LoadChitietphong()
        {
            cbbLoaiphong.Items.Add("VIP");
            cbbLoaiphong.Items.Add("Superior");
            cbbLoaiphong.Items.Add("Standard");
            cbbSonguoitoida.Items.Add(2);
            cbbSonguoitoida.Items.Add(4);
            cbbTinhtrang.Items.Add("Phòng trống");
            cbbTinhtrang.Items.Add("Phòng đã cho thuê");
            cbbTinhtrang.Items.Add("Phòng đang dọn dẹp");
            cbbTinhtrang.Items.Add("Phòng hỏng");
            cbbTang.Items.Add("1");
            cbbTang.Items.Add("2");
            cbbTang.Items.Add("3");
            cbbTang.Items.Add("4");
            cbbTang.Items.Add("5");
            DataTable phong = busphong.getPhongByma(maphonghitiet.MAPHONG);
            if (phong.Rows.Count > 0)
            {
                txtMaphong.Text = phong.Rows[0]["maphong"].ToString();
                txtTenphong.Text = phong.Rows[0]["tenphong"].ToString();
                cbbTang.Text = phong.Rows[0]["tang"].ToString();
                cbbLoaiphong.Text = phong.Rows[0]["loaiphong"].ToString();
                cbbSonguoitoida.Text = phong.Rows[0]["songuoitoida"].ToString();
                txtDongia.Text = phong.Rows[0]["dongia"].ToString();
                txtMota.Text = phong.Rows[0]["mota"].ToString();
                int tt = int.Parse(phong.Rows[0]["tinhtrang"].ToString());
                if (tt == 0) cbbTinhtrang.Text = "Phòng trống";
                else if (tt == 1) cbbTinhtrang.Text = "Phòng đã cho thuê";
                else if (tt == 2) cbbTinhtrang.Text = "Phòng đang dọn dẹp";
                else cbbTinhtrang.Text = "Phòng hỏng";
            }
            
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            busphong.deletePhong(maphonghitiet.MAPHONG);
            MessageBox.Show("Xoá phòng thành công", "Thông báo");
            Close();
            LoadChitietphong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool kt=true;
            foreach(char c in txtDongia.Text)
            {
                if ((byte)c < 48 || (byte)c > 57)
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
            {
                int tinhtrang;
                if (cbbTinhtrang.Text.Equals("Phòng trống")) tinhtrang = 0;
                else if (cbbTinhtrang.Text.Equals("Phòng đã cho thuê")) tinhtrang = 1;
                else if (cbbTinhtrang.Text.Equals("Phòng đang dọn dẹp")) tinhtrang = 2;
                else tinhtrang = 3;

                busphong.updatePhong(long.Parse(txtMaphong.Text), txtTenphong.Text, int.Parse(cbbTang.Text), cbbLoaiphong.Text, int.Parse(cbbSonguoitoida.Text), float.Parse(txtDongia.Text), txtMota.Text, tinhtrang);
                MessageBox.Show("Sửa phòng thành công", "Thông báo");
                Close();
                LoadChitietphong();
            }
            else
            {
                MessageBox.Show("Đơn giá chỉ được chứa ký tự số", "Thông báo");
            }
            
        }
    }
}

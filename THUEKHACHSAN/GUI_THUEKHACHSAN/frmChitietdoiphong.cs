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
    public partial class frmChitietdoiphong : Form
    {
        BUS_Phong busphong = new BUS_Phong();
        BUS_Thuephong busthuephong = new BUS_Thuephong();
        public frmChitietdoiphong()
        {
            InitializeComponent();
            LoadChitietdoiphong();
        }

        public void LoadChitietdoiphong()
        {
            DataTable phong = busphong.getPhongByma(maphonghitiet.MAPHONG);
            if (phong.Rows.Count > 0)
            {
                txtMaphong.Text = phong.Rows[0]["maphong"].ToString();
                txtTenphong.Text = phong.Rows[0]["tenphong"].ToString();
                txtTang.Text = phong.Rows[0]["tang"].ToString();
                txtLoaiphong.Text = phong.Rows[0]["loaiphong"].ToString();
                txtSonguoitoida.Text = phong.Rows[0]["songuoitoida"].ToString();
                txtDongia.Text = phong.Rows[0]["dongia"].ToString();
                txtMota.Text = phong.Rows[0]["mota"].ToString();
                int tt = int.Parse(phong.Rows[0]["tinhtrang"].ToString());
                btnDoiphong.Enabled = false;
                if (tt == 0)
                {
                    txtTinhtrang.Text = "Phòng trống";
                    btnDoiphong.Enabled = true;
                }
                else if (tt == 1) txtTinhtrang.Text = "Phòng đã cho thuê";
                else if (tt == 2) txtTinhtrang.Text = "Phòng đang dọn dẹp";
                else txtTinhtrang.Text = "Phòng hỏng";
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDoiphong_Click(object sender, EventArgs e)
        {
            DataTable dt = busthuephong.getThongtinthuephong(mahoadondoi.MAHOADON);

            Console.WriteLine(dt.Rows[0]["tenkhach"].ToString());
            Console.WriteLine(dt.Rows[0]["soCMND"].ToString());
            Console.WriteLine(maphonghitiet.MAPHONG);
            Console.WriteLine(DateTime.Parse(dt.Rows[0]["ngaythue"].ToString()));
            Console.WriteLine(int.Parse(dt.Rows[0]["songuoi"].ToString()));
            Console.WriteLine(mahoadondoi.MAHOADON);
            busthuephong.updateThuephong(dt.Rows[0]["tenkhach"].ToString(), dt.Rows[0]["soCMND"].ToString(), maphonghitiet.MAPHONG, DateTime.Parse(dt.Rows[0]["ngaythue"].ToString()), int.Parse(dt.Rows[0]["songuoi"].ToString()),mahoadondoi.MAHOADON );
            MessageBox.Show("Đổi phòng thành công", "Thông báo");
            Close();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

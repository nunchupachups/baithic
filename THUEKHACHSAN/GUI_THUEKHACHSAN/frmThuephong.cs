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
    public partial class frmThuephong : Form
    {
        BUS_Thuephong busthuephong = new BUS_Thuephong();
        BUS_Phong busphong = new BUS_Phong();

        public frmThuephong()
        {
            InitializeComponent();
            dgvPhong.DataSource = busphong.getListPhongtrong();
            for (int i = 1; i <= 5; i++) cbbTang.Items.Add(i.ToString());
            cbbLoaiphong.Items.Add("VIP");
            cbbLoaiphong.Items.Add("Superior");
            cbbLoaiphong.Items.Add("Standard");
            cbbSonguoitoida.Items.Add(2);
            cbbSonguoitoida.Items.Add(4);
            cbbTang.Focus();
            txtTennhanvien.Text = nhanvien.TEN;
            txtManhanvien.Text = nhanvien.ID.ToString();
        }

        private void btnThuephong_Click(object sender, EventArgs e )
        {
            bool kt = true;
            foreach (char c in txtSoCMND.Text)
            {
                if ((byte)c < 48 || (byte)c > 57)
                {
                    kt = false;
                    break;
                }
            }

            bool kt1 = true;
            foreach (char c in txtSoluonguoi.Text)
            {
                if ((byte)c < 48 || (byte)c > 57)
                {
                    kt1 = false;
                    break;
                }
            }
            bool kt2 = true;
            foreach (char c in txtHotenkhach.Text)
            {
                if ((byte)c < 65 || (byte)c > 90&&(byte)c < 97 || (byte)c >122)
                {
                    kt2 = false;
                    break;
                }
            }

            if (txtMaphong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải chọn phòng", "Thông báo");
            } else if (txtHotenkhach.Text.Trim() == "")
            {
                txtHotenkhach.Focus();
                MessageBox.Show("Không được bỏ trống tên khách", "Thông báo");
            } else if (txtSoCMND.Text.Trim() == "")
            {
                txtSoCMND.Focus();
                MessageBox.Show("Không được bỏ trống Số chứng minh nhân dân của khách", "Thông báo");
            } else if (txtSoluonguoi.Text.Trim() == "")
            {
                txtSoluonguoi.Focus();
                MessageBox.Show("Không được bỏ trống số lượng người", "Thông báo");
            }
            else if (dtThuephong.Text.Trim() == "")
            {
                dtThuephong.Focus();
                MessageBox.Show("Không được bỏ trống ngày thuê phòng", "Thông báo");
            }
            else if (!kt)
            {
                txtSoCMND.Focus();
                MessageBox.Show("Số CMND chỉ được chứa ký tự số", "Thông báo");
            }
            else if (!kt1)
            {
                txtSoluonguoi.Focus();
                MessageBox.Show("Số người chỉ được chứa ký tự số", "Thông báo");
            }
            else if (!kt2)
            {
                txtHotenkhach.Focus();
                MessageBox.Show("Họ tên khách chỉ được chứa ký tự chữ", "Thông báo");
            }
            else if (int.Parse(txtSoluonguoi.Text.Trim())>(int)dgvPhong[4,dgvPhong.CurrentRow.Index].Value)
            {
                
                txtSoluonguoi.Focus();
                MessageBox.Show("Số người không được lớn hơn số người tối đa của phòng", "Thông báo");
            }
            else 
            {
                bool tp =busthuephong.insertThuephong(txtHotenkhach.Text, txtSoCMND.Text, long.Parse(txtMaphong.Text),DateTime.Parse(dtThuephong.Text), long.Parse(txtManhanvien.Text),  int.Parse(txtSoluonguoi.Text));
                if(tp) MessageBox.Show("Thuê phòng thành công", "Thông báo");
                else MessageBox.Show("Thuê phòng thất bại", "Thông báo");
                dgvPhong.DataSource= busphong.getListPhongtrong();
                cbbTang.Focus();
                cbbTang.Text = "";
                cbbLoaiphong.Text = "";
                cbbSonguoitoida.Text = "";
                txtMaphong.Text = "";
                txtTenphong.Text = "";
                txtTang.Text = "";
                txtLoaiphong.Text = "";
                txtGiathuephong.Text = "";
                txtHotenkhach.Text = "";
                txtSoCMND.Text = "";
                txtSoluonguoi.Text = "";
                dtThuephong.Text = "";

            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

            if (cbbTang.SelectedItem == null && cbbLoaiphong.SelectedItem == null && cbbSonguoitoida.SelectedItem == null)
                dgvPhong.DataSource = busphong.getListPhongtrong();
            else if (cbbTang.SelectedItem != null && cbbLoaiphong.SelectedItem == null && cbbSonguoitoida.SelectedItem == null)
                dgvPhong.DataSource = busphong.timkiemPhongtrongBytang(cbbTang.SelectedItem.ToString());
            else if (cbbTang.SelectedItem == null && cbbLoaiphong.SelectedItem != null && cbbSonguoitoida.SelectedItem == null)
                dgvPhong.DataSource = busphong.timkiemPhongtrongByloaiphong(cbbLoaiphong.SelectedItem.ToString());
            else if (cbbTang.SelectedItem == null && cbbLoaiphong.SelectedItem == null && cbbSonguoitoida.SelectedItem != null)
                dgvPhong.DataSource = busphong.timkiemPhongtrongBysonguoitoida(cbbSonguoitoida.SelectedItem.ToString());
            else if (cbbTang.SelectedItem != null && cbbLoaiphong.SelectedItem != null && cbbSonguoitoida.SelectedItem == null)
                dgvPhong.DataSource = busphong.timkiemPhongtrongBytangvaloaiphong(cbbTang.SelectedItem.ToString(), cbbLoaiphong.SelectedItem.ToString());
            else if (cbbTang.SelectedItem == null && cbbLoaiphong.SelectedItem != null && cbbSonguoitoida.SelectedItem != null)
                dgvPhong.DataSource = busphong.timkiemPhongtrongByloaiphongvasonguoitoida(cbbLoaiphong.SelectedItem.ToString() ,cbbSonguoitoida.SelectedItem.ToString());
            else if (cbbTang.SelectedItem != null && cbbLoaiphong.SelectedItem == null && cbbSonguoitoida.SelectedItem != null)
                dgvPhong.DataSource = busphong.timkiemPhongtrongBytangvasonguoitoida( cbbTang.SelectedItem.ToString(),cbbSonguoitoida.SelectedItem.ToString());
            else if (cbbTang.SelectedItem != null && cbbLoaiphong.SelectedItem != null && cbbSonguoitoida.SelectedItem != null)
                dgvPhong.DataSource = busphong.timkiemPhongtrong(cbbTang.SelectedItem.ToString(),cbbLoaiphong.SelectedItem.ToString(),cbbSonguoitoida.SelectedItem.ToString());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPhong_Click(object sender, EventArgs e)
        {
            int i = dgvPhong.CurrentRow.Index;
            txtMaphong.Text = dgvPhong[0, i].Value.ToString();
            txtTenphong.Text = dgvPhong[1, i].Value.ToString();
            txtTang.Text = dgvPhong[2, i].Value.ToString();
            txtGiathuephong.Text = dgvPhong[5, i].Value.ToString();
            txtLoaiphong.Text = dgvPhong[3, i].Value.ToString();
            txtHotenkhach.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbTang.Focus();
            cbbTang.Text = "";
            cbbLoaiphong.Text = "";
            cbbSonguoitoida.Text = "";
            txtMaphong.Text = "";
            txtTenphong.Text = "";
            txtTang.Text = "";
            txtLoaiphong.Text = "";
            txtGiathuephong.Text = "";
            txtHotenkhach.Text = "";
            txtSoCMND.Text = "";
            txtSoluonguoi.Text = "";
            dtThuephong.Text = "";
        }
    }
}

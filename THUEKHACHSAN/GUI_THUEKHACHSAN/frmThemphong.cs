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
    public partial class frmThemphong : Form
    {
        BUS_Phong busphong = new BUS_Phong();
        public frmThemphong()
        {
            InitializeComponent();
            txtTenphong.Focus();
            cbbLoaiphong.Items.Add("VIP");
            cbbLoaiphong.Items.Add("Superior");
            cbbLoaiphong.Items.Add("Standard");
            cbbLoaiphong.SelectedIndex = 0;
            cbbSonguoitoida.Items.Add(2);
            cbbSonguoitoida.Items.Add(4);
            cbbSonguoitoida.SelectedIndex = 0;
            txtTang.Text = tangthemphong.TANG.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenphong.Text.Trim().Equals("")||txtTenphong==null||cbbLoaiphong.SelectedItem.ToString().Trim().Equals("")||cbbLoaiphong==null||cbbSonguoitoida.SelectedItem.ToString().Trim().Equals("")||cbbSonguoitoida==null||txtDongia.Text.Trim().Equals("")||txtDongia==null||txtMota.Text.Trim().Equals("")||txtMota==null)
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo");
            else
            {
                busphong.insertPhong(txtTenphong.Text, int.Parse(txtTang.Text), cbbLoaiphong.SelectedItem.ToString(), int.Parse(cbbSonguoitoida.SelectedItem.ToString()), float.Parse(txtDongia.Text), txtMota.Text, 0);
                MessageBox.Show("Thêm phòng thành công", "Thông báo");
                Close();
            }
                
        }
    }
}

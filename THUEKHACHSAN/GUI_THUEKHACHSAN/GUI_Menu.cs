using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_THUEKHACHSAN
{
    public partial class GUI_Menu : Form
    {
        public GUI_Menu()
        {
            InitializeComponent();
            Lock_Unlock(mySave.KT);
        }

        void Lock_Unlock(Boolean kt)
        {
            mnuDangxuat.Enabled = mnuSodophong.Enabled = mnuQuanlithuephong.Enabled = mnuLichsuthuephong.Enabled = !kt;
            mnuDangnhap.Enabled = mnuThoat.Enabled = kt;
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuDangnhap_Click(object sender, EventArgs e)
        {
            frmDangnhap dn = new frmDangnhap();
            dn.Show();
        }

        private void mnuDangxuat_Click(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
            Lock_Unlock(mySave.KT);

        }

        private void GUI_Menu_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.KT);
        }

        private void mnuThuephong_Click(object sender, EventArgs e)
        {
            frmThuephong tp = new frmThuephong();
            tp.Show();
        }

        private void mnuTraphong_Click(object sender, EventArgs e)
        {
            frmDanhsachthuephong tp = new frmDanhsachthuephong();
            tp.Show();
        }

        private void mnuSodophong_Click(object sender, EventArgs e)
        {
            frmSodophong sdp = new frmSodophong();
            sdp.Show();
        }

        private void mnuLichsuthuephong_Click(object sender, EventArgs e)
        {
            frmLichsuthue ls = new frmLichsuthue();
            ls.Show();
        }
    }
}

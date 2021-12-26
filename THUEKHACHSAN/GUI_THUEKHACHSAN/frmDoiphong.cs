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

    public partial class frmDoiphong : Form
    {
        List<phongItem> phong;
        BUS_Phong busphong = new BUS_Phong();
        public frmDoiphong()
        {
            InitializeComponent();
            LoadPhong();
        }

        private void LoadPhong()
        {
            flp1.Controls.Clear();
            flp2.Controls.Clear();
            flp3.Controls.Clear();
            flp4.Controls.Clear();
            flp5.Controls.Clear();
            phong = new List<phongItem>();
            DataTable listphong = busphong.getListPhong1();


            for (int i = 0; i < listphong.Rows.Count; i++)
            {
                phongItem a = new phongItem();
                a.loaiphong = listphong.Rows[i]["loaiphong"].ToString();
                a.tenphong = listphong.Rows[i]["tenphong"].ToString();
                a.maphong = listphong.Rows[i]["maphong"].ToString();
                if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhphong = "phongtrong.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhphong = "phongdathue.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhphong = "donphong.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhphong = "phonghong.png";
                phong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietphong_Click(this, e, long.Parse(a.maphong));
            }
            foreach (phongItem p in phong)
            {
                flp1.Controls.Add(p);
            }

            phong.Clear();
            listphong = busphong.getListPhong2();
            for (int i = 0; i < listphong.Rows.Count; i++)
            {
                phongItem a = new phongItem();
                a.loaiphong = listphong.Rows[i]["loaiphong"].ToString();
                a.tenphong = listphong.Rows[i]["tenphong"].ToString();
                a.maphong = listphong.Rows[i]["maphong"].ToString();
                if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhphong = "phongtrong.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhphong = "phongdathue.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhphong = "donphong.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhphong = "phonghong.png";
                phong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietphong_Click(this, e, long.Parse(a.maphong));
            }
            foreach (phongItem p in phong)
            {
                flp2.Controls.Add(p);
            }


            phong.Clear();
            listphong = busphong.getListPhong3();
            for (int i = 0; i < listphong.Rows.Count; i++)
            {
                phongItem a = new phongItem();
                a.loaiphong = listphong.Rows[i]["loaiphong"].ToString();
                a.tenphong = listphong.Rows[i]["tenphong"].ToString();
                a.maphong = listphong.Rows[i]["maphong"].ToString();
                if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhphong = "phongtrong.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhphong = "phongdathue.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhphong = "donphong.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhphong = "phonghong.png";
                phong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietphong_Click(this, e, long.Parse(a.maphong));
            }
            foreach (phongItem p in phong)
            {
                flp3.Controls.Add(p);
            }

            phong.Clear();
            listphong = busphong.getListPhong4();
            for (int i = 0; i < listphong.Rows.Count; i++)
            {
                phongItem a = new phongItem();
                a.loaiphong = listphong.Rows[i]["loaiphong"].ToString();
                a.tenphong = listphong.Rows[i]["tenphong"].ToString();
                a.maphong = listphong.Rows[i]["maphong"].ToString();
                if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhphong = "phongtrong.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhphong = "phongdathue.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhphong = "donphong.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhphong = "phonghong.png";
                phong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietphong_Click(this, e, long.Parse(a.maphong));
            }
            foreach (phongItem p in phong)
            {
                flp4.Controls.Add(p);
            }

            phong.Clear();
            listphong = busphong.getListPhong5();
            for (int i = 0; i < listphong.Rows.Count; i++)
            {
                phongItem a = new phongItem();
                a.loaiphong = listphong.Rows[i]["loaiphong"].ToString();
                a.tenphong = listphong.Rows[i]["tenphong"].ToString();
                a.maphong = listphong.Rows[i]["maphong"].ToString();
                if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 0) a.anhphong = "phongtrong.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 1) a.anhphong = "phongdathue.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 2) a.anhphong = "donphong.png";
                else if (int.Parse(listphong.Rows[i]["tinhtrang"].ToString()) == 3) a.anhphong = "phonghong.png";
                phong.Add(a);
                a.Cursor = Cursors.Hand;
                a.getanh.Click += (sender, e) => chitietphong_Click(this, e, long.Parse(a.maphong));
            }
            foreach (phongItem p in phong)
            {
                flp5.Controls.Add(p);
            }
        }

        public void chitietphong_Click(object sender, EventArgs e, long maphong)
        {
            maphonghitiet.MAPHONG = maphong;
            frmChitietdoiphong ctp = new frmChitietdoiphong();
            ctp.Show();
            Close();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDoiphong_Activated(object sender, EventArgs e)
        {
            LoadPhong();
        }
    }
}

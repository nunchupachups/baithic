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
    public partial class frmSodophong : Form
    {
        List<phongItem> phong;
        BUS_Phong busphong = new BUS_Phong();
        public frmSodophong()
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
            DataTable listphong = busphong.getListPhongbytang(1);
            

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
            foreach(phongItem p in phong)
            {
                flp1.Controls.Add(p);
            }
            if (flp1.Controls.Count < 10)
            {
                addphong a1 = new addphong();
                a1.anhplus = "plus.png";
                a1.tang = 1;
                flp1.Controls.Add(a1);
                a1.Cursor = Cursors.Hand;
                a1.getanh.Click += (sender, e) => addphong_Click(this, e, 1);
                
            }

            phong.Clear();
            listphong = busphong.getListPhongbytang(2);
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
            if (flp2.Controls.Count < 10)
            {
                addphong a1 = new addphong();
                a1.anhplus = "plus.png";
                a1.tang = 2;
                flp2.Controls.Add(a1);
                a1.Cursor = Cursors.Hand;
                a1.getanh.Click += (sender, e) => addphong_Click(this, e, 2);
            }


            phong.Clear();
            listphong = busphong.getListPhongbytang(3);
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
            if (flp3.Controls.Count < 10)
            {
                addphong a1 = new addphong();
                a1.anhplus = "plus.png";
                a1.tang = 3;
                flp3.Controls.Add(a1);
                a1.Cursor = Cursors.Hand;
                a1.getanh.Click += (sender, e) => addphong_Click(this, e, 3);
            }

            phong.Clear();
            listphong = busphong.getListPhongbytang(4);
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
            if (flp4.Controls.Count < 10)
            {
                addphong a1 = new addphong();
                a1.anhplus = "plus.png";
                a1.tang = 4;
                flp4.Controls.Add(a1);
                a1.Cursor = Cursors.Hand;
                a1.getanh.Click += (sender, e) => addphong_Click(this, e, 4);
            }

            phong.Clear();
            listphong = busphong.getListPhongbytang(5);
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
            if (flp5.Controls.Count < 10)
            {
                addphong a1 = new addphong();
                a1.anhplus = "plus.png";
                a1.tang = 5;
                flp5.Controls.Add(a1);
                a1.Cursor = Cursors.Hand;
                a1.getanh.Click += (sender, e) => addphong_Click(this, e, 5);
            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void addphong_Click(object sender, EventArgs e, int tang)
        {
            tangthemphong.TANG = tang;
            frmThemphong tp = new frmThemphong();
            tp.Show();
            LoadPhong();
        }

        public void chitietphong_Click(object sender, EventArgs e, long maphong)
        {
            maphonghitiet.MAPHONG = maphong;
            frmChitietphong ctp = new frmChitietphong();
            ctp.Show();
        }

        private void frmSodophong_Activated(object sender, EventArgs e)
        {
            LoadPhong();
        }
    }
}

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
    public partial class phongItem : UserControl
    {
        public phongItem()
        {
            InitializeComponent();
        }

        public string loaiphong
        {
            get => lblloaiphong.Text;
            set => lblloaiphong.Text = value;
        }

        public string tenphong
        {
            get => lblTenphong.Text;
            set => lblTenphong.Text = value;
        }

        public string maphong
        {
            get => lblMaphong.Text;
            set => lblMaphong.Text = value;
        }
        
        public string anhphong
        {
            set => anh.Image = new Bitmap(Application.StartupPath + "\\Resources\\" + value);
        }

        public PictureBox getanh
        {
            get { return anh; }
        }
    }
     
}

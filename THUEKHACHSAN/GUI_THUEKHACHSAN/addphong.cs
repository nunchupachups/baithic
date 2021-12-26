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
    public partial class addphong : UserControl
    {
        public addphong()
        {
            InitializeComponent();

        }

        
        public string anhplus
        {
            set => anh.Image = new Bitmap(Application.StartupPath + "\\Resources\\" + value);
        }

        public PictureBox getanh
        {
            get { return anh; }
        }
        public int tang
        {
            get => int.Parse(lblTang.Text);
            set => lblTang.Text = value.ToString();
        }
    }
}

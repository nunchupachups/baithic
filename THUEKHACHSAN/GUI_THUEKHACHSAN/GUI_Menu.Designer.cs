
namespace GUI_THUEKHACHSAN
{
    partial class GUI_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSodophong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanlithuephong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuephong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhsachthuephong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLichsuthuephong = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuSodophong,
            this.mnuQuanlithuephong,
            this.mnuLichsuthuephong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangnhap,
            this.mnuDangxuat,
            this.mnuThoat});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(70, 24);
            this.mnuSystem.Text = "System";
            // 
            // mnuDangnhap
            // 
            this.mnuDangnhap.Name = "mnuDangnhap";
            this.mnuDangnhap.Size = new System.Drawing.Size(165, 26);
            this.mnuDangnhap.Text = "Đăng nhập";
            this.mnuDangnhap.Click += new System.EventHandler(this.mnuDangnhap_Click);
            // 
            // mnuDangxuat
            // 
            this.mnuDangxuat.Name = "mnuDangxuat";
            this.mnuDangxuat.Size = new System.Drawing.Size(165, 26);
            this.mnuDangxuat.Text = "Đăng xuất";
            this.mnuDangxuat.Click += new System.EventHandler(this.mnuDangxuat_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(165, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuSodophong
            // 
            this.mnuSodophong.Name = "mnuSodophong";
            this.mnuSodophong.Size = new System.Drawing.Size(109, 24);
            this.mnuSodophong.Text = "Sơ đồ phòng";
            this.mnuSodophong.Click += new System.EventHandler(this.mnuSodophong_Click);
            // 
            // mnuQuanlithuephong
            // 
            this.mnuQuanlithuephong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThuephong,
            this.mnuDanhsachthuephong});
            this.mnuQuanlithuephong.Name = "mnuQuanlithuephong";
            this.mnuQuanlithuephong.Size = new System.Drawing.Size(150, 24);
            this.mnuQuanlithuephong.Text = "Quản lí thuê phòng";
            // 
            // mnuThuephong
            // 
            this.mnuThuephong.Name = "mnuThuephong";
            this.mnuThuephong.Size = new System.Drawing.Size(240, 26);
            this.mnuThuephong.Text = "Thuê phòng";
            this.mnuThuephong.Click += new System.EventHandler(this.mnuThuephong_Click);
            // 
            // mnuDanhsachthuephong
            // 
            this.mnuDanhsachthuephong.Name = "mnuDanhsachthuephong";
            this.mnuDanhsachthuephong.Size = new System.Drawing.Size(240, 26);
            this.mnuDanhsachthuephong.Text = "Danh sách thuê phòng";
            this.mnuDanhsachthuephong.Click += new System.EventHandler(this.mnuTraphong_Click);
            // 
            // mnuLichsuthuephong
            // 
            this.mnuLichsuthuephong.Name = "mnuLichsuthuephong";
            this.mnuLichsuthuephong.Size = new System.Drawing.Size(148, 24);
            this.mnuLichsuthuephong.Text = "Lịch sử thuê phòng";
            this.mnuLichsuthuephong.Click += new System.EventHandler(this.mnuLichsuthuephong_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GUI_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 393);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI_Menu";
            this.Text = "Sơ đồ phòng";
            this.Activated += new System.EventHandler(this.GUI_Menu_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuDangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangxuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuSodophong;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanlithuephong;
        private System.Windows.Forms.ToolStripMenuItem mnuThuephong;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhsachthuephong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuLichsuthuephong;
    }
}


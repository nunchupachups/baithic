
namespace GUI_THUEKHACHSAN
{
    partial class frmDanhsachthuephong
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
            this.btnReset = new System.Windows.Forms.Button();
            this.txtLoaiphong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnTraphong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtThuephong = new System.Windows.Forms.DateTimePicker();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.txtSoluonguoi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTang = new System.Windows.Forms.TextBox();
            this.txtGiathuephong = new System.Windows.Forms.TextBox();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvThuephong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tkTenphong = new System.Windows.Forms.TextBox();
            this.txtHotenkhach = new System.Windows.Forms.TextBox();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.tkTenkhach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dtTraphong = new System.Windows.Forms.DateTimePicker();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.btnDoiphong = new System.Windows.Forms.Button();
            this.btnHuyphong = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuephong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1003, 638);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(203, 67);
            this.btnReset.TabIndex = 76;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtLoaiphong
            // 
            this.txtLoaiphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiphong.Location = new System.Drawing.Point(233, 516);
            this.txtLoaiphong.Name = "txtLoaiphong";
            this.txtLoaiphong.ReadOnly = true;
            this.txtLoaiphong.Size = new System.Drawing.Size(174, 32);
            this.txtLoaiphong.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 26);
            this.label8.TabIndex = 74;
            this.label8.Text = "Loại phòng : ";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(1296, 66);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(156, 49);
            this.btnTimkiem.TabIndex = 73;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnTraphong
            // 
            this.btnTraphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraphong.Location = new System.Drawing.Point(760, 638);
            this.btnTraphong.Name = "btnTraphong";
            this.btnTraphong.Size = new System.Drawing.Size(203, 67);
            this.btnTraphong.TabIndex = 72;
            this.btnTraphong.Text = "Trả phòng";
            this.btnTraphong.UseVisualStyleBackColor = true;
            this.btnTraphong.Click += new System.EventHandler(this.btnTraphong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1246, 638);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(203, 67);
            this.btnThoat.TabIndex = 71;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtThuephong
            // 
            this.dtThuephong.Enabled = false;
            this.dtThuephong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThuephong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtThuephong.Location = new System.Drawing.Point(791, 514);
            this.dtThuephong.Name = "dtThuephong";
            this.dtThuephong.Size = new System.Drawing.Size(219, 32);
            this.dtThuephong.TabIndex = 70;
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManhanvien.Location = new System.Drawing.Point(1217, 392);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.ReadOnly = true;
            this.txtManhanvien.Size = new System.Drawing.Size(235, 32);
            this.txtManhanvien.TabIndex = 69;
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennhanvien.Location = new System.Drawing.Point(1217, 432);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.ReadOnly = true;
            this.txtTennhanvien.Size = new System.Drawing.Size(235, 32);
            this.txtTennhanvien.TabIndex = 68;
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCMND.Location = new System.Drawing.Point(791, 432);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.ReadOnly = true;
            this.txtSoCMND.Size = new System.Drawing.Size(219, 32);
            this.txtSoCMND.TabIndex = 66;
            // 
            // txtSoluonguoi
            // 
            this.txtSoluonguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluonguoi.Location = new System.Drawing.Point(791, 477);
            this.txtSoluonguoi.Name = "txtSoluonguoi";
            this.txtSoluonguoi.ReadOnly = true;
            this.txtSoluonguoi.Size = new System.Drawing.Size(219, 32);
            this.txtSoluonguoi.TabIndex = 65;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(412, 557);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 26);
            this.label17.TabIndex = 64;
            this.label17.Text = "/người/ngày";
            // 
            // txtTang
            // 
            this.txtTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTang.Location = new System.Drawing.Point(233, 474);
            this.txtTang.Name = "txtTang";
            this.txtTang.ReadOnly = true;
            this.txtTang.Size = new System.Drawing.Size(174, 32);
            this.txtTang.TabIndex = 62;
            // 
            // txtGiathuephong
            // 
            this.txtGiathuephong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiathuephong.Location = new System.Drawing.Point(232, 554);
            this.txtGiathuephong.Name = "txtGiathuephong";
            this.txtGiathuephong.ReadOnly = true;
            this.txtGiathuephong.Size = new System.Drawing.Size(174, 32);
            this.txtGiathuephong.TabIndex = 61;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaphong.Location = new System.Drawing.Point(233, 392);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.ReadOnly = true;
            this.txtMaphong.Size = new System.Drawing.Size(174, 32);
            this.txtMaphong.TabIndex = 60;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(48, 477);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 26);
            this.label16.TabIndex = 59;
            this.label16.Text = "Tầng : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(46, 557);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 26);
            this.label15.TabIndex = 58;
            this.label15.Text = "Giá thuê phòng : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(584, 477);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 26);
            this.label14.TabIndex = 57;
            this.label14.Text = "Số lượng người : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(48, 435);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 26);
            this.label13.TabIndex = 56;
            this.label13.Text = "Tên phòng : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1040, 435);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 26);
            this.label12.TabIndex = 55;
            this.label12.Text = "Tên nhân viên : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(584, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 26);
            this.label11.TabIndex = 54;
            this.label11.Text = "Họ tên khách : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(584, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 26);
            this.label10.TabIndex = 53;
            this.label10.Text = "Số CMND : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(584, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 26);
            this.label9.TabIndex = 52;
            this.label9.Text = "Ngày thuê phòng : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1040, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 26);
            this.label7.TabIndex = 51;
            this.label7.Text = "Mã nhân viên : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 26);
            this.label6.TabIndex = 50;
            this.label6.Text = "Mã phòng : ";
            // 
            // dgvThuephong
            // 
            this.dgvThuephong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuephong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ma,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvThuephong.Location = new System.Drawing.Point(51, 127);
            this.dgvThuephong.Name = "dgvThuephong";
            this.dgvThuephong.RowHeadersWidth = 51;
            this.dgvThuephong.RowTemplate.Height = 24;
            this.dgvThuephong.Size = new System.Drawing.Size(1401, 240);
            this.dgvThuephong.TabIndex = 49;
            this.dgvThuephong.Click += new System.EventHandler(this.dgvThuephong_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mahoadon";
            this.Column1.HeaderText = "Mã hoá đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // ma
            // 
            this.ma.DataPropertyName = "maphong";
            this.ma.HeaderText = "Mã phòng";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            this.ma.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenphong";
            this.Column2.HeaderText = "Tên phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenkhach";
            this.Column3.HeaderText = "Tên khách";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "soCMND";
            this.Column4.HeaderText = "Số CMND";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "songuoi";
            this.Column5.HeaderText = "số người";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ngaythue";
            this.Column6.HeaderText = "Ngày thuê";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "hoten";
            this.Column7.HeaderText = "Nhân viên đưa phòng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(678, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 26);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tên khách hàng : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tên phòng : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 26);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tìm kiếm phòng : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(583, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Danh sách thuê phòng";
            // 
            // tkTenphong
            // 
            this.tkTenphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tkTenphong.Location = new System.Drawing.Point(388, 86);
            this.tkTenphong.Name = "tkTenphong";
            this.tkTenphong.Size = new System.Drawing.Size(219, 32);
            this.tkTenphong.TabIndex = 77;
            // 
            // txtHotenkhach
            // 
            this.txtHotenkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotenkhach.Location = new System.Drawing.Point(791, 392);
            this.txtHotenkhach.Name = "txtHotenkhach";
            this.txtHotenkhach.ReadOnly = true;
            this.txtHotenkhach.Size = new System.Drawing.Size(219, 32);
            this.txtHotenkhach.TabIndex = 67;
            // 
            // txtTenphong
            // 
            this.txtTenphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenphong.Location = new System.Drawing.Point(233, 432);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.ReadOnly = true;
            this.txtTenphong.Size = new System.Drawing.Size(174, 32);
            this.txtTenphong.TabIndex = 63;
            // 
            // tkTenkhach
            // 
            this.tkTenkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tkTenkhach.Location = new System.Drawing.Point(859, 86);
            this.tkTenkhach.Name = "tkTenkhach";
            this.tkTenkhach.Size = new System.Drawing.Size(219, 32);
            this.tkTenkhach.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1040, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 79;
            this.label4.Text = "Tổng tiền : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(584, 557);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(178, 26);
            this.label20.TabIndex = 82;
            this.label20.Text = "Ngày trả phòng : ";
            // 
            // dtTraphong
            // 
            this.dtTraphong.Enabled = false;
            this.dtTraphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTraphong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTraphong.Location = new System.Drawing.Point(791, 552);
            this.dtTraphong.Name = "dtTraphong";
            this.dtTraphong.Size = new System.Drawing.Size(219, 32);
            this.dtTraphong.TabIndex = 83;
            this.dtTraphong.UseWaitCursor = true;
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongtien.ForeColor = System.Drawing.Color.Red;
            this.lblTongtien.Location = new System.Drawing.Point(1212, 539);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(0, 26);
            this.lblTongtien.TabIndex = 84;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1040, 477);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 26);
            this.label18.TabIndex = 85;
            this.label18.Text = "Mã hoá đơn : ";
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahoadon.Location = new System.Drawing.Point(1217, 477);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.ReadOnly = true;
            this.txtMahoadon.Size = new System.Drawing.Size(235, 32);
            this.txtMahoadon.TabIndex = 86;
            // 
            // btnDoiphong
            // 
            this.btnDoiphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiphong.Location = new System.Drawing.Point(522, 638);
            this.btnDoiphong.Name = "btnDoiphong";
            this.btnDoiphong.Size = new System.Drawing.Size(203, 67);
            this.btnDoiphong.TabIndex = 87;
            this.btnDoiphong.Text = "Đổi phòng";
            this.btnDoiphong.UseVisualStyleBackColor = true;
            this.btnDoiphong.Click += new System.EventHandler(this.btnDoiphong_Click);
            // 
            // btnHuyphong
            // 
            this.btnHuyphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyphong.Location = new System.Drawing.Point(283, 638);
            this.btnHuyphong.Name = "btnHuyphong";
            this.btnHuyphong.Size = new System.Drawing.Size(203, 67);
            this.btnHuyphong.TabIndex = 88;
            this.btnHuyphong.Text = "Huỷ thuê phòng";
            this.btnHuyphong.UseVisualStyleBackColor = true;
            this.btnHuyphong.Click += new System.EventHandler(this.btnHuyphong_Click);
            // 
            // frmDanhsachthuephong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 736);
            this.Controls.Add(this.btnHuyphong);
            this.Controls.Add(this.btnDoiphong);
            this.Controls.Add(this.txtMahoadon);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblTongtien);
            this.Controls.Add(this.dtTraphong);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tkTenkhach);
            this.Controls.Add(this.tkTenphong);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtLoaiphong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnTraphong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dtThuephong);
            this.Controls.Add(this.txtManhanvien);
            this.Controls.Add(this.txtTennhanvien);
            this.Controls.Add(this.txtHotenkhach);
            this.Controls.Add(this.txtSoCMND);
            this.Controls.Add(this.txtSoluonguoi);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtTenphong);
            this.Controls.Add(this.txtTang);
            this.Controls.Add(this.txtGiathuephong);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvThuephong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDanhsachthuephong";
            this.Text = "frmTraphong";
            this.Activated += new System.EventHandler(this.frmDanhsachthuephong_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuephong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtLoaiphong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnTraphong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtThuephong;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.TextBox txtSoluonguoi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTang;
        private System.Windows.Forms.TextBox txtGiathuephong;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvThuephong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tkTenphong;
        private System.Windows.Forms.TextBox txtHotenkhach;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.TextBox tkTenkhach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtTraphong;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.Button btnDoiphong;
        private System.Windows.Forms.Button btnHuyphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
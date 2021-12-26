
namespace GUI_THUEKHACHSAN
{
    partial class phongItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.anh = new System.Windows.Forms.PictureBox();
            this.lblloaiphong = new System.Windows.Forms.Label();
            this.lblTenphong = new System.Windows.Forms.Label();
            this.lblMaphong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.anh);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 94);
            this.panel1.TabIndex = 0;
            // 
            // anh
            // 
            this.anh.Location = new System.Drawing.Point(3, 3);
            this.anh.Name = "anh";
            this.anh.Size = new System.Drawing.Size(95, 89);
            this.anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anh.TabIndex = 0;
            this.anh.TabStop = false;
            // 
            // lblloaiphong
            // 
            this.lblloaiphong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblloaiphong.AutoSize = true;
            this.lblloaiphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloaiphong.ForeColor = System.Drawing.Color.Red;
            this.lblloaiphong.Location = new System.Drawing.Point(12, 97);
            this.lblloaiphong.Name = "lblloaiphong";
            this.lblloaiphong.Size = new System.Drawing.Size(70, 26);
            this.lblloaiphong.TabIndex = 1;
            this.lblloaiphong.Text = "label1";
            this.lblloaiphong.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTenphong
            // 
            this.lblTenphong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenphong.AutoSize = true;
            this.lblTenphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenphong.Location = new System.Drawing.Point(12, 123);
            this.lblTenphong.Name = "lblTenphong";
            this.lblTenphong.Size = new System.Drawing.Size(76, 26);
            this.lblTenphong.TabIndex = 2;
            this.lblTenphong.Text = "label2";
            this.lblTenphong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaphong
            // 
            this.lblMaphong.AutoSize = true;
            this.lblMaphong.Location = new System.Drawing.Point(3, 141);
            this.lblMaphong.Name = "lblMaphong";
            this.lblMaphong.Size = new System.Drawing.Size(46, 17);
            this.lblMaphong.TabIndex = 3;
            this.lblMaphong.Text = "label1";
            this.lblMaphong.Visible = false;
            // 
            // phongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMaphong);
            this.Controls.Add(this.lblTenphong);
            this.Controls.Add(this.lblloaiphong);
            this.Controls.Add(this.panel1);
            this.Name = "phongItem";
            this.Size = new System.Drawing.Size(101, 160);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox anh;
        private System.Windows.Forms.Label lblloaiphong;
        private System.Windows.Forms.Label lblTenphong;
        private System.Windows.Forms.Label lblMaphong;
    }
}

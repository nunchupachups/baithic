
namespace GUI_THUEKHACHSAN
{
    partial class addphong
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
            this.lblTang = new System.Windows.Forms.Label();
            this.anh = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTang);
            this.panel1.Controls.Add(this.anh);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 94);
            this.panel1.TabIndex = 4;
            // 
            // lblTang
            // 
            this.lblTang.AutoSize = true;
            this.lblTang.Location = new System.Drawing.Point(22, 29);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(46, 17);
            this.lblTang.TabIndex = 1;
            this.lblTang.Text = "label1";
            this.lblTang.Visible = false;
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
            // addphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "addphong";
            this.Size = new System.Drawing.Size(102, 95);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox anh;
        private System.Windows.Forms.Label lblTang;
    }
}

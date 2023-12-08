namespace Hotel_Application
{
    partial class Admin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnUINhanVien = new System.Windows.Forms.Button();
            this.quanLyHoaDon1 = new Hotel_Application.QuanLyHoaDon();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 1151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRoom
            // 
            this.btnRoom.Location = new System.Drawing.Point(77, 86);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(180, 98);
            this.btnRoom.TabIndex = 2;
            this.btnRoom.Text = "Quản Lý Phòng";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(77, 272);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(180, 98);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "Quản Lý Nhân Sự";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(77, 474);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(180, 98);
            this.btnService.TabIndex = 4;
            this.btnService.Text = "Quản Lý Dịch Vụ";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(77, 664);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(180, 98);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "Quản Lý Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(77, 867);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(180, 98);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(185, 1047);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(145, 98);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnUINhanVien
            // 
            this.btnUINhanVien.Location = new System.Drawing.Point(-2, 1046);
            this.btnUINhanVien.Name = "btnUINhanVien";
            this.btnUINhanVien.Size = new System.Drawing.Size(145, 98);
            this.btnUINhanVien.TabIndex = 9;
            this.btnUINhanVien.Text = "Giao Diện Nhân Viên";
            this.btnUINhanVien.UseVisualStyleBackColor = true;
            this.btnUINhanVien.Click += new System.EventHandler(this.btnUINhanVien_Click);
            // 
            // quanLyHoaDon1
            // 
            this.quanLyHoaDon1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quanLyHoaDon1.Location = new System.Drawing.Point(336, -6);
            this.quanLyHoaDon1.Name = "quanLyHoaDon1";
            this.quanLyHoaDon1.Size = new System.Drawing.Size(1440, 1200);
            this.quanLyHoaDon1.TabIndex = 10;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 1144);
            this.Controls.Add(this.quanLyHoaDon1);
            this.Controls.Add(this.btnUINhanVien);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUINhanVien;
        private QuanLyHoaDon quanLyHoaDon1;
    }
}
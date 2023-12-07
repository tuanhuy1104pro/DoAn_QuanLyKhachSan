namespace Hotel_Application
{
    partial class NhanVien
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.phong1 = new Hotel_Application.Phong();
            this.btnDangKyHoaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(156, 1050);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(145, 98);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(33, 595);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(180, 98);
            this.btnThongKe.TabIndex = 12;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(33, 57);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(180, 98);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(33, 207);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(180, 98);
            this.btnHoaDon.TabIndex = 10;
            this.btnHoaDon.Text = "Quản Lý Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // phong1
            // 
            this.phong1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.phong1.Location = new System.Drawing.Point(302, -3);
            this.phong1.Name = "phong1";
            this.phong1.Size = new System.Drawing.Size(1444, 1150);
            this.phong1.TabIndex = 9;
            // 
            // btnDangKyHoaDon
            // 
            this.btnDangKyHoaDon.Location = new System.Drawing.Point(33, 398);
            this.btnDangKyHoaDon.Name = "btnDangKyHoaDon";
            this.btnDangKyHoaDon.Size = new System.Drawing.Size(180, 98);
            this.btnDangKyHoaDon.TabIndex = 14;
            this.btnDangKyHoaDon.Text = "Đăng Ký Hóa Đơn";
            this.btnDangKyHoaDon.UseVisualStyleBackColor = true;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 1144);
            this.Controls.Add(this.btnDangKyHoaDon);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.phong1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHoaDon;
        private Phong phong1;
        private System.Windows.Forms.Button btnDangKyHoaDon;
    }
}
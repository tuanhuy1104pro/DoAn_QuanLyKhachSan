namespace Hotel_Application
{
    partial class AddDichVu
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
            this.label5 = new System.Windows.Forms.Label();
            this.cboLoaiService = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateService = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(484, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 32);
            this.label5.TabIndex = 68;
            this.label5.Text = "Loại Dịch Vụ";
            // 
            // cboLoaiService
            // 
            this.cboLoaiService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiService.FormattingEnabled = true;
            this.cboLoaiService.Location = new System.Drawing.Point(285, 126);
            this.cboLoaiService.Name = "cboLoaiService";
            this.cboLoaiService.Size = new System.Drawing.Size(181, 37);
            this.cboLoaiService.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(331, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 55);
            this.label1.TabIndex = 69;
            this.label1.Text = "Thêm Dịch Vụ";
            // 
            // btnCreateService
            // 
            this.btnCreateService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateService.Location = new System.Drawing.Point(433, 393);
            this.btnCreateService.Name = "btnCreateService";
            this.btnCreateService.Size = new System.Drawing.Size(108, 86);
            this.btnCreateService.TabIndex = 70;
            this.btnCreateService.Text = "Tạo";
            this.btnCreateService.UseVisualStyleBackColor = true;
            this.btnCreateService.Click += new System.EventHandler(this.btnCreateService_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(600, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 32);
            this.label10.TabIndex = 72;
            this.label10.Text = "Tên Dịch Vụ";
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDichVu.Location = new System.Drawing.Point(285, 209);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(300, 39);
            this.txtTenDichVu.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(600, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 74;
            this.label2.Text = "Giá Tiền";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(285, 292);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(300, 39);
            this.txtGiaTien.TabIndex = 73;
            // 
            // AddDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTenDichVu);
            this.Controls.Add(this.btnCreateService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboLoaiService);
            this.Name = "AddDichVu";
            this.Text = "AddDichVu";
            this.Load += new System.EventHandler(this.AddDichVu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLoaiService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateService;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaTien;
    }
}
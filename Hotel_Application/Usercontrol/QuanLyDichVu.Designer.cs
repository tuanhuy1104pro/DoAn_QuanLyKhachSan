namespace Hotel_Application.Usercontrol
{
    partial class QuanLyDichVu
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
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.txtKhuyenMaiGoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenGoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddGoiService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboGoiService = new System.Windows.Forms.ComboBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnAddIntoGoi = new System.Windows.Forms.Button();
            this.btnEditGoiService = new System.Windows.Forms.Button();
            this.btnDeleteGoiService = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvDetailGoiService = new System.Windows.Forms.DataGridView();
            this.btnDeleteIntoGoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailGoiService)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteService.Location = new System.Drawing.Point(1049, 269);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(108, 86);
            this.btnDeleteService.TabIndex = 60;
            this.btnDeleteService.Text = "Xóa";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(436, 128);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 62;
            this.dgvDichVu.RowTemplate.Height = 28;
            this.dgvDichVu.Size = new System.Drawing.Size(721, 126);
            this.dgvDichVu.TabIndex = 56;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // txtKhuyenMaiGoi
            // 
            this.txtKhuyenMaiGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhuyenMaiGoi.Location = new System.Drawing.Point(155, 591);
            this.txtKhuyenMaiGoi.Name = "txtKhuyenMaiGoi";
            this.txtKhuyenMaiGoi.Size = new System.Drawing.Size(300, 39);
            this.txtKhuyenMaiGoi.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(584, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 55);
            this.label1.TabIndex = 48;
            this.label1.Text = "Quản Lý  Dịch Vụ";
            // 
            // txtTenGoi
            // 
            this.txtTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGoi.Location = new System.Drawing.Point(155, 515);
            this.txtTenGoi.Name = "txtTenGoi";
            this.txtTenGoi.Size = new System.Drawing.Size(300, 39);
            this.txtTenGoi.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(295, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 32);
            this.label7.TabIndex = 66;
            this.label7.Text = "Dịch Vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(559, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(493, 55);
            this.label8.TabIndex = 67;
            this.label8.Text = "Quản Lý Gói Dịch Vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(246, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 32);
            this.label9.TabIndex = 68;
            this.label9.Text = "Tạo Gói";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(470, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 32);
            this.label10.TabIndex = 69;
            this.label10.Text = "Tên Gói";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(470, 591);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 32);
            this.label11.TabIndex = 70;
            this.label11.Text = "Khuyến Mãi (Nếu Có)";
            // 
            // btnAddGoiService
            // 
            this.btnAddGoiService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGoiService.Location = new System.Drawing.Point(252, 649);
            this.btnAddGoiService.Name = "btnAddGoiService";
            this.btnAddGoiService.Size = new System.Drawing.Size(108, 86);
            this.btnAddGoiService.TabIndex = 71;
            this.btnAddGoiService.Text = "Tạo";
            this.btnAddGoiService.UseVisualStyleBackColor = true;
            this.btnAddGoiService.Click += new System.EventHandler(this.btnAddGoiService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1076, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 32);
            this.label2.TabIndex = 72;
            this.label2.Text = "Đưa Dịch Vụ Vào Gói";
            // 
            // cboService
            // 
            this.cboService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(1082, 519);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(282, 37);
            this.cboService.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1370, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 32);
            this.label3.TabIndex = 74;
            this.label3.Text = "List Dịch Vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1370, 573);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 32);
            this.label6.TabIndex = 76;
            this.label6.Text = "List Gói";
            // 
            // cboGoiService
            // 
            this.cboGoiService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGoiService.FormattingEnabled = true;
            this.cboGoiService.Location = new System.Drawing.Point(1082, 573);
            this.cboGoiService.Name = "cboGoiService";
            this.cboGoiService.Size = new System.Drawing.Size(282, 37);
            this.cboGoiService.TabIndex = 75;
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.Location = new System.Drawing.Point(436, 269);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(108, 86);
            this.btnAddService.TabIndex = 59;
            this.btnAddService.Text = "Thêm";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnAddIntoGoi
            // 
            this.btnAddIntoGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIntoGoi.Location = new System.Drawing.Point(1173, 634);
            this.btnAddIntoGoi.Name = "btnAddIntoGoi";
            this.btnAddIntoGoi.Size = new System.Drawing.Size(108, 86);
            this.btnAddIntoGoi.TabIndex = 77;
            this.btnAddIntoGoi.Text = "Thêm";
            this.btnAddIntoGoi.UseVisualStyleBackColor = true;
            this.btnAddIntoGoi.Click += new System.EventHandler(this.btnAddIntoGoi_Click);
            // 
            // btnEditGoiService
            // 
            this.btnEditGoiService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGoiService.Location = new System.Drawing.Point(375, 444);
            this.btnEditGoiService.Name = "btnEditGoiService";
            this.btnEditGoiService.Size = new System.Drawing.Size(80, 51);
            this.btnEditGoiService.TabIndex = 79;
            this.btnEditGoiService.Text = "Sửa";
            this.btnEditGoiService.UseVisualStyleBackColor = true;
            this.btnEditGoiService.Click += new System.EventHandler(this.btnEditGoiService_Click);
            // 
            // btnDeleteGoiService
            // 
            this.btnDeleteGoiService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGoiService.Location = new System.Drawing.Point(155, 447);
            this.btnDeleteGoiService.Name = "btnDeleteGoiService";
            this.btnDeleteGoiService.Size = new System.Drawing.Size(85, 51);
            this.btnDeleteGoiService.TabIndex = 78;
            this.btnDeleteGoiService.Text = "Xóa";
            this.btnDeleteGoiService.UseVisualStyleBackColor = true;
            this.btnDeleteGoiService.Click += new System.EventHandler(this.btnDeleteGoiService_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(644, 734);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(237, 32);
            this.label12.TabIndex = 82;
            this.label12.Text = "Chi Tiết Các Gói";
            // 
            // dgvDetailGoiService
            // 
            this.dgvDetailGoiService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailGoiService.Location = new System.Drawing.Point(3, 781);
            this.dgvDetailGoiService.Name = "dgvDetailGoiService";
            this.dgvDetailGoiService.RowHeadersWidth = 62;
            this.dgvDetailGoiService.RowTemplate.Height = 28;
            this.dgvDetailGoiService.Size = new System.Drawing.Size(1176, 301);
            this.dgvDetailGoiService.TabIndex = 81;
            this.dgvDetailGoiService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailGoiService_CellClick);
            // 
            // btnDeleteIntoGoi
            // 
            this.btnDeleteIntoGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIntoGoi.Location = new System.Drawing.Point(1198, 781);
            this.btnDeleteIntoGoi.Name = "btnDeleteIntoGoi";
            this.btnDeleteIntoGoi.Size = new System.Drawing.Size(137, 63);
            this.btnDeleteIntoGoi.TabIndex = 83;
            this.btnDeleteIntoGoi.Text = "Xóa";
            this.btnDeleteIntoGoi.UseVisualStyleBackColor = true;
            this.btnDeleteIntoGoi.Click += new System.EventHandler(this.btnDeleteIntoGoi_Click);
            // 
            // QuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnDeleteIntoGoi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvDetailGoiService);
            this.Controls.Add(this.btnEditGoiService);
            this.Controls.Add(this.btnDeleteGoiService);
            this.Controls.Add(this.btnAddIntoGoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboGoiService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddGoiService);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.txtKhuyenMaiGoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenGoi);
            this.Name = "QuanLyDichVu";
            this.Size = new System.Drawing.Size(1590, 1100);
            this.Load += new System.EventHandler(this.QuanLyDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailGoiService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.TextBox txtKhuyenMaiGoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenGoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddGoiService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboGoiService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnAddIntoGoi;
        private System.Windows.Forms.Button btnEditGoiService;
        private System.Windows.Forms.Button btnDeleteGoiService;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvDetailGoiService;
        private System.Windows.Forms.Button btnDeleteIntoGoi;
    }
}

namespace Hotel_Application
{
    partial class NhanSu
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
            this.dgvNhanSu = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditChucVu = new System.Windows.Forms.Button();
            this.btnDeleteChucVu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.btnAddChucVu = new System.Windows.Forms.Button();
            this.btnEditNhanSu = new System.Windows.Forms.Button();
            this.btnDeleteNhanSu = new System.Windows.Forms.Button();
            this.btnAddNhanSu = new System.Windows.Forms.Button();
            this.lbTimNhanSu = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnReloadNhanSu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhanSu
            // 
            this.dgvNhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanSu.Location = new System.Drawing.Point(6, 551);
            this.dgvNhanSu.Name = "dgvNhanSu";
            this.dgvNhanSu.RowHeadersWidth = 62;
            this.dgvNhanSu.RowTemplate.Height = 28;
            this.dgvNhanSu.Size = new System.Drawing.Size(1451, 440);
            this.dgvNhanSu.TabIndex = 34;
            this.dgvNhanSu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanSu_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(502, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(422, 55);
            this.label6.TabIndex = 32;
            this.label6.Text = "Quản Lý Nhân Sự";
            // 
            // btnEditChucVu
            // 
            this.btnEditChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditChucVu.Location = new System.Drawing.Point(409, 17);
            this.btnEditChucVu.Name = "btnEditChucVu";
            this.btnEditChucVu.Size = new System.Drawing.Size(137, 63);
            this.btnEditChucVu.TabIndex = 29;
            this.btnEditChucVu.Text = "Sửa";
            this.btnEditChucVu.UseVisualStyleBackColor = true;
            this.btnEditChucVu.Click += new System.EventHandler(this.btnEditChucVu_Click);
            // 
            // btnDeleteChucVu
            // 
            this.btnDeleteChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteChucVu.Location = new System.Drawing.Point(6, 17);
            this.btnDeleteChucVu.Name = "btnDeleteChucVu";
            this.btnDeleteChucVu.Size = new System.Drawing.Size(137, 63);
            this.btnDeleteChucVu.TabIndex = 28;
            this.btnDeleteChucVu.Text = "Xóa";
            this.btnDeleteChucVu.UseVisualStyleBackColor = true;
            this.btnDeleteChucVu.Click += new System.EventHandler(this.btnDeleteChucVu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(583, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 46);
            this.label3.TabIndex = 27;
            this.label3.Text = "Phụ Cấp";
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhuCap.Location = new System.Drawing.Point(785, 268);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Size = new System.Drawing.Size(465, 39);
            this.txtPhuCap.TabIndex = 26;
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Location = new System.Drawing.Point(6, 89);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.RowHeadersWidth = 62;
            this.dgvChucVu.RowTemplate.Height = 28;
            this.dgvChucVu.Size = new System.Drawing.Size(540, 364);
            this.dgvChucVu.TabIndex = 25;
            this.dgvChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(578, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 46);
            this.label2.TabIndex = 24;
            this.label2.Text = "Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(831, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 55);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quản Lý Chức Vụ";
            // 
            // txtTenCV
            // 
            this.txtTenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCV.Location = new System.Drawing.Point(785, 196);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(465, 39);
            this.txtTenCV.TabIndex = 22;
            // 
            // btnAddChucVu
            // 
            this.btnAddChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChucVu.Location = new System.Drawing.Point(1256, 196);
            this.btnAddChucVu.Name = "btnAddChucVu";
            this.btnAddChucVu.Size = new System.Drawing.Size(140, 111);
            this.btnAddChucVu.TabIndex = 21;
            this.btnAddChucVu.Text = "Thêm";
            this.btnAddChucVu.UseVisualStyleBackColor = true;
            this.btnAddChucVu.Click += new System.EventHandler(this.btnAddChucVu_Click);
            // 
            // btnEditNhanSu
            // 
            this.btnEditNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditNhanSu.Location = new System.Drawing.Point(815, 1040);
            this.btnEditNhanSu.Name = "btnEditNhanSu";
            this.btnEditNhanSu.Size = new System.Drawing.Size(172, 111);
            this.btnEditNhanSu.TabIndex = 44;
            this.btnEditNhanSu.Text = "Sửa";
            this.btnEditNhanSu.UseVisualStyleBackColor = true;
            this.btnEditNhanSu.Click += new System.EventHandler(this.btnEditNhanSu_Click);
            // 
            // btnDeleteNhanSu
            // 
            this.btnDeleteNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNhanSu.Location = new System.Drawing.Point(535, 1040);
            this.btnDeleteNhanSu.Name = "btnDeleteNhanSu";
            this.btnDeleteNhanSu.Size = new System.Drawing.Size(160, 111);
            this.btnDeleteNhanSu.TabIndex = 43;
            this.btnDeleteNhanSu.Text = "Xóa";
            this.btnDeleteNhanSu.UseVisualStyleBackColor = true;
            this.btnDeleteNhanSu.Click += new System.EventHandler(this.btnDeleteNhanSu_Click);
            // 
            // btnAddNhanSu
            // 
            this.btnAddNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNhanSu.Location = new System.Drawing.Point(278, 1040);
            this.btnAddNhanSu.Name = "btnAddNhanSu";
            this.btnAddNhanSu.Size = new System.Drawing.Size(162, 111);
            this.btnAddNhanSu.TabIndex = 42;
            this.btnAddNhanSu.Text = "Thêm";
            this.btnAddNhanSu.UseVisualStyleBackColor = true;
            this.btnAddNhanSu.Click += new System.EventHandler(this.btnAddNhanSu_Click);
            // 
            // lbTimNhanSu
            // 
            this.lbTimNhanSu.AutoSize = true;
            this.lbTimNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimNhanSu.ForeColor = System.Drawing.Color.White;
            this.lbTimNhanSu.Location = new System.Drawing.Point(1214, 1068);
            this.lbTimNhanSu.Name = "lbTimNhanSu";
            this.lbTimNhanSu.Size = new System.Drawing.Size(195, 46);
            this.lbTimNhanSu.TabIndex = 45;
            this.lbTimNhanSu.Text = "Tìm Kiếm";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(205, 17);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(137, 63);
            this.btnReload.TabIndex = 46;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnReloadNhanSu
            // 
            this.btnReloadNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadNhanSu.Location = new System.Drawing.Point(1320, 482);
            this.btnReloadNhanSu.Name = "btnReloadNhanSu";
            this.btnReloadNhanSu.Size = new System.Drawing.Size(137, 63);
            this.btnReloadNhanSu.TabIndex = 47;
            this.btnReloadNhanSu.Text = "Reload";
            this.btnReloadNhanSu.UseVisualStyleBackColor = true;
            this.btnReloadNhanSu.Click += new System.EventHandler(this.btnReloadNhanSu_Click);
            // 
            // NhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnReloadNhanSu);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lbTimNhanSu);
            this.Controls.Add(this.btnEditNhanSu);
            this.Controls.Add(this.btnDeleteNhanSu);
            this.Controls.Add(this.btnAddNhanSu);
            this.Controls.Add(this.dgvNhanSu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditChucVu);
            this.Controls.Add(this.btnDeleteChucVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhuCap);
            this.Controls.Add(this.dgvChucVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.btnAddChucVu);
            this.Name = "NhanSu";
            this.Size = new System.Drawing.Size(1460, 1190);
            this.Load += new System.EventHandler(this.NhanSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNhanSu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditChucVu;
        private System.Windows.Forms.Button btnDeleteChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Button btnAddChucVu;
        private System.Windows.Forms.Button btnEditNhanSu;
        private System.Windows.Forms.Button btnDeleteNhanSu;
        private System.Windows.Forms.Button btnAddNhanSu;
        private System.Windows.Forms.Label lbTimNhanSu;
        private System.Windows.Forms.Button btnReload;
        public System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.Button btnReloadNhanSu;
    }
}

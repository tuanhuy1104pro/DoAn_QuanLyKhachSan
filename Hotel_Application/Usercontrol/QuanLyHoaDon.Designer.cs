namespace Hotel_Application
{
    partial class QuanLyHoaDon
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSortHoaDon = new System.Windows.Forms.ComboBox();
            this.lbTimHoaDon = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 230);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.RowTemplate.Height = 28;
            this.dgvHoaDon.Size = new System.Drawing.Size(1414, 827);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(619, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 55);
            this.label1.TabIndex = 49;
            this.label1.Text = "Hóa Đơn";
            // 
            // cboSortHoaDon
            // 
            this.cboSortHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortHoaDon.FormattingEnabled = true;
            this.cboSortHoaDon.Items.AddRange(new object[] {
            "Tăng Dần",
            "Giảm Dần",
            "Theo Thời Gian Thuê"});
            this.cboSortHoaDon.Location = new System.Drawing.Point(1215, 160);
            this.cboSortHoaDon.Name = "cboSortHoaDon";
            this.cboSortHoaDon.Size = new System.Drawing.Size(202, 37);
            this.cboSortHoaDon.TabIndex = 50;
            // 
            // lbTimHoaDon
            // 
            this.lbTimHoaDon.AutoSize = true;
            this.lbTimHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimHoaDon.ForeColor = System.Drawing.Color.White;
            this.lbTimHoaDon.Location = new System.Drawing.Point(1300, 1097);
            this.lbTimHoaDon.Name = "lbTimHoaDon";
            this.lbTimHoaDon.Size = new System.Drawing.Size(103, 25);
            this.lbTimHoaDon.TabIndex = 51;
            this.lbTimHoaDon.Text = "Tìm Kiếm";
            this.lbTimHoaDon.Click += new System.EventHandler(this.lbTimHoaDon_Click);
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(900, 1091);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(394, 35);
            this.txtMaHoaDon.TabIndex = 52;
            this.txtMaHoaDon.Text = "Mã Hóa Đơn Hoặc Tên Khách Hàng";
            this.txtMaHoaDon.Click += new System.EventHandler(this.txtMaHoaDon_Click);
            this.txtMaHoaDon.TextChanged += new System.EventHandler(this.txtMaHoaDon_TextChanged);
            this.txtMaHoaDon.Leave += new System.EventHandler(this.txtMaHoaDon_Leave);
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.lbTimHoaDon);
            this.Controls.Add(this.cboSortHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHoaDon);
            this.Name = "QuanLyHoaDon";
            this.Size = new System.Drawing.Size(1420, 1200);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSortHoaDon;
        private System.Windows.Forms.Label lbTimHoaDon;
        private System.Windows.Forms.TextBox txtMaHoaDon;
    }
}

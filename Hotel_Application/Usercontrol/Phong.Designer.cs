﻿namespace Hotel_Application
{
    partial class Phong
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
            this.components = new System.ComponentModel.Container();
            this.btnAddKindRoom = new System.Windows.Forms.Button();
            this.txtTenLoaiPhong = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaLoaiPhong = new System.Windows.Forms.TextBox();
            this.btnXoaLoaiPhong = new System.Windows.Forms.Button();
            this.btnSuaLoaiPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.btnAddPhong = new System.Windows.Forms.Button();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddKindRoom
            // 
            this.btnAddKindRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKindRoom.Location = new System.Drawing.Point(944, 102);
            this.btnAddKindRoom.Name = "btnAddKindRoom";
            this.btnAddKindRoom.Size = new System.Drawing.Size(140, 111);
            this.btnAddKindRoom.TabIndex = 0;
            this.btnAddKindRoom.Text = "Thêm";
            this.btnAddKindRoom.UseVisualStyleBackColor = true;
            // 
            // txtTenLoaiPhong
            // 
            this.txtTenLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiPhong.Location = new System.Drawing.Point(473, 102);
            this.txtTenLoaiPhong.Name = "txtTenLoaiPhong";
            this.txtTenLoaiPhong.Size = new System.Drawing.Size(465, 39);
            this.txtTenLoaiPhong.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(491, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản Lý Loại Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(266, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Loại";
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Location = new System.Drawing.Point(0, 240);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.RowHeadersWidth = 62;
            this.dgvLoaiPhong.RowTemplate.Height = 28;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(1306, 318);
            this.dgvLoaiPhong.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giá Tiền";
            // 
            // txtGiaLoaiPhong
            // 
            this.txtGiaLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaLoaiPhong.Location = new System.Drawing.Point(473, 174);
            this.txtGiaLoaiPhong.Name = "txtGiaLoaiPhong";
            this.txtGiaLoaiPhong.Size = new System.Drawing.Size(465, 39);
            this.txtGiaLoaiPhong.TabIndex = 7;
            // 
            // btnXoaLoaiPhong
            // 
            this.btnXoaLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiPhong.Location = new System.Drawing.Point(1309, 301);
            this.btnXoaLoaiPhong.Name = "btnXoaLoaiPhong";
            this.btnXoaLoaiPhong.Size = new System.Drawing.Size(137, 63);
            this.btnXoaLoaiPhong.TabIndex = 9;
            this.btnXoaLoaiPhong.Text = "Xóa";
            this.btnXoaLoaiPhong.UseVisualStyleBackColor = true;
            // 
            // btnSuaLoaiPhong
            // 
            this.btnSuaLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiPhong.Location = new System.Drawing.Point(1309, 401);
            this.btnSuaLoaiPhong.Name = "btnSuaLoaiPhong";
            this.btnSuaLoaiPhong.Size = new System.Drawing.Size(137, 63);
            this.btnSuaLoaiPhong.TabIndex = 10;
            this.btnSuaLoaiPhong.Text = "Sửa";
            this.btnSuaLoaiPhong.UseVisualStyleBackColor = true;
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhong.Location = new System.Drawing.Point(1309, 1041);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(137, 63);
            this.btnSuaPhong.TabIndex = 19;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.Location = new System.Drawing.Point(1309, 935);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(137, 63);
            this.btnXoaPhong.TabIndex = 18;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(234, 759);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 46);
            this.label4.TabIndex = 17;
            this.label4.Text = "Loại Phòng";
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(0, 882);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 62;
            this.dgvPhong.RowTemplate.Height = 28;
            this.dgvPhong.Size = new System.Drawing.Size(1306, 318);
            this.dgvPhong.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(243, 687);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 46);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tên Phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(543, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 55);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quản Lý Phòng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(473, 695);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(465, 39);
            this.txtTenPhong.TabIndex = 12;
            // 
            // btnAddPhong
            // 
            this.btnAddPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhong.Location = new System.Drawing.Point(944, 695);
            this.btnAddPhong.Name = "btnAddPhong";
            this.btnAddPhong.Size = new System.Drawing.Size(140, 111);
            this.btnAddPhong.TabIndex = 11;
            this.btnAddPhong.Text = "Thêm";
            this.btnAddPhong.UseVisualStyleBackColor = true;
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Location = new System.Drawing.Point(473, 767);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(465, 40);
            this.cboLoaiPhong.TabIndex = 20;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.cboLoaiPhong);
            this.Controls.Add(this.btnSuaPhong);
            this.Controls.Add(this.btnXoaPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.btnAddPhong);
            this.Controls.Add(this.btnSuaLoaiPhong);
            this.Controls.Add(this.btnXoaLoaiPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGiaLoaiPhong);
            this.Controls.Add(this.dgvLoaiPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenLoaiPhong);
            this.Controls.Add(this.btnAddKindRoom);
            this.Name = "Phong";
            this.Size = new System.Drawing.Size(1480, 1200);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddKindRoom;
        private System.Windows.Forms.TextBox txtTenLoaiPhong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaLoaiPhong;
        private System.Windows.Forms.Button btnXoaLoaiPhong;
        private System.Windows.Forms.Button btnSuaLoaiPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Button btnAddPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
    }
}

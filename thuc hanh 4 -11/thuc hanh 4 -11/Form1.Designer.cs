namespace thuc_hanh_4__11
{
    partial class Form1
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pictureBoxServiceImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServiceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 64);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(601, 243);
            this.dgvKhachHang.TabIndex = 0;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(619, 64);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(544, 243);
            this.dgvDichVu.TabIndex = 1;
            this.dgvDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(584, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "hóa đơn dịch vụ :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbTongTien
            // 
            this.txbTongTien.Location = new System.Drawing.Point(734, 329);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(292, 22);
            this.txbTongTien.TabIndex = 3;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(734, 411);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(136, 57);
            this.btnHoaDon.TabIndex = 4;
            this.btnHoaDon.Text = "Tạo hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 329);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 35);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(148, 329);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 34);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(273, 325);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 38);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pictureBoxServiceImage
            // 
            this.pictureBoxServiceImage.Location = new System.Drawing.Point(1178, 64);
            this.pictureBoxServiceImage.Name = "pictureBoxServiceImage";
            this.pictureBoxServiceImage.Size = new System.Drawing.Size(184, 145);
            this.pictureBoxServiceImage.TabIndex = 8;
            this.pictureBoxServiceImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Danh sách khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(614, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Danh sách dịch vụ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxServiceImage);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.txbTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.dgvKhachHang);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServiceImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.PictureBox pictureBoxServiceImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


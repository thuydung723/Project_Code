namespace Đồ_Án_QLCH
{
    partial class GUI_ChiTiet_HoaDonNhap
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.txtSLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDSCTHDNhap = new System.Windows.Forms.DataGridView();
            this.grbCTHD = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGNhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTTHD = new System.Windows.Forms.GroupBox();
            this.txtKhoHang = new System.Windows.Forms.TextBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.vbBtnThoat = new Đồ_Án_QLCH.VBButton();
            this.vbBtnSua = new Đồ_Án_QLCH.VBButton();
            this.vbBtnXoa = new Đồ_Án_QLCH.VBButton();
            this.vbBtnNhapMoi = new Đồ_Án_QLCH.VBButton();
            this.vbBtnThem = new Đồ_Án_QLCH.VBButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTHDNhap)).BeginInit();
            this.grbCTHD.SuspendLayout();
            this.grbTTHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sản phẩm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng:";
            // 
            // cboSanPham
            // 
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(189, 33);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(168, 28);
            this.cboSanPham.TabIndex = 40;
            this.cboSanPham.SelectedIndexChanged += new System.EventHandler(this.cboSanPham_SelectedIndexChanged);
            // 
            // txtSLuong
            // 
            this.txtSLuong.Location = new System.Drawing.Point(189, 82);
            this.txtSLuong.Name = "txtSLuong";
            this.txtSLuong.Size = new System.Drawing.Size(168, 26);
            this.txtSLuong.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(12, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(333, 25);
            this.label10.TabIndex = 50;
            this.label10.Text = "Danh sách chi tiết sản phẩm hóa đơn";
            // 
            // dgvDSCTHDNhap
            // 
            this.dgvDSCTHDNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCTHDNhap.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSCTHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTHDNhap.Location = new System.Drawing.Point(39, 422);
            this.dgvDSCTHDNhap.Name = "dgvDSCTHDNhap";
            this.dgvDSCTHDNhap.RowHeadersWidth = 62;
            this.dgvDSCTHDNhap.RowTemplate.Height = 28;
            this.dgvDSCTHDNhap.Size = new System.Drawing.Size(1393, 290);
            this.dgvDSCTHDNhap.TabIndex = 52;
            this.dgvDSCTHDNhap.VirtualMode = true;
            this.dgvDSCTHDNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCTHDNhap_CellClick);
            this.dgvDSCTHDNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCTHDNhap_CellContentClick);
            // 
            // grbCTHD
            // 
            this.grbCTHD.Controls.Add(this.label6);
            this.grbCTHD.Controls.Add(this.txtGNhap);
            this.grbCTHD.Controls.Add(this.label4);
            this.grbCTHD.Controls.Add(this.cboSanPham);
            this.grbCTHD.Controls.Add(this.label5);
            this.grbCTHD.Controls.Add(this.txtSLuong);
            this.grbCTHD.Location = new System.Drawing.Point(802, 145);
            this.grbCTHD.Name = "grbCTHD";
            this.grbCTHD.Size = new System.Drawing.Size(588, 220);
            this.grbCTHD.TabIndex = 55;
            this.grbCTHD.TabStop = false;
            this.grbCTHD.Text = "Chi tiết hóa đơn nhập";
            this.grbCTHD.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Đơn giá nhập:";
            // 
            // txtGNhap
            // 
            this.txtGNhap.Location = new System.Drawing.Point(189, 128);
            this.txtGNhap.Name = "txtGNhap";
            this.txtGNhap.Size = new System.Drawing.Size(168, 26);
            this.txtGNhap.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Kho hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày tạo:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(136, 41);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(166, 26);
            this.txtMaHD.TabIndex = 36;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // grbTTHD
            // 
            this.grbTTHD.Controls.Add(this.txtKhoHang);
            this.grbTTHD.Controls.Add(this.txtNhanVien);
            this.grbTTHD.Controls.Add(this.dtpNgayTao);
            this.grbTTHD.Controls.Add(this.label1);
            this.grbTTHD.Controls.Add(this.txtMaHD);
            this.grbTTHD.Controls.Add(this.label2);
            this.grbTTHD.Controls.Add(this.label3);
            this.grbTTHD.Controls.Add(this.label8);
            this.grbTTHD.Location = new System.Drawing.Point(39, 130);
            this.grbTTHD.Name = "grbTTHD";
            this.grbTTHD.Size = new System.Drawing.Size(648, 235);
            this.grbTTHD.TabIndex = 56;
            this.grbTTHD.TabStop = false;
            this.grbTTHD.Text = "Thông tin hóa đơn nhập";
            // 
            // txtKhoHang
            // 
            this.txtKhoHang.Location = new System.Drawing.Point(136, 149);
            this.txtKhoHang.Name = "txtKhoHang";
            this.txtKhoHang.Size = new System.Drawing.Size(166, 26);
            this.txtKhoHang.TabIndex = 68;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(136, 94);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(166, 26);
            this.txtNhanVien.TabIndex = 67;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.CustomFormat = "M/dd/yyyy HH:mm:ss";
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTao.Location = new System.Drawing.Point(464, 42);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.ShowUpDown = true;
            this.dtpNgayTao.Size = new System.Drawing.Size(166, 26);
            this.dtpNgayTao.TabIndex = 66;
            this.dtpNgayTao.ValueChanged += new System.EventHandler(this.dtpNgayTao_ValueChanged);
            // 
            // vbBtnThoat
            // 
            this.vbBtnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbBtnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbBtnThoat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbBtnThoat.BorderRadius = 20;
            this.vbBtnThoat.BorderSize = 0;
            this.vbBtnThoat.FlatAppearance.BorderSize = 0;
            this.vbBtnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbBtnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbBtnThoat.ForeColor = System.Drawing.Color.White;
            this.vbBtnThoat.Location = new System.Drawing.Point(1282, 730);
            this.vbBtnThoat.Name = "vbBtnThoat";
            this.vbBtnThoat.Size = new System.Drawing.Size(150, 40);
            this.vbBtnThoat.TabIndex = 70;
            this.vbBtnThoat.Text = "Thoát";
            this.vbBtnThoat.TextColor = System.Drawing.Color.White;
            this.vbBtnThoat.UseVisualStyleBackColor = false;
            this.vbBtnThoat.Click += new System.EventHandler(this.vbBtnThoat_Click);
            // 
            // vbBtnSua
            // 
            this.vbBtnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbBtnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbBtnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbBtnSua.BorderRadius = 20;
            this.vbBtnSua.BorderSize = 0;
            this.vbBtnSua.FlatAppearance.BorderSize = 0;
            this.vbBtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbBtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbBtnSua.ForeColor = System.Drawing.Color.White;
            this.vbBtnSua.Location = new System.Drawing.Point(666, 730);
            this.vbBtnSua.Name = "vbBtnSua";
            this.vbBtnSua.Size = new System.Drawing.Size(150, 40);
            this.vbBtnSua.TabIndex = 64;
            this.vbBtnSua.Text = "Sửa";
            this.vbBtnSua.TextColor = System.Drawing.Color.White;
            this.vbBtnSua.UseVisualStyleBackColor = false;
            this.vbBtnSua.Click += new System.EventHandler(this.vbBtnSua_Click);
            // 
            // vbBtnXoa
            // 
            this.vbBtnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbBtnXoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbBtnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbBtnXoa.BorderRadius = 20;
            this.vbBtnXoa.BorderSize = 0;
            this.vbBtnXoa.FlatAppearance.BorderSize = 0;
            this.vbBtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbBtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbBtnXoa.ForeColor = System.Drawing.Color.White;
            this.vbBtnXoa.Location = new System.Drawing.Point(991, 730);
            this.vbBtnXoa.Name = "vbBtnXoa";
            this.vbBtnXoa.Size = new System.Drawing.Size(150, 40);
            this.vbBtnXoa.TabIndex = 41;
            this.vbBtnXoa.Text = "Xóa";
            this.vbBtnXoa.TextColor = System.Drawing.Color.White;
            this.vbBtnXoa.UseVisualStyleBackColor = false;
            this.vbBtnXoa.Click += new System.EventHandler(this.vbBtnXoa_Click);
            // 
            // vbBtnNhapMoi
            // 
            this.vbBtnNhapMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbBtnNhapMoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbBtnNhapMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbBtnNhapMoi.BorderRadius = 20;
            this.vbBtnNhapMoi.BorderSize = 0;
            this.vbBtnNhapMoi.FlatAppearance.BorderSize = 0;
            this.vbBtnNhapMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbBtnNhapMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbBtnNhapMoi.ForeColor = System.Drawing.Color.White;
            this.vbBtnNhapMoi.Location = new System.Drawing.Point(330, 730);
            this.vbBtnNhapMoi.Name = "vbBtnNhapMoi";
            this.vbBtnNhapMoi.Size = new System.Drawing.Size(150, 40);
            this.vbBtnNhapMoi.TabIndex = 64;
            this.vbBtnNhapMoi.Text = "Nhập mới";
            this.vbBtnNhapMoi.TextColor = System.Drawing.Color.White;
            this.vbBtnNhapMoi.UseVisualStyleBackColor = false;
            this.vbBtnNhapMoi.Click += new System.EventHandler(this.vbBtnNhapMoi_Click);
            // 
            // vbBtnThem
            // 
            this.vbBtnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbBtnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbBtnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbBtnThem.BorderRadius = 20;
            this.vbBtnThem.BorderSize = 0;
            this.vbBtnThem.FlatAppearance.BorderSize = 0;
            this.vbBtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbBtnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbBtnThem.ForeColor = System.Drawing.Color.White;
            this.vbBtnThem.Location = new System.Drawing.Point(39, 730);
            this.vbBtnThem.Name = "vbBtnThem";
            this.vbBtnThem.Size = new System.Drawing.Size(150, 40);
            this.vbBtnThem.TabIndex = 40;
            this.vbBtnThem.Text = "Tạo CTHĐ";
            this.vbBtnThem.TextColor = System.Drawing.Color.White;
            this.vbBtnThem.UseVisualStyleBackColor = false;
            this.vbBtnThem.Click += new System.EventHandler(this.vbBtnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(510, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(371, 32);
            this.label7.TabIndex = 71;
            this.label7.Text = "CHI TIẾT HÓA ĐƠN NHẬP";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // GUI_ChiTiet_HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1466, 792);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vbBtnThoat);
            this.Controls.Add(this.grbTTHD);
            this.Controls.Add(this.vbBtnSua);
            this.Controls.Add(this.vbBtnXoa);
            this.Controls.Add(this.grbCTHD);
            this.Controls.Add(this.vbBtnNhapMoi);
            this.Controls.Add(this.dgvDSCTHDNhap);
            this.Controls.Add(this.vbBtnThem);
            this.Controls.Add(this.label10);
            this.Name = "GUI_ChiTiet_HoaDonNhap";
            this.Text = "GUI_HoaDonNhap";
            this.Load += new System.EventHandler(this.GUI_HoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTHDNhap)).EndInit();
            this.grbCTHD.ResumeLayout(false);
            this.grbCTHD.PerformLayout();
            this.grbTTHD.ResumeLayout(false);
            this.grbTTHD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.TextBox txtSLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDSCTHDNhap;
        private System.Windows.Forms.GroupBox grbCTHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTTHD;
        private VBButton vbBtnThem;
        private VBButton vbBtnXoa;
        private VBButton vbBtnNhapMoi;
        private VBButton vbBtnSua;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private VBButton vbBtnThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGNhap;
        private System.Windows.Forms.TextBox txtKhoHang;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label7;
    }
}
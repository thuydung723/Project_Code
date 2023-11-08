namespace Đồ_Án_QLCH
{
    partial class GUI_QuanLi_HDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_QuanLi_HDN));
            this.grbTTHD = new System.Windows.Forms.GroupBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboKhoHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grbTKHD = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpTimKiemKT = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTimKiemBD = new System.Windows.Forms.DateTimePicker();
            this.txtMaKhoTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vbBtnTK = new Đồ_Án_QLCH.VBButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHDTK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvDSHDNhap = new System.Windows.Forms.DataGridView();
            this.vbBInHoaDon = new Đồ_Án_QLCH.VBButton();
            this.vbBtnThoat = new Đồ_Án_QLCH.VBButton();
            this.vbBtnSua = new Đồ_Án_QLCH.VBButton();
            this.vbBtnNhapMoi = new Đồ_Án_QLCH.VBButton();
            this.vbBtnXoa = new Đồ_Án_QLCH.VBButton();
            this.vbBtnThem = new Đồ_Án_QLCH.VBButton();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbTTHD.SuspendLayout();
            this.grbTKHD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHDNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTHD
            // 
            this.grbTTHD.Controls.Add(this.txtTenNV);
            this.grbTTHD.Controls.Add(this.label9);
            this.grbTTHD.Controls.Add(this.txtTongTien);
            this.grbTTHD.Controls.Add(this.label6);
            this.grbTTHD.Controls.Add(this.dtpNgayTao);
            this.grbTTHD.Controls.Add(this.label1);
            this.grbTTHD.Controls.Add(this.txtMaHD);
            this.grbTTHD.Controls.Add(this.label2);
            this.grbTTHD.Controls.Add(this.cboNhanVien);
            this.grbTTHD.Controls.Add(this.cboKhoHang);
            this.grbTTHD.Controls.Add(this.label3);
            this.grbTTHD.Controls.Add(this.label8);
            this.grbTTHD.Location = new System.Drawing.Point(12, 135);
            this.grbTTHD.Name = "grbTTHD";
            this.grbTTHD.Size = new System.Drawing.Size(643, 256);
            this.grbTTHD.TabIndex = 0;
            this.grbTTHD.TabStop = false;
            this.grbTTHD.Text = "Thông tin hóa đơn";
            this.grbTTHD.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(478, 42);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(149, 26);
            this.txtTenNV.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Tên nhân viên:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(478, 161);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(149, 26);
            this.txtTongTien.TabIndex = 50;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tổng tiền hóa đơn:";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.CustomFormat = "M/dd/yyyy HH:mm:ss";
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTao.Location = new System.Drawing.Point(126, 94);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.ShowUpDown = true;
            this.dtpNgayTao.Size = new System.Drawing.Size(149, 26);
            this.dtpNgayTao.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mã hóa đơn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(126, 33);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(149, 26);
            this.txtMaHD.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ngày tạo:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(126, 153);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(149, 28);
            this.cboNhanVien.TabIndex = 46;
            this.cboNhanVien.SelectedValueChanged += new System.EventHandler(this.cboNhanVien_SelectedValueChanged);
            // 
            // cboKhoHang
            // 
            this.cboKhoHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoHang.FormattingEnabled = true;
            this.cboKhoHang.Location = new System.Drawing.Point(478, 94);
            this.cboKhoHang.Name = "cboKhoHang";
            this.cboKhoHang.Size = new System.Drawing.Size(149, 28);
            this.cboKhoHang.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nhân viên:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Kho hàng:";
            // 
            // grbTKHD
            // 
            this.grbTKHD.Controls.Add(this.groupBox2);
            this.grbTKHD.Controls.Add(this.groupBox1);
            this.grbTKHD.Controls.Add(this.txtMaKhoTK);
            this.grbTKHD.Controls.Add(this.label5);
            this.grbTKHD.Controls.Add(this.vbBtnTK);
            this.grbTKHD.Controls.Add(this.label4);
            this.grbTKHD.Controls.Add(this.txtMaHDTK);
            this.grbTKHD.Location = new System.Drawing.Point(698, 135);
            this.grbTKHD.Name = "grbTKHD";
            this.grbTKHD.Size = new System.Drawing.Size(648, 263);
            this.grbTKHD.TabIndex = 1;
            this.grbTKHD.TabStop = false;
            this.grbTKHD.Text = "Tìm kiếm hóa đơn";
            this.grbTKHD.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpTimKiemKT);
            this.groupBox2.ForeColor = System.Drawing.Color.Purple;
            this.groupBox2.Location = new System.Drawing.Point(384, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 89);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đến ngày";
            // 
            // dtpTimKiemKT
            // 
            this.dtpTimKiemKT.CustomFormat = "M/dd/yyyy HH:mm:ss";
            this.dtpTimKiemKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimKiemKT.Location = new System.Drawing.Point(39, 29);
            this.dtpTimKiemKT.Name = "dtpTimKiemKT";
            this.dtpTimKiemKT.ShowUpDown = true;
            this.dtpTimKiemKT.Size = new System.Drawing.Size(150, 26);
            this.dtpTimKiemKT.TabIndex = 52;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTimKiemBD);
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(18, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 96);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Từ ngày";
            // 
            // dtpTimKiemBD
            // 
            this.dtpTimKiemBD.CustomFormat = "M/dd/yyyy HH:mm:ss";
            this.dtpTimKiemBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimKiemBD.Location = new System.Drawing.Point(31, 36);
            this.dtpTimKiemBD.Name = "dtpTimKiemBD";
            this.dtpTimKiemBD.ShowUpDown = true;
            this.dtpTimKiemBD.Size = new System.Drawing.Size(150, 26);
            this.dtpTimKiemBD.TabIndex = 51;
            this.dtpTimKiemBD.ValueChanged += new System.EventHandler(this.dtpTimKiemBD_ValueChanged);
            // 
            // txtMaKhoTK
            // 
            this.txtMaKhoTK.Location = new System.Drawing.Point(215, 100);
            this.txtMaKhoTK.Name = "txtMaKhoTK";
            this.txtMaKhoTK.Size = new System.Drawing.Size(192, 26);
            this.txtMaKhoTK.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Kho hàng:";
            // 
            // vbBtnTK
            // 
            this.vbBtnTK.BackColor = System.Drawing.Color.Green;
            this.vbBtnTK.BackgroundColor = System.Drawing.Color.Green;
            this.vbBtnTK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbBtnTK.BorderRadius = 20;
            this.vbBtnTK.BorderSize = 0;
            this.vbBtnTK.FlatAppearance.BorderSize = 0;
            this.vbBtnTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbBtnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbBtnTK.ForeColor = System.Drawing.Color.White;
            this.vbBtnTK.Location = new System.Drawing.Point(457, 68);
            this.vbBtnTK.Name = "vbBtnTK";
            this.vbBtnTK.Size = new System.Drawing.Size(150, 52);
            this.vbBtnTK.TabIndex = 47;
            this.vbBtnTK.Text = "Tìm kiếm";
            this.vbBtnTK.TextColor = System.Drawing.Color.White;
            this.vbBtnTK.UseVisualStyleBackColor = false;
            this.vbBtnTK.Click += new System.EventHandler(this.vbBtnTK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Mã hóa đơn:";
            // 
            // txtMaHDTK
            // 
            this.txtMaHDTK.Location = new System.Drawing.Point(215, 53);
            this.txtMaHDTK.Name = "txtMaHDTK";
            this.txtMaHDTK.Size = new System.Drawing.Size(192, 26);
            this.txtMaHDTK.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(21, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Danh sách hóa đơn";
            // 
            // dgvDSHDNhap
            // 
            this.dgvDSHDNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHDNhap.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDSHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHDNhap.Location = new System.Drawing.Point(26, 422);
            this.dgvDSHDNhap.Name = "dgvDSHDNhap";
            this.dgvDSHDNhap.RowHeadersWidth = 62;
            this.dgvDSHDNhap.RowTemplate.Height = 28;
            this.dgvDSHDNhap.Size = new System.Drawing.Size(1320, 271);
            this.dgvDSHDNhap.TabIndex = 36;
            this.dgvDSHDNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellClick);
            this.dgvDSHDNhap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHDNhap_CellDoubleClick);
            // 
            // vbBInHoaDon
            // 
            this.vbBInHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbBInHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbBInHoaDon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbBInHoaDon.BorderRadius = 20;
            this.vbBInHoaDon.BorderSize = 0;
            this.vbBInHoaDon.FlatAppearance.BorderSize = 0;
            this.vbBInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbBInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbBInHoaDon.ForeColor = System.Drawing.Color.White;
            this.vbBInHoaDon.Location = new System.Drawing.Point(1196, 710);
            this.vbBInHoaDon.Name = "vbBInHoaDon";
            this.vbBInHoaDon.Size = new System.Drawing.Size(150, 40);
            this.vbBInHoaDon.TabIndex = 70;
            this.vbBInHoaDon.Text = "In hóa đơn";
            this.vbBInHoaDon.TextColor = System.Drawing.Color.White;
            this.vbBInHoaDon.UseVisualStyleBackColor = false;
            this.vbBInHoaDon.Click += new System.EventHandler(this.vbBInHoaDon_Click);
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
            this.vbBtnThoat.Location = new System.Drawing.Point(955, 710);
            this.vbBtnThoat.Name = "vbBtnThoat";
            this.vbBtnThoat.Size = new System.Drawing.Size(150, 40);
            this.vbBtnThoat.TabIndex = 69;
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
            this.vbBtnSua.Location = new System.Drawing.Point(235, 710);
            this.vbBtnSua.Name = "vbBtnSua";
            this.vbBtnSua.Size = new System.Drawing.Size(150, 40);
            this.vbBtnSua.TabIndex = 68;
            this.vbBtnSua.Text = "Sửa";
            this.vbBtnSua.TextColor = System.Drawing.Color.White;
            this.vbBtnSua.UseVisualStyleBackColor = false;
            this.vbBtnSua.Click += new System.EventHandler(this.vbBtnSua_Click);
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
            this.vbBtnNhapMoi.Location = new System.Drawing.Point(716, 710);
            this.vbBtnNhapMoi.Name = "vbBtnNhapMoi";
            this.vbBtnNhapMoi.Size = new System.Drawing.Size(150, 40);
            this.vbBtnNhapMoi.TabIndex = 67;
            this.vbBtnNhapMoi.Text = "Nhập mới";
            this.vbBtnNhapMoi.TextColor = System.Drawing.Color.White;
            this.vbBtnNhapMoi.UseVisualStyleBackColor = false;
            this.vbBtnNhapMoi.Click += new System.EventHandler(this.vbBtnNhapMoi_Click);
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
            this.vbBtnXoa.Location = new System.Drawing.Point(469, 710);
            this.vbBtnXoa.Name = "vbBtnXoa";
            this.vbBtnXoa.Size = new System.Drawing.Size(150, 40);
            this.vbBtnXoa.TabIndex = 66;
            this.vbBtnXoa.Text = "Xóa";
            this.vbBtnXoa.TextColor = System.Drawing.Color.White;
            this.vbBtnXoa.UseVisualStyleBackColor = false;
            this.vbBtnXoa.Click += new System.EventHandler(this.vbBtnXoa_Click);
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
            this.vbBtnThem.Location = new System.Drawing.Point(12, 710);
            this.vbBtnThem.Name = "vbBtnThem";
            this.vbBtnThem.Size = new System.Drawing.Size(150, 40);
            this.vbBtnThem.TabIndex = 65;
            this.vbBtnThem.Text = "Tạo hóa đơn";
            this.vbBtnThem.TextColor = System.Drawing.Color.White;
            this.vbBtnThem.UseVisualStyleBackColor = false;
            this.vbBtnThem.Click += new System.EventHandler(this.vbBtnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(463, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 32);
            this.label7.TabIndex = 71;
            this.label7.Text = "HÓA ĐƠN NHẬP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(765, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // GUI_QuanLi_HDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1393, 762);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vbBInHoaDon);
            this.Controls.Add(this.vbBtnThoat);
            this.Controls.Add(this.vbBtnSua);
            this.Controls.Add(this.vbBtnNhapMoi);
            this.Controls.Add(this.vbBtnXoa);
            this.Controls.Add(this.vbBtnThem);
            this.Controls.Add(this.dgvDSHDNhap);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grbTKHD);
            this.Controls.Add(this.grbTTHD);
            this.Name = "GUI_QuanLi_HDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_QuanLi_HDN";
            this.Load += new System.EventHandler(this.GUI_QuanLi_HDN_Load);
            this.Click += new System.EventHandler(this.GUI_QuanLi_HDN_Click);
            this.grbTTHD.ResumeLayout(false);
            this.grbTTHD.PerformLayout();
            this.grbTKHD.ResumeLayout(false);
            this.grbTKHD.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHDNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTHD;
        private System.Windows.Forms.GroupBox grbTKHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboKhoHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHDTK;
        private VBButton vbBtnTK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvDSHDNhap;
        private VBButton vbBtnNhapMoi;
        private VBButton vbBtnXoa;
        private VBButton vbBtnThem;
        private VBButton vbBtnSua;
        private VBButton vbBtnThoat;
        private System.Windows.Forms.TextBox txtMaKhoTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTimKiemBD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpTimKiemKT;
        private System.Windows.Forms.GroupBox groupBox1;
        private VBButton vbBInHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label9;
    }
}
namespace Đồ_Án_QLCH
{
    partial class GUI_QuanLy_HoaDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_QuanLy_HoaDonBan));
            this.dgvDSHDBan = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.grbTKHD = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpTimKiemKT = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTimKiemBD = new System.Windows.Forms.DateTimePicker();
            this.txtMaKHTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vbBtnTK = new Đồ_Án_QLCH.VBButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHDTK = new System.Windows.Forms.TextBox();
            this.grbTTHD = new System.Windows.Forms.GroupBox();
            this.vbBQLKH = new Đồ_Án_QLCH.VBButton();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongTienHD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskSDT = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vbButton1 = new Đồ_Án_QLCH.VBButton();
            this.vbBtnThoat = new Đồ_Án_QLCH.VBButton();
            this.vbBtnSua = new Đồ_Án_QLCH.VBButton();
            this.vbBtnNhapMoi = new Đồ_Án_QLCH.VBButton();
            this.vbBtnXoa = new Đồ_Án_QLCH.VBButton();
            this.vbBtnThem = new Đồ_Án_QLCH.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHDBan)).BeginInit();
            this.grbTKHD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbTTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSHDBan
            // 
            this.dgvDSHDBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHDBan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDSHDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHDBan.Location = new System.Drawing.Point(26, 420);
            this.dgvDSHDBan.Name = "dgvDSHDBan";
            this.dgvDSHDBan.RowHeadersWidth = 62;
            this.dgvDSHDBan.RowTemplate.Height = 28;
            this.dgvDSHDBan.Size = new System.Drawing.Size(1336, 270);
            this.dgvDSHDBan.TabIndex = 73;
            this.dgvDSHDBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHDBan_CellClick);
            this.dgvDSHDBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellContentClick);
            this.dgvDSHDBan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHDBan_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(12, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 25);
            this.label11.TabIndex = 72;
            this.label11.Text = "Danh sách hóa đơn";
            // 
            // grbTKHD
            // 
            this.grbTKHD.Controls.Add(this.groupBox2);
            this.grbTKHD.Controls.Add(this.groupBox1);
            this.grbTKHD.Controls.Add(this.txtMaKHTK);
            this.grbTKHD.Controls.Add(this.label2);
            this.grbTKHD.Controls.Add(this.vbBtnTK);
            this.grbTKHD.Controls.Add(this.label4);
            this.grbTKHD.Controls.Add(this.txtMaHDTK);
            this.grbTKHD.Location = new System.Drawing.Point(836, 83);
            this.grbTKHD.Name = "grbTKHD";
            this.grbTKHD.Size = new System.Drawing.Size(541, 312);
            this.grbTKHD.TabIndex = 71;
            this.grbTKHD.TabStop = false;
            this.grbTKHD.Text = "Tìm kiếm hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpTimKiemKT);
            this.groupBox2.ForeColor = System.Drawing.Color.Purple;
            this.groupBox2.Location = new System.Drawing.Point(309, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 79);
            this.groupBox2.TabIndex = 55;
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
            this.groupBox1.Location = new System.Drawing.Point(19, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 87);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Từ ngày";
            // 
            // dtpTimKiemBD
            // 
            this.dtpTimKiemBD.CustomFormat = "M/dd/yyyy HH:mm:ss";
            this.dtpTimKiemBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimKiemBD.Location = new System.Drawing.Point(30, 37);
            this.dtpTimKiemBD.Name = "dtpTimKiemBD";
            this.dtpTimKiemBD.ShowUpDown = true;
            this.dtpTimKiemBD.Size = new System.Drawing.Size(150, 26);
            this.dtpTimKiemBD.TabIndex = 51;
            // 
            // txtMaKHTK
            // 
            this.txtMaKHTK.Location = new System.Drawing.Point(155, 105);
            this.txtMaKHTK.Name = "txtMaKHTK";
            this.txtMaKHTK.Size = new System.Drawing.Size(154, 26);
            this.txtMaKHTK.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Khách hàng:";
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
            this.vbBtnTK.Location = new System.Drawing.Point(369, 73);
            this.vbBtnTK.Name = "vbBtnTK";
            this.vbBtnTK.Size = new System.Drawing.Size(150, 55);
            this.vbBtnTK.TabIndex = 47;
            this.vbBtnTK.Text = "Tìm kiếm";
            this.vbBtnTK.TextColor = System.Drawing.Color.White;
            this.vbBtnTK.UseVisualStyleBackColor = false;
            this.vbBtnTK.Click += new System.EventHandler(this.vbBtnTK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Mã hóa đơn:";
            // 
            // txtMaHDTK
            // 
            this.txtMaHDTK.Location = new System.Drawing.Point(155, 53);
            this.txtMaHDTK.Name = "txtMaHDTK";
            this.txtMaHDTK.Size = new System.Drawing.Size(154, 26);
            this.txtMaHDTK.TabIndex = 46;
            // 
            // grbTTHD
            // 
            this.grbTTHD.Controls.Add(this.vbBQLKH);
            this.grbTTHD.Controls.Add(this.txtTenNV);
            this.grbTTHD.Controls.Add(this.label12);
            this.grbTTHD.Controls.Add(this.txtTenKH);
            this.grbTTHD.Controls.Add(this.label10);
            this.grbTTHD.Controls.Add(this.txtKhachHang);
            this.grbTTHD.Controls.Add(this.dtpNgayTao);
            this.grbTTHD.Controls.Add(this.label3);
            this.grbTTHD.Controls.Add(this.txtMaHD);
            this.grbTTHD.Controls.Add(this.label6);
            this.grbTTHD.Controls.Add(this.cboNhanVien);
            this.grbTTHD.Controls.Add(this.label1);
            this.grbTTHD.Controls.Add(this.label7);
            this.grbTTHD.Controls.Add(this.label8);
            this.grbTTHD.Controls.Add(this.txtTongTienHD);
            this.grbTTHD.Controls.Add(this.label9);
            this.grbTTHD.Controls.Add(this.mskSDT);
            this.grbTTHD.Location = new System.Drawing.Point(26, 83);
            this.grbTTHD.Name = "grbTTHD";
            this.grbTTHD.Size = new System.Drawing.Size(758, 318);
            this.grbTTHD.TabIndex = 70;
            this.grbTTHD.TabStop = false;
            this.grbTTHD.Text = "Thông tin hóa đơn";
            this.grbTTHD.Enter += new System.EventHandler(this.grbTTHD_Enter);
            // 
            // vbBQLKH
            // 
            this.vbBQLKH.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbBQLKH.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbBQLKH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbBQLKH.BorderRadius = 20;
            this.vbBQLKH.BorderSize = 0;
            this.vbBQLKH.FlatAppearance.BorderSize = 0;
            this.vbBQLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbBQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbBQLKH.ForeColor = System.Drawing.Color.White;
            this.vbBQLKH.Location = new System.Drawing.Point(191, 261);
            this.vbBQLKH.Name = "vbBQLKH";
            this.vbBQLKH.Size = new System.Drawing.Size(344, 51);
            this.vbBQLKH.TabIndex = 88;
            this.vbBQLKH.Text = "Quản Lý Khách Hàng";
            this.vbBQLKH.TextColor = System.Drawing.Color.White;
            this.vbBQLKH.UseVisualStyleBackColor = false;
            this.vbBQLKH.Click += new System.EventHandler(this.vbBQLKH_Click_1);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(148, 157);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(163, 26);
            this.txtTenNV.TabIndex = 87;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 86;
            this.label12.Text = "Tên nhân viên:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(510, 50);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(163, 26);
            this.txtTenKH.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 84;
            this.label10.Text = "Tên khách hàng:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(148, 209);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(163, 26);
            this.txtKhachHang.TabIndex = 83;
            this.txtKhachHang.TextChanged += new System.EventHandler(this.txtKhachHang_TextChanged);
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.CustomFormat = "M/dd/yyyy HH:mm:ss";
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTao.Location = new System.Drawing.Point(510, 98);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.ShowUpDown = true;
            this.dtpNgayTao.Size = new System.Drawing.Size(163, 26);
            this.dtpNgayTao.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(148, 50);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(163, 26);
            this.txtMaHD.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(148, 100);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(163, 28);
            this.cboNhanVien.TabIndex = 73;
            this.cboNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboNhanVien_SelectedIndexChanged);
            this.cboNhanVien.SelectedValueChanged += new System.EventHandler(this.cboNhanVien_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Ngày tạo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 77;
            this.label7.Text = "Khách hàng:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 79;
            this.label8.Text = "Tổng tiền hóa đơn:";
            // 
            // txtTongTienHD
            // 
            this.txtTongTienHD.Location = new System.Drawing.Point(510, 212);
            this.txtTongTienHD.Name = "txtTongTienHD";
            this.txtTongTienHD.Size = new System.Drawing.Size(163, 26);
            this.txtTongTienHD.TabIndex = 78;
            this.txtTongTienHD.TextChanged += new System.EventHandler(this.txtTongTienHD_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 80;
            this.label9.Text = "SDT KH:";
            // 
            // mskSDT
            // 
            this.mskSDT.Location = new System.Drawing.Point(510, 154);
            this.mskSDT.Mask = "(999) 000-0000";
            this.mskSDT.Name = "mskSDT";
            this.mskSDT.Size = new System.Drawing.Size(163, 26);
            this.mskSDT.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(432, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 32);
            this.label5.TabIndex = 79;
            this.label5.Text = " HÓA ĐƠN BÁN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(705, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 20;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(1227, 712);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(150, 40);
            this.vbButton1.TabIndex = 81;
            this.vbButton1.Text = "In hóa đơn";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
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
            this.vbBtnThoat.Location = new System.Drawing.Point(1004, 712);
            this.vbBtnThoat.Name = "vbBtnThoat";
            this.vbBtnThoat.Size = new System.Drawing.Size(150, 40);
            this.vbBtnThoat.TabIndex = 78;
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
            this.vbBtnSua.Location = new System.Drawing.Point(233, 712);
            this.vbBtnSua.Name = "vbBtnSua";
            this.vbBtnSua.Size = new System.Drawing.Size(150, 40);
            this.vbBtnSua.TabIndex = 77;
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
            this.vbBtnNhapMoi.Location = new System.Drawing.Point(741, 712);
            this.vbBtnNhapMoi.Name = "vbBtnNhapMoi";
            this.vbBtnNhapMoi.Size = new System.Drawing.Size(150, 40);
            this.vbBtnNhapMoi.TabIndex = 76;
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
            this.vbBtnXoa.Location = new System.Drawing.Point(491, 712);
            this.vbBtnXoa.Name = "vbBtnXoa";
            this.vbBtnXoa.Size = new System.Drawing.Size(150, 40);
            this.vbBtnXoa.TabIndex = 75;
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
            this.vbBtnThem.Location = new System.Drawing.Point(26, 712);
            this.vbBtnThem.Name = "vbBtnThem";
            this.vbBtnThem.Size = new System.Drawing.Size(150, 40);
            this.vbBtnThem.TabIndex = 74;
            this.vbBtnThem.Text = "Tạo hóa đơn";
            this.vbBtnThem.TextColor = System.Drawing.Color.White;
            this.vbBtnThem.UseVisualStyleBackColor = false;
            this.vbBtnThem.Click += new System.EventHandler(this.vbBtnThem_Click);
            // 
            // GUI_QuanLy_HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 764);
            this.Controls.Add(this.vbButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vbBtnThoat);
            this.Controls.Add(this.vbBtnSua);
            this.Controls.Add(this.vbBtnNhapMoi);
            this.Controls.Add(this.vbBtnXoa);
            this.Controls.Add(this.vbBtnThem);
            this.Controls.Add(this.dgvDSHDBan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grbTKHD);
            this.Controls.Add(this.grbTTHD);
            this.Name = "GUI_QuanLy_HoaDonBan";
            this.Text = "GUI_QuanLy_HoaDonBan";
            this.Load += new System.EventHandler(this.GUI_QuanLy_HoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHDBan)).EndInit();
            this.grbTKHD.ResumeLayout(false);
            this.grbTKHD.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grbTTHD.ResumeLayout(false);
            this.grbTTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VBButton vbBtnThoat;
        private VBButton vbBtnSua;
        private VBButton vbBtnNhapMoi;
        private VBButton vbBtnXoa;
        private VBButton vbBtnThem;
        private System.Windows.Forms.DataGridView dgvDSHDBan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grbTKHD;
        private VBButton vbBtnTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHDTK;
        private System.Windows.Forms.GroupBox grbTTHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskSDT;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.TextBox txtMaKHTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongTienHD;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpTimKiemKT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTimKiemBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VBButton vbButton1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label12;
        private VBButton vbBQLKH;
    }
}
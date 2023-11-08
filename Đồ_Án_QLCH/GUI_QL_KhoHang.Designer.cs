namespace Đồ_Án_QLCH
{
    partial class GUI_QL_KhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_QL_KhoHang));
            this.grbTTKH = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.vbBNhaCC = new Đồ_Án_QLCH.VBButton();
            this.cboNVQL = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.txtTenKho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbTKKho = new System.Windows.Forms.GroupBox();
            this.vbBtnTK = new Đồ_Án_QLCH.VBButton();
            this.txtTenKhoTK = new System.Windows.Forms.TextBox();
            this.txtMaKhoTK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvDSK = new System.Windows.Forms.DataGridView();
            this.vbBtnThoat = new Đồ_Án_QLCH.VBButton();
            this.vbBtnNhapMoi = new Đồ_Án_QLCH.VBButton();
            this.vbBtnXoa = new Đồ_Án_QLCH.VBButton();
            this.vbBtnSua = new Đồ_Án_QLCH.VBButton();
            this.vbBtnThem = new Đồ_Án_QLCH.VBButton();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbTTKH.SuspendLayout();
            this.grbTKKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTKH
            // 
            this.grbTTKH.Controls.Add(this.label10);
            this.grbTTKH.Controls.Add(this.txtTenNCC);
            this.grbTTKH.Controls.Add(this.txtMaNCC);
            this.grbTTKH.Controls.Add(this.vbBNhaCC);
            this.grbTTKH.Controls.Add(this.cboNVQL);
            this.grbTTKH.Controls.Add(this.label8);
            this.grbTTKH.Controls.Add(this.label7);
            this.grbTTKH.Controls.Add(this.txtTrangThai);
            this.grbTTKH.Controls.Add(this.label1);
            this.grbTTKH.Controls.Add(this.txtMaKho);
            this.grbTTKH.Controls.Add(this.txtTenKho);
            this.grbTTKH.Controls.Add(this.label4);
            this.grbTTKH.Controls.Add(this.txtDiaChi);
            this.grbTTKH.Controls.Add(this.label2);
            this.grbTTKH.Controls.Add(this.label3);
            this.grbTTKH.Location = new System.Drawing.Point(33, 115);
            this.grbTTKH.Name = "grbTTKH";
            this.grbTTKH.Size = new System.Drawing.Size(684, 293);
            this.grbTTKH.TabIndex = 60;
            this.grbTTKH.TabStop = false;
            this.grbTTKH.Text = "Thông tin kho hàng";
            this.grbTTKH.Enter += new System.EventHandler(this.grbTTKH_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Tên NCC:";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(486, 50);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(161, 26);
            this.txtTenNCC.TabIndex = 52;
            this.txtTenNCC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(130, 234);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(169, 26);
            this.txtMaNCC.TabIndex = 51;
            this.txtMaNCC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // vbBNhaCC
            // 
            this.vbBNhaCC.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbBNhaCC.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbBNhaCC.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbBNhaCC.BorderRadius = 20;
            this.vbBNhaCC.BorderSize = 0;
            this.vbBNhaCC.FlatAppearance.BorderSize = 0;
            this.vbBNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbBNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbBNhaCC.ForeColor = System.Drawing.Color.White;
            this.vbBNhaCC.Location = new System.Drawing.Point(355, 223);
            this.vbBNhaCC.Name = "vbBNhaCC";
            this.vbBNhaCC.Size = new System.Drawing.Size(314, 48);
            this.vbBNhaCC.TabIndex = 50;
            this.vbBNhaCC.Text = "Quản lý nhà cung cấp";
            this.vbBNhaCC.TextColor = System.Drawing.Color.White;
            this.vbBNhaCC.UseVisualStyleBackColor = false;
            this.vbBNhaCC.Click += new System.EventHandler(this.vbBNhaCC_Click);
            // 
            // cboNVQL
            // 
            this.cboNVQL.FormattingEnabled = true;
            this.cboNVQL.Location = new System.Drawing.Point(486, 113);
            this.cboNVQL.Name = "cboNVQL";
            this.cboNVQL.Size = new System.Drawing.Size(161, 28);
            this.cboNVQL.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Trạng thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Nhân Viên QL:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(486, 173);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(161, 26);
            this.txtTrangThai.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã kho:";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(130, 54);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(169, 26);
            this.txtMaKho.TabIndex = 41;
            // 
            // txtTenKho
            // 
            this.txtTenKho.Location = new System.Drawing.Point(130, 118);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(169, 26);
            this.txtTenKho.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(130, 173);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(169, 26);
            this.txtDiaChi.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên kho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nhà cung cấp:";
            // 
            // grbTKKho
            // 
            this.grbTKKho.Controls.Add(this.vbBtnTK);
            this.grbTKKho.Controls.Add(this.txtTenKhoTK);
            this.grbTKKho.Controls.Add(this.txtMaKhoTK);
            this.grbTKKho.Controls.Add(this.label6);
            this.grbTKKho.Controls.Add(this.label5);
            this.grbTKKho.Location = new System.Drawing.Point(757, 115);
            this.grbTKKho.Name = "grbTKKho";
            this.grbTKKho.Size = new System.Drawing.Size(505, 293);
            this.grbTKKho.TabIndex = 61;
            this.grbTKKho.TabStop = false;
            this.grbTKKho.Text = "Tìm kiếm kho hàng";
            this.grbTKKho.Enter += new System.EventHandler(this.grbTKKho_Enter);
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
            this.vbBtnTK.Location = new System.Drawing.Point(194, 171);
            this.vbBtnTK.Name = "vbBtnTK";
            this.vbBtnTK.Size = new System.Drawing.Size(150, 50);
            this.vbBtnTK.TabIndex = 39;
            this.vbBtnTK.Text = "Tìm kiếm";
            this.vbBtnTK.TextColor = System.Drawing.Color.White;
            this.vbBtnTK.UseVisualStyleBackColor = false;
            this.vbBtnTK.Click += new System.EventHandler(this.vbBtnTK_Click);
            // 
            // txtTenKhoTK
            // 
            this.txtTenKhoTK.Location = new System.Drawing.Point(226, 100);
            this.txtTenKhoTK.Name = "txtTenKhoTK";
            this.txtTenKhoTK.Size = new System.Drawing.Size(164, 26);
            this.txtTenKhoTK.TabIndex = 3;
            // 
            // txtMaKhoTK
            // 
            this.txtMaKhoTK.Location = new System.Drawing.Point(226, 51);
            this.txtMaKhoTK.Name = "txtMaKhoTK";
            this.txtMaKhoTK.Size = new System.Drawing.Size(164, 26);
            this.txtMaKhoTK.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên kho:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã kho:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(12, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 25);
            this.label11.TabIndex = 62;
            this.label11.Text = "Danh sách kho";
            // 
            // dgvDSK
            // 
            this.dgvDSK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSK.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSK.Location = new System.Drawing.Point(43, 453);
            this.dgvDSK.Name = "dgvDSK";
            this.dgvDSK.RowHeadersWidth = 62;
            this.dgvDSK.RowTemplate.Height = 28;
            this.dgvDSK.Size = new System.Drawing.Size(1219, 254);
            this.dgvDSK.TabIndex = 63;
            this.dgvDSK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSK_CellClick);
            this.dgvDSK.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSK_CellDoubleClick);
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
            this.vbBtnThoat.Location = new System.Drawing.Point(1135, 725);
            this.vbBtnThoat.Name = "vbBtnThoat";
            this.vbBtnThoat.Size = new System.Drawing.Size(150, 40);
            this.vbBtnThoat.TabIndex = 69;
            this.vbBtnThoat.Text = "Thoát";
            this.vbBtnThoat.TextColor = System.Drawing.Color.White;
            this.vbBtnThoat.UseVisualStyleBackColor = false;
            this.vbBtnThoat.Click += new System.EventHandler(this.vbBtnThoat_Click);
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
            this.vbBtnNhapMoi.Location = new System.Drawing.Point(866, 725);
            this.vbBtnNhapMoi.Name = "vbBtnNhapMoi";
            this.vbBtnNhapMoi.Size = new System.Drawing.Size(150, 40);
            this.vbBtnNhapMoi.TabIndex = 68;
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
            this.vbBtnXoa.Location = new System.Drawing.Point(567, 725);
            this.vbBtnXoa.Name = "vbBtnXoa";
            this.vbBtnXoa.Size = new System.Drawing.Size(150, 40);
            this.vbBtnXoa.TabIndex = 67;
            this.vbBtnXoa.Text = "Xóa";
            this.vbBtnXoa.TextColor = System.Drawing.Color.White;
            this.vbBtnXoa.UseVisualStyleBackColor = false;
            this.vbBtnXoa.Click += new System.EventHandler(this.vbBtnXoa_Click);
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
            this.vbBtnSua.Location = new System.Drawing.Point(295, 725);
            this.vbBtnSua.Name = "vbBtnSua";
            this.vbBtnSua.Size = new System.Drawing.Size(150, 40);
            this.vbBtnSua.TabIndex = 66;
            this.vbBtnSua.Text = "Sửa";
            this.vbBtnSua.TextColor = System.Drawing.Color.White;
            this.vbBtnSua.UseVisualStyleBackColor = false;
            this.vbBtnSua.Click += new System.EventHandler(this.vbBtnSua_Click);
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
            this.vbBtnThem.Location = new System.Drawing.Point(33, 725);
            this.vbBtnThem.Name = "vbBtnThem";
            this.vbBtnThem.Size = new System.Drawing.Size(150, 40);
            this.vbBtnThem.TabIndex = 65;
            this.vbBtnThem.Text = "Thêm";
            this.vbBtnThem.TextColor = System.Drawing.Color.White;
            this.vbBtnThem.UseVisualStyleBackColor = false;
            this.vbBtnThem.Click += new System.EventHandler(this.vbBtnThem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(371, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(309, 32);
            this.label9.TabIndex = 70;
            this.label9.Text = "QUẢN LÝ KHO HÀNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(757, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GUI_QL_KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 786);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vbBtnThoat);
            this.Controls.Add(this.vbBtnNhapMoi);
            this.Controls.Add(this.vbBtnXoa);
            this.Controls.Add(this.vbBtnSua);
            this.Controls.Add(this.vbBtnThem);
            this.Controls.Add(this.dgvDSK);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grbTKKho);
            this.Controls.Add(this.grbTTKH);
            this.Name = "GUI_QL_KhoHang";
            this.Text = "GUI_QL_KhoHang";
            this.Load += new System.EventHandler(this.GUI_QL_KhoHang_Load);
            this.grbTTKH.ResumeLayout(false);
            this.grbTTKH.PerformLayout();
            this.grbTKKho.ResumeLayout(false);
            this.grbTKKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.TextBox txtTenKho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbTKKho;
        private VBButton vbBtnTK;
        private System.Windows.Forms.TextBox txtTenKhoTK;
        private System.Windows.Forms.TextBox txtMaKhoTK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvDSK;
        private VBButton vbBtnThoat;
        private VBButton vbBtnNhapMoi;
        private VBButton vbBtnXoa;
        private VBButton vbBtnSua;
        private VBButton vbBtnThem;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.ComboBox cboNVQL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VBButton vbBNhaCC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
    }
}
namespace Đồ_Án_QLCH
{
    partial class GUI_Kho_Hang
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
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dgvDSCTK = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.grbCTKH = new System.Windows.Forms.GroupBox();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.grbTTKH = new System.Windows.Forms.GroupBox();
            this.txtNVQL = new System.Windows.Forms.TextBox();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.txtTenKho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vbBtnThoat = new Đồ_Án_QLCH.VBButton();
            this.vbBtnNhapMoi = new Đồ_Án_QLCH.VBButton();
            this.vbBtnSua = new Đồ_Án_QLCH.VBButton();
            this.vbBtnThem = new Đồ_Án_QLCH.VBButton();
            this.vbBtnXoa = new Đồ_Án_QLCH.VBButton();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTK)).BeginInit();
            this.grbCTKH.SuspendLayout();
            this.grbTTKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sản phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ghi chú:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(156, 103);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(179, 26);
            this.txtSoLuong.TabIndex = 46;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(156, 150);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(179, 26);
            this.txtGhiChu.TabIndex = 47;
            // 
            // dgvDSCTK
            // 
            this.dgvDSCTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCTK.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSCTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTK.Location = new System.Drawing.Point(26, 404);
            this.dgvDSCTK.Name = "dgvDSCTK";
            this.dgvDSCTK.RowHeadersWidth = 62;
            this.dgvDSCTK.RowTemplate.Height = 28;
            this.dgvDSCTK.Size = new System.Drawing.Size(1300, 293);
            this.dgvDSCTK.TabIndex = 49;
            this.dgvDSCTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCTK_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(2, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 25);
            this.label10.TabIndex = 51;
            this.label10.Text = "Danh sách chi tiết kho";
            // 
            // grbCTKH
            // 
            this.grbCTKH.Controls.Add(this.cboSanPham);
            this.grbCTKH.Controls.Add(this.label5);
            this.grbCTKH.Controls.Add(this.label6);
            this.grbCTKH.Controls.Add(this.txtSoLuong);
            this.grbCTKH.Controls.Add(this.label8);
            this.grbCTKH.Controls.Add(this.txtGhiChu);
            this.grbCTKH.Location = new System.Drawing.Point(844, 120);
            this.grbCTKH.Name = "grbCTKH";
            this.grbCTKH.Size = new System.Drawing.Size(482, 216);
            this.grbCTKH.TabIndex = 58;
            this.grbCTKH.TabStop = false;
            this.grbCTKH.Text = "Chi tiết kho hàng";
            // 
            // cboSanPham
            // 
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(156, 53);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(179, 28);
            this.cboSanPham.TabIndex = 55;
            // 
            // grbTTKH
            // 
            this.grbTTKH.Controls.Add(this.txtNVQL);
            this.grbTTKH.Controls.Add(this.txtNhaCC);
            this.grbTTKH.Controls.Add(this.label7);
            this.grbTTKH.Controls.Add(this.label2);
            this.grbTTKH.Controls.Add(this.txtMaKho);
            this.grbTTKH.Controls.Add(this.txtTenKho);
            this.grbTTKH.Controls.Add(this.label3);
            this.grbTTKH.Controls.Add(this.label9);
            this.grbTTKH.Location = new System.Drawing.Point(26, 120);
            this.grbTTKH.Name = "grbTTKH";
            this.grbTTKH.Size = new System.Drawing.Size(691, 216);
            this.grbTTKH.TabIndex = 59;
            this.grbTTKH.TabStop = false;
            this.grbTTKH.Text = "Thông tin kho hàng";
            this.grbTTKH.Enter += new System.EventHandler(this.grbTTKH_Enter);
            // 
            // txtNVQL
            // 
            this.txtNVQL.Location = new System.Drawing.Point(505, 113);
            this.txtNVQL.Name = "txtNVQL";
            this.txtNVQL.Size = new System.Drawing.Size(161, 26);
            this.txtNVQL.TabIndex = 62;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.Location = new System.Drawing.Point(505, 51);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(161, 26);
            this.txtNhaCC.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "Nhân Viên QL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Mã kho:";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(149, 49);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(169, 26);
            this.txtMaKho.TabIndex = 54;
            this.txtMaKho.TextChanged += new System.EventHandler(this.txtMaKho_TextChanged);
            // 
            // txtTenKho
            // 
            this.txtTenKho.Location = new System.Drawing.Point(149, 113);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(169, 26);
            this.txtTenKho.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tên kho:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Nhà cung cấp:";
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
            this.vbBtnThoat.Location = new System.Drawing.Point(1176, 718);
            this.vbBtnThoat.Name = "vbBtnThoat";
            this.vbBtnThoat.Size = new System.Drawing.Size(150, 40);
            this.vbBtnThoat.TabIndex = 64;
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
            this.vbBtnNhapMoi.Location = new System.Drawing.Point(870, 718);
            this.vbBtnNhapMoi.Name = "vbBtnNhapMoi";
            this.vbBtnNhapMoi.Size = new System.Drawing.Size(150, 40);
            this.vbBtnNhapMoi.TabIndex = 63;
            this.vbBtnNhapMoi.Text = "Nhập mới";
            this.vbBtnNhapMoi.TextColor = System.Drawing.Color.White;
            this.vbBtnNhapMoi.UseVisualStyleBackColor = false;
            this.vbBtnNhapMoi.Click += new System.EventHandler(this.vbBtnNhapMoi_Click);
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
            this.vbBtnSua.Location = new System.Drawing.Point(293, 718);
            this.vbBtnSua.Name = "vbBtnSua";
            this.vbBtnSua.Size = new System.Drawing.Size(150, 40);
            this.vbBtnSua.TabIndex = 61;
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
            this.vbBtnThem.Location = new System.Drawing.Point(37, 718);
            this.vbBtnThem.Name = "vbBtnThem";
            this.vbBtnThem.Size = new System.Drawing.Size(150, 40);
            this.vbBtnThem.TabIndex = 60;
            this.vbBtnThem.Text = "Thêm CTK";
            this.vbBtnThem.TextColor = System.Drawing.Color.White;
            this.vbBtnThem.UseVisualStyleBackColor = false;
            this.vbBtnThem.Click += new System.EventHandler(this.vbBtnThem_Click);
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
            this.vbBtnXoa.Location = new System.Drawing.Point(576, 718);
            this.vbBtnXoa.Name = "vbBtnXoa";
            this.vbBtnXoa.Size = new System.Drawing.Size(150, 40);
            this.vbBtnXoa.TabIndex = 62;
            this.vbBtnXoa.Text = "Xóa";
            this.vbBtnXoa.TextColor = System.Drawing.Color.White;
            this.vbBtnXoa.UseVisualStyleBackColor = false;
            this.vbBtnXoa.Click += new System.EventHandler(this.vbBtnXoa_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(570, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(301, 32);
            this.label12.TabIndex = 65;
            this.label12.Text = "CHI TIẾT KHO HÀNG";
            // 
            // GUI_Kho_Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1426, 770);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.vbBtnThoat);
            this.Controls.Add(this.vbBtnNhapMoi);
            this.Controls.Add(this.vbBtnXoa);
            this.Controls.Add(this.vbBtnSua);
            this.Controls.Add(this.vbBtnThem);
            this.Controls.Add(this.grbTTKH);
            this.Controls.Add(this.grbCTKH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDSCTK);
            this.Name = "GUI_Kho_Hang";
            this.Text = "Kho_Hang";
            this.Load += new System.EventHandler(this.Kho_Hang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTK)).EndInit();
            this.grbCTKH.ResumeLayout(false);
            this.grbCTKH.PerformLayout();
            this.grbTTKH.ResumeLayout(false);
            this.grbTTKH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridView dgvDSCTK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grbCTKH;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.GroupBox grbTTKH;
        private VBButton vbBtnThoat;
        private VBButton vbBtnNhapMoi;
        private VBButton vbBtnSua;
        private VBButton vbBtnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.TextBox txtTenKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNVQL;
        private System.Windows.Forms.TextBox txtNhaCC;
        private VBButton vbBtnXoa;
        private System.Windows.Forms.Label label12;
    }
}
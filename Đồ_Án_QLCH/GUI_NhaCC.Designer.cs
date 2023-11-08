namespace Đồ_Án_QLCH
{
    partial class GUI_NhaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_NhaCC));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.dgvDSNCC = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.grbTKNCC = new System.Windows.Forms.GroupBox();
            this.vbBtnTK = new Đồ_Án_QLCH.VBButton();
            this.txtTenNCCTK = new System.Windows.Forms.TextBox();
            this.txtMaNCCTK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTTNCC = new System.Windows.Forms.GroupBox();
            this.mskSDT = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vbBtnThoat = new Đồ_Án_QLCH.VBButton();
            this.vbBtnNhapMoi = new Đồ_Án_QLCH.VBButton();
            this.vbBtnXoa = new Đồ_Án_QLCH.VBButton();
            this.vbBtnSua = new Đồ_Án_QLCH.VBButton();
            this.vbBtnThem = new Đồ_Án_QLCH.VBButton();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNCC)).BeginInit();
            this.grbTKNCC.SuspendLayout();
            this.grbTTNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên  nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(204, 51);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(178, 26);
            this.txtMaNCC.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(204, 149);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(181, 26);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(204, 99);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(181, 26);
            this.txtTenNCC.TabIndex = 6;
            // 
            // dgvDSNCC
            // 
            this.dgvDSNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNCC.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNCC.Location = new System.Drawing.Point(32, 390);
            this.dgvDSNCC.Name = "dgvDSNCC";
            this.dgvDSNCC.RowHeadersWidth = 62;
            this.dgvDSNCC.RowTemplate.Height = 28;
            this.dgvDSNCC.Size = new System.Drawing.Size(1156, 273);
            this.dgvDSNCC.TabIndex = 30;
            this.dgvDSNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNCC_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(27, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // grbTKNCC
            // 
            this.grbTKNCC.Controls.Add(this.vbBtnTK);
            this.grbTKNCC.Controls.Add(this.txtTenNCCTK);
            this.grbTKNCC.Controls.Add(this.txtMaNCCTK);
            this.grbTKNCC.Controls.Add(this.label6);
            this.grbTKNCC.Controls.Add(this.label1);
            this.grbTKNCC.Location = new System.Drawing.Point(779, 97);
            this.grbTKNCC.Name = "grbTKNCC";
            this.grbTKNCC.Size = new System.Drawing.Size(409, 237);
            this.grbTKNCC.TabIndex = 32;
            this.grbTKNCC.TabStop = false;
            this.grbTKNCC.Text = "Tìm kiếm nhà cung cấp";
            this.grbTKNCC.Enter += new System.EventHandler(this.grbTKNCC_Enter);
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
            this.vbBtnTK.Location = new System.Drawing.Point(125, 155);
            this.vbBtnTK.Name = "vbBtnTK";
            this.vbBtnTK.Size = new System.Drawing.Size(150, 50);
            this.vbBtnTK.TabIndex = 39;
            this.vbBtnTK.Text = "Tìm kiếm";
            this.vbBtnTK.TextColor = System.Drawing.Color.White;
            this.vbBtnTK.UseVisualStyleBackColor = false;
            this.vbBtnTK.Click += new System.EventHandler(this.vbBtnTK_Click);
            // 
            // txtTenNCCTK
            // 
            this.txtTenNCCTK.Location = new System.Drawing.Point(173, 99);
            this.txtTenNCCTK.Name = "txtTenNCCTK";
            this.txtTenNCCTK.Size = new System.Drawing.Size(157, 26);
            this.txtTenNCCTK.TabIndex = 3;
            // 
            // txtMaNCCTK
            // 
            this.txtMaNCCTK.Location = new System.Drawing.Point(173, 51);
            this.txtMaNCCTK.Name = "txtMaNCCTK";
            this.txtMaNCCTK.Size = new System.Drawing.Size(164, 26);
            this.txtMaNCCTK.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp:";
            // 
            // grbTTNCC
            // 
            this.grbTTNCC.Controls.Add(this.mskSDT);
            this.grbTTNCC.Controls.Add(this.label7);
            this.grbTTNCC.Controls.Add(this.label2);
            this.grbTTNCC.Controls.Add(this.txtMaNCC);
            this.grbTTNCC.Controls.Add(this.label3);
            this.grbTTNCC.Controls.Add(this.txtTenNCC);
            this.grbTTNCC.Controls.Add(this.label4);
            this.grbTTNCC.Controls.Add(this.txtDiaChi);
            this.grbTTNCC.Location = new System.Drawing.Point(32, 97);
            this.grbTTNCC.Name = "grbTTNCC";
            this.grbTTNCC.Size = new System.Drawing.Size(558, 237);
            this.grbTTNCC.TabIndex = 33;
            this.grbTTNCC.TabStop = false;
            this.grbTTNCC.Text = "Thông tin nhà cung cấp";
            // 
            // mskSDT
            // 
            this.mskSDT.Location = new System.Drawing.Point(204, 197);
            this.mskSDT.Mask = "(999) 000-0000";
            this.mskSDT.Name = "mskSDT";
            this.mskSDT.Size = new System.Drawing.Size(178, 26);
            this.mskSDT.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số điện thoại:";
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
            this.vbBtnThoat.Location = new System.Drawing.Point(1029, 689);
            this.vbBtnThoat.Name = "vbBtnThoat";
            this.vbBtnThoat.Size = new System.Drawing.Size(150, 40);
            this.vbBtnThoat.TabIndex = 38;
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
            this.vbBtnNhapMoi.Location = new System.Drawing.Point(779, 689);
            this.vbBtnNhapMoi.Name = "vbBtnNhapMoi";
            this.vbBtnNhapMoi.Size = new System.Drawing.Size(150, 40);
            this.vbBtnNhapMoi.TabIndex = 37;
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
            this.vbBtnXoa.Location = new System.Drawing.Point(533, 689);
            this.vbBtnXoa.Name = "vbBtnXoa";
            this.vbBtnXoa.Size = new System.Drawing.Size(150, 40);
            this.vbBtnXoa.TabIndex = 36;
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
            this.vbBtnSua.Location = new System.Drawing.Point(285, 689);
            this.vbBtnSua.Name = "vbBtnSua";
            this.vbBtnSua.Size = new System.Drawing.Size(150, 40);
            this.vbBtnSua.TabIndex = 35;
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
            this.vbBtnThem.Location = new System.Drawing.Point(32, 689);
            this.vbBtnThem.Name = "vbBtnThem";
            this.vbBtnThem.Size = new System.Drawing.Size(150, 40);
            this.vbBtnThem.TabIndex = 34;
            this.vbBtnThem.Text = "Thêm";
            this.vbBtnThem.TextColor = System.Drawing.Color.White;
            this.vbBtnThem.UseVisualStyleBackColor = false;
            this.vbBtnThem.Click += new System.EventHandler(this.vbBtnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(318, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(377, 32);
            this.label8.TabIndex = 39;
            this.label8.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(729, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // GUI_NhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 741);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vbBtnThoat);
            this.Controls.Add(this.vbBtnNhapMoi);
            this.Controls.Add(this.vbBtnXoa);
            this.Controls.Add(this.vbBtnSua);
            this.Controls.Add(this.vbBtnThem);
            this.Controls.Add(this.grbTTNCC);
            this.Controls.Add(this.grbTKNCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDSNCC);
            this.Name = "GUI_NhaCC";
            this.Text = "GUI_NhaCC";
            this.Load += new System.EventHandler(this.GUI_NhaCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNCC)).EndInit();
            this.grbTKNCC.ResumeLayout(false);
            this.grbTKNCC.PerformLayout();
            this.grbTTNCC.ResumeLayout(false);
            this.grbTTNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.DataGridView dgvDSNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbTKNCC;
        private System.Windows.Forms.TextBox txtTenNCCTK;
        private System.Windows.Forms.TextBox txtMaNCCTK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTTNCC;
        private VBButton vbBtnThoat;
        private VBButton vbBtnNhapMoi;
        private VBButton vbBtnXoa;
        private VBButton vbBtnSua;
        private VBButton vbBtnThem;
        private VBButton vbBtnTK;
        private System.Windows.Forms.MaskedTextBox mskSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
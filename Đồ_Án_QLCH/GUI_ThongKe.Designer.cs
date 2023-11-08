namespace Đồ_Án_QLCH
{
    partial class GUI_ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ThongKe));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTimKiemBD = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpTimKiemKT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoSPTK = new System.Windows.Forms.RadioButton();
            this.rdoSPBC = new System.Windows.Forms.RadioButton();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.rdoNgay = new System.Windows.Forms.RadioButton();
            this.vbbThoat = new Đồ_Án_QLCH.VBButton();
            this.vbButton2 = new Đồ_Án_QLCH.VBButton();
            this.vbbThongKe = new Đồ_Án_QLCH.VBButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(519, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(743, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(597, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thống kê doanh thu theo (tháng,quý)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(33, 493);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 62;
            this.dgvThongKe.RowTemplate.Height = 28;
            this.dgvThongKe.Size = new System.Drawing.Size(1184, 321);
            this.dgvThongKe.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTimKiemBD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(611, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Từ ngày";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpTimKiemBD
            // 
            this.dtpTimKiemBD.CustomFormat = "M/dd/yyyy HH:mm:ss";
            this.dtpTimKiemBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimKiemBD.Location = new System.Drawing.Point(50, 34);
            this.dtpTimKiemBD.Name = "dtpTimKiemBD";
            this.dtpTimKiemBD.ShowUpDown = true;
            this.dtpTimKiemBD.Size = new System.Drawing.Size(174, 28);
            this.dtpTimKiemBD.TabIndex = 52;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpTimKiemKT);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(957, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 86);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đến ngày";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtpTimKiemKT
            // 
            this.dtpTimKiemKT.CustomFormat = "M/dd/yyyy HH:mm:ss";
            this.dtpTimKiemKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimKiemKT.Location = new System.Drawing.Point(48, 34);
            this.dtpTimKiemKT.Name = "dtpTimKiemKT";
            this.dtpTimKiemKT.ShowUpDown = true;
            this.dtpTimKiemKT.Size = new System.Drawing.Size(175, 28);
            this.dtpTimKiemKT.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(33, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thống kê doanh thu theo ngày";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.CustomFormat = "M/dd/yyyy";
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTao.Location = new System.Drawing.Point(50, 27);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.ShowUpDown = true;
            this.dtpNgayTao.Size = new System.Drawing.Size(180, 28);
            this.dtpNgayTao.TabIndex = 49;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpNgayTao);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(38, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 86);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ngày thống kê";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoSPTK);
            this.groupBox4.Controls.Add(this.rdoSPBC);
            this.groupBox4.Controls.Add(this.rdoThang);
            this.groupBox4.Controls.Add(this.rdoNgay);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(53, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(710, 158);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // rdoSPTK
            // 
            this.rdoSPTK.AutoSize = true;
            this.rdoSPTK.Location = new System.Drawing.Point(346, 98);
            this.rdoSPTK.Name = "rdoSPTK";
            this.rdoSPTK.Size = new System.Drawing.Size(197, 24);
            this.rdoSPTK.TabIndex = 3;
            this.rdoSPTK.TabStop = true;
            this.rdoSPTK.Text = "Thống kê hàng tồn kho";
            this.rdoSPTK.UseVisualStyleBackColor = true;
            this.rdoSPTK.CheckedChanged += new System.EventHandler(this.rdoSPTK_CheckedChanged);
            // 
            // rdoSPBC
            // 
            this.rdoSPBC.AutoSize = true;
            this.rdoSPBC.Location = new System.Drawing.Point(20, 98);
            this.rdoSPBC.Name = "rdoSPBC";
            this.rdoSPBC.Size = new System.Drawing.Size(242, 24);
            this.rdoSPBC.TabIndex = 2;
            this.rdoSPBC.TabStop = true;
            this.rdoSPBC.Text = "Thống kê sản phẩm bán chạy";
            this.rdoSPBC.UseVisualStyleBackColor = true;
            this.rdoSPBC.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoThang
            // 
            this.rdoThang.AutoSize = true;
            this.rdoThang.Location = new System.Drawing.Point(346, 34);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Size = new System.Drawing.Size(220, 24);
            this.rdoThang.TabIndex = 1;
            this.rdoThang.TabStop = true;
            this.rdoThang.Text = "Thống kê HĐB theo tháng";
            this.rdoThang.UseVisualStyleBackColor = true;
            this.rdoThang.CheckedChanged += new System.EventHandler(this.rdoThang_CheckedChanged);
            // 
            // rdoNgay
            // 
            this.rdoNgay.AutoSize = true;
            this.rdoNgay.Location = new System.Drawing.Point(20, 42);
            this.rdoNgay.Name = "rdoNgay";
            this.rdoNgay.Size = new System.Drawing.Size(213, 24);
            this.rdoNgay.TabIndex = 0;
            this.rdoNgay.TabStop = true;
            this.rdoNgay.Text = "Thống kê HĐB theo ngày";
            this.rdoNgay.UseVisualStyleBackColor = true;
            this.rdoNgay.CheckedChanged += new System.EventHandler(this.rdoNgay_CheckedChanged);
            // 
            // vbbThoat
            // 
            this.vbbThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbbThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbbThoat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbbThoat.BorderRadius = 20;
            this.vbbThoat.BorderSize = 0;
            this.vbbThoat.FlatAppearance.BorderSize = 0;
            this.vbbThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbbThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbbThoat.ForeColor = System.Drawing.Color.White;
            this.vbbThoat.Location = new System.Drawing.Point(1114, 272);
            this.vbbThoat.Name = "vbbThoat";
            this.vbbThoat.Size = new System.Drawing.Size(150, 40);
            this.vbbThoat.TabIndex = 8;
            this.vbbThoat.Text = "Thoát";
            this.vbbThoat.TextColor = System.Drawing.Color.White;
            this.vbbThoat.UseVisualStyleBackColor = false;
            this.vbbThoat.Click += new System.EventHandler(this.vbbThoat_Click);
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 20;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(1114, 192);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(150, 40);
            this.vbButton2.TabIndex = 7;
            this.vbButton2.Text = "In thống kê";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            this.vbButton2.Click += new System.EventHandler(this.vbButton2_Click);
            // 
            // vbbThongKe
            // 
            this.vbbThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbbThongKe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vbbThongKe.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbbThongKe.BorderRadius = 20;
            this.vbbThongKe.BorderSize = 0;
            this.vbbThongKe.FlatAppearance.BorderSize = 0;
            this.vbbThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbbThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbbThongKe.ForeColor = System.Drawing.Color.White;
            this.vbbThongKe.Location = new System.Drawing.Point(1114, 109);
            this.vbbThongKe.Name = "vbbThongKe";
            this.vbbThongKe.Size = new System.Drawing.Size(150, 40);
            this.vbbThongKe.TabIndex = 6;
            this.vbbThongKe.Text = "Thống kê";
            this.vbbThongKe.TextColor = System.Drawing.Color.White;
            this.vbbThongKe.UseVisualStyleBackColor = false;
            this.vbbThongKe.Click += new System.EventHandler(this.vbbThongKe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(33, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "Chức Năng";
            // 
            // GUI_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1304, 852);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vbbThoat);
            this.Controls.Add(this.vbButton2);
            this.Controls.Add(this.vbbThongKe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "GUI_ThongKe";
            this.Text = "GUI_ThongKe";
            this.Load += new System.EventHandler(this.GUI_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private VBButton vbbThongKe;
        private System.Windows.Forms.DateTimePicker dtpTimKiemKT;
        private VBButton vbButton2;
        private VBButton vbbThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTimKiemBD;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.RadioButton rdoNgay;
        private System.Windows.Forms.RadioButton rdoSPBC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoSPTK;
    }
}
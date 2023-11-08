using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;
namespace Đồ_Án_QLCH
{
    public partial class GUI_QL_KhoHang : Form
    {
        BUS_QL_KhoHang buskho = new BUS_QL_KhoHang();
        BUS_NhaCC busncc = new BUS_NhaCC();
        BUS_NhanVien busnv = new BUS_NhanVien();
        public GUI_QL_KhoHang()
        {
            InitializeComponent();
        }

        private void GUI_QL_KhoHang_Load(object sender, EventArgs e)
        {
            dgvDSK.DataSource = buskho.getKhoHang();
            dgvDSK.Columns[0].HeaderText = "Mã kho";
            dgvDSK.Columns[1].HeaderText = "Tên kho";
            dgvDSK.Columns[2].HeaderText = "Địa chỉ";
            dgvDSK.Columns[3].HeaderText = "Nhà cung cấp";
            dgvDSK.Columns[4].HeaderText = " Mã nhân viên";
            dgvDSK.Columns[5].HeaderText = "Trạng thái";
            //DataTable dataTableNCC = busncc.getNhaCC();
            //cboNhaCC.DataSource = dataTableNCC;
            //cboNhaCC.DisplayMember = "tenNCC";
            //cboNhaCC.ValueMember = "maNCC";
            DataTable dataTableNV = busnv.getNhanVien();
            cboNVQL.DataSource = dataTableNV;
            cboNVQL.DisplayMember = "hoTenNV";
            cboNVQL.ValueMember = "maNV";
            //Mới
            dgvDSK.DataSource= buskho.LayDSKhoHang();
            dgvDSK.Columns["hoTenNV"].DisplayIndex = dgvDSK.Columns["maNV"].DisplayIndex + 1;
            dgvDSK.Columns["hoTenNV"].HeaderText = "Họ tên nhân viên";
           ////
        }
        private void vbBtnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaKho.Text;
            string ten=txtTenKho.Text;
            string diachi = txtDiaChi.Text;
            string mancc=txtMaNCC.Text;
            string manv = cboNVQL.SelectedValue.ToString();
            string trangthai = txtTrangThai.Text;
            DTO_QL_KhoHang warehouse = new DTO_QL_KhoHang(ma, ten, diachi, mancc, manv, trangthai);
            if (buskho.kiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã kho đã tồn tại,vui lòng chọn mã khác !");
            }
            else
            {
                if (buskho.themKhoHang(warehouse) == true)
                {
                    MessageBox.Show("Thêm thông tin kho thành công.");
                    dgvDSK.DataSource = buskho.getKhoHang();
                }
            }
           GUI_Kho_Hang gUI_Kho_Hang = new GUI_Kho_Hang();
            gUI_Kho_Hang.ShowDialog();
            
        }
        private void vbBtnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaKho.Text;
            string ten = txtTenKho.Text;
            string diachi = txtDiaChi.Text;
            string mancc =txtMaNCC.Text;
            string manv = cboNVQL.SelectedValue.ToString();
            string trangthai = txtTrangThai.Text;
            DTO_QL_KhoHang warehouse = new DTO_QL_KhoHang(ma, ten, diachi, mancc,manv,trangthai);
            if (buskho.suaKhoHang(warehouse) == true)
            {
                MessageBox.Show("Sửa thông tin kho thành công.");
                dgvDSK.DataSource = buskho.getKhoHang();
            }
        }
        private void vbBtnXoa_Click(object sender, EventArgs e)
        {
            string ma =txtMaKho.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin của kho không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (buskho.xoaKhoHang(ma) == true)
                {
                    MessageBox.Show("Xóa thông tin kho thành công");
                    dgvDSK.DataSource = buskho.getKhoHang();
                }
                foreach (Control ctrl in grbTTKH.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        (ctrl as TextBox).Text = "";
                    }

                }
            }
        }
        private void vbBtnNhapMoi_Click(object sender, EventArgs e)
        {

            foreach (Control ctrl in grbTTKH.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }
                
            }
            foreach (Control ctrl in grbTKKho.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }
            }
        }
        private void vbBtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thoat == DialogResult.OK)
            {
                this.Hide();
                GUI_Main frm = new GUI_Main();
                frm.ShowDialog();
            }
        }
        private void vbBtnTK_Click(object sender, EventArgs e)
        {
            string ma = txtMaKhoTK.Text;
            string ten = txtTenKhoTK.Text;
            if (ma.Trim() == "" && ten.Trim() == "")
            {
                MessageBox.Show("Bạn cần nhập điều kiện tìm kiếm");
            }
            if (ten.Trim() == "")
            {
                MessageBox.Show("Tìm kiếm theo mã kho");
                dgvDSK.DataSource = buskho.timKiemKhoID(ma);
            }
            if (ma.Trim() == "")
            {
                MessageBox.Show("Tìm kiếm  theo tên kho");
                dgvDSK.DataSource = buskho.timKiemKhoName(ten);
            }
        }
        private void dgvDSK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            txtMaKho.Text = dgvDSK[0, HangChon].Value.ToString();
            txtTenKho.Text = dgvDSK[1, HangChon].Value.ToString();
            txtDiaChi.Text = dgvDSK[2, HangChon].Value.ToString();
            txtMaNCC.Text = dgvDSK[3, HangChon].Value.ToString();
            cboNVQL.Text = dgvDSK[4, HangChon].Value.ToString();
            txtTrangThai.Text = dgvDSK[5, HangChon].Value.ToString();
        }

        private void grbTKKho_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void grbTTKH_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string mancc = txtMaNCC.Text;
            txtTenNCC.Text=buskho.LayTTTenNCC(mancc);
        }

        private void vbBNhaCC_Click(object sender, EventArgs e)
        {
            GUI_NhaCC frm = new GUI_NhaCC();
            frm.ShowDialog();
        }

        private void dgvDSK_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GUI_Kho_Hang frm=new GUI_Kho_Hang();
            frm.ShowDialog();
        }
    }
}

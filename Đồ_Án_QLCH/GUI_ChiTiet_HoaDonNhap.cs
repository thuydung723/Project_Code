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
    public partial class GUI_ChiTiet_HoaDonNhap : Form
    {
        BUS_CTHDNhap buscthdn = new BUS_CTHDNhap();
        BUS_NhanVien busnv = new BUS_NhanVien();
        BUS_KhoHang buskho = new BUS_KhoHang();
        BUS_SanPham bussp = new BUS_SanPham();
        public GUI_ChiTiet_HoaDonNhap()
        {
            InitializeComponent();
        }

        private void GUI_HoaDonNhap_Load(object sender, EventArgs e)
        {
            //dgvDSHDNhap.DataSource = buscthdn.getHDNhap();
            //dgvDSHDNhap.Columns[0].HeaderText = "Mã hóa đơn nhập";
            //dgvDSHDNhap.Columns[1].HeaderText = "Ngày tạo";
            //dgvDSHDNhap.Columns[2].HeaderText = "Nhân viên";
            //dgvDSHDNhap.Columns[3].HeaderText = "Kho hàng";
            dgvDSCTHDNhap.DataSource = buscthdn.getCTHDNhap();
            dgvDSCTHDNhap.Columns[0].HeaderText = "Mã hóa đơn nhập";
            dgvDSCTHDNhap.Columns[1].HeaderText = "Sản phẩm";
            dgvDSCTHDNhap.Columns[2].HeaderText = "Số lượng";
            dgvDSCTHDNhap.Columns[3].HeaderText = "Đơn giá nhập";
            dgvDSCTHDNhap.Columns[4].HeaderText = "Thành tiền";
            DataTable dataTableSanPham = bussp.getSanPham();
            cboSanPham.DataSource = dataTableSanPham;
            cboSanPham.DisplayMember = "tenSP";
            cboSanPham.ValueMember = "maSP";

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void label9_Click(object sender, EventArgs e)
        {
        }
        private void vbBtnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaHD.Text;
            string masp = cboSanPham.SelectedValue.ToString();
            int sluong = int.Parse(txtSLuong.Text);
            int sl;
            sl = buscthdn.SoLuongSPKho(masp);
            string gianhap = txtGNhap.Text;
            DTO_CTHDNhap CTHDN = new DTO_CTHDNhap(ma, masp, sluong, gianhap);
            
            if (buscthdn.KiemTraSoLuongSP(masp, sluong) == false)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn sản phẩm" + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSLuong.Text = "";
                txtSLuong.Focus();
                return;
            }
            else if (buscthdn.kiemTraMaTrung(ma) == 1 && buscthdn.themCTHDNhap(CTHDN) == true && buscthdn.KiemTraSoLuongSP(masp, sluong) == true)
            {
                MessageBox.Show("Thêm thông tin chi tiết hóa đơn thành công");
                dgvDSCTHDNhap.DataSource = buscthdn.getCTHDNhap();
                buscthdn.CapNhapSoLuongSP(masp);
                buscthdn.CapNhatSoLuongSP1(masp);
            }
            else
            {
                MessageBox.Show("Mã hóa đơn chưa tồn tại,vui lòng kiểm tra lại thông tin.");
            }
        }

        private void vbBtnNhapMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grbTTHD.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }

                if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Text = "";
                }
            }
            foreach (Control ctrl in grbCTHD.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }
            }
            dgvDSCTHDNhap.Rows.Clear();
        }

        private void vbBtnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaHD.Text;
            string masp = cboSanPham.SelectedValue.ToString();
            // string sluong = txtSLuong.Text;
            int sluong = int.Parse(txtSLuong.Text);
            string gianhap = txtGNhap.Text;
            DTO_CTHDNhap CTHDNhap = new DTO_CTHDNhap(ma, masp, sluong, gianhap);
            if (buscthdn.suaCTHDNhap(CTHDNhap) == true)
            {
                MessageBox.Show("Sửa thông tin kho thành công.");
               // dgvDSHDNhap.DataSource = buscthdn.getHDNhap();
                dgvDSCTHDNhap.DataSource = buscthdn.getCTHDNhap();
            }
        }

        private void vbBtnXoa_Click(object sender, EventArgs e)
        {
            //string ma = txtMaHD.Text;
            //DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin của hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr == DialogResult.Yes)
            //{
            //    if (buscthdn.xoaDSHDNhap(ma) == true)
            //    {
            //        MessageBox.Show("Xóa thông tin hóa đơn thành công");
            //        dgvDSHDNhap.DataSource = buscthdn.getHDNhap();
            //        dgvDSCTHDNhap.DataSource = buscthdn.getCTHDNhap();
            //    }
            //}
        }

        private void vbBtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thoat == DialogResult.OK)
            {
                this.Hide();
                GUI_QuanLi_HDN gui_QuanLi_HDN = new GUI_QuanLi_HDN();
                gui_QuanLi_HDN.ShowDialog();
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            //txtTongTien.Text= (Convert.ToInt32(txtSLuong.Text) * Convert.ToInt32(txtDonGia.Text)).ToString();
        }

        private void dgvDSHDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int HangChon = e.RowIndex;
            //txtMaHD.Text = dgvDSHDNhap[0, HangChon].Value.ToString();
            //dtpNgayTao.Text = dgvDSHDNhap[1, HangChon].Value.ToString();
            //txtNhanVien.Text = dgvDSHDNhap[2, HangChon].Value.ToString();
            //txtKhoHang.Text = dgvDSHDNhap[3, HangChon].Value.ToString();
        }

        private void dgvDSCTHDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            cboSanPham.Text = dgvDSCTHDNhap[1, HangChon].Value.ToString();
            txtSLuong.Text = dgvDSCTHDNhap[2, HangChon].Value.ToString();
            txtGNhap.Text = dgvDSCTHDNhap[3, HangChon].Value.ToString();

        }

        private void vbBtnThanhToan_Click(object sender, EventArgs e)
        {
        }
        //Mới
        private void dgvDSHDNhap_SelectionChanged(object sender, EventArgs e)
        {
        }
        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSCTHDNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpNgayTao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            string mahdn = txtMaHD.Text;
            txtNhanVien.Text = buscthdn.LayTTHoaDonTenNV(mahdn);
            txtKhoHang.Text = buscthdn.LayTTHoaDonTenKho(mahdn);
        }
    }
}

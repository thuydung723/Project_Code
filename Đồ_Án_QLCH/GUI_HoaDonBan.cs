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
    public partial class GUI_HoaDonBan : Form
    {
        BUS_chiTietHDBan buscthdb=new BUS_chiTietHDBan();
        BUS_NhanVien busnv=new BUS_NhanVien();
        BUS_SanPham bussp=new BUS_SanPham();
        public GUI_HoaDonBan()
        {
            InitializeComponent();
        }
        private void GUI_HoaDonBan_Load(object sender, EventArgs e)
        {
           // dgvDSHDBan.DataSource = buscthdb.getHDBan();
            //dgvDSHDBan.Columns[0].HeaderText = "Mã hóa đơn bán";
            //dgvDSHDBan.Columns[1].HeaderText = "Mã nhân viên";
            //dgvDSHDBan.Columns[2].HeaderText = " Mã khách Hàng";
            //dgvDSHDBan.Columns[3].HeaderText = "Ngày bán";
            dgvchiTietHDB.DataSource = buscthdb.getChiTietHDBan();
            dgvchiTietHDB.Columns[0].HeaderText = "Mã hóa đơn bán";
            dgvchiTietHDB.Columns[1].HeaderText = "Sản phẩm";
            dgvchiTietHDB.Columns[2].HeaderText = "Số lượng";
            dgvchiTietHDB.Columns[3].HeaderText = "Đơn giá bán";
            dgvchiTietHDB.Columns[4].HeaderText = "Chiết khấu %";
            dgvchiTietHDB.Columns[5].HeaderText = "Thành tiền";
            DataTable dataTableSanPham = bussp.getSanPham();
            cboSanPham.DataSource = dataTableSanPham;
            cboSanPham.DisplayMember = "tenSP";
            cboSanPham.ValueMember = "maSP";
        }

        private void dgvDSHDBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int HangChon = e.RowIndex;
            //txtMaHD.Text = dgvDSHDBan[0, HangChon].Value.ToString();
            //txtNhanVien.Text = dgvDSHDBan[1, HangChon].Value.ToString();
            //txtKhachHang.Text = dgvDSHDBan[2, HangChon].Value.ToString();
           // dtpNgayTao.Text = dgvDSHDBan[3, HangChon].Value.ToString();
            //mskSDT.Text = dgvDSHDBan[6, HangChon].Value.ToString();
        }

        private void dgvchiTietHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon=e.RowIndex;
            cboSanPham.Text=dgvchiTietHDB[1, HangChon].Value.ToString();
            txtSL.Text=dgvchiTietHDB[2, HangChon].Value.ToString();
            txtChietKhau.Text = dgvchiTietHDB[4, HangChon].ToString();
        }

        private void vbBtnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaHD.Text;
            string masp = cboSanPham.SelectedValue.ToString();
             int sl=int.Parse(txtSL.Text);
            int ck = int.Parse(txtChietKhau.Text);
            DTO_chiTietHDBan CTHDB = new DTO_chiTietHDBan(ma, masp, sl,ck);
            if (buscthdb.KiemTraSoLuongSP(masp, sl) == false)
            {
                MessageBox.Show("Sản phẩm hết hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (buscthdb.kiemTraMaTrung(ma) == 1 && buscthdb.themCTHDBan(CTHDB) == true && buscthdb.KiemTraSoLuongSP(masp, sl) == true)
            {
                MessageBox.Show("Thêm thông tin chi tiết hóa đơn thành công");
                dgvchiTietHDB.DataSource = buscthdb.getChiTietHDBan();
                buscthdb.CapNhapSoLuongSP(masp);
            }
            else
            {
                MessageBox.Show("Mã hóa đơn chưa tồn tại,vui lòng kiểm tra lại thông tin.");
            }
        }

        private void vbBtnXoa_Click(object sender, EventArgs e)
        {
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
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thoat == DialogResult.OK)
            {
                this.Hide();
                GUI_QuanLy_HoaDonBan gui_QuanLi_HDBan = new GUI_QuanLy_HoaDonBan();
                gui_QuanLi_HDBan.ShowDialog();
            }
        }
        private void dgvDSHDBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvchiTietHDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void txtSL_TextChanged(object sender, EventArgs e)
        {
        }
        private void grbTTHD_Enter(object sender, EventArgs e)
        {

        }
        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            string mahdb = txtMaHD.Text;
            txtNhanVien.Text = buscthdb.LayTTHoaDonTen(mahdb);
            txtKhachHang.Text = buscthdb.LayTTHoaDonTenKH(mahdb);
            mskSDT.Text = buscthdb.LayTTSDTKH(mahdb);
        }
    }
}

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
    public partial class GUI_Kho_Hang : Form
    {
        BUS_KhoHang buskho=new BUS_KhoHang();
        BUS_SanPham bussp = new BUS_SanPham();
        public GUI_Kho_Hang()
        {
            InitializeComponent();
        }
        private void Kho_Hang_Load(object sender, EventArgs e)
        {
            //dgvDSK.DataSource = buskho.getKhoHang();
            //dgvDSK.Columns[0].HeaderText = "Mã kho";
            //dgvDSK.Columns[1].HeaderText = "Tên kho";
            //dgvDSK.Columns[2].HeaderText = "Địa chỉ";
            //dgvDSK.Columns[3].HeaderText = "Nhà cung cấp";
            //dgvDSK.Columns[4].HeaderText = "Nhân viên";
            //dgvDSK.Columns[5].HeaderText = "Trạng thái";
            DataTable dataTableSP = bussp.getSanPham();
            cboSanPham.DataSource = dataTableSP;
            cboSanPham.DisplayMember = "tenSP";
            cboSanPham.ValueMember = "maSP";
            dgvDSCTK.DataSource = buskho.getCTKhoHang();
            dgvDSCTK.Columns[0].HeaderText = "Mã kho";
            dgvDSCTK.Columns[1].HeaderText = "Sản phẩm";
            dgvDSCTK.Columns[2].HeaderText = "Số lượng";
            dgvDSCTK.Columns[3].HeaderText = "Ghi chú";
        }
        private void vbBtnThem_Click(object sender, EventArgs e)
        {
            string ma=txtMaKho.Text;
            string masp = cboSanPham.SelectedValue.ToString();
            string sLuong = txtSoLuong.Text;
            string ghichu = txtGhiChu.Text;
            DTO_KhoHang DSK = new DTO_KhoHang(ma, masp, sLuong, ghichu);
            if(buskho.kiemTraMaTrung(ma)==1 && buskho.themCTKhoHang(DSK)==true)
            {
                MessageBox.Show("Thêm thông tin chi tiết kho thành công");
                dgvDSCTK.DataSource = buskho.getCTKhoHang();
            }
            else
            {
                MessageBox.Show("Mã kho không tồn tại,vui lòng kiểm tra lại thông tin!");
            }
        }
        private void vbBtnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaKho.Text;
            string masp = cboSanPham.SelectedValue.ToString();
            string sLuong = txtSoLuong.Text;
            string ghichu = txtGhiChu.Text;
            DTO_KhoHang DSK = new DTO_KhoHang(ma, masp, sLuong, ghichu);
            if (buskho.suaCTKhoHang(DSK) == true)
            {
                MessageBox.Show("Sửa thông tin kho thành công.");
                dgvDSCTK.DataSource = buskho.getCTKhoHang();
            }

        }
        private void vbBtnXoa_Click(object sender, EventArgs e)
        {
            //Xóa bên QL_Kho_Hàng thì tự động chi tiết kho hàng cũng bị xóa theo
            //string ma = txtMaKho.Text;
            //DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin của kho không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr == DialogResult.Yes)
            //{
            //    if (buskho.xoaKhoHang(ma) == true)
            //    {
            //        MessageBox.Show("Xóa thông tin kho thành công");
            //       // dgvDSK.DataSource = buskho.getKhoHang();
            //        dgvDSCTK.DataSource = buskho.getCTKhoHang();
            //    }
            //}
        }
        private void vbBtnNhapMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grbCTKH.Controls)
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
                GUI_QL_KhoHang gUI_QL_KhoHang = new GUI_QL_KhoHang();
                gUI_QL_KhoHang.ShowDialog();
            }
            
        }
        private void dgvDSK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int HangChon = e.RowIndex;
            //txtMaKho.Text = dgvDSK[0, HangChon].Value.ToString();
            //txtTenKho.Text = dgvDSK[1, HangChon].Value.ToString();
            //txtDiaChi.Text = dgvDSK[2, HangChon].Value.ToString();
            //txtNhaCC.Text = dgvDSK[3, HangChon].Value.ToString();
            //txtNVQL.Text = dgvDSK[4, HangChon].Value.ToString();
            //txtTrangThai.Text = dgvDSK[5, HangChon].Value.ToString();
        }
        private void dgvDSCTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            cboSanPham.Text=dgvDSCTK[1, HangChon].Value.ToString();
            txtSoLuong.Text=dgvDSCTK[2, HangChon].Value.ToString();
            txtGhiChu.Text = dgvDSCTK[3, HangChon].Value.ToString();
        }

        private void grbTTKH_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaKho_TextChanged(object sender, EventArgs e)
        {
            string makho = txtMaKho.Text;
            txtTenKho.Text = buskho.LayTTTenKHo(makho);
            txtNhaCC.Text = buskho.LayTTNCC(makho);
            txtNVQL.Text = buskho.LayTTNV(makho);
        }
    }
}

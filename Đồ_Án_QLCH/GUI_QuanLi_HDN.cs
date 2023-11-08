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
    public partial class GUI_QuanLi_HDN : Form
    {
        BUS_QuanLy_HDN bushdn=new BUS_QuanLy_HDN();
        
        BUS_NhanVien busnv=new BUS_NhanVien();
        BUS_KhoHang buskho=new BUS_KhoHang();
       
        public GUI_QuanLi_HDN()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void GUI_QuanLi_HDN_Load(object sender, EventArgs e)
        {
            // dgvDSHDNhap.DataSource = bushdn.getHDNhap();
            dgvDSHDNhap.DataSource = bushdn.LayDSHDN();
            dgvDSHDNhap.Columns[0].HeaderText = "Mã hóa đơn nhập";
            dgvDSHDNhap.Columns[1].HeaderText = "Ngày tạo";
            dgvDSHDNhap.Columns[2].HeaderText = " Mã nhân viên";
            dgvDSHDNhap.Columns[3].HeaderText = "Mã kho hàng";
          //  dgvDSHDNhap.Columns[4].HeaderText = "Tổng tiền hóa đơn";
            DataTable dataTableNV = busnv.getNhanVien();
            cboNhanVien.DataSource = dataTableNV;
            cboNhanVien.DisplayMember = "hoTenNV";
            cboNhanVien.ValueMember = "maNV";
            DataTable dataTableKho = buskho.getKhoHang();
            cboKhoHang.DataSource = dataTableKho;
            cboKhoHang.DisplayMember = "tenKho";
            cboKhoHang.ValueMember = "maKHO";
            dgvDSHDNhap.DataSource = bushdn.LayDSHDN();
            dgvDSHDNhap.Columns["hoTenNV"].DisplayIndex = dgvDSHDNhap.Columns["maNV"].DisplayIndex + 1;
            dgvDSHDNhap.Columns["hoTenNV"].HeaderText = "Họ tên nhân viên";
            dgvDSHDNhap.Columns["tenKho"].DisplayIndex = dgvDSHDNhap.Columns["maKHO"].DisplayIndex + 1;
            dgvDSHDNhap.Columns["tenKho"].HeaderText = "Tên kho";
        }
        private void vbBtnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaHD.Text;
            DateTime ngayt = DateTime.Parse(dtpNgayTao.Value.ToString());
            string manv = cboNhanVien.SelectedValue.ToString();
            string makho = cboKhoHang.SelectedValue.ToString();
            DTO_QuanLy_HDN Bill = new DTO_QuanLy_HDN(ma, ngayt, manv, makho);
            if (bushdn.kiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại,vui lòng chọn mã khác !");
            }
            else
            {
                if (bushdn.themHDNhap(Bill) == true)
                {
                    MessageBox.Show("Nhập thông tin chi tiết cho hóa đơn của bạn.");
                    dgvDSHDNhap.DataSource = bushdn.getHDNhap();
                }
                GUI_ChiTiet_HoaDonNhap gUI_ChiTiet_HoaDonNhap = new GUI_ChiTiet_HoaDonNhap();
                gUI_ChiTiet_HoaDonNhap.ShowDialog();
            }
        }
        private void vbBtnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaHD.Text;
            DateTime ngayt=DateTime.Parse(dtpNgayTao.Value.ToString());
            string manv = cboNhanVien.SelectedValue.ToString();
            string makho = cboKhoHang.SelectedValue.ToString();
            DTO_QuanLy_HDN Bill = new DTO_QuanLy_HDN(ma, ngayt, manv, makho);
            if (bushdn.suaHDNhap(Bill) == true)
            {
                MessageBox.Show("Sửa thông tin  hóa đơn nhập thành công.");
                dgvDSHDNhap.DataSource = bushdn.getHDNhap();
            }
        }
        private void vbBtnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaHD.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin của hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bushdn.CapNhapSoLuongSP(ma);
                if (bushdn.xoaHDNhap(ma) == true)
                {
                    MessageBox.Show("Xóa thông tin hóa đơn thành công");
                   dgvDSHDNhap.DataSource = bushdn.LayDSHDN();
                }
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
            foreach (Control ctrl in grbTKHD.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }
            }
        }
        private void GUI_QuanLi_HDN_Click(object sender, EventArgs e)
        {
        }
        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            txtMaHD.Text = dgvDSHDNhap[0, HangChon].Value.ToString();
           dtpNgayTao.Text = dgvDSHDNhap[1, HangChon].Value.ToString();
            //cboNhanVien.Text=dgvDSHDNhap[2, HangChon].Value.ToString();
            txtTenNV.Text=dgvDSHDNhap[2+1,HangChon].Value.ToString();
           // cboKhoHang.Text = dgvDSHDNhap[3, HangChon].Value.ToString();
            txtTongTien.Text=dgvDSHDNhap[4,HangChon].Value.ToString();  
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
            string ma = txtMaHDTK.Text;
            string makho = txtMaKhoTK.Text;
            DateTime startDate = dtpTimKiemBD.Value.Date;
            DateTime endDate = dtpTimKiemKT.Value.Date;
            if (makho.Trim() == "" )
            {
                DataTable dataTable = bushdn.timKiemHDID(ma);
                dgvDSHDNhap.DataSource = dataTable;
            }
            if (ma.Trim() == "")
            {
                DataTable dataTable = bushdn.timKiemHDIDKho(makho);
                dgvDSHDNhap.DataSource = dataTable;
            }
            if(ma.Trim() =="" && makho.Trim()=="")
            {
                DataTable dataTable = bushdn.timKiemHDTG(startDate, endDate);
                dgvDSHDNhap.DataSource = dataTable;
            }
            //Mới
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
        }
        private void dtpTimKiemBD_ValueChanged(object sender, EventArgs e)
        {
        }
        private void vbBInHoaDon_Click(object sender, EventArgs e)
        {
            string mahdn = txtMaHD.Text;
            DataTable dataTable = bushdn.InTTHDN(mahdn);
           // string fileName = string.Format("{0}_{1}.xlsx", mahdn, DateTime.Now.ToString("yyyyMMddHHmmss"));
            string duongdan = @"C:\Users\Nguyen Thuy Dung\source\repos\HoaDonNhapA.xlsx";
            //txtMaHD.Text = Guid.NewGuid().ToString();
            string printime = DateTime.Now.ToString();
            bushdn.ExportToExcel(dataTable,duongdan,txtMaHD.Text,txtTenNV.Text,txtTongTien.Text, printime);
            MessageBox.Show("Exported to Excel successfully!");
        }

        private void cboNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            string manv = cboNhanVien.SelectedValue.ToString();
            txtTenNV.Text=bushdn.GetTenNhanVienByMa(manv);
        }

        private void dgvDSHDNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GUI_ChiTiet_HoaDonNhap frm = new GUI_ChiTiet_HoaDonNhap();
            frm.ShowDialog();
        }
    }
}

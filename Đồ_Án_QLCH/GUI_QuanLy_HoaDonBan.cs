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
    public partial class GUI_QuanLy_HoaDonBan : Form
    {
        BUS_QuanLi_HDBan bushdb = new BUS_QuanLi_HDBan();
        BUS_NhanVien busnv = new BUS_NhanVien();
        BUS_KhachHang buskh=new BUS_KhachHang();
        public GUI_QuanLy_HoaDonBan()
        {
            InitializeComponent();
        }

        private void vbBtnTK_Click(object sender, EventArgs e)
        {
            string ma = txtMaHDTK.Text;
            string makh = txtMaKHTK.Text;
            DateTime startDate = dtpTimKiemBD.Value.Date;
            DateTime endDate = dtpTimKiemKT.Value.Date;
            if (ma.Trim() == "")
            {
                DataTable dataTable = bushdb.timKiemHDIDKH(makh);
                dgvDSHDBan.DataSource = dataTable;
            }
            if (makh.Trim() == "")
            {
                DataTable dataTable = bushdb.timKiemHDID(ma);
                dgvDSHDBan.DataSource = dataTable;
            }
            if (ma.Trim() == "" && makh.Trim() == "")
            {
                DataTable dataTable = bushdb.timKiemHDTG(startDate, endDate);
                dgvDSHDBan.DataSource = dataTable;
            }
        }

        private void dgvDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GUI_QuanLy_HoaDonBan_Load(object sender, EventArgs e)
        {
            dgvDSHDBan.DataSource = bushdb.getHDBan();
            dgvDSHDBan.Columns[0].HeaderText = "Mã hóa đơn bán";
            dgvDSHDBan.Columns[1].HeaderText = "Mã nhân viên";
            dgvDSHDBan.Columns[2].HeaderText = " Mã khách Hàng";
            dgvDSHDBan.Columns[3].HeaderText = "Ngày bán";
           // dgvDSHDBan.Columns[4].HeaderText = "Số điện thoại khách hàng";
            DataTable dataTableNV = busnv.getNhanVien();
            cboNhanVien.DataSource = dataTableNV;
            cboNhanVien.DisplayMember = "hoTenNV";
            cboNhanVien.ValueMember = "maNV";
            dgvDSHDBan.DataSource=bushdb.LayDSHDBan();
            dgvDSHDBan.Columns["hoTenNV"].DisplayIndex = dgvDSHDBan.Columns["maNV"].DisplayIndex + 1;
            dgvDSHDBan.Columns["hoTenNV"].HeaderText = "Họ tên nhân viên";
            dgvDSHDBan.Columns["hoTenKH"].DisplayIndex = dgvDSHDBan.Columns["maKH"].DisplayIndex + 1;
            dgvDSHDBan.Columns["hoTenKH"].HeaderText = "Họ tên khách hàng";
        }

        private void dgvDSHDBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            txtMaHD.Text=dgvDSHDBan[0,HangChon].Value.ToString();
            cboNhanVien.Text = dgvDSHDBan[1, HangChon].Value.ToString();
            txtTenNV.Text= dgvDSHDBan[2, HangChon].Value.ToString();
            txtKhachHang.Text = dgvDSHDBan[3, HangChon].Value.ToString();
          //  dtpNgayTao.Text=dgvDSHDBan[5,HangChon].Value.ToString();
            mskSDT.Text=dgvDSHDBan[6,HangChon].Value.ToString();
            txtTongTienHD.Text = dgvDSHDBan[7, HangChon].Value.ToString();
        }

        private void vbBtnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaHD.Text;
            string manv = cboNhanVien.SelectedValue.ToString();
            string makh = txtKhachHang.Text;
            DateTime ngayt = DateTime.Parse(dtpNgayTao.Value.ToString());
            DTO_QuanLi_HDBan Bill = new DTO_QuanLi_HDBan(ma, manv, makh, ngayt);
            if (bushdb.kiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại,vui lòng chọn mã khác !");
            }
            else
            {
                if(bushdb.themHDBanMoi(Bill) == true)
                {
                    MessageBox.Show("Nhập thông tin chi tiết cho hóa đơn của bạn.");
                    dgvDSHDBan.DataSource = bushdb.getHDBan();
                }
                GUI_HoaDonBan gUI_HoaDonBan = new GUI_HoaDonBan();
                gUI_HoaDonBan.ShowDialog();
            }
        }

        private void vbBtnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaHD.Text;
            string manv = cboNhanVien.SelectedValue.ToString();
            string makh = txtKhachHang.Text;
            DateTime ngayt = DateTime.Parse(dtpNgayTao.Value.ToString());
            DTO_QuanLi_HDBan Bill = new DTO_QuanLi_HDBan(ma, manv, makh, ngayt);
            if(bushdb.suaHDBan(Bill)==true)
            {
                MessageBox.Show("Sửa thông tin hóa đơn bán thành công");
                dgvDSHDBan.DataSource= bushdb.LayDSHDBan();
            }    
        }

        private void vbBtnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaHD.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin của hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bushdb.CapNhapSoLuongSP(ma);
                if (bushdb.xoaHDBan(ma) == true)
                {
                    MessageBox.Show("Xóa thông tin hóa đơn thành công");
                    dgvDSHDBan.DataSource = bushdb.LayDSHDBan();

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTongTienHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            string mahdb=txtMaHD.Text;
            DataTable dataTable = bushdb.InTTHDBan(mahdb);
            string duongdan = @"C:\Users\Nguyen Thuy Dung\source\repos\HoaDonNhapA.xlsx";
            string printime = DateTime.Now.ToString();
            bushdb.ExportToExcel(dataTable, duongdan, txtMaHD.Text,txtTenNV.Text,txtTenKH.Text,txtTongTienHD.Text, printime);
            MessageBox.Show("Exported to Excel successfully!");
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {

            string makh = txtKhachHang.Text;
            txtTenKH.Text = bushdb.LayTTTenKH(makh);
            mskSDT.Text = bushdb.LayTTSDTKH(makh);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void grbTTHD_Enter(object sender, EventArgs e)
        {

        }

        //private void vbBQLKH_Click(object sender, EventArgs e)
        //{
        //    GUI_QLKH frm = new GUI_QLKH();
        //    frm.ShowDialog();
        //}

        private void vbBQLKH_Click_1(object sender, EventArgs e)
        {

            GUI_QLKH frm = new GUI_QLKH();
            frm.ShowDialog();
        }

        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string manv = cboNhanVien.SelectedValue.ToString();
            //txtTenNV.Text = bushdb.GetTenNhanVienByMa(manv);
        }

        private void cboNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            string manv = cboNhanVien.SelectedValue.ToString();
            txtTenNV.Text = bushdb.GetTenNhanVienByMa(manv);
        }

        private void dgvDSHDBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GUI_HoaDonBan frm=new GUI_HoaDonBan();
            frm.ShowDialog();
        }
    }
}

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
    public partial class GUI_NhanVien : Form
    {
        BUS_NhanVien busnv = new BUS_NhanVien();
        public GUI_NhanVien()
        {
            InitializeComponent();
        }

        public void GUI_QLNV_Load(object sender, EventArgs e)
        {
            dgvDSNV.DataSource = busnv.getNhanVien();
            dgvDSNV.Columns[0].HeaderText = "Mã nhân viên";
            dgvDSNV.Columns[1].HeaderText = "Tên nhân viên";
            dgvDSNV.Columns[2].HeaderText = "Giới tính";
            dgvDSNV.Columns[3].HeaderText = "Ngày sinh";
            dgvDSNV.Columns[4].HeaderText = "Quê quán";
            dgvDSNV.Columns[5].HeaderText = "Số điện thoại";
            dgvDSNV.Columns[6].HeaderText = "Email";

        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            txtMaNV.Text = dgvDSNV[0, HangChon].Value.ToString();
            txtHoTenNV.Text = dgvDSNV[1, HangChon].Value.ToString();
            string gt = dgvDSNV[2, HangChon].Value.ToString();
            if (gt == "Nam")
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
            dtpNgayS.Text = dgvDSNV[3, HangChon].Value.ToString();
            txtQuequan.Text = dgvDSNV[4, HangChon].Value.ToString();
            mskSDT.Text = dgvDSNV[5, HangChon].Value.ToString();
            txtEmail.Text = dgvDSNV[6, HangChon].Value.ToString();
        }

        private void vbBtnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtHoTenNV.Text;
            string gt;
            if (rdoNam.Checked == true)
            {
                gt = rdoNam.Text;
            }
            else
            {
                gt = rdoNu.Text;
            }
            DateTime ngayS = DateTime.Parse(dtpNgayS.Value.ToShortDateString());
            string  quequan = txtQuequan.Text;
            string sdt = mskSDT.Text;
            string email = txtEmail.Text;
            DTO_NhanVien employee = new DTO_NhanVien(ma, ten, gt, ngayS, quequan, sdt, email);
            if (busnv.kiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại,vui lòng chọn mã khác !");
            }
            else
            {
                if (busnv.themNhanVien(employee) == true)
                {
                    MessageBox.Show("Thêm thông tin nhân viên thành công.");
                    dgvDSNV.DataSource = busnv.getNhanVien();
                }
            }
        }

        private void vbBtnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtHoTenNV.Text;
            string gt;
            if (rdoNam.Checked == true)
            {
                gt = rdoNam.Text;
            }
            else
            {
                gt = rdoNu.Text;
            }
            DateTime ngayS = DateTime.Parse(dtpNgayS.Value.ToShortDateString());
            string quequan = txtQuequan.Text;
            string sdt = mskSDT.Text;
            string email = txtEmail.Text;
            DTO_NhanVien employee = new DTO_NhanVien(ma, ten, gt, ngayS, quequan, sdt, email);
            if (busnv.suaNhanVien(employee) == true)
            {
                MessageBox.Show("Sửa thông tin  nhân viên thành công.");
                dgvDSNV.DataSource = busnv.getNhanVien();
            }
        }

        private void vbBtnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin của nhân viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busnv.xoaNhanVien(ma) == true)
                {
                    MessageBox.Show("Xóa thông tin nhân viên thành công");
                    dgvDSNV.DataSource = busnv.getNhanVien();
                }
                foreach (Control ctrl in grbTTNV.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        (ctrl as TextBox).Text = "";
                    }
                    if (ctrl is RadioButton)
                    {
                        (ctrl as RadioButton).Checked = false;
                    }
                    if (ctrl is ComboBox)
                    {
                        (ctrl as ComboBox).Text = "";
                    }
                    if (ctrl is MaskedTextBox)
                    {
                        (ctrl as MaskedTextBox).Text = "";
                    }
                }
            }
        }

        private void vbBtnNhapMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grbTTNV.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }
                if (ctrl is RadioButton)
                {
                    (ctrl as RadioButton).Checked = false;
                }
                if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Text = "";
                }
                if (ctrl is MaskedTextBox)
                {
                    (ctrl as MaskedTextBox).Text = "";
                }
            }
            foreach (Control ctrl in grbTKNV.Controls)
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
            string ma = txtMaNVTK.Text;
            string ten = txtTenNVTK.Text;
            if(ma.Trim()=="" && ten.Trim()=="")
            {
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm");
            }    
            if ( ten.Trim() == "")
            {
                MessageBox.Show("Tìm kiếm  theo mã nhân viên");
                dgvDSNV.DataSource = busnv.timKiemNhanVienID(ma);
            }
           if(ma.Trim() =="")
            {
                MessageBox.Show("Tìm kiếm  theo tên nhân viên");
                dgvDSNV.DataSource=busnv.timKiemNhanVienName(ten);
            }    
           if(ma.Trim() != "" && ten.Trim() !="" )
            {
                MessageBox.Show("Thông tin nhân viên");
                dgvDSNV.DataSource = busnv.timKiemNhanVienID(ma);
            }    
        }

        private void grbTKNV_Enter(object sender, EventArgs e)
        {

        }
    }
}

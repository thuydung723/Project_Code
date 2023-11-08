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
    public partial class GUI_QLKH : Form
    {
        BUS_KhachHang buskh = new BUS_KhachHang();
        public GUI_QLKH()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GUI_QLKH_Load(object sender, EventArgs e)
        {
            dgvDSKH.DataSource = buskh.getKhachHang();
            dgvDSKH.Columns[0].HeaderText = "Mã khách hàng";
            dgvDSKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvDSKH.Columns[2].HeaderText = "Số điện thoại";
            dgvDSKH.Columns[3].HeaderText = "Email";
        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            txtMaKH.Text = dgvDSKH[0, HangChon].Value.ToString();
            txtTenKH.Text = dgvDSKH[1, HangChon].Value.ToString();
            mskSoDT.Text = dgvDSKH[2, HangChon].Value.ToString();
            txtEmail.Text = dgvDSKH[3, HangChon].Value.ToString();
        }

        private void vbBtnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaKH.Text;
            string ten = txtTenKH.Text;
            string sdt = mskSoDT.Text;
            string email = txtEmail.Text;
            DTO_KhachHang client = new DTO_KhachHang(ma, ten, sdt, email);
            if (buskh.kiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại,vui lòng chọn mã khác !");
            }
            else
            {
                if (buskh.themKhachHang(client) == true)
                {
                    MessageBox.Show("Thêm thông tin khách hàng thành công.");
                    dgvDSKH.DataSource = buskh.getKhachHang();
                }
            }
        }

        private void vbBtnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaKH.Text;
            string ten = txtTenKH.Text;
            string sdt = mskSoDT.Text;
            string email = txtEmail.Text;
            DTO_KhachHang client = new DTO_KhachHang(ma, ten, sdt, email);
            if (buskh.suaKhachHang(client) == true)
            {
                MessageBox.Show("Sửa thông tin  khách hàng thành công.");
                dgvDSKH.DataSource = buskh.getKhachHang();
            }
        }

        private void vbBtnXoa_Click(object sender, EventArgs e)
        {

            string ma = txtMaKH.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin của khách hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (buskh.xoaKhachHang(ma) == true)
                {
                    MessageBox.Show("Xóa thông tin khách hàng thành công");
                    dgvDSKH.DataSource = buskh.getKhachHang();
                    foreach (Control ctrl in grbTTKH.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            (ctrl as TextBox).Text = "";
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
        }

        private void vbBtnNhapMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grbTTKH.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
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
            foreach (Control ctrl in grbTKKH.Controls)
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
            string ma = txtMaKHTK.Text;
            string ten = txtTenKHTK.Text;
            if (ma.Trim() == "" && ten.Trim() == "")
            {
                MessageBox.Show("Bạn cần nhập điều kiện tìm kiếm");
            }
            if (ten.Trim() == "")
            {
                MessageBox.Show("Tìm kiếm theo mã khách hàng");
                dgvDSKH.DataSource = buskh.timKiemKhachHangID(ma);
            }
            if (ma.Trim() == "")
            {
                MessageBox.Show("Tìm kiếm  theo tên khách hàng");
                dgvDSKH.DataSource = buskh.timKiemKhachHangName(ten);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

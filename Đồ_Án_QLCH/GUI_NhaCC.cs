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
    public partial class GUI_NhaCC : Form
    {
        BUS_NhaCC busncc=new BUS_NhaCC();
        public GUI_NhaCC()
        {
            InitializeComponent();
        }

        private void GUI_NhaCC_Load(object sender, EventArgs e)
        {
            dgvDSNCC.DataSource = busncc.getNhaCC();
            dgvDSNCC.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvDSNCC.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvDSNCC.Columns[2].HeaderText = "Địa chỉ";
            dgvDSNCC.Columns[3].HeaderText = "Số điện thoại";
        }

        private void dgvDSNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Hangchon = e.RowIndex;
            txtMaNCC.Text=dgvDSNCC[0,Hangchon].Value.ToString();
            txtTenNCC.Text = dgvDSNCC[1, Hangchon].Value.ToString();
            mskSDT.Text = dgvDSNCC[3, Hangchon].Value.ToString();
            txtDiaChi.Text = dgvDSNCC[2, Hangchon].Value.ToString();
        }

        private void vbBtnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text;
            string ten=txtTenNCC.Text;
            string sdt = mskSDT.Text;
            string diachi = txtDiaChi.Text;
            DTO_NhaCC provider = new DTO_NhaCC(ma, ten, diachi,sdt);
            if (busncc.kiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại,vui lòng chọn mã khác !");
            }
            else
            {
                if (busncc.themNhaCC(provider) == true)
                {
                    MessageBox.Show("Thêm thông tin nhà cung cấp thành công.");
                    dgvDSNCC.DataSource = busncc.getNhaCC();
                }
            }
        }

        private void vbBtnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text;
            string ten = txtTenNCC.Text;
            string sdt = mskSDT.Text;
            string diachi = txtDiaChi.Text;
            DTO_NhaCC provider = new DTO_NhaCC(ma, ten,  diachi,sdt);
            if (busncc.suaNhaCC(provider) == true)
            {
                MessageBox.Show("Sửa thông tin  nhà cung cấp thành công.");
                dgvDSNCC.DataSource = busncc.getNhaCC();
            }
        }

        private void vbBtnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin của nhà cung cấp không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busncc.xoaNhaCC(ma) == true)
                {
                    MessageBox.Show("Xóa thông tin khách hàng thành công");
                    dgvDSNCC.DataSource = busncc.getNhaCC();
                }
                foreach (Control ctrl in grbTTNCC.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        (ctrl as TextBox).Text = "";
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

            foreach (Control ctrl in grbTTNCC.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }
                if (ctrl is MaskedTextBox)
                {
                    (ctrl as MaskedTextBox).Text = "";
                }
            }
            foreach (Control ctrl in grbTKNCC.Controls)
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
            string ma = txtMaNCCTK.Text;
            string ten = txtTenNCCTK.Text;
            if (ma.Trim() == "" && ten.Trim() == "")
            {
                MessageBox.Show("Bạn cần nhập điều kiện tìm kiếm");
            }
            if (ten.Trim() == "")
            {
                MessageBox.Show("Tìm kiếm  theo mã nhà cung cấp");
               dgvDSNCC.DataSource = busncc.timKiemNhaCCID(ma);
            }
            if (ma.Trim() == "")
            {
                MessageBox.Show("Tìm kiếm  theo tên nhà cung cấp");
                dgvDSNCC.DataSource = busncc.timkiemNhaCCName(ten);
            }
        }

        private void grbTKNCC_Enter(object sender, EventArgs e)
        {

        }
    }
}

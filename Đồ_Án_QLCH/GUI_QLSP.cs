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
    public partial class GUI_QLSP : Form
    {
        BUS_SanPham bussp=new BUS_SanPham();
        public GUI_QLSP()
        {
            InitializeComponent();
        }

        private void GUI_QLSP_Load(object sender, EventArgs e)
        {
            dgvDSSP.DataSource = bussp.getSanPham();
            dgvDSSP.Columns[0].HeaderText = "Mã sản phẩm";
            dgvDSSP.Columns[1].HeaderText = "Tên sản phẩm";
            dgvDSSP.Columns[2].HeaderText = "Loại sản phẩm";
            dgvDSSP.Columns[3].HeaderText = "Số lượng";
            dgvDSSP.Columns[4].HeaderText = "Đơn giá bán";
            dgvDSSP.Columns[5].HeaderText = "Mô tả";
            DataTable dataTable = bussp.getLoaiSanPham();
            cboLoaiSP.DataSource = dataTable;
            cboLoaiSP.DisplayMember = "tenLoaiSP";
            cboLoaiSP.ValueMember = "maLoaiSP";
        }

        private void dgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            txtMaSP.Text = dgvDSSP[0, HangChon].Value.ToString();
            txtTenSP.Text = dgvDSSP[1, HangChon].Value.ToString();
            cboLoaiSP.Text = dgvDSSP[2, HangChon].Value.ToString();
            txtSL.Text=dgvDSSP[3,HangChon].Value.ToString();
            txtDgBan.Text = dgvDSSP[4, HangChon].Value.ToString();
            txtMota.Text=dgvDSSP[5,HangChon].Value.ToString();
        }

        private void vbBtnThem_Click(object sender, EventArgs e)
        {
            string ma =txtMaSP.Text;
            string ten = txtTenSP.Text;
            string loaiSP = cboLoaiSP.SelectedValue.ToString();
            string sluong=txtSL.Text;
            string giaB=txtDgBan.Text;
            string mt=txtMota.Text;
            DTO_SanPham product=new DTO_SanPham(ma,ten,loaiSP,sluong,giaB,mt);
            if (bussp.kiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại,vui lòng chọn mã khác !");
            }
            else
            {
                if (bussp.themSanPham(product) == true)
                {
                    MessageBox.Show("Thêm thông tin sản phẩm thành công.");
                    dgvDSSP.DataSource = bussp.getSanPham();
                }
            }
        }

        private void vbBtnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaSP.Text;
            string ten = txtTenSP.Text;
            string loaiSP = cboLoaiSP.SelectedValue.ToString();
            string sluong = txtSL.Text;
            string giaB = txtDgBan.Text;
            string mt = txtMota.Text;
            DTO_SanPham product = new DTO_SanPham(ma, ten,loaiSP, sluong, giaB, mt);
            if (bussp.suaSanPham(product) == true)
            {
                MessageBox.Show("Sửa thông tin  sản phẩm thành công.");
                dgvDSSP.DataSource = bussp.getSanPham();
            }
        }

        private void vbBtnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaSP.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin của sản phẩm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (bussp.xoaSanPham(ma) == true)
                {
                    MessageBox.Show("Xóa thông tin sản phẩm thành công");
                    dgvDSSP.DataSource = bussp.getSanPham();
                }
                foreach (Control ctrl in grbTTSP.Controls)
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
            foreach (Control ctrl in grbTTSP.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }
            }
            foreach (Control ctrl in grbTKSP.Controls)
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
            string ma = txtMaSPTK.Text;
            string ten = txtTenSPTK.Text;
            if (ma.Trim() == "" && ten.Trim() == "")
            {
                MessageBox.Show("Bạn cần nhập điều kiện tìm kiếm");
            }
            if (ten.Trim() == "")
            {
                MessageBox.Show("Tìm kiếm  theo mã sản phẩm");
                dgvDSSP.DataSource = bussp.timKiemSanPhamID(ma);
            }
            if (ma.Trim() == "")
            {
                MessageBox.Show("Tìm kiếm  theo tên sản phẩm");
                dgvDSSP.DataSource = bussp.timKiemSanPhamName(ten);
            }
        }

        private void dgvDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbTTSP_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

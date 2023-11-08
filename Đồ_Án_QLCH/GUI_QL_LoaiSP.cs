using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;
namespace Đồ_Án_QLCH
{
    public partial class GUI_QL_LoaiSP : Form
    {
        BUS_LoaiSP buslsp=new BUS_LoaiSP();
        public GUI_QL_LoaiSP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_QL_LoaiSP_Load(object sender, EventArgs e)
        {
            dgvLoaiSP.DataSource = buslsp.getLoaiSP();
            dgvLoaiSP.Columns[0].HeaderText = "Mã loại sản phẩm";
            dgvLoaiSP.Columns[1].HeaderText = "Tên loại sản phẩm";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void vbBtnThem_Click(object sender, EventArgs e)
        {
            string ma=txtMaLoai.Text;
            string ten = txtTenLoaiSP.Text;
            DTO_LoaiSP loaiSP = new DTO_LoaiSP(ma, ten);
            if (buslsp.kiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã loại sản phẩm đã tồn tại,vui lòng chọn mã khác !");
            }
            else
            {
                if (buslsp.themLoaiSP(loaiSP) == true)
                {
                    MessageBox.Show("Thêm thông tin loại sản phẩm thành công.");
                    dgvLoaiSP.DataSource = buslsp.getLoaiSP();
                }
            }
        }

        private void vbBtnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaLoai.Text;
            string ten = txtTenLoaiSP.Text;
            DTO_LoaiSP loaiSP = new DTO_LoaiSP(ma, ten);
            if (buslsp.UpdateLoaiSP(loaiSP) == true)
            {
                MessageBox.Show("Sửa thông tin  nhà cung cấp thành công.");
                dgvLoaiSP.DataSource = buslsp.getLoaiSP();
            }
        }

        private void vbBtnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaLoai.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin của loại sản phẩm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (buslsp.xoaLoaiSP(ma) == true)
                {
                    MessageBox.Show("Xóa thông tin khách hàng thành công");
                    dgvLoaiSP.DataSource = buslsp.getLoaiSP();
                }
                foreach (Control ctrl in grbLSP.Controls)
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
            foreach (Control ctrl in grbLSP.Controls)
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

        private void dgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Hangchon = e.RowIndex;
            txtMaLoai.Text = dgvLoaiSP[0, Hangchon].Value.ToString();
            txtTenLoaiSP.Text=dgvLoaiSP[1, Hangchon].Value.ToString();
        }
    }
}

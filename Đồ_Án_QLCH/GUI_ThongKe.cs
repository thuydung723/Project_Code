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
    public partial class GUI_ThongKe : Form
    {
        BUS_ThongKe bustk = new BUS_ThongKe();
        public GUI_ThongKe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_ThongKe_Load(object sender, EventArgs e)
        {
           // dgvThongKe.DataSource = bustk.LayDSHDBan();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vbbThongKe_Click(object sender, EventArgs e)
        {
           switch(searchType)
            {
                case SearchType.ByDate:
                    DateTime ngay = dtpNgayTao.Value.Date;
                    DataTable dataTable1 = bustk.timKiemHDTGNgay(ngay);
                    dgvThongKe.DataSource = dataTable1;
                    break;
                case SearchType.ByDateRange:
                    DateTime startDate = dtpTimKiemBD.Value.Date;
                    DateTime endDate = dtpTimKiemKT.Value.Date;
                    DataTable dataTable = bustk.timKiemHDTG(startDate, endDate);
                    dgvThongKe.DataSource = dataTable;
                    break;
                case SearchType.SanPhamHot:
                    DataTable dataTable2 = bustk.SanPhamBanChay();
                    dgvThongKe.DataSource = dataTable2;
                    break;
                case SearchType.SanPhamTonKho:
                    DataTable dataTable3 = bustk.SanPhamTonKho();
                    dgvThongKe.DataSource= dataTable3;
                    break;
            }    
        }
        //button in thống kê
        private void vbButton2_Click(object sender, EventArgs e)
        {
            switch (searchType)
            {
                case SearchType.ByDate:
                    DateTime ngay = dtpNgayTao.Value.Date;
                    DataTable dataTable = bustk.timKiemHDTGNgay(ngay);
                    dgvThongKe.DataSource = dataTable;
                    string duongdan = @"C:\Users\Nguyen Thuy Dung\source\repos\HoaDonNhapA.xlsx";
                    string printime = DateTime.Now.ToString();
                    bustk.ExportToExcel(dataTable, duongdan, printime);
                    MessageBox.Show("Exported to Excel successfully!");
                    break;
                case SearchType.ByDateRange:
                    DateTime startDate = dtpTimKiemBD.Value.Date;
                    DateTime endDate = dtpTimKiemKT.Value.Date;
                    DataTable dataTable1 = bustk.timKiemHDTG(startDate, endDate);
                    dgvThongKe.DataSource = dataTable1;
                    string duongdan1 = @"C:\Users\Nguyen Thuy Dung\source\repos\HoaDonNhapA.xlsx";
                    string printime1 = DateTime.Now.ToString();
                    bustk.ExportToExcel(dataTable1, duongdan1, printime1);
                    MessageBox.Show("Exported to Excel successfully!");
                    break;
            }
              

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        enum SearchType
        {
            ByDate,
            ByDateRange,
            SanPhamHot,
            SanPhamTonKho,
        }
        private SearchType searchType;
        private void rdoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoNgay.Checked)
            {
                searchType = SearchType.ByDate;
                DateTime ngay = dtpNgayTao.Value.Date;
            }    
        }

        private void rdoThang_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoThang.Checked)
            {
                searchType = SearchType.ByDateRange;
                DateTime startDate = dtpTimKiemBD.Value.Date;
                DateTime endDate = dtpTimKiemKT.Value.Date;
            }    
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoSPBC.Checked)
            {
                searchType = SearchType.SanPhamHot;
                DataTable dataTable= bustk.SanPhamBanChay(); 
            }    
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdoSPTK_CheckedChanged(object sender, EventArgs e)
        {
            searchType = SearchType.SanPhamTonKho;
            DataTable dataTable = bustk.SanPhamTonKho();
        }

        private void vbbThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(thoat == DialogResult.OK)
            {
                this.Hide();
                GUI_Main frm = new GUI_Main();
                frm.ShowDialog();
            }    
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Đồ_Án_QLCH
{
    public partial class GUI_Main : Form
    {
        public GUI_Main()
        {
            InitializeComponent();
        }
        private void tìmKiếmHĐNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhaCC frm=new GUI_NhaCC();
            frm.ShowDialog();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QL_KhoHang frm=new GUI_QL_KhoHang();
            frm.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLSP frm=new GUI_QLSP();
            frm.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhanVien frm=new GUI_NhanVien();
            frm.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhaCC frm = new GUI_NhaCC();
            frm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLKH frm=new GUI_QLKH();
            frm.ShowDialog();
        }

        private void chiTiếtKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Kho_Hang frm = new GUI_Kho_Hang();
            frm.ShowDialog();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QuanLi_HDN frm=new GUI_QuanLi_HDN();
            frm.ShowDialog();
        }

        private void chiTiếtHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ChiTiet_HoaDonNhap frm=new GUI_ChiTiet_HoaDonNhap();
            frm.ShowDialog();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QuanLy_HoaDonBan frm=new GUI_QuanLy_HoaDonBan();
            frm.ShowDialog();
        }

        private void chiTiếtHóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoDanhThuTheoQuýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ThongKe frm = new GUI_ThongKe();
            frm.ShowDialog();
        }

        private void GUI_Main_Load(object sender, EventArgs e)
        {
            //DTO_Main dTO_Main = new DTO_Main();
            //if(dTO_Main.Username!= manager && dTO_Main.Password!=m )
           // hóaĐơnNhậpToolStripMenuItem.Visible=false;
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoDoanhThuTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
           GUI_ThongKe frm=new GUI_ThongKe();
            frm.ShowDialog();
        }

        private void báoCáoSảnPhẩmBánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ThongKe frm = new GUI_ThongKe();
            frm.ShowDialog();
        }

        private void báoCáoHàngTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ThongKe frm = new GUI_ThongKe();
            frm.ShowDialog();
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Login frm=new GUI_Login();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tìmKiếmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLSP frm=new GUI_QLSP();
            frm.ShowDialog();
        }

        private void tìmKiếmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhanVien frm = new GUI_NhanVien();
            frm.ShowDialog();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLKH frm=new GUI_QLKH();
            frm.ShowDialog();
        }

        private void tìmKiếmHĐBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QuanLi_HDN frm=new GUI_QuanLi_HDN();
            frm.ShowDialog();
        }

        private void tìmKiếmHĐBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUI_QuanLy_HoaDonBan frm = new GUI_QuanLy_HoaDonBan();
            frm.ShowDialog();
        }
    }
}

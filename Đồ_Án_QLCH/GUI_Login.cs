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
    public partial class GUI_Login : Form
    {
        BUS_Logins busdn=new BUS_Logins();
        public GUI_Login()
        {
            InitializeComponent();
        }

        private void GUI_Login_Load(object sender, EventArgs e)
        {

        }

        private void vbBtnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtTenDN.Text;
            string pass = txtMk.Text;
            if (busdn.KiemTraTaiKhoan(user, pass))
            {
                MessageBox.Show("Đăng nhập thành công hệ thống!");
                this.Hide();
                GUI_Main gUI_Main = new GUI_Main();
                gUI_Main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHTMK.Checked == true)
            {
                txtMk.PasswordChar = (char)0;
            }
            else
            {
                txtMk.PasswordChar = '*';
            }
        }

        private void vbBtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thoat == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

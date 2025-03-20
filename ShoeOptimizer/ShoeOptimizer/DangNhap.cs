using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeOptimizer
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            txt_pass.PasswordChar = '*';
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = txt_name.Text.Trim(); // Lấy giá trị từ ô nhập username
            string password = txt_pass.Text.Trim(); // Lấy giá trị từ ô nhập password

            if (username == "user" && password == "123")
            {
                TimKiem timKiemForm = new TimKiem();
                timKiemForm.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            else if (username == "admin" && password == "123")
            {
                QuanLyGiay quanLyForm = new QuanLyGiay();
                quanLyForm.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

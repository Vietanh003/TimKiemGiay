using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ShoeOptimizer
{
    public partial class DangNhap : Form
    {
        private bool isRegisterMode = false; 
        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");

        public DangNhap()
        {
            InitializeComponent();
            txt_pass.PasswordChar = '*';
            txt_confirmPass.PasswordChar = '*';
            txt_confirmPass.Visible = false;
            lbl_confirmPass.Visible = false;

            EnsureJsonFileExists(); 
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (isRegisterMode)
            {
                RegisterUser();
            }
            else
            {
                LoginUser();
            }
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            isRegisterMode = !isRegisterMode; 

            if (isRegisterMode)
            {
                lbl_title.Text = "Đăng Ký";
                lbl_confirmPass.Visible = true;
                txt_confirmPass.Visible = true;
                btn_xacnhan.Text = "Xác Nhận Đăng Ký";
                btn_dangky.Text = "Đăng Nhập";
            }
            else
            {
                lbl_title.Text = "Đăng Nhập";
                lbl_confirmPass.Visible = false;
                txt_confirmPass.Visible = false;
                btn_xacnhan.Text = "Xác Nhận Đăng Nhập";
                btn_dangky.Text = "Đăng Ký";
            }
        }

        private void LoginUser()
        {
            string username = txt_name.Text.Trim();
            string password = txt_pass.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var users = LoadUsers();
            if (users.TryGetValue(username, out string storedPassword) && storedPassword == password)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form nextForm;
                if (username == "admin")
                {
                    nextForm = new QuanLyGiay();
                }
                else
                {
                    nextForm = new LocSanPham();
                }

                nextForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RegisterUser()
        {
            string username = txt_name.Text.Trim();
            string password = txt_pass.Text.Trim();
            string confirmPassword = txt_confirmPass.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var users = LoadUsers();
            if (users.ContainsKey(username))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            users[username] = password;
            SaveUsers(users);
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_dangky.PerformClick(); 
        }

        private Dictionary<string, string> LoadUsers()
        {
            try
            {
                if (!File.Exists(filePath)) return new Dictionary<string, string>();

                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đọc dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Dictionary<string, string>();
            }
        }

        private void SaveUsers(Dictionary<string, string> users)
        {
            try
            {
                string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnsureJsonFileExists()
        {
            if (!File.Exists(filePath))
            {
                var defaultUsers = new Dictionary<string, string> { { "admin", "123" } };
                SaveUsers(defaultUsers);
            }
        }
    }
}

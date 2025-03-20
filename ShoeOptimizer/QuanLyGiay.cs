using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Drawing;


namespace ShoeOptimizer
{
    public partial class QuanLyGiay : Form
    {
        private string filePath = "products.json";
        private List<Product> products = new List<Product>();
        private int selectedIndex = -1;

        public QuanLyGiay()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
            }
            UpdateDataGridView();
        }

        private void SaveProducts()
        {
            string json = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        private void UpdateDataGridView()
        {
            dtgv_dssp.DataSource = null;
            dtgv_dssp.DataSource = products;
        }

        private void btn_chonhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Chọn hình ảnh sản phẩm"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_hinh.Text = openFileDialog.FileName;
                picanhsp.SizeMode = PictureBoxSizeMode.Zoom; 
                picanhsp.Image = Image.FromFile(openFileDialog.FileName);
            }
        }



        private void btn_them_Click(object sender, EventArgs e)
        {
            if (ValidateFields(out Product product))
            {
                products.Add(product);
                SaveProducts();
                UpdateDataGridView();
                ClearFields();
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0 || selectedIndex >= products.Count)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateFields(out Product updatedProduct))
            {
                products[selectedIndex] = updatedProduct;
                SaveProducts();
                UpdateDataGridView();
                ClearFields();
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0 || selectedIndex >= products.Count)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            products.RemoveAt(selectedIndex);
            SaveProducts();
            UpdateDataGridView();
            ClearFields();
            MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dtgv_dssp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < products.Count)
            {
                selectedIndex = e.RowIndex;
                Product selectedProduct = products[selectedIndex];

                txt_tensp.Text = selectedProduct.Name;
                txt_gia.Text = selectedProduct.Price.ToString();
                cbo_size.Text = selectedProduct.Size;
                txt_soluong.Text = selectedProduct.Quantity.ToString();
                txt_hinh.Text = selectedProduct.ImagePath;
                cbo_thieu.Text = selectedProduct.ThuongHieu;

                if (File.Exists(selectedProduct.ImagePath))
                {
                    picanhsp.Image = Image.FromFile(selectedProduct.ImagePath);
                    picanhsp.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    picanhsp.Image = null; 
                }
            }
        }


        private void ClearFields()
        {
            txt_tensp.Clear();
            txt_gia.Clear();
            cbo_size.SelectedIndex = -1;
            txt_soluong.Clear();
            txt_hinh.Clear();
            selectedIndex = -1;
        }

        private bool ValidateFields(out Product product)
        {
            product = null;

            string name = txt_tensp.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txt_gia.Text.Trim(), out decimal price) || price <= 0)
            {
                MessageBox.Show("Giá sản phẩm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string size = cbo_size.Text.Trim();
            if (string.IsNullOrWhiteSpace(size))
            {
                MessageBox.Show("Vui lòng chọn size!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string thuonghieu = cbo_thieu.Text.Trim(); // Lấy giá trị thương hiệu
            if (string.IsNullOrWhiteSpace(thuonghieu))
            {
                MessageBox.Show("Vui lòng chọn thương hiệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txt_soluong.Text.Trim(), out int quantity) || quantity < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string imagePath = txt_hinh.Text.Trim();
            if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
            {
                MessageBox.Show("Vui lòng chọn hình ảnh hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            product = new Product
            {
                Name = name,
                Price = price,
                Size = size,
                Quantity = quantity,
                ThuongHieu= thuonghieu,
                ImagePath = imagePath
            };

            return true;
        }
    }

   
}

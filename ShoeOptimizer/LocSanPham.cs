using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace ShoeOptimizer
{
    public partial class LocSanPham : Form
    {
        private string filePath = "products.json";
        private List<Product> products = new List<Product>();
        private List<Product> filteredProducts = new List<Product>(); // Danh sách giày sau khi lọc
        private List<Product> selectedShoes = new List<Product>(); // Danh sách giày đã chọn
        private decimal budget;

        public LocSanPham()
        {
            InitializeComponent();
            LoadProducts();
        }

        // 🟢 1️⃣ Đọc danh sách giày từ file JSON
        private void LoadProducts()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
            }
            UpdateProductList(products);
        }

        // 🟢 2️⃣ Hiển thị danh sách giày lên DataGridView
        private void UpdateProductList(List<Product> list)
        {
            dtgv_dssp.DataSource = null;
            dtgv_dssp.DataSource = list;
        }

        private void ApplyFilters()
        {
            string selectedBrand = cbo_thieu.Text;
            string selectedSize = cbo_size.Text;

            filteredProducts = products
                .Where(p => (string.IsNullOrEmpty(selectedBrand) || p.ThuongHieu == selectedBrand) &&
                            (string.IsNullOrEmpty(selectedSize) || p.Size == selectedSize))
                .ToList();

            UpdateProductList(filteredProducts);
        }


        private void cbo_thieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cbo_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btn_chontoiuu_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtBudget.Text, out budget) || budget <= 0)
            {
                MessageBox.Show("Ngân sách không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedShoes.Clear();
            decimal remainingBudget = budget;

            // Nếu không có lọc, dùng toàn bộ danh sách sản phẩm
            var availableShoes = filteredProducts.Any() ? filteredProducts : products;

            List<Product> sortedShoes = new List<Product>();

            // 🟢 Xử lý theo tiêu chí người dùng chọn
            if (rdoGiaThapNhat.Checked)
            {
                // Chọn giày có giá thấp nhất trước
                sortedShoes = availableShoes.OrderBy(p => p.Price).ToList();
            }
            else if (rdoGiaCaoNhat.Checked)
            {
                // Chọn giày có giá cao nhất nhưng vẫn nằm trong ngân sách
                sortedShoes = availableShoes.OrderByDescending(p => p.Price).ToList();
            }

            // 🟢 Chọn giày theo ngân sách
            foreach (var shoe in sortedShoes)   
            {
                if (shoe.Price <= remainingBudget)
                {
                    selectedShoes.Add(shoe);
                    remainingBudget -= shoe.Price;
                }
            }

            UpdateSelectedShoes();
            lbl_tongchiphi.Text = $"Tổng chi phí: {budget - remainingBudget:C}";
        }



        // 🟢 5️⃣ Hiển thị danh sách giày đã chọn lên DataGridView
        private void UpdateSelectedShoes()
        {
            dtgv_dsdc.DataSource = null;
            dtgv_dsdc.DataSource = selectedShoes;
        }
    }
}


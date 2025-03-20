using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ShoeOptimizer
{
    public partial class TimKiem : Form
    {
        private List<Giay> danhSachHienTai; // Danh sách đang hiển thị
        public TimKiem()
        {
            InitializeComponent();
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "HinhAnhColumn";
            imgColumn.HeaderText = "Hình Ảnh";
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Căn chỉnh hình vừa ô
            dgv_KetQua.Columns.Add(imgColumn);
            LoadDanhSach();
            HienThiTatCa(); // Hiển thị tất cả giày ngay khi mở form
        }
        private void HienThiDanhSach(List<Giay> danhSach)
        {
            // Đặt DataSource về null và xóa cột cũ để cập nhật dữ liệu mới
            dgv_KetQua.DataSource = null;
            dgv_KetQua.Columns.Clear();

            // Tạo danh sách dữ liệu mới, chuyển đổi đường dẫn thành ảnh
            var data = danhSach.Select(g => new
            {
                g.Ten,
                g.Gia,
                g.KichThuoc,
                g.ThuongHieu,
                g.SoLuong,
                 // Lưu đường dẫn thay vì Image object
                HinhAnh = (!string.IsNullOrEmpty(g.HinhAnh) && File.Exists(g.HinhAnh))
                    ? Image.FromFile(g.HinhAnh) : null // Chuyển đổi đường dẫn thành Image
            }).ToList();

            // Đặt DataSource cho DataGridView
            dgv_KetQua.DataSource = data;

            // Kiểm tra xem cột "HinhAnh" có tồn tại hay chưa, nếu chưa thì thêm mới
            if (dgv_KetQua.Columns["HinhAnh"] is DataGridViewImageColumn imgColumn)
            {
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            else
            {
                DataGridViewImageColumn newImgColumn = new DataGridViewImageColumn
                {
                    HeaderText = "Hình Ảnh",
                    Name = "HinhAnh",
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dgv_KetQua.Columns.Add(newImgColumn);
            }

            // Định dạng cột hình ảnh để tránh lỗi nếu giá trị null
            dgv_KetQua.Columns["HinhAnh"].DefaultCellStyle.NullValue = null;

            // Tùy chỉnh tự động chỉnh kích thước
            dgv_KetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_KetQua.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void HienThiTatCa()
        {
            HienThiDanhSach(ListGiay.danhSachGiay);
        }
        private void LoadDanhSach()
        {
            // Load dữ liệu vào ComboBox
            cb_TenGiay.DataSource = ListGiay.danhSachGiay.Select(g => g.Ten).Distinct().ToList();
            cb_KichThuoc.DataSource = Enumerable.Range(30, 11).ToList(); // Từ 30 đến 40
            cb_ThuongHieu.DataSource = ListGiay.danhSachGiay.Select(g => g.ThuongHieu).Distinct().ToList();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            // Lọc danh sách theo điều kiện tìm kiếm
            var danhSachLoc = ListGiay.danhSachGiay.Where(g =>
                (cb_TenGiay.SelectedItem == null || g.Ten == cb_TenGiay.SelectedItem.ToString()) &&
                (cb_KichThuoc.SelectedItem == null || g.KichThuoc == Convert.ToInt32(cb_KichThuoc.SelectedItem)) &&
                (cb_ThuongHieu.SelectedItem == null || g.ThuongHieu == cb_ThuongHieu.SelectedItem.ToString()) &&
                (string.IsNullOrEmpty(txt_SoLuongToiThieu.Text) || g.SoLuong >= Convert.ToInt32(txt_SoLuongToiThieu.Text)) &&
                (rb_Duoi500k.Checked ? g.Gia < 500000 : true) &&
                (rb_500k_3000k.Checked ? (g.Gia >= 500000 && g.Gia <= 3000000) : true) &&
                (rb_Tren5000k.Checked ? g.Gia > 5000000 : true)
            ).ToList();

            HienThiDanhSach(danhSachLoc);
        }

        private void dgv_KetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_KetQua_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_XemTatCa_Click(object sender, EventArgs e)
        {
            HienThiTatCa();
        }
    }
}
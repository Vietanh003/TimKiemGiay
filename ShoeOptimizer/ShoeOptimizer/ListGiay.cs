using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeOptimizer
{
    internal class ListGiay
    {
        public static List<Giay> danhSachGiay = new List<Giay>
        {
            new Giay { Ten = "Nike Air Max", Gia = 1200000, KichThuoc = 38, ThuongHieu = "Nike", SoLuong = 10, HinhAnh = "D:\\2025\\kỹ thuật lập trình\\TimKiemGiay-main\\ShoeOptimizer\\anh\\anh1.jpg" },
            new Giay { Ten = "Adidas Ultraboost", Gia = 2500000, KichThuoc = 40, ThuongHieu = "Adidas", SoLuong = 5, HinhAnh = "D:\\2025\\kỹ thuật lập trình\\TimKiemGiay-main\\ShoeOptimizer\\anh\\anh2.jpg" },
            new Giay { Ten = "Puma RS-X", Gia = 700000, KichThuoc = 36, ThuongHieu = "Puma", SoLuong = 8, HinhAnh = "D:\\2025\\kỹ thuật lập trình\\TimKiemGiay-main\\ShoeOptimizer\\anh\\anh3.jpg" },
            new Giay { Ten = "Converse Chuck Taylor", Gia = 450000, KichThuoc = 39, ThuongHieu = "Converse", SoLuong = 15, HinhAnh = @"D:\\2025\\kỹ thuật lập trình\\TimKiemGiay-main\\ShoeOptimizer\\anh\\anh4.jpg" }
        };
    }
}

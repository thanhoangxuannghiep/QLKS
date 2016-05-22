using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace BUS
{
    public class QLKhachHang
    {
        public static DataTable getAll()
        {
            return KhachHang.getAll("KHACHHANG");
        }

        public static bool insert(string name_table, string[] array_columns, string[] array_values)
        {
            return KhachHang.insert(name_table, array_columns, array_values);
        }

        public static int insert(string name_table, string[] array_columns, string TenKH, int GioiTinh, string SoCMND, int LoaiKHID, string SoDienThoai, string Email, decimal DiemThuong)
        {
            return KhachHang.insert(name_table, array_columns, TenKH, GioiTinh, SoCMND, LoaiKHID, SoDienThoai, Email, DiemThuong);
        }
        public static bool update(string name_table, string[] array_columns, int MaKH, string TenKH, int GioiTinh, string SoCMND, int LoaiKHID, string SoDienThoai, string Email, decimal DiemThuong)
        {
            return KhachHang.update(name_table, array_columns, MaKH, TenKH, GioiTinh, SoCMND, LoaiKHID, SoDienThoai, Email, DiemThuong);
        }
        public static bool delete(int MaKH)
        {
            return KhachHang.delete(MaKH);
        }
    }
}

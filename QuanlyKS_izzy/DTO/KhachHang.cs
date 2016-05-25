using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KhachHang : DTObject
    {
        public static DataTable getAll(string name_table)
        {
            DataTable data;
            try
            {
                DataProvider provider = new DataProvider();
                string sql = "select MaKH, TenKH, (CASE GioiTinh WHEN 1 THEN N'Nam' WHEN 0 THEN N'Nữ' END) AS GioiTinh, SoCMND, (CASE LoaiKHID WHEN 1 THEN N'Nội Địa' WHEN 2 THEN N'Quốc Tế' END) AS LoaiKHID, SoDienThoai, Email, DiemThuong from " + name_table;
                data = provider.ExecuteQuery_DataTble(sql);
            }
            catch (Exception)
            {
                data = new DataTable();
                throw;
            }
            return data;
        }
        public static int insert(string name_table, string[] array_columns, string TenKH, int GioiTinh, string SoCMND, int LoaiKHID, string SoDienThoai, string Email, decimal DiemThuong)
        {
            try
            {
                DataProvider provider = new DataProvider();
                string sql = "insert into " + name_table + "(" + String.Join(",", array_columns) + ") OUTPUT INSERTED.MaKH values(N'" + TenKH + "', " + GioiTinh + ", '" + SoCMND + "', " + LoaiKHID + ", '" + SoDienThoai + "', '" + Email + "', " + DiemThuong + ")";
                return 1;//provider.ExecuteInsertQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool update(string name_table, string[] array_columns, int MaKH, string TenKH, int GioiTinh, string SoCMND, int LoaiKHID, string SoDienThoai, string Email, decimal DiemThuong)
        {
            try
            {
                DataProvider provider = new DataProvider();
                string sql = "update " + name_table + " set " + array_columns[0] + " = N'" + TenKH + "',  " + array_columns[1] + " = " + GioiTinh + ", " + array_columns[2] + " = '" + SoCMND + "', " + array_columns[3] + " = " + LoaiKHID + ", " + array_columns[4] + " = '" + SoDienThoai + "', " + array_columns[5] + " = '" + Email + "', " + array_columns[6] + " = " + DiemThuong + " WHERE MaKH = " + MaKH;
                return provider.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

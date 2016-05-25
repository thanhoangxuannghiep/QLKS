using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAO;

namespace DTO
{
    public class NhanVienDTO
    {
        private string maNV;
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private string tenNhanVien;
        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }
        private DateTime ngaySinh;
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string soCMND;
        public string SoCMND
        {
            get { return soCMND; }
            set { soCMND = value; }
        }
        private DateTime ngayVaoLam;
        public DateTime NgayVaoLam
        {
            get { return ngayVaoLam; }
            set { ngayVaoLam = value; }
        }
        private bool gioiTinh;
        public bool GioiTinh
        {
          get { return gioiTinh; }
          set { gioiTinh = value; }
        }
        private bool deleted;
        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        public static DataTable getAll()
        {
            string sql = "select MaNV, TenNhanVien, NgaySinh, NgayVaoLam, SoCMND, Deleted, LOAINHANVIEN.TenLoaiNhanvien, (CASE GioiTinh WHEN 1 THEN N'Nam' WHEN 0 THEN N'Nữ' END) AS GioiTinh from NHANVIEN, LOAINHANVIEN where NHANVIEN.LoaiNhanVien = LOAINHANVIEN.MaLoaiNV";
            return DTObject.exec(sql);
        }

        public static bool create(string[] value)
        {
            string[] col = { "TenNhanVien", "NgaySinh", "SoCMND", "NgayVaoLam", "LoaiNhanVien", "GioiTinh", "Deleted" };
            return DTObject.insert("NHANVIEN", col, value);
        }
        public static bool update(string _set, string _where)
        {

            try
            {
                DataProvider provider = new DataProvider();

                string sql = "UPDATE NHANVIEN SET " + _set + " WHERE " + _where;
                return provider.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool deletebyId(int id)
        {
            try
            {
                DataProvider provider = new DataProvider();
                string sql = "DELETE FROM NHANVIEN WHERE MaNV = " + id.ToString();
                return provider.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

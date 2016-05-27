using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAO;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string maTaiKhoan;
        public string MaTaiKhoan
        {
            get { return maTaiKhoan; }
            set { maTaiKhoan = value; }
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
        private bool active;
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string soDT;
        public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }

        public static DataTable getAll()
        {
            string sql = "select t.MaTaiKhoan, t.HoTen, t.SoCMND, t.NgayVaoLam, t.NgaySinh, t.email, t.SoDienThoai, t.Username, t.PassWord,"+
            "(CASE t.GioiTinh WHEN 1 THEN N'Nam' WHEN 0 THEN N'Nữ' END) AS GioiTinh, (CASE t.Deleted WHEN 0 THEN N'Đang hoạt động' WHEN 1 THEN N'Đã xóa' END) AS Deleted,"
            + " nv.TenLoaiNhanVien, t.Active"
                + " from TaiKhoan t, LOAINHANVIEN nv where t.LoaiTaiKhoan = nv.MaLoaiNV";
            return DTObject.exec(sql);
        }

        public static bool create(string[] value)
        {
            string[] col = { "HoTen", "SoCMND", "NgayVaoLam", "NgaySinh", "email", "SoDienThoai", "Username", "PassWord", "LoaiTaiKhoan", "GioiTinh", "Deleted", "Active" };
            return DTObject.insert("TAIKHOAN", col, value);
        }
        public static bool update(string _set, string _where)
        {

            try
            {
                DataProvider provider = new DataProvider();

                string sql = "UPDATE TaiKhoan SET " + _set + " WHERE " + _where;
                return provider.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable get_loainhanvien()
        {
            return DTObject.getAll("LOAINHANVIEN");
        }
        public static DataTable get_user_byUsername(string username)
        {
            string sql = "SELECT * FROM TAIKHOAN WHERE Username='" + username + "'";

            return DTBill.exec(sql);
        }
        public static DataTable get_email_byEmail(string email)
        {
            string sql = "SELECT * FROM TAIKHOAN WHERE email='" + email + "'";

            return DTBill.exec(sql);
        }
    }
}

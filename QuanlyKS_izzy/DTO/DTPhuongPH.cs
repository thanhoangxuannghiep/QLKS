using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Security.Cryptography;
using DAO;


namespace DTO
{
    public class DTBill : DTObject
    {
        public static DataTable getHoaDon()
        {
            return DTObject.getAll("HOADON");
        }
        public static DataTable getChiTietHoaDon(int mhd)
        {
            string sql = "SELECT * FROM CHITIETHOADON WHERE MaHD=N'" + mhd.ToString() + "'";

            return DTBill.exec(sql);
        }

        public static DataTable getNhanVien()
        {
            string sql = "SELECT * FROM NHANVIEN";

            return DTBill.exec(sql);
        }

        public static DataTable getRoom()
        {
            return DTBill.exec("SELECT * FROM PHONG");
        }

        public static DataTable getRent()
        {
            return DTBill.exec("SELECT * FROM PHIEUTHUE");
        }


        public static bool create(string[] value)
        {
            string[] col = { "NgayLap", "TongGia", "NhanVien", "Phong", "MaPhieuThue" };
            return DTObject.insert("HOADON", col, value);
        }
        public static bool update(string _set, string _where)
        {
            try
            {
                DataProvider provider = new DataProvider();

                string sql = "UPDATE HOADON SET " + _set + " WHERE " + _where;
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
                string sql = "DELETE FROM HOADON WHERE MaHoaDon = " + id.ToString();
                string sql2 = "DELETE FROM CHITIETHOADON WHERE MaHD=N'" + id.ToString() + "'";
                provider.ExecuteNonQuery(sql2);
                return provider.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable exec(string query)
        {
            try
            {
                DataProvider provider = new DataProvider();
                return provider.ExecuteQuery_DataTble(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public class DTBillDetail
    {
        public static bool create(string[] value)
        {
            string[] col = { "MaHD", "MaDichVu", "NgaySuDung", "Phong" };
            return DTObject.insert("CHITIETHOADON", col, value);
        }

        public static bool update(string _set, string _where)
        {

            try
            {
                DataProvider provider = new DataProvider();

                string sql = "UPDATE CHITIETHOADON SET " + _set + " WHERE " + _where;
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
                //string sql = "DELETE FROM HOADON WHERE MaHoaDon = " + id.ToString();
                string sql2 = "DELETE FROM CHITIETHOADON WHERE UUID=N'" + id.ToString() + "'";
                //provider.ExecuteNonQuery(sql2);
                return provider.ExecuteNonQuery(sql2);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    public class DTService : DTObject
    {
        public static DataTable getAll()
        {
            return DTObject.getAll("DICHVU");
        }

        public static bool create(string[] value)
        {
            string[] col = { "TenDichVu", "Gia" };
            return DTObject.insert("DICHVU", col, value);
        }
        public static bool update(string _set, string _where)
        {

            try
            {
                DataProvider provider = new DataProvider();

                string sql = "UPDATE DICHVU SET " + _set + " WHERE " + _where;
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
                string sql = "DELETE FROM DICHVU WHERE MaDichVu = " + id.ToString();
                return provider.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    public class DTRent : DTObject
    {
        public static DataTable getAll()
        {
            return DTObject.getAll("PHIEUTHUE");
        }

        public static bool create(string[] value)
        {

            string[] col = { "TenPhieuThue", "TinhTrangPhieuThue", "MaPhong", "NgayLap", "NgayBatDau", "NgayKetThuc", "MaKH" };
            return DTObject.insert("PHIEUTHUE", col, value);
        }
        public static bool update(string _set, string _where)
        {

            try
            {
                DataProvider provider = new DataProvider();

                string sql = "UPDATE PHIEUTHUE SET " + _set + " WHERE " + _where;
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
                string sql = "DELETE FROM PHIEUTHUE WHERE MaPhieuThue = " + id.ToString();
                return provider.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable exec(string query)
        {
            try
            {
                DataProvider provider = new DataProvider();

                return provider.ExecuteQuery_DataTble(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    public class DTLogin : DTObject
    {
        private static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static int getData(string user, string pass)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                pass = GetMd5Hash(md5Hash, pass);
            }

            DataProvider provider = new DataProvider();
            string sql = "SELECT * FROM TAIKHOAN WHERE Username=N'" + user + "' AND Password=N'" + pass + "'";

            DataSet ds = provider.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }

            return -1;

        }
    }

    public class DBManager : DTObject
    {
        public static void exportDB(string path)
        {
            string sql = "Backup database quanlykhachsan to disk='" + path + "'";
           
            DataProvider provider = new DataProvider();
            provider.ExecuteNonQuery(sql);
        }

        public static void importDB(string path)
        {
            string sql = "RESTORE DATABASE AdventureWorks FROM DISK = '" + path + "' WITH REPLACE";
            DataProvider provider = new DataProvider();
            provider.ExecuteNonQuery(sql);
        }
    }
}

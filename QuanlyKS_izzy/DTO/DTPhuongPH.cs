using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;


namespace DTO
{
    public class DTBill : DTObject
    {
        public static DataTable getAll()
        {
            return DTObject.getAll("HOADON");
        }

        public static bool create(string[] value)
        {
            string[] col = { "MaHoaDon", "NgayLap", "TongGia", "NhanVien", "Phong", "MaPhieuThue" };
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
            string[] col = {"TenPhieuThue", "TinhTrangPhieuThue", "MaPhong", "NgayLap", "NgayBatDau", "NgayKetThuc", "MaKH" };
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
}

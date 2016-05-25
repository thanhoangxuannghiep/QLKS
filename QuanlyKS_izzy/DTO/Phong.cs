using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Phong : DTObject
    {
        public static bool updateTrangThaiPhong(int maPhong, int trangThai)
        {
            try
            {
                DataProvider provider = new DataProvider();
                string sql = "UPDATE PHONG set TinhTrangPhong = " + trangThai + " WHERE MaPhong = " + maPhong;
                return provider.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

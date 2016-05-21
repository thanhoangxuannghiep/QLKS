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
        public DataTable getAll()
        {
            return KhachHang.getAll("KHACHHANG");
        }

        public static bool insert(string name_table, string[] array_columns, string[] array_values)
        {
            return KhachHang.insert(name_table, array_columns, array_values);
        }
    }
}

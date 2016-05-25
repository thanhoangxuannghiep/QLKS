using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DevExpress.XtraEditors;

namespace BUS
{
    public class NhanVienBUS
    {
        public static DataTable getAll()
        {
            return NhanVienDTO.getAll();
        }

        public static bool create(string[] _value)
        {
            return NhanVienDTO.create(_value);
        }
    }
}

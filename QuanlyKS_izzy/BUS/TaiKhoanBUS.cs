using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DevExpress.XtraEditors;

namespace BUS
{
    public class TaiKhoanBUS
    {
        public static DataTable getAll()
        {
            return TaiKhoanDTO.getAll();
        }

        public static int create(string[] _value)
        {
            for (int i = 0; i < _value.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(_value[i]))
                    return i;
            }

            TaiKhoanDTO.create(_value);

            return -1;
        }
        public static DataTable get_loainhanvien(){
            return TaiKhoanDTO.get_loainhanvien();
        }
        public static DataTable get_user_byUsername(string username)
        {
            return TaiKhoanDTO.get_user_byUsername(username);
        }
        public static DataTable get_email_byEmail(string email)
        {
            return TaiKhoanDTO.get_email_byEmail(email);
        }
        public static int update(string[] _set, string _where)
        {
            string _value = "";
            for (int i = 0; i < _set.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(_set[i]))
                    return i;


            }
            _value += @"HoTen=N'" + _set[0] + "',";
            _value += @"SoCMND=N'" + _set[1] + "',";
            _value += @"NgayVaoLam=convert(date, '" + _set[2] + "',105),";
            _value += @"NgaySinh=convert(date, '" + _set[3] + "',105),";
            _value += @"email='" + _set[4] + "'";
            _value += @"SoDienThoai='" + _set[5] + "'";
            _value += @"Username='" + _set[6] + "'";
            _value += @"PassWord='" + _set[7] + "'";
            _value += @"LoaiTaiKhoan='" + _set[8] + "'";
            _value += @"GioiTinh='" + _set[9] + "'";
            _value += @"Deleted='" + _set[10] + "'";
            _value += @"Active='" + _set[11] + "'";
            DTBill.update(_value, _where);
            return -1;
        }
    }
}

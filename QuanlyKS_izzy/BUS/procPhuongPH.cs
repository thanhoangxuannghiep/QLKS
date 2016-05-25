using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DevExpress.XtraEditors;

namespace BUS
{
    public class procUCBill
    {
        public static DataTable getAll()
        {
            return DTBill.getAll("HOADON");
        }

        public static int create(string[] _value)
        {
            for (int i = 0; i < _value.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(_value[i]))
                    return i;
            }

            DTBill.create(_value);

            return -1;
        }

        public static int update(string[] _set, string _where)
        {
            string _value = "";
            //"NgayLap", "TongGia", "NhanVien", "Phong", "MaPhieuThue"
            for (int i = 0; i < _set.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(_set[i]))
                    return i;


            }
            _value += @"NgayLap=N'" + _set[0] + "',";
            _value += @"TongGia=N'" + _set[1] + "',";
            _value += @"NhanVien=N'" + _set[2] + "',";
            _value += @"Phong='" + _set[3] + "',";
            _value += @"MaPhieuThue='" + _set[4] + "'";


            DTBill.update(_value, _where);
            return -1;
        }

        public static bool delbyid(string id)
        {
            if (String.IsNullOrWhiteSpace(id))
                return false;

            if (DTBill.deletebyId(int.Parse(id)))
                return true;
            return false;
        }
    }

    public class procUCBillDetail
    {


        public static int create(string[] _value)
        {
            for (int i = 0; i < _value.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(_value[i]))
                    return i;
            }

            DTBillDetail.create(_value);

            return -1;
        }

        public static int update(string[] _set, string _where)
        {
            string _value = "";
            //"NgayLap", "TongGia", "NhanVien", "Phong", "MaPhieuThue"
            for (int i = 0; i < _set.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(_set[i]))
                    return i;


            }
            _value += @"MaHD=N'" + _set[0] + "',";
            _value += @"MaDichVu=N'" + _set[1] + "',";
            _value += @"NgaySuDung=N'" + _set[2] + "',";
            _value += @"Phong='" + _set[3] + "'";



            DTBillDetail.update(_value, _where);
            return -1;
        }

        public static bool delbyid(string id)
        {
            if (String.IsNullOrWhiteSpace(id))
                return false;

            if (DTBillDetail.deletebyId(int.Parse(id)))
                return true;
            return false;
        }
    }

    public class procUCRent
    {
        public static DataTable getAll()
        {
            return DTRent.getAll();
        }

        public static int create(string[] _value)
        {
            for (int i = 0; i < _value.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(_value[i]))
                    return i;
            }

            DTRent.create(_value);
            return -1;
        }
        public static int createGetID(string[] _value)
        {
            for (int i = 0; i < _value.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(_value[i]))
                    return i;
            }

            return DTRent.createGetID(_value);
        }
        public static int update(string[] _set, string _where)
        {
            string _value = "";
            for (int i = 0; i < _set.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(_set[i]))
                    return i;
            }
                _value += @"TenPhieuThue=N'" + _set[0] + "',";
                _value += @"TinhTrangPhieuThue=N'" + _set[1] + "',";
                _value += @"MaPhong=N'" + _set[2] + "',";
                _value += @"NgayLap='" + _set[3] + "',";
                _value += @"NgayBatDau='" + _set[4] + "',";
                _value += @"NgayKetThuc='" + _set[5] + "',";
                _value += @"MaKH='" + _set[6] + "'";

                DTRent.update("PHIEUTHUE", _value, _where);
                return -1;

        }
        public static bool delbyid(string id)
        {
            if (String.IsNullOrWhiteSpace(id))
                return false;

            if (DTRent.deletebyId(int.Parse(id)))
                return true;
            return false;
        }

        public static DataTable getRoom()
        {
            string sql = "SELECT MaPhong, TenPhong, Tang FROM PHONG";
            return DTRent.exec(sql);     
        }

        public static DataTable getCustomer()
        {
            string sql = "SELECT * FROM KHACHHANG";
            return DTRent.exec(sql);
        }
    }

    public class procUCService
    {
        public static DataTable getAll()
        {
            return DTService.getAll();
        }

        public static int create(string[] _value)
        {
            for (int i = 0; i < _value.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(_value[i]))
                    return i;
            }

            DTService.create(_value);
            return -1;
            //return 
        }

        public static int update(string[] _set, string _where)
        {
            string _value = "";

            for (int i = 0; i < _set.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(_set[i]))
                    return i;


            }

            _value += @"TenDichVu=N'" + _set[0] + "',";
            _value += @"Gia=N'" + _set[1] + "'";
            DTService.update("DICHVU", _value, _where);
            return -1;
        }

        public static bool delbyid(string id)
        {
            if (String.IsNullOrWhiteSpace(id))
                return false;

            if (DTService.deletebyId(int.Parse(id)))
                return true;
            return false;
        }
    }

    public class procLogin
    {
        public static int Login(string user, string pass)
        {
            if (String.IsNullOrWhiteSpace(user))
                return -2;
            if (String.IsNullOrWhiteSpace(pass))
                return -3;

            return DTLogin.getData(user, pass);
        }
    }
}

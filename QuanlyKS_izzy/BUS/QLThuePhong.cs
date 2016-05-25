using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;

namespace BUS
{
    public class QLThuePhong
    {
        //Tình trạng thuê phòng bao gồm:
        //    + -1 là chưa thuê
        //    + 0 là thuê rồi chưa check in
        //    + 1 là thuê và đã check in
        public static DataTable getAll()
        {
            return Phong.getAll("PHONG");
        }

        public static bool updateTrangThaiPhong(int maPhong, int trangThai)
        {
            return Phong.updateTrangThaiPhong(maPhong, trangThai);
        }
    }
}

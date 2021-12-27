using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_THUEKHACHSAN;

namespace BUS_THUEKHACHSAN
{
    public class BUS_Thuephong
    {
        DAL_Thuephong dalthuephong = new DAL_Thuephong();
        public DataTable getListThuephong(int ls)
        {
            return dalthuephong.getListThuephong(ls);
        }

        public DataTable getThongtinthuephong(long mahoadon)
        {
            return dalthuephong.getThongtinthuephong(mahoadon);
        }

        public DataTable timkiemBytenphong(string tenphong, int ls)
        {
            return dalthuephong.timkiemBytenphong(tenphong,ls);
        }

        public DataTable timkiemBytenkhach(string tenkhach,int ls)
        {
            return dalthuephong.timkiemBytenkhach(tenkhach,ls);
        }

        public DataTable timkiem(string tenphong, string tenkhach, int ls)
        {
            return dalthuephong.timkiem(tenphong, tenkhach,ls);
        }

        public bool insertThuephong(string tenkhach, string soCMND, long maphong, DateTime ngaythue, long idnhanvienduaphong, int songuoi)
        {
            return dalthuephong.insertThuephong(tenkhach, soCMND, maphong, ngaythue, idnhanvienduaphong, songuoi);
        }

        public bool updateThuephong(string tenkhach, string soCMND, long maphong, DateTime ngaythue, int songuoi, long mahoadon)
        {
            return dalthuephong.updateThuephong(tenkhach, soCMND, maphong, ngaythue, songuoi, mahoadon);
        }

        public bool traPhong(long mahoadon, long idnhanvientraphong)
        {
            return dalthuephong.traPhong(mahoadon, idnhanvientraphong);
        }
        public bool deleteThuephong(long mahoadon)
        {
            return dalthuephong.deleteThuephong(mahoadon);
        }

        public bool taoHoadon(long mahoadon)
        {
            return dalthuephong.taoHoadon(mahoadon);
        }

        public DataTable getHoadon()
        {
            return dalthuephong.getHoadon();
        }
    }
}

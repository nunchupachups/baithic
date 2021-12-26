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
    public class BUS_Phong
    {
        DAL_Phong dalPhong = new DAL_Phong();
        public DataTable getListPhong1()
        {
            return dalPhong.getListPhong1();
        }

        public DataTable getListPhong2()
        {
            return dalPhong.getListPhong2();
        }

        public DataTable getListPhong3()
        {
            return dalPhong.getListPhong3();
        }

        public DataTable getListPhong4()
        {
            return dalPhong.getListPhong4();
        }

        public DataTable getListPhong5()
        {
            return dalPhong.getListPhong5();
        }


        public DataTable getListPhongtrong()
        {
            return dalPhong.getListPhongtrong();
        }

        public DataTable getPhongByma(long maphong)
        {
            return dalPhong.getPhongByma(maphong);
        }

        public DataTable timkiemPhongtrong(string tang, string loaiphong, string songuoitoida)
        {
            return dalPhong.timkiemPhongtrong(tang, loaiphong, songuoitoida);
        }

        public DataTable timkiemPhongtrongBytang(string tang)
        {
            return dalPhong.timkiemPhongtrongBytang(tang);
        }

        public DataTable timkiemPhongtrongByloaiphong(string loaiphong)
        {
            return dalPhong.timkiemPhongtrongByloaiphong(loaiphong);
        }

        public DataTable timkiemPhongtrongBysonguoitoida(string songuoitoida)
        {
            return dalPhong.timkiemPhongtrongBysonguoitoida(songuoitoida);
        }

        public DataTable timkiemPhongtrongBytangvaloaiphong(string tang, string loaiphong)
        {
            return dalPhong.timkiemPhongtrongBytangvaloaiphong(tang, loaiphong);
        }

        public DataTable timkiemPhongtrongBytangvasonguoitoida(string tang, string songuoitoida)
        {
            return dalPhong.timkiemPhongtrongBytangvasonguoitoida(tang, songuoitoida);        
        }

        public DataTable timkiemPhongtrongByloaiphongvasonguoitoida(string loaiphong, string songuoitoida) 
        {
            return dalPhong.timkiemPhongtrongByloaiphongvasonguoitoida(loaiphong, songuoitoida);
        }



        public bool insertPhong(string tenphong, int tang, string loaiphong, int songuoitoida, float dongia, string mota, int tinhtrang)
        {
            return dalPhong.insertPhong(tenphong, tang, loaiphong, songuoitoida, dongia, mota, tinhtrang);
        }

        public bool updatePhong(long maphong, string tenphong, int tang, string loaiphong, int songuoitoida, float dongia, string mota, int tinhtrang)
        {
            return dalPhong.updatePhong(maphong, tenphong, tang, loaiphong, songuoitoida, dongia, mota,tinhtrang);
        }

        public bool updateTinhtrangPhong(long maphong, int tinhtrang)
        {
            return dalPhong.updateTinhtrangPhong(maphong, tinhtrang);
        }

        public bool deletePhong(long maphong)
        {
            return dalPhong.deletePhong(maphong);
        }
    }
}

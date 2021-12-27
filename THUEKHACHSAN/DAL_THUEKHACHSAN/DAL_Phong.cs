using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_THUEKHACHSAN
{
    public class DAL_Phong:DBConnection
    {
        public DataTable getListPhongbytang(int tang)
        {
            string str = string.Format("select * from phong where tang='{0}'", tang);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalPhong = new DataTable();
            dal.Fill(dalPhong);
            return dalPhong;
        }

        public DataTable getListPhongtrong()
        {
            string str = string.Format("select * from phong where tinhtrang='{0}'",0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalPhong = new DataTable();
            dal.Fill(dalPhong);
            return dalPhong;
        }

        public DataTable getPhongByma(long maphong)
        {
            string str = string.Format("select * from phong where maphong='{0}'",maphong);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalPhong = new DataTable();
            dal.Fill(dalPhong);
            return dalPhong;
        }

        public DataTable timkiemPhongtrongBytang(string tang)
        {
            string str = string.Format("select * from phong where tang='{0}' and tinhtrang='{1}'", tang, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalPhong = new DataTable();
            dal.Fill(dalPhong);
            return dalPhong;
        }

        public DataTable timkiemPhongtrongByloaiphong(string loaiphong)
        {
            string str = string.Format("select * from phong where loaiphong = '{0}' and tinhtrang='{1}'", loaiphong, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalPhong = new DataTable();
            dal.Fill(dalPhong);
            return dalPhong;
        }

        public DataTable timkiemPhongtrongBysonguoitoida(string songuoitoida)
        {
            string str = string.Format("select * from phong where songuoitoida ='{0}' and tinhtrang='{1}'", songuoitoida, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalPhong = new DataTable();
            dal.Fill(dalPhong);
            return dalPhong;
        }

        public DataTable timkiemPhongtrongBytangvaloaiphong(string tang, string loaiphong)
        {
            string str = string.Format("select * from phong where tang='{0}' and loaiphong = '{1}' and tinhtrang='{2}'", tang, loaiphong, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalPhong = new DataTable();
            dal.Fill(dalPhong);
            return dalPhong;
        }

        public DataTable timkiemPhongtrongBytangvasonguoitoida(string tang, string songuoitoida)
        {
            string str = string.Format("select * from phong where tang='{0}' and songuoitoida ='{1}' and tinhtrang='{2}'", tang, songuoitoida, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalPhong = new DataTable();
            dal.Fill(dalPhong);
            return dalPhong;
        }

        public DataTable timkiemPhongtrongByloaiphongvasonguoitoida(string loaiphong, string songuoitoida)
        {
            string str = string.Format("select * from phong where loaiphong = '{0}' and songuoitoida ='{1}' and tinhtrang='{2}'", loaiphong, songuoitoida, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalPhong = new DataTable();
            dal.Fill(dalPhong);
            return dalPhong;
        }

        public DataTable timkiemPhongtrong(string tang, string loaiphong, string songuoitoida)
        {
            string str = string.Format("select * from phong where tang='{0}' and loaiphong = '{1}' and songuoitoida ='{2}' and tinhtrang='{3}'", tang, loaiphong, songuoitoida, 0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalPhong = new DataTable();
            dal.Fill(dalPhong);
            return dalPhong;
        }

        public bool insertPhong(string tenphong, int tang, string loaiphong, int songuoitoida, float dongia, string mota, int tinhtrang)
        {
            string str = string.Format("insert into phong(tenphong, tang, loaiphong, songuoitoida, dongia, mota, tinhtrang) values('N{0}','{1}','{2}','{3}','{4}',N'{5}','{6}')", tenphong, tang, loaiphong, songuoitoida, dongia, mota, tinhtrang);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool updatePhong(long maphong, string tenphong, int tang, string loaiphong, int songuoitoida, float dongia, string mota, int tinhtrang)
        {
            string str = string.Format("update phong set tenphong = N'{0}', tang = '{1}', loaiphong = '{2}', songuoitoida = '{3}', dongia = '{4}', mota = N'{5}', tinhtrang = '{6}' where maphong = '{7}'", tenphong, tang, loaiphong, songuoitoida, dongia, mota, tinhtrang, maphong);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool updateTinhtrangPhong(long maphong, int tinhtrang)
        {
            string str = string.Format("update phong set tinhtrang = '{0}' where maphong = '{1}'", tinhtrang, maphong);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool deletePhong(long maphong)
        {
            string str = string.Format("delete from phong where maphong = '{0}'", maphong);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_THUEKHACHSAN
{
    public class DAL_Thuephong:DBConnection
    {
        public DataTable getListThuephong(int ls)
        {
            string str = string.Format("select mahoadon, tenkhach, thuephong.soCMND, thuephong.maphong, ngaythue, hoten, songuoi, tenphong from thuephong inner join phong on thuephong.maphong = phong.maphong inner join nhanvien on nhanvien.idnhanvien = thuephong.idnhanvienduaphong or nhanvien.idnhanvien = thuephong.idnhanvientraphong where tratien='{0}'",ls);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalThuephong = new DataTable();
            dal.Fill(dalThuephong);
            return dalThuephong;
        }

        public DataTable getThongtinthuephong(long mahoadon)
        {
            string str = string.Format("select mahoadon, tenkhach, thuephong.soCMND, thuephong.maphong, ngaythue, ngaytra, tongtien, hoten, songuoi, tenphong, tang, loaiphong, dongia, idnhanvien " +
                "from thuephong inner join phong on thuephong.maphong = phong.maphong " +
                "inner join nhanvien on nhanvien.idnhanvien = thuephong.idnhanvienduaphong or nhanvien.idnhanvien = thuephong.idnhanvientraphong where mahoadon='{0}'", mahoadon);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalThuephong = new DataTable();
            dal.Fill(dalThuephong);
            return dalThuephong;
        }

        public DataTable timkiemBytenphong(string tenphong, int ls)
        {
            string str = string.Format("select mahoadon, tenkhach, thuephong.soCMND, thuephong.maphong, ngaythue, hoten, songuoi, tenphong from thuephong inner join phong on thuephong.maphong = phong.maphong inner join nhanvien on nhanvien.idnhanvien = thuephong.idnhanvienduaphong or nhanvien.idnhanvien = thuephong.idnhanvientraphong where tratien = '{1}' and tenphong = '{0}'" , tenphong, ls);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalThuephong = new DataTable();
            dal.Fill(dalThuephong);
            return dalThuephong;
        }

        public DataTable timkiemBytenkhach(string tenkhach, int ls)
        {
            string str = string.Format("select mahoadon, tenkhach, thuephong.soCMND, thuephong.maphong, ngaythue, hoten, songuoi, tenphong from thuephong inner join phong on thuephong.maphong = phong.maphong inner join nhanvien on nhanvien.idnhanvien = thuephong.idnhanvienduaphong or nhanvien.idnhanvien = thuephong.idnhanvientraphong where tratien='{1}' and tenkhach like'%{0}%'", tenkhach, ls);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalThuephong = new DataTable();
            dal.Fill(dalThuephong);
            return dalThuephong;
        }
        public DataTable timkiem(string tenphong, string tenkhach, int ls)
        {
            string str = string.Format("select mahoadon, tenkhach, thuephong.soCMND, thuephong.maphong, ngaythue, hoten, songuoi, tenphong from thuephong inner join phong on thuephong.maphong = phong.maphong inner join nhanvien on nhanvien.idnhanvien = thuephong.idnhanvienduaphong or nhanvien.idnhanvien = thuephong.idnhanvientraphong where tratien='{2}' and (tenkhach like'%{0}%' or tenphong = '{1}')",  tenkhach, tenphong,ls);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalThuephong = new DataTable();
            dal.Fill(dalThuephong);
            return dalThuephong;
        }


        public bool insertThuephong(string tenkhach, string soCMND, long maphong, DateTime ngaythue, long idnhanvienduaphong, int songuoi)
        {
            Console.WriteLine(1);
            string str = string.Format("insert into thuephong(tenkhach, soCMND, maphong, ngaythue, tratien, idnhanvienduaphong, songuoi) values(N'{0}','{1}','{2}','{3}','{4}','{5}','{6}')", tenkhach, soCMND, maphong, ngaythue, false, idnhanvienduaphong, songuoi); ;
            Console.WriteLine(2);
            try
            {
                Console.WriteLine(3);
                DAL_Phong dalphong = new DAL_Phong();
                dalphong.updateTinhtrangPhong(maphong, 1);
                Console.WriteLine(4);
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine(5);
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool updateThuephong(string tenkhach, string soCMND, long maphong, DateTime ngaythue, int songuoi, long mahoadon)
        {
            DataTable dalthuephong = getThongtinthuephong(mahoadon);
            long maphongcu = (long)dalthuephong.Rows[0]["maphong"];
            string str = string.Format("update thuephong set tenkhach = N'{0}', soCMND= '{1}', maphong='{2}', ngaythue='{3}', songuoi='{4}' where mahoadon= '{5}'", tenkhach, soCMND, maphong, ngaythue, songuoi, mahoadon);
            try
            {
                DAL_Phong dalphong = new DAL_Phong();

                //doiphong
                if (maphong != maphongcu)
                {
                    dalphong.updateTinhtrangPhong(maphongcu, 2);
                    dalphong.updateTinhtrangPhong(maphong, 1);
                }
                Console.WriteLine(maphong);
                Console.WriteLine(maphongcu);
                
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

        public bool traPhong(long mahoadon, long idnhanvientraphong)
        {
            DataTable dalthuephong = getThongtinthuephong(mahoadon);
            long maphong = (long)dalthuephong.Rows[0]["maphong"];
            string str;
            try
            {
                DAL_Phong dalphong = new DAL_Phong();
                dalphong.updateTinhtrangPhong(maphong, 2);
                int day = DateTime.Now.Subtract(DateTime.Parse(dalthuephong.Rows[0]["ngaythue"].ToString())).Days;
                if (DateTime.Parse(dalthuephong.Rows[0]["ngaythue"].ToString()).Subtract(DateTime.Now).Hours > 1) day++;
                float tongtien = day * float.Parse(dalthuephong.Rows[0]["songuoi"].ToString()) * float.Parse(dalthuephong.Rows[0]["dongia"].ToString());
                str = string.Format("update thuephong set tongtien='{0}', ngaytra='{1}', tratien='{2}', idnhanvientraphong='{3}' where mahoadon='{4}'", tongtien, DateTime.Now,1, idnhanvientraphong, mahoadon);
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

        public bool deleteThuephong(long mahoadon)
        {
            string str = string.Format("delete from thuephong where mahoadon = '{0}'", mahoadon);
            try
            {
                DAL_Phong dalphong = new DAL_Phong();
                DataTable dalthuephong = getThongtinthuephong(mahoadon);
                dalphong.updateTinhtrangPhong((long)dalthuephong.Rows[0]["maphong"], 0);
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

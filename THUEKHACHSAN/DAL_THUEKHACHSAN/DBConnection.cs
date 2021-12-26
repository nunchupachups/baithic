using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_THUEKHACHSAN
{
    public class DBConnection
    {
        public static SqlConnection con = new SqlConnection("server=DESKTOP-2021CPJ;uid=sa;pwd=nghiaoi123;database=QLKHACHSAN");
    }
}

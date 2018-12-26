using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace bkmusic.dal
{
    public class BaiHat
    {
        public DataTable GetList()
        {
            Database.db.ConStr = "Data Source=ETNALO\\SQLEXPRESS;Initial Catalog=bkmusic;Integrated Security=True";
            SqlCommand sqlCmd = new SqlCommand("Select TenBaiHat, TenCaSi from BaiHat, CaSi Where BaiHat.MaCaSi = CaSi.MaCaSi");
            sqlCmd.CommandType = CommandType.Text;
            return Database.db.GetData(sqlCmd);
        }
    }
}

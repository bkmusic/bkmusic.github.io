using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace bkmusic.dal
{
    public class CaSi
    {
        string Con = "Data Source=ETNALO\\SQLEXPRESS;Initial Catalog=bkmusic;Integrated Security=True";

        public DataTable GetList()
        {
            Database.db.ConStr = Con;
            SqlCommand sqlCmd = new SqlCommand("Select * from CaSi");
            sqlCmd.CommandType = CommandType.Text;
            return Database.db.GetData(sqlCmd);
        }

        public DataTable GetListbyMaCaSi(int MaCaSi)
        {
            Database.db.ConStr = Con;
            SqlCommand sqlCmd = new SqlCommand("Select * from CaSi Where MaCaSi=@MaCaSi");
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@MaCaSi", MaCaSi);
            return Database.db.GetData(sqlCmd);
        }

        public void Insert(string TenCaSi, string GioiTinh, String NgaySinh, string MoTa)
        {
            Database.db.ConStr = Con;
            SqlCommand sqlCmd = new SqlCommand("Insert into CaSi(TenCaSi,GioiTinh,NgaySinh,MoTa) Values (@TenCaSi, @GioiTinh, @NgaySinh, @MoTa)");
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@TenCaSi", TenCaSi);
            sqlCmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            sqlCmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            sqlCmd.Parameters.AddWithValue("@MoTa", MoTa);
            Database.db.ExecNonQuery(sqlCmd);
        }

        public void Update(int MaCaSi, string TenCaSi, string GioiTinh, String NgaySinh, string MoTa)
        {
            Database.db.ConStr = Con;
            SqlCommand sqlCmd = new SqlCommand("Update CaSi Set TenCaSi=@TenCaSi, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, MoTa=@MoTa where MaCaSi=@MaCaSi");
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@TenCaSi", TenCaSi);
            sqlCmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            sqlCmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            sqlCmd.Parameters.AddWithValue("@MoTa", MoTa);
            sqlCmd.Parameters.AddWithValue("@MaCaSi", MaCaSi);
            Database.db.ExecNonQuery(sqlCmd);
        }
    }
}

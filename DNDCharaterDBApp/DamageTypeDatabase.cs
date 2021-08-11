using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DNDCharaterDBApp
{
    class DamageTypeDatabase
    {
        public DataTable GetAllDamageTypes() 
        {
            SqlConnection con = DbHelper.GetConnection();

            SqlDataAdapter da = new SqlDataAdapter("select * from DamageType", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

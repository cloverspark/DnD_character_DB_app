using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DNDCharaterDBApp
{
    class ArmorDatabase
    {
        public static List<Armor> GetArmor()
        {
            // Get a connection to the db
            SqlConnection con = DbHelper.GetConnection();

            // cmd is the query 
            SqlCommand cmd = new SqlCommand();

            // sql command
            cmd.CommandText = "SELECT * " +
                              "FROM Armor";

            cmd.Connection = con;

            // Open the connection to the db
            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            List<Armor> armors = new List<Armor>();

            while (rdr.Read())
            {
                Armor temp = new Armor();

                temp.ArmorID = Convert.ToInt32(rdr["ArmorId"]);
                temp.ArmorName = Convert.ToString(rdr["ArmorName"]);

                armors.Add(temp);
            }

            con.Close();

            return armors;
        }
    }
}

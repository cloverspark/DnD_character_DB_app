using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DNDCharaterDBApp
{
    static class DescriptionDatabase
    {
        public static DataTable GetAllDescriptions()
        {
            SqlConnection con = DbHelper.GetConnection();

            SqlDataAdapter da = new SqlDataAdapter("select DescriptionID, HairStyle+', '+HairColor+', '+EyeColor+', '+SkinColor+', '+SkinColor+', '+RaceName as result from [Description]", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void Delete(Description s)
        {
            SqlConnection con = DbHelper.GetConnection();

            string query = "DELETE FROM Description " +
                            "WHERE DescriptionID = @id";
            SqlCommand delCmd = new SqlCommand(query, con);
            delCmd.Parameters.AddWithValue("@id", s.DescriptionID);

            try
            {
                con.Open();

                int rows = delCmd.ExecuteNonQuery();
                if (rows != 1)
                {
                    throw new Exception("A Description was not deleted!");
                }
            }
            catch (SqlException se)
            {
                // Log the error
                throw se;
            }
            finally
            {
                con.Close();
            }
        }
    }
}

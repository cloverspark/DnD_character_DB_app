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
        /// <summary>
        /// grabs all descriptions from data base
        /// </summary>
        /// <returns>a data table with all current descriptions</returns>
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
            // Connect to Database
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
        public static void Add(Description d)
        {
            SqlConnection con = DbHelper.GetConnection();

            // Setup command object (query)
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;
            insertCmd.CommandText =
                "INSERT INTO Description(HairStyle, HairColor, EyeColor, SkinType, SkinColor, RaceName) " +
                "VALUES(@HairStyle, @HairColor, @EyeColor, @SkinType, ,@SkinColor, @RaceName)";
            insertCmd.Parameters.AddWithValue("@HairStyle", d.HairStyle);
            insertCmd.Parameters.AddWithValue("@HairColor", d.HairColor);
            insertCmd.Parameters.AddWithValue("@EyeColor", d.EyeColor);
            insertCmd.Parameters.AddWithValue("@SkinType", d.SkinType);
            insertCmd.Parameters.AddWithValue("@SkinColor", d.SkinColor);
            insertCmd.Parameters.AddWithValue("@RaceName", d.RaceName);
            
            con.Open();

            // Execute command
            insertCmd.ExecuteNonQuery();

            // Close connection
            con.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DNDCharaterDBApp
{
    class CharacterSheetDatabase
    {
        public static DataTable GetAllSheets()
        {
            SqlConnection con = DbHelper.GetConnection();



            SqlDataAdapter da = new SqlDataAdapter("select SheetID , CharacterName +', '+ ClassName as result from CharacterSheet ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void Delete(CharacterSheet s)
        {
            SqlConnection con = DbHelper.GetConnection();

            string query = "DELETE FROM CharacterSheet " +
                            "WHERE SheetID = @id";
            SqlCommand delCmd = new SqlCommand(query, con);
            delCmd.Parameters.AddWithValue("@id", s.SheetID);

            try
            {
                con.Open();

                int rows = delCmd.ExecuteNonQuery();
                if (rows != 1)
                {
                    throw new Exception("A CharacterSheet was not deleted!");
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

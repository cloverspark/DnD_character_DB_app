using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DNDCharaterDBApp
{
    public class CharacterSheetAndDescriptionDB
    {
        public static DataTable GetAllCharacterInfo()
        {
            SqlConnection con = DbHelper.GetConnection();

            SqlDataAdapter da = new SqlDataAdapter("SELECT FROM Description JOIN CharterSheet ON" +
                                                   "Description.DescriptionID = CharterSheet.Description", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

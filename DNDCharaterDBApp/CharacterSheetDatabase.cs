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

            SqlDataAdapter da = new SqlDataAdapter("select SheetID, CharterName, RaceName from CharterSheet , Racewhere CharterSheet.race = Race.RaceID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

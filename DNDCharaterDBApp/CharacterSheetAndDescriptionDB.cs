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
        public static List<CharactorAndDescription> GetAllCharacterInfo()
        {
            SqlConnection con = DbHelper.GetConnection();

            // cmd is the query 
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText =  "SELECT * FROM Description JOIN CharterSheet ON Description.DescriptionID = CharterSheet.Description";

            cmd.Connection = con;

            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            List<CharactorAndDescription> characterList = new List<CharactorAndDescription>();

            while (rdr.Read())
            {
                CharactorAndDescription charactor = new CharactorAndDescription();

                charactor.CharterName = Convert.ToString(rdr["CharterName"]);
                charactor.ClassName = Convert.ToString(rdr["className"]);
                charactor.HairStyle = Convert.ToString(rdr["HairStyle"]);
                charactor.HairColor = Convert.ToString(rdr["HairColor"]);
                charactor.EyeColor = Convert.ToString(rdr["EyeColor"]);
                charactor.SkinType = Convert.ToString(rdr["SkinType"]);
                charactor.SkinColor = Convert.ToString(rdr["SkinColor"]);
                charactor.RaceName = Convert.ToString(rdr["RaceName"]);

                characterList.Add(charactor);
            }

            con.Close();

            return characterList;
        }
    }
}

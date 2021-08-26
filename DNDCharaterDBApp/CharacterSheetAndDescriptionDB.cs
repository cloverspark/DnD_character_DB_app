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

            cmd.CommandText = "SELECT * FROM Description JOIN CharacterSheet ON Description.DescriptionID = CharacterSheet.Description";

            cmd.Connection = con;

            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            List<CharactorAndDescription> characterList = new List<CharactorAndDescription>();

            while (rdr.Read())
            {
                CharactorAndDescription character = new CharactorAndDescription();

                character.SheetID = Convert.ToInt32(rdr["SheetId"]);
                character.DescriptionID = Convert.ToInt32(rdr["DescriptionID"]);
                character.CharacterName = Convert.ToString(rdr["CharacterName"]);
                character.ClassName = Convert.ToString(rdr["className"]);
                character.HairStyle = Convert.ToString(rdr["HairStyle"]);
                character.HairColor = Convert.ToString(rdr["HairColor"]);
                character.EyeColor = Convert.ToString(rdr["EyeColor"]);
                character.SkinType = Convert.ToString(rdr["SkinType"]);
                character.SkinColor = Convert.ToString(rdr["SkinColor"]);
                character.RaceName = Convert.ToString(rdr["RaceName"]);

                characterList.Add(character);
            }

            con.Close();

            return characterList;
        }

        /// <summary>
        /// Update the character in the database
        /// </summary>
        /// <param name="character"></param>
        /// <returns>The number of rows affected. Because it is updating 2 tables the 
        /// total rows affected should be 2</returns>
        public static int UpdateCharacter(CharactorAndDescription character)
        {

            SqlConnection con = DbHelper.GetConnection();

            // cmd is the query 
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE CharacterSheet " +
                              $"SET CharacterName = '{character.CharacterName}', ClassName = '{character.ClassName}' " +
                              $"WHERE SheetID = '{character.SheetID}'";

            cmd.Connection = con;

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            cmd.CommandText = "UPDATE Description  " +
                              $"SET HairStyle = '{character.HairStyle}', HairColor = '{character.HairColor}', EyeColor = '{character.EyeColor}', " +
                              $"SkinType = '{character.SkinType}', SkinColor = '{character.SkinColor}', RaceName = '{character.RaceName}'" +
                              $"WHERE DescriptionID = '{character.DescriptionID}'";

            rows += cmd.ExecuteNonQuery();

            con.Close();

            return rows;

            // Use this for add
            // INSERT INTO Description(HairStyle, HairColor, EyeColor, SkinType, SkinColor, RaceName) " +
            // $"VALUES ({character.HairStyle}, {character.HairColor}, {character.EyeColor}, {character.SkinType}, {character.SkinType}, {character.RaceName})";
        }
    }
}

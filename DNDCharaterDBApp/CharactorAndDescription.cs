using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDCharaterDBApp
{
    /// <summary>
    /// This class is combined with CharacterSheet and Description
    /// </summary>
    public partial class CharactorAndDescription
    {
        public int SheetID { get; set; }
        public string CharterName { get; set; }
        public int Description { get; set; }
        public string ClassName { get; set; }
        public int DescriptionID { get; set; }
        public string HairStyle { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string SkinType { get; set; }
        public string SkinColor { get; set; }
        public string RaceName { get; set; }

        public string GetDisplayText()
        {
            return CharterName;
        }

        public override string ToString()
        {
            return $"{CharterName}, {ClassName}";
        }
    }
}

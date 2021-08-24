using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNDCharaterDBApp
{
    public partial class UpdateCharacterForm : Form
    {
        public UpdateCharacterForm()
        {
            InitializeComponent();
        }

        private void UpdateCharacterForm_Load(object sender, EventArgs e)
        {
            // Get all the Character Sheets and their Descriptions to display on int the list box
            List<CharactorAndDescription> characters = CharacterSheetAndDescriptionDB.GetAllCharacterInfo();

            PopulateCharacterListBx(characters);
        }

        private void CharacterListBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharactorAndDescription character = CharacterListBx.SelectedItem as CharactorAndDescription;

            PopulateTxtBxs(character);
        }

        public void PopulateTxtBxs(CharactorAndDescription character)
        {
            CharacterTxtBx.Text = character.CharterName;
            HairStyleTxtBx.Text = character.HairStyle;
            ClassTxtBx.Text = character.ClassName;
            HairColorTxtBx.Text = character.HairColor;
            EyeColorTxtBx.Text = character.EyeColor;
            SkinTypeTxtBx.Text = character.SkinType;
            SkinColorTxtBx.Text = character.SkinColor;
            RaceNameTxtBx.Text = character.RaceName;
        }

        public void PopulateCharacterListBx(List<CharactorAndDescription> characters)
        {
            foreach (CharactorAndDescription cd in characters)
            {
                CharacterListBx.Items.Add(cd);
            }
        }
    }
}

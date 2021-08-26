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
            CharacterTxtBx.Text = character.CharacterName;
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
            CharacterListBx.Items.Clear();

            foreach (CharactorAndDescription cd in characters)
            {
                CharacterListBx.Items.Add(cd);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                CharactorAndDescription character = new CharactorAndDescription();

                // This character is only used to get the character's SheetID and DescriptionID.
                // Because we do not want the user to change the id's you don't get it form the
                // form you get it from the selected character bacouse all of the info of the
                // Character is stored in the list box
                CharactorAndDescription charecterIDS = (CharactorAndDescription)CharacterListBx.SelectedItem;


                character.SheetID = charecterIDS.SheetID;
                character.DescriptionID = charecterIDS.DescriptionID;
                character.CharacterName = CharacterTxtBx.Text;
                character.HairStyle = HairStyleTxtBx.Text;
                character.ClassName = ClassTxtBx.Text;
                character.HairColor = HairColorTxtBx.Text;
                character.EyeColor = EyeColorTxtBx.Text;
                character.SkinType = SkinTypeTxtBx.Text;
                character.SkinColor = SkinColorTxtBx.Text;
                character.RaceName = RaceNameTxtBx.Text;

                int rows = CharacterSheetAndDescriptionDB.UpdateCharacter(character);

                if(rows == 2)
                {
                    // Get all the Character Sheets and their Descriptions to display on int the list box
                    List<CharactorAndDescription> characters = CharacterSheetAndDescriptionDB.GetAllCharacterInfo();

                    PopulateCharacterListBx(characters);

                    MessageBox.Show($"{character.CharacterName} was successfuly updated!", "Success"
                                    ,MessageBoxButtons.OK
                                    ,MessageBoxIcon.Information);

                    ClearAllTxtBxs();
                }

                else
                {
                    MessageBox.Show("Update Faild", "Error"
                                    ,MessageBoxButtons.OK
                                    ,MessageBoxIcon.Error);
                }
            }
        }

        public void ClearAllTxtBxs()
        {
            CharacterTxtBx.Text = "";
            HairStyleTxtBx.Text = "";
            ClassTxtBx.Text = "";
            HairColorTxtBx.Text = "";
            EyeColorTxtBx.Text = "";
            SkinTypeTxtBx.Text = "";
            SkinColorTxtBx.Text = "";
            RaceNameTxtBx.Text = "";
        }

        public bool IsValid()
        {
            if(CharacterListBx.SelectedItem == null)
            {
                MessageBox.Show("Please Choose a Character to Update", "Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }

            else if (CharacterTxtBx.Text == "")
            {
                
                MessageBox.Show("Please Enter a Character Name", "Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }

            else if (HairStyleTxtBx.Text == "")
            {

                MessageBox.Show("Please Enter a Hair Style", "Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }

            else if (ClassTxtBx.Text == "")
            {

                MessageBox.Show("Please Enter a Character Class", "Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }

            else if (HairColorTxtBx.Text == "")
            {

                MessageBox.Show("Please Enter a Hair Color", "Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }

            else if (EyeColorTxtBx.Text == "")
            {

                MessageBox.Show("Please Enter a Eye Color", "Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }

            else if (SkinTypeTxtBx.Text == "")
            {

                MessageBox.Show("Please Enter a Skin Type", "Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }

            else if (SkinColorTxtBx.Text == "")
            {

                MessageBox.Show("Please Enter a Skin Color", "Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }

            else if (RaceNameTxtBx.Text == "")
            {

                MessageBox.Show("Please Enter a Race", "Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}

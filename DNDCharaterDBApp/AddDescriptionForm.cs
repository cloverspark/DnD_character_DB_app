using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNDCharaterDBApp
{
    public partial class AddDescriptionForm : Form
    {
        public AddDescriptionForm()
        {
            InitializeComponent();
        }

        private void AddDescriptionBtn_Click(object sender, EventArgs e)
        {
            Description d = new Description();
            d.HairStyle = HairStyleTxtBx.Text;
            d.HairColor = HairColorTxtBx.Text;
            d.EyeColor = EyeColorTxtBx.Text;
            d.SkinType = SkinTypeTxtBx.Text;
            d.SkinColor = SkinColorTxtBx.Text;
            d.RaceName = RaceNameTxtBx.Text;

            DescriptionDatabase.Add(d);
            clearTextBox();
        }
        public void clearTextBox() 
        {
            HairStyleTxtBx.Text = "";
            HairColorTxtBx.Text = "";
            EyeColorTxtBx.Text = "";
            SkinTypeTxtBx.Text = "";
            SkinColorTxtBx.Text = "";
            RaceNameTxtBx.Text = "";
        }
    }
}

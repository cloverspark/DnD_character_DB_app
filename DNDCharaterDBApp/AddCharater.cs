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
    public partial class AddCharaterForm : Form
    {
        public AddCharaterForm()
        {
            InitializeComponent();
        }
        public void PopulateCurrentDescriptions()
        {
            DataTable dt = DescriptionDatabase.GetAllDescriptions();
            DescritionCB.DataSource = dt;
            DescritionCB.DisplayMember = nameof(Description.result);
            DescritionCB.ValueMember = nameof(Description.DescriptionID);
            DescritionCB.SelectedIndex = -1;
        }

        private void AddCharaterForm_Load(object sender, EventArgs e)
        {
            PopulateCurrentDescriptions();
        }

        private void AddCharacterBtn_Click(object sender, EventArgs e)
        {
            CharacterSheet cs = new CharacterSheet();
            cs.CharacterName = CharacterNameTxtBx.Text;
            cs.Description = Convert.ToInt32(DescritionCB.SelectedValue);
            cs.ClassName = ClassNameTxtBx.Text;

            CharacterSheetDatabase.Add(cs);
            ClearText();
        }
        public void ClearText() 
        {
            CharacterNameTxtBx.Text = "";
            ClassNameTxtBx.Text = "";
            PopulateCurrentDescriptions();

        }
    }
}

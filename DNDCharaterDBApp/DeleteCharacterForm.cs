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
    public partial class DeleteCharacterForm : Form
    {
        public DeleteCharacterForm()
        {
            InitializeComponent();
        }
        private void DeleteCharacterForm_Load(object sender, EventArgs e)
        {
            PopulateCurrentCharacterSheets();
            PopulateCurrentDescriptions();
        }
        public void PopulateCurrentCharacterSheets()
        {
            DataTable dt = CharacterSheetDatabase.GetAllSheets();
            CharacterSheetCB.DataSource = dt;
            CharacterSheetCB.DisplayMember = nameof(CharaterSheet.result);
            CharacterSheetCB.ValueMember = nameof(CharaterSheet.SheetID);
            CharacterSheetCB.SelectedIndex = -1;
        }
        public void PopulateCurrentDescriptions() 
        {
            DataTable dt = DescriptionDatabase.GetAllDescriptions();
            DescritionCB.DataSource = dt;
            DescritionCB.DisplayMember = nameof(Description.result);
            DescritionCB.ValueMember = nameof(Description.DescriptionID);
            DescritionCB.SelectedIndex = -1;
        }

        private void CharacterDeleteBtn_Click(object sender, EventArgs e)
        {
            CharaterSheet cs = new CharaterSheet();
            cs.SheetID = Convert.ToInt32(CharacterSheetCB.SelectedValue);
            CharacterSheetDatabase.Delete(cs);
            PopulateCurrentCharacterSheets();
        }

        private void DescriptionDeleteBtn_Click(object sender, EventArgs e)
        {
            Description d = new Description();
            d.DescriptionID = Convert.ToInt32(DescritionCB.SelectedValue);

            DescriptionDatabase.Delete(d);
            PopulateCurrentDescriptions();
        }
    }
}

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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteCharacterForm_Load(object sender, EventArgs e)
        {
            PopulateCurrentCharacterSheets();
        }
        public void PopulateCurrentCharacterSheets()
        {
            DataTable dt = CharacterSheetDatabase.GetAllSheets();
            CharacterSheetCB.DataSource = dt;
            CharacterSheetCB.DisplayMember = nameof(CharaterSheet.result);
            CharacterSheetCB.ValueMember = nameof(CharaterSheet.SheetID);
            CharacterSheetCB.SelectedIndex = -1;
        }
    }
}

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
    public partial class UpdateCharacterForm : Form
    {
        public UpdateCharacterForm()
        {
            InitializeComponent();
        }

        private void UpdateCharacterForm_Load(object sender, EventArgs e)
        {
            DataTable characters = CharacterSheetDatabase.GetAllSheets();

            CharacterListBx.Items.Add(characters.Rows.ToString());
        }
    }
}

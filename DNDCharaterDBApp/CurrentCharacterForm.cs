using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DNDCharaterDBApp
{
    public partial class CurrentCharacterForm : Form
    {
        public CurrentCharacterForm()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void PopulateCurrentCharacterSheets() 
        {
            DataTable dt = CharacterSheetDatabase.GetAllSheets();
            CharacterSheetCB.DataSource = dt;
            CharacterSheetCB.DisplayMember = nameof(CharterSheet.CharterName);
            CharacterSheetCB.ValueMember = nameof(CharterSheet.SheetID);
            CharacterSheetCB.SelectedIndex = -1; 
        }

        private void CurrentCharacterForm_Load(object sender, EventArgs e)
        {
            PopulateCurrentCharacterSheets();
            
        }
    }
}

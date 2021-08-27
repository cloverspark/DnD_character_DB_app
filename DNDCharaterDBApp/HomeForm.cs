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
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCharacterForm UCF = new UpdateCharacterForm();
            UCF.ShowDialog();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteCharacterForm DCF = new DeleteCharacterForm();
            DCF.ShowDialog();
        }

        private void CurrentBtn_Click(object sender, EventArgs e)
        {
            CurrentCharacterForm CCF = new CurrentCharacterForm();
            CCF.ShowDialog();
        }

        private void AddCharacterBtn_Click(object sender, EventArgs e)
        {
            AddCharaterForm ACF = new AddCharaterForm();
            ACF.ShowDialog();
        }

        private void AddDescriptionBtn_Click(object sender, EventArgs e)
        {
            AddDescriptionForm ADF = new AddDescriptionForm();
            ADF.ShowDialog();
        }
    }
}

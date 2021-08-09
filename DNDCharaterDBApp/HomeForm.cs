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
            UpdateCharaterForm UCF = new UpdateCharaterForm();
            UCF.ShowDialog();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteCharaterForm DCF = new DeleteCharaterForm();
            DCF.ShowDialog();
        }

        private void CurrentBtn_Click(object sender, EventArgs e)
        {
            CurrentCharatersForm DCF = new CurrentCharatersForm();
            DCF.ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddCharaterForm ACF = new AddCharaterForm();
            ACF.ShowDialog();
        }
    }
}

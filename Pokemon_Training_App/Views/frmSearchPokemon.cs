using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Training_App.Views
{
    public partial class frmSearchPokemon : Form
    {
        public frmSearchPokemon()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // clsoe this window
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // validate inputs
            // construct query
            // query database
            // open frmSearchResult with query results
            frmSearchResultPokemon form = new frmSearchResultPokemon();
            form.Show();
        }

        private void radNumber_CheckedChanged(object sender, EventArgs e)
        {
            // check if is checked
            if (radNumber.Checked)
            {
                // disable pokemon name controls
                txtPokemonName.Enabled = false;
                slblPokemonName.Enabled = false;

                // enable pokemon number controls
                txtPokemonNum.Enabled = true;
                slblPokemonNum.Enabled = true;

                // set focus to pokemon number textbox
                txtPokemonNum.Focus();

                // clear pokemon name textbox
                txtPokemonName.Clear();
            }
        }

        private void radName_CheckedChanged(object sender, EventArgs e)
        {
            // check if is checked
            if (radName.Checked)
            {
                // disable pokemon number controls
                txtPokemonNum.Enabled = false;
                slblPokemonNum.Enabled = false;

                // enable pokemon name controls
                txtPokemonName.Enabled = true;
                slblPokemonName.Enabled = true;

                // set focus to pokemon name textbox
                txtPokemonName.Focus();

                // clear pokemon number textbox
                txtPokemonNum.Clear();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokemon_Training_App.Classes;

namespace Pokemon_Training_App.Views
{
    public partial class frmAddPokemon : System.Windows.Forms.Form
    {
        public frmAddPokemon()
        {
            InitializeComponent();
        }

        /*** HELPERS ***/
        private bool InputsValid()
        {
            // check number values are positive
            foreach (NumericUpDown numericUpDown in this.Controls.OfType<NumericUpDown>())
            {
                if (numericUpDown.Value < 0)
                {
                    return false;
                }
            }

            // check pokename is not null or empty
            if (String.IsNullOrEmpty(txtPokemonName.Text))
            {
                return false;
            }

            // valid
            return true;
        }

        /*** EVENTS ***/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // validate data,
            if (InputsValid())
            {
                // do insert
                try
                {
                    pokemonTableAdapter.Insert((int)numPokeNum.Value, txtPokemonName.Text);
                    pokemonTableAdapter.Update(pokemonDataSet);
                    MessageBox.Show("Successful operation!", "Success", MessageBoxButtons.OK);
                } catch
                {
                    MessageBox.Show("There was a problem with the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else
            {
                // display error message
                MessageBox.Show("Invalid Inputs", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // set number values to 1
            foreach (NumericUpDown numericUpDown in this.Controls.OfType<NumericUpDown>())
            {
                numericUpDown.Value = 1;
            }

            // clear text from name textbox
            txtPokemonName.Clear();

            // focus on pokemon number input
            numPokeNum.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close this window
            this.Close();
        }
    }
}

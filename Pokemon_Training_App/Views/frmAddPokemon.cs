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

            // check textboxes are not empty
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                if (String.IsNullOrEmpty(textBox.Text))
                {
                    return false;
                }
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
                    // add pokemon data
                    pokemonTableAdapter.Insert((int)numPokeNum.Value, txtPokemonName.Text);

                    // add form data
                    formsTableAdapter.InsertForm((int)numPokeNum.Value, txtFormName.Text, (int)numBaseHealth.Value, (int)numBaseAttack.Value, (int)numBaseDefense.Value, (int)numBaseSpAttack.Value, (int)numBaseSpDefense.Value, (int)numBaseSpeed.Value);

                    MessageBox.Show("Successful operation!", "Success", MessageBoxButtons.OK);
                } catch
                {
                    MessageBox.Show("There was a problem with the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // prepare inputs for new entry
                numPokeNum.Value++;
                txtPokemonName.Clear();
                txtPokemonName.Focus();
                txtFormName.Text = "default";
            }
            else
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

            // set form name to 'default'
            txtFormName.Text = "default";

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

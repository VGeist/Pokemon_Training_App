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

        /*** EVENTS ***/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // get errors
            string[] pokeErrors = Pokemon.GetErrors((int)numPokeNum.Value, txtPokemonName.Text);
            string[] formErrors = PokeForm.GetErrors(txtFormName.Text, (int)numBaseHealth.Value, (int)numBaseAttack.Value, (int)numBaseDefense.Value, (int)numBaseSpAttack.Value, (int)numBaseSpDefense.Value, (int)numBaseSpeed.Value);

            // put errors into one list
            string[] errors = new string[pokeErrors.Length + formErrors.Length];
            pokeErrors.CopyTo(errors, 0);
            formErrors.CopyTo(errors, pokeErrors.Length);

            // check for errors
            if (errors.Length == 0)
            {
                // no errors, do insert
                try
                {
                    // add pokemon data
                    pokemonTableAdapter.Insert((int)numPokeNum.Value, txtPokemonName.Text);

                    // add form data
                    formsTableAdapter.InsertForm((int)numPokeNum.Value, txtFormName.Text, (int)numBaseHealth.Value, (int)numBaseAttack.Value, (int)numBaseDefense.Value, (int)numBaseSpAttack.Value, (int)numBaseSpDefense.Value, (int)numBaseSpeed.Value);

                    MessageBox.Show(txtPokemonName.Text + " successfully added!", "Success", MessageBoxButtons.OK);
                } catch
                {
                    MessageBox.Show("There was a problem with the database. Check that the Pokemon you tried to enter is not already in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // prepare inputs for new entry; only add if not at max input value
                if (numPokeNum.Value < numPokeNum.Maximum)
                {
                    numPokeNum.Value++;
                }

                txtPokemonName.Clear();
                txtPokemonName.Focus();
                txtFormName.Text = "default";
            }
            else
            {
                // errors found, create and display error message
                string errorMsg = Program.buildErrorListMessage(errors);
                MessageBox.Show(errorMsg, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            // close this window
            this.Close();
        }

        private void NumUpDown_Enter(object sender, EventArgs e)
        {
            // event only for numericUpDown controls
            NumericUpDown numeric = (NumericUpDown)sender;
            numeric.Select(0, numeric.Text.Length); // NOTE: Text property is hidden by IntelliSense for NumericUpDown objects :(
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            // event only for textBox controls
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }
    }
}

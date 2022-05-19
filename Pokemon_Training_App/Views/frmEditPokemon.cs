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
    public partial class frmEditPokemon : Form
    {
        int PokeNum;

        public frmEditPokemon(int pokeNum)
        {
            InitializeComponent();

            // set PokeNum field and display
            PokeNum = pokeNum;
            lblPokeNum.Text = "#" + pokeNum.ToString();
        }

        /*** HELPERS ***/

        /*** EVENTS ***/
        private void frmEditPokemon_Load(object sender, EventArgs e)
        {
            try
            {
                this.pokemonTableAdapter.FillByPokeNum(this.pokemonDataSet.Pokemon, PokeNum);
            } 
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:" + Environment.NewLine + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string[] errors = Pokemon.GetErrors(PokeNum, txtPokemonName.Text);

            if (errors.Length == 0)
            {
                // no errors, do update
                try
                {
                    string newName = txtPokemonName.Text;

                    // update the Pokemon
                    this.pokemonTableAdapter.UpdatePokemon(PokeNum, newName);

                    // success message
                    MessageBox.Show("Succesfully updated " + newName + "!", "Success", MessageBoxButtons.OK);

                    this.Close();
                } catch (Exception ex)
                {
                    // exception message
                    MessageBox.Show("A problem occured:" + Environment.NewLine + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                // errors, build message and display
                string errorMsg = Program.buildErrorListMessage(errors);
                MessageBox.Show(errorMsg, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // show confirmation message
            DialogResult confirm = MessageBox.Show("Are you sure? Data can not be recovered.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // delete the Pokemon
                    this.pokemonTableAdapter.DeletePokemon(PokeNum);

                    this.Close();
                } catch
                {
                    // exception message
                    MessageBox.Show("A problem occured. NOTE: All partners and forms that use this pokemon need to be deleted before deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        private void txtPokemonName_Enter(object sender, EventArgs e)
        {
            txtPokemonName.SelectAll();
        }
    }
}

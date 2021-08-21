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
        private bool InputsValid()
        {
            // check that pokeName input is valid
            if (String.IsNullOrEmpty(txtPokemonName.Text))
            {
                // invalid
                return false;
            }

            return true;
        }

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
            if (InputsValid())
            {
                try
                {
                    string newName = txtPokemonName.Text;

                    // update the Pokemon
                    this.pokemonTableAdapter.UpdatePokemon(PokeNum, newName);

                    this.Close();
                } catch (Exception ex)
                {
                    // exception message
                    MessageBox.Show("A problem occured: " + Environment.NewLine + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                // invalid message
                MessageBox.Show("Invalid inputs.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (InputsValid())
            {
                try
                {
                    // delete the Pokemon
                    this.pokemonTableAdapter.DeletePokemon(PokeNum);

                    this.Close();
                } catch (Exception ex)
                {
                    // exception message
                    MessageBox.Show("A problem occured: " + Environment.NewLine + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // invalid message
                MessageBox.Show("Invalid inputs.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}

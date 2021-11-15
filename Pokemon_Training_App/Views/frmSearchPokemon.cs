using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokemon_Training_App.Data;

namespace Pokemon_Training_App.Views
{
    public partial class frmSearchPokemon : Form
    {
        public PokemonFilter Filter;

        public frmSearchPokemon()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // validate value
            if (radNumber.Checked)
            {
                // searching by Number
                // check if valid
                if(isPokeNumValid())
                {
                    // set filter and dialog result
                    Filter = PokemonFilter.Number;
                    this.DialogResult = DialogResult.OK;

                    this.Close();
                }
            } else
            {
                // searching by Name
                // check if valid
                if (isPokeNameValid())
                {
                    // set filter and dialog result
                    Filter = PokemonFilter.Name;
                    this.DialogResult = DialogResult.OK;

                    this.Close();
                }
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            // set filter and dialog result to none
            Filter = PokemonFilter.None;
            this.DialogResult = DialogResult.OK;

            this.Close();
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
                numPokeNum.Enabled = true;
                slblPokemonNum.Enabled = true;

                // set focus to pokemon number textbox
                numPokeNum.Focus();

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
                numPokeNum.Enabled = false;
                slblPokemonNum.Enabled = false;

                // enable pokemon name controls
                txtPokemonName.Enabled = true;
                slblPokemonName.Enabled = true;

                // set focus to pokemon name textbox
                txtPokemonName.Focus();

                // set number to 1
                numPokeNum.Value = 1;
            }
        }

        private bool isPokeNumValid()
        {
            // check if the number is positive
            if (numPokeNum.Value < 0)
            {
                // value is negative, invalid
                MessageBox.Show("Number must be greater than zero.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool isPokeNameValid()
        {
            // check if null or empty
            if (String.IsNullOrEmpty(txtPokemonName.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else
            {
                return true;
            }
        }

        public string getNameText()
        {
            return txtPokemonName.Text;
        }

        public int getNumberValue()
        {
            return (int)numPokeNum.Value; // removes any decimal value
        }
    }
}
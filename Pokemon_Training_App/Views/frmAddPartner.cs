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
    public partial class frmAddPartner : Form
    {
        public frmAddPartner()
        {
            InitializeComponent();
        }
        
        /*** HELPERS ***/
        private bool combosSelected()
        {
            bool isValid = true;

            // check all comboboxes for a selected item
            foreach (ComboBox comboBox in this.Controls.OfType<ComboBox>())
            {
                if (comboBox.SelectedIndex == -1)
                {
                    // no item selected
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        /*** EVENTS ***/
        private void btnAddForm_Click(object sender, EventArgs e)
        {
            // check that a pokemon is selected
            if (cmbPokeNum.SelectedIndex > -1)
            {
                // a pokemon is selected, open frmAddForm as a modal window
                frmAddForm form = new frmAddForm((int)cmbPokeNum.SelectedValue);
                form.ShowDialog();
            } else
            {
                // no pokemon selected, error message and focus on control
                MessageBox.Show("You need to select a pokemon from the dropdown list.", "Please select a Pokemon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbPokeNum.Focus();
            }
        }

        private Partner buildPartner()
        {

            // build partner
            Pokemon species = new Pokemon();
            Partner partner = new Partner(species);

            // Info
            partner.PokeNumber = (int)cmbPokeNum.SelectedValue;
            partner.Nickname = txtNickname.Text;
            partner.Level = (int)numLevel.Value;

            // Stats
            partner.Health = (int)numHealthStat.Value;
            partner.Attack = (int)numAttackStat.Value;
            partner.Defense = (int)numDefenseStat.Value;
            partner.SpAttack = (int)numSpAttackStat.Value;
            partner.SpDefense = (int)numSpDefenseStat.Value;
            partner.Speed = (int)numSpeedStat.Value;

            // EVs
            partner.HealthEV = (int)numHealthEV.Value;
            partner.AttackEV = (int)numAttackEV.Value;
            partner.DefenseEV = (int)numDefenseEV.Value;
            partner.SpAttackEV = (int)numSpAttackEV.Value;
            partner.SpDefenseEV = (int)numSpDefenseEV.Value;
            partner.SpeedEV = (int)numSpeedEV.Value;

            return partner;
        }

        // TODO: implement add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check combo boxes have a selected value
            if (!combosSelected())
            {
                // ask user to select values, do not continue
                MessageBox.Show("Check that you have selected an item in each dropdown list.", "Form Not Filled Out", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Partner partner = buildPartner();

            // find errors
            string[] errors = partner.GetErrors();

            // display success or faliure message
            if (errors.Length == 0)
            {
                // no errors, add to database
            } else
            {
                // errors found, display message
                string errorMsg = Program.buildErrorListMessage(errors);
                MessageBox.Show(errorMsg, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // TODO: redo this method to work with new control types

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close window
            this.Close();
        }

        private void frmAddPartner_Load(object sender, EventArgs e)
        {
            try
            {
                // get data
                pokemonTableAdapter.Fill(pokemonDataSet.Pokemon);

                // check if there are pokeomn in the database
                if (pokemonDataSet.Pokemon.Count == 0)
                {
                    // no pokemon in database, ask to create new pokemon
                    DialogResult dialogResult = MessageBox.Show(
                        "No pokemon found in the database. " +  // message start
                        "At least one pokemon is needed before partners can be created."
                        + Environment.NewLine +
                        "Would you like to create one now?",    // message end
                        "No Pokemon",   /* caption */
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // open frmAddPokemon
                        frmAddPokemon redirect = new frmAddPokemon();
                        redirect.ShowDialog();
                    }

                    // close form, DO NOT CONTINUE FROM THIS POINT (use return)
                    this.Close();
                    return;
                }

                naturesTableAdapter.Fill(pokemonDataSet.Natures);
                formsTableAdapter.Fill(pokemonDataSet.Forms);

                cmbPokeNum.SelectedIndex = 0; // should never be out of range 
            } catch
            {
                // TODO: add exception handling for database errors
                this.Close();
            }
            
        }
    }
}

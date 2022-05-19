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
using Pokemon_Training_App.Data;

namespace Pokemon_Training_App.Views
{
    public partial class frmEditPartner : Form
    {
        int PartnerID;

        public frmEditPartner(int id)
        {
            InitializeComponent();

            PartnerID = id;
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

        private PokeForm getForm()
        {
            // gets currently selected form
            int formID = (int)cmbForm.SelectedValue;
            PokemonDataSet.FormsRow row = null;
            try
            {
                row = formsTableAdapter.GetFormByID(formID).First();
            }
            catch (Exception e)
            {
                MessageBox.Show("Database error occured:" + Environment.NewLine + e.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return new PokeForm(-1, -1, -1, -1, -1, -1, -1);
            }

            PokeForm pokeForm = new PokeForm(formID, row.BaseHealth, row.BaseAttack, row.BaseDefense, row.BaseSpAttack, row.BaseSpDefense, row.BaseSpeed, row.Name);
            return pokeForm;
        }

        private string[] getNatureBonusAndMalus()
        {
            // returns string arry { nameOfStatWithbonus, nameOfStatWithMalus }
            string name = cmbNature.Text;
            PokemonDataSet.NaturesRow row = null;

            try
            {
                row = naturesTableAdapter.GetNatureByName(name).First();
            }
            catch (Exception e)
            {
                MessageBox.Show("Database error occured:" + Environment.NewLine + e.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return new string[] { "", "" };
            }

            return new string[] { row.StatBonus, row.StatMalus };
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
            partner.HasPokerus = chkHasPokerus.Checked;

            // Nature
            string[] natureBonusAndMalus = getNatureBonusAndMalus();
            partner.ChangeNature(cmbNature.SelectedText, natureBonusAndMalus[0], natureBonusAndMalus[1]);

            // Form
            partner.Form = getForm();

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

        /*** EVENTS ***/
        private void frmEditPartner_Load(object sender, EventArgs e)
        {
            // get natures into combo box
            this.naturesTableAdapter.Fill(this.pokemonDataSet.Natures);
            // get forms into combo box
            this.formsTableAdapter.Fill(this.pokemonDataSet.Forms);
            // get pokemon into combo box
            this.pokemonTableAdapter.Fill(this.pokemonDataSet.Pokemon);
            // set control values
            this.partnersTableAdapter.FillByPartnerID(this.pokemonDataSet.Partners, PartnerID);
            
            // TODO: investigate why EV values are set to 0 unless tpgEV becomes the SelectedTab
            /* iterate through the tabs of tabStats, this ensures that values in the database
             * are properly set to the corresponding field. Unknown cause.
            */
            tabStats.SelectedTab = tpgEV;
            tabStats.SelectedTab = tpgStats;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // check combo boxes have a selected value
            if (!combosSelected())
            {
                // ask user to select values, do not continue
                MessageBox.Show("Check that you have selected an item in each dropdown list.", "Form Not Filled Out", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // create a partner object to get errors
            Partner partner = buildPartner();
            string[] errors = partner.GetErrors();

            string[] statErrors = partner.GetStatErrors();

            // display success or faliure message
            if (errors.Length == 0)
            {
                // check for stat errors
                if (statErrors.Count() > 0)
                {
                    // errors exist; build message and display
                    string statErrorsMsg = "These stats are out of range:";
                    for (int i = 0; i < statErrors.Length; i++)
                    {
                        statErrorsMsg += Environment.NewLine + statErrors[i];
                    }

                    statErrorsMsg += Environment.NewLine + "Do you want to save anyway?";

                    // ask user if invalid stats are ok
                    DialogResult dialogResult = MessageBox.Show(statErrorsMsg, partner.Nickname + " | Unexpected Stat Values", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.No)
                    {
                        // do not save
                        return;
                    }
                }

                // no errors, add to database
                try
                {
                    // update database
                    this.partnersTableAdapter.UpdatePartnerByID(
                        PartnerID, 
                        partner.Nickname,
                        partner.PokeNumber,
                        (int)cmbForm.SelectedValue,
                        (int)cmbNature.SelectedValue,
                        partner.Level,
                        partner.HasPokerus,
                        partner.Health,     // stat start
                        partner.Attack,
                        partner.Defense,
                        partner.SpAttack,
                        partner.SpDefense,
                        partner.Speed,      // stat end
                        partner.HealthEV,   // ev start
                        partner.AttackEV,
                        partner.DefenseEV,
                        partner.SpAttackEV,
                        partner.SpDefenseEV,
                        partner.SpeedEV);

                    // success message
                    MessageBox.Show("Successfully updated " + partner.Nickname + "?", "Success", MessageBoxButtons.OK);

                    // close form
                    this.Close();
                }
                catch
                {
                    // database error 
                    MessageBox.Show("The database encounterd an error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // errors found, display message
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
                    // delete the Partner
                    this.partnersTableAdapter.DeletePartnerByID(PartnerID);

                    // if the partner is in the paty, remove it
                    if (Party.containsPartner(PartnerID))
                    {
                        Party.removeMemberByID(PartnerID);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    // exception message
                    MessageBox.Show("A problem occured: " + Environment.NewLine + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            // check that a pokemon is selected
            if (cmbPokeNum.SelectedIndex > -1)
            {
                // a pokemon is selected, open frmAddForm as a modal window
                frmAddForm form = new frmAddForm((int)cmbPokeNum.SelectedValue);
                form.ShowDialog();
                formsTableAdapter.Fill(pokemonDataSet.Forms);
            }
            else
            {
                // no pokemon selected, error message and focus on control
                MessageBox.Show("You need to select a pokemon from the dropdown list.", "Please select a Pokemon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbPokeNum.Focus();
            }
        }

        private void NumUpDown_Enter(object sender, EventArgs e)
        {
            // event only for numericUpDown controls
            NumericUpDown numeric = (NumericUpDown)sender;
            numeric.Select(0, numeric.Text.Length); // NOTE: Text property is hidden by IntelliSense for NumericUpDown objects :(
        }

        private void txtNickname_TextChanged(object sender, EventArgs e)
        {
            txtNickname.SelectAll();
        }
    }
}
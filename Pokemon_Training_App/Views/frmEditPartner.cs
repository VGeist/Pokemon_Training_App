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

            // display success or faliure message
            if (errors.Length == 0)
            {
                // no errors, add to database
                try
                {
                    // update database
                    this.partnersTableAdapter.UpdatePartnerByID(
                        PartnerID,
                        txtNickname.Text,
                        (int)cmbPokeNum.SelectedValue,
                        (int)cmbForm.SelectedValue,
                        (int)cmbNature.SelectedValue,
                        (int)numLevel.Value,
                        chkHasPokerus.Checked,
                        (int)numHealthStat.Value,
                        (int)numAttackStat.Value,
                        (int)numDefenseStat.Value,
                        (int)numSpAttackStat.Value,
                        (int)numSpDefenseStat.Value,
                        (int)numSpeedStat.Value,
                        (int)numHealthEV.Value,
                        (int)numAttackEV.Value,
                        (int)numDefenseEV.Value,
                        (int)numSpAttackEV.Value,
                        (int)numSpDefenseEV.Value,
                        (int)numSpeedEV.Value);

                    // success message
                    MessageBox.Show("Successful operation", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}

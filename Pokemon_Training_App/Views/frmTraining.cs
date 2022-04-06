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
    public partial class frmTraining : Form
    {
        public frmTraining()
        {
            InitializeComponent();
        }

        /** BACKING FIELDS **/
        private Partner[] _trainingData = new Partner[6];

        /** HELPERS **/
        private void displaySlotData(int slotNum)
        {
            // check slot for partner
            if (_trainingData[slotNum] != null)
            {
                // set values
                Partner partner = _trainingData[slotNum];

                // IMPORTANT!!!! IF CONTROL NAMES ARE CHANGED ADJUSTMENTS TO BELOW CODE WOULD BE NEEDED
                tlpMembersTable.Controls["lblNickname" + slotNum].Text =        partner.Nickname;
                tlpMembersTable.Controls["picInfected" + slotNum].Visible =     partner.HasPokerus;
                tlpMembersTable.Controls["lblHealthEV" + slotNum].Text =        partner.HealthEV.ToString();
                tlpMembersTable.Controls["lblAttackEV" + slotNum].Text =        partner.AttackEV.ToString();
                tlpMembersTable.Controls["lblDefenseEV" + slotNum].Text =       partner.DefenseEV.ToString();
                tlpMembersTable.Controls["lblSpAttackEV" + slotNum].Text =      partner.SpAttackEV.ToString();
                tlpMembersTable.Controls["lblSpDefenseEV" + slotNum].Text =     partner.SpDefenseEV.ToString();
                tlpMembersTable.Controls["lblSpeedEV" + slotNum].Text =         partner.SpeedEV.ToString();
                tlpMembersTable.Controls["lblTotalEV" + slotNum].Text =         partner.TotalEVs().ToString();

                // ENABLE the slot controls
                tlpMembersTable.Controls["chkDoTrainingPokemon" + slotNum].Enabled = true;
                tlpMembersTable.Controls["lblNickname" + slotNum].Enabled = true;
                tlpMembersTable.Controls["picInfected" + slotNum].Enabled = true;
                tlpMembersTable.Controls["cmbHeldItem" + slotNum].Enabled = true; 
                tlpMembersTable.Controls["lblHealthEV" + slotNum].Enabled = true;
                tlpMembersTable.Controls["lblAttackEV" + slotNum].Enabled = true;
                tlpMembersTable.Controls["lblDefenseEV" + slotNum].Enabled = true;
                tlpMembersTable.Controls["lblSpAttackEV" + slotNum].Enabled = true;
                tlpMembersTable.Controls["lblSpDefenseEV" + slotNum].Enabled = true;
                tlpMembersTable.Controls["lblSpeedEV" + slotNum].Enabled = true;
                tlpMembersTable.Controls["lblTotalEV" + slotNum].Enabled = true;
            } else
            {
                displaySlotDefault(slotNum);
            }
        }

        private void displaySlotDefault(int slotNum)
        {
            CheckBox checkBox = (CheckBox)tlpMembersTable.Controls["chkDoTrainingPokemon" + slotNum];

            // sets a slot to display as empty
            tlpMembersTable.Controls["lblNickname" + slotNum].Text =        "-- EMPTY --";
            tlpMembersTable.Controls["picInfected" + slotNum].Visible =     false;
            tlpMembersTable.Controls["lblHealthEV" + slotNum].Text =        "--";
            tlpMembersTable.Controls["lblAttackEV" + slotNum].Text =        "--";
            tlpMembersTable.Controls["lblDefenseEV" + slotNum].Text =       "--";
            tlpMembersTable.Controls["lblSpAttackEV" + slotNum].Text =      "--";
            tlpMembersTable.Controls["lblSpDefenseEV" + slotNum].Text =     "--";
            tlpMembersTable.Controls["lblSpeedEV" + slotNum].Text =         "--";
            tlpMembersTable.Controls["lblTotalEV" + slotNum].Text =         "--";

            // DISABLE the slot controls
            checkBox.Enabled = false;
            tlpMembersTable.Controls["lblNickname" + slotNum].Enabled = false;
            tlpMembersTable.Controls["picInfected" + slotNum].Enabled = false;
            tlpMembersTable.Controls["cmbHeldItem" + slotNum].Enabled = false;
            tlpMembersTable.Controls["lblHealthEV" + slotNum].Enabled = false;
            tlpMembersTable.Controls["lblAttackEV" + slotNum].Enabled = false;
            tlpMembersTable.Controls["lblDefenseEV" + slotNum].Enabled = false;
            tlpMembersTable.Controls["lblSpAttackEV" + slotNum].Enabled = false;
            tlpMembersTable.Controls["lblSpDefenseEV" + slotNum].Enabled = false;
            tlpMembersTable.Controls["lblSpeedEV" + slotNum].Enabled = false;
            tlpMembersTable.Controls["lblTotalEV" + slotNum].Enabled = false;

            // deselect slot
            checkBox.Checked = false;
        }

        private Partner getPartnerDataForSlot(int slotNum)
        {
            Partner partner = null;
            int id = Party.getIDBySlot(slotNum);
            if (id > -1)
            {
                // slot not empty, get data
                partner = getPartnerData(id);
            }

            return partner;
        }

        private Partner getPartnerData(int id)
        {
            // get partner from database by ID
            PokemonDataSet.PartnersRow partnersRow;
            PokemonDataSet.NaturesRow naturesRow;
            PokemonDataSet.FormsRow formsRow;

            Partner partner;

            try
            {
                // database queries
                partnersRow = partnersTableAdapter.GetDataByPartnerID(id).First();
                naturesRow = naturesTableAdapter.GetNatureByName(partnersRow.NatureName).First();
                formsRow = formsTableAdapter.GetFormByID(partnersRow.FormID).First();

                partner = buildPartner(partnersRow, naturesRow, formsRow);
            } catch
            {
                MessageBox.Show("Database error occured.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Pokemon species = new Pokemon();
                species.PokeName = "default";
                species.PokeNumber = -1;

                partner = new Partner(species);
            }

            return partner;
        }

        private Partner buildPartner(PokemonDataSet.PartnersRow partnersRow, PokemonDataSet.NaturesRow naturesRow, PokemonDataSet.FormsRow formsRow)
        {
            // determine favored/hindered stat
            string statBonus = naturesRow.StatBonus;
            string statMalus = naturesRow.StatBonus;

            // Form Data
            PokeForm form = new PokeForm(
                formsRow.FormID,
                formsRow.BaseHealth,
                formsRow.BaseAttack,
                formsRow.BaseDefense,
                formsRow.BaseSpAttack,
                formsRow.BaseSpDefense,
                formsRow.BaseSpeed,
                formsRow.Name
                );

            // Species data
            Pokemon species = new Pokemon();

            species.PokeNumber = partnersRow.PokeNum;
            species.PokeName = partnersRow.PokeName;

            Partner partner = new Partner(species,
                partnersRow.Nickname,
                partnersRow.Level,
                partnersRow.NatureName,
                statBonus,
                statMalus,
                partnersRow.HasPokerus,

                // Stats
                partnersRow.Health,
                partnersRow.Attack,
                partnersRow.Defense,
                partnersRow.SpAttack,
                partnersRow.SpDefense,
                partnersRow.Speed,

                // EVs
                partnersRow.EVHealth,
                partnersRow.EVAttack,
                partnersRow.EVDefense,
                partnersRow.EVSpAttack,
                partnersRow.EVSpDefense,
                partnersRow.EVSpeed
                );

            partner.Form = form;

            return partner;
        }

        private void trainSelected()
        {
            // IMPORTANT: Changes to control names may cause errors!!!
            // determine which slots are selected
            for (int slot = 0; slot < _trainingData.Length; slot++)
            {
                // get checkbox
                CheckBox chkBox = (CheckBox)tlpMembersTable.Controls["chkDoTrainingPokemon" + slot];
                if (chkBox.Checked)
                {
                    Partner partner = _trainingData[slot];

                    int initialTotalEVs = partner.TotalEVs();

                    // check if already at max 
                    if (initialTotalEVs == 510)
                    {
                        // Total is greater than 510 maximum; notify user and go to next partner
                        MessageBox.Show(partner.Nickname + " has reached peak performance and can no longer gain EVs!", "Total EVs at maximum");
                        continue;
                    }

                    // get gains
                    int healthGain = (int)numHealthEV.Value;
                    int attackGain = (int)numAttackEV.Value;
                    int defenseGain = (int)numDefenseEV.Value;
                    int spAttackGain = (int)numSpAttackEV.Value;
                    int spDefenseGain = (int)numSpDefenseEV.Value;
                    int speedGain = (int)numSpeedEV.Value;

                    // Health EV
                    if (healthGain != 0)
                    {
                        partner.AddEVs("Health", healthGain);
                    }

                    // Attack EV
                    if (attackGain != 0)
                    {
                        partner.AddEVs("Attack", attackGain);
                    }

                    // Defense EV
                    if (defenseGain != 0)
                    {
                        partner.AddEVs("Defense", defenseGain);
                    }

                    // SpAttack EV
                    if (spAttackGain != 0)
                    {
                        partner.AddEVs("SpAttack", spAttackGain);
                    }

                    // SpDefense EV
                    if (spDefenseGain != 0)
                    {
                        partner.AddEVs("SpDefense", spDefenseGain);
                    }

                    // Speed EV
                    if (speedGain != 0)
                    {
                        partner.AddEVs("Speed", speedGain);
                    }
                }
            }
        }

        private void saveToDatabase(int slot)
        {
            Partner partner = _trainingData[slot];

            string[] errors = partner.GetErrors();

            // display success or faliure message
            if (errors.Length == 0)
            {
                // no errors, add to database
                PokemonDataSet.NaturesRow naturesRow;

                try
                {

                    naturesRow = naturesTableAdapter.GetNatureByName(partner.Nature).First();

                    partnersTableAdapter.UpdatePartnerByID(Party.getIDBySlot(slot), 
                        partner.Nickname,
                        partner.PokeNumber,
                        partner.Form.GetID(),
                        naturesRow.NatureID,
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
                    MessageBox.Show("Successful operation", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void emptySlot(int slot)
        {
            // removes member from party, clears partyData and clears display of that slot
            Party.removeMemberBySlot(slot);
            _trainingData[slot] = null;
            displaySlotDefault(slot);
        }

        /** EVENTS **/
        private void frmTraining_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _trainingData.Length; i++)
            {
                _trainingData[i] = getPartnerDataForSlot(i);
                displaySlotData(i);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            trainSelected();

            for  (int i = 0; i < _trainingData.Length; i++)
            {
                displaySlotData(i);
            }
        }

        private void btnConfirmTraining_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _trainingData.Length; i++)
            {
                if (_trainingData[i] != null)
                {
                    saveToDatabase(i);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Any unsaved changes will be discarded. Is this OK?", "Discard Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); ;
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSetZero_Click(object sender, EventArgs e)
        {
            numHealthEV.Value = 0;
            numAttackEV.Value = 0;
            numDefenseEV.Value = 0;
            numSpAttackEV.Value = 0;
            numSpDefenseEV.Value = 0;
            numSpeedEV.Value = 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // confirm removal
            DialogResult result = MessageBox.Show("Are you sure you want to remove the selected members from the party? Any unsaved changes will be lost.", "Unsaved Changes Will Be Lost", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // remove selected members from party
                CheckBox[] slotCheckBoxes = new CheckBox[] {
                    chkDoTrainingPokemon0,
                    chkDoTrainingPokemon1,
                    chkDoTrainingPokemon2,
                    chkDoTrainingPokemon3,
                    chkDoTrainingPokemon4,
                    chkDoTrainingPokemon5
                };

                int count = 0;

                for (int i = 0; i < slotCheckBoxes.Length; i++)
                {
                    if (slotCheckBoxes[i].Checked && Party.getIDBySlot(i) > -1)
                    {
                        emptySlot(i);
                        count++;
                    }
                }

                // success message
                MessageBox.Show($"Removed {count} members from party.", $"Removed {count} Members", MessageBoxButtons.OK);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            // get first selected partner
            for (int slot = 0; slot < _trainingData.Length; slot++)
            {
                // get checkbox
                CheckBox chkBox = (CheckBox)tlpMembersTable.Controls["chkDoTrainingPokemon" + slot];
                if (chkBox.Checked)
                {
                    frmPreview form = new frmPreview(getPartnerDataForSlot(slot), _trainingData[slot]);
                    form.ShowDialog();
                    return;
                }
            }

            MessageBox.Show("No partner was selected. Select a partner to preview its changes.", "Select a Partner To Preview Changes");
        }
    }
}

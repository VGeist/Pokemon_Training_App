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
                tlpMembersTable.Controls["lblNickname" + slotNum].Text = partner.Nickname;
                tlpMembersTable.Controls["picInfected" + slotNum].Visible = partner.HasPokerus;
                tlpMembersTable.Controls["lblHealthEV" + slotNum].Text = partner.HealthEV.ToString();
                tlpMembersTable.Controls["lblAttackEV" + slotNum].Text = partner.AttackEV.ToString();
                tlpMembersTable.Controls["lblDefenseEV" + slotNum].Text = partner.DefenseEV.ToString();
                tlpMembersTable.Controls["lblSpAttackEV" + slotNum].Text = partner.SpAttackEV.ToString();
                tlpMembersTable.Controls["lblSpDefenseEV" + slotNum].Text = partner.SpDefenseEV.ToString();
                tlpMembersTable.Controls["lblSpeedEV" + slotNum].Text = partner.SpeedEV.ToString();
                tlpMembersTable.Controls["lblTotalEV" + slotNum].Text = partner.TotalEVs().ToString();

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
            }
            else
            {
                displaySlotDefault(slotNum);
            }
        }

        private void displaySlotDefault(int slotNum)
        {
            CheckBox checkBox = (CheckBox)tlpMembersTable.Controls["chkDoTrainingPokemon" + slotNum];

            // sets a slot to display as empty
            tlpMembersTable.Controls["lblNickname" + slotNum].Text = "-- EMPTY --";
            tlpMembersTable.Controls["picInfected" + slotNum].Visible = false;
            tlpMembersTable.Controls["lblHealthEV" + slotNum].Text = "--";
            tlpMembersTable.Controls["lblAttackEV" + slotNum].Text = "--";
            tlpMembersTable.Controls["lblDefenseEV" + slotNum].Text = "--";
            tlpMembersTable.Controls["lblSpAttackEV" + slotNum].Text = "--";
            tlpMembersTable.Controls["lblSpDefenseEV" + slotNum].Text = "--";
            tlpMembersTable.Controls["lblSpeedEV" + slotNum].Text = "--";
            tlpMembersTable.Controls["lblTotalEV" + slotNum].Text = "--";

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
            }
            catch
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
            string statMalus = naturesRow.StatMalus;

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
            int[] selected = getSelectedSlots();

            for (int i = 0; i < selected.Length; i++)
            {
                Partner partner = _trainingData[selected[i]];

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

                // apply mods
                // item
                string item = tlpMembersTable.Controls["cmbHeldItem" + selected[i]].Text;
                if (item == "Power Weight")
                {
                    healthGain += 4;
                }
                else if (item == "Power Bracer")
                {
                    attackGain += 4;
                }
                else if (item == "Power Belt")
                {
                    defenseGain += 4;
                }
                else if (item == "Power Lens")
                {
                    spAttackGain += 4;
                }
                else if (item == "Power Band")
                {
                    spDefenseGain += 4;
                }
                else if (item == "Power Anklet")
                {
                    speedGain += 4;
                }
                else if (item == "Macho Brace")
                {
                    healthGain *= 2;
                    attackGain *= 2;
                    defenseGain *= 2;
                    spAttackGain *= 2;
                    spDefenseGain *= 2;
                    speedGain *= 2;
                }

                // pokerus
                if (partner.HasPokerus)
                {
                    healthGain *= 2;
                    attackGain *= 2;
                    defenseGain *= 2;
                    spAttackGain *= 2;
                    spDefenseGain *= 2;
                    speedGain *= 2;
                }

                // Add EVs
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

        private bool trySaveToDatabase(int slot)
        // returns true if successful
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

                    // success
                    return true;
                }
                catch
                {
                    // database error 
                    MessageBox.Show("The database encounterd an error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // failure
                    return false;
                }
            }
            else
            {
                // errors found, display message
                string errorMsg = Program.buildErrorListMessage(errors);
                MessageBox.Show(errorMsg + Environment.NewLine + "Changes not saved to database.", $"{slot + 1} | {partner.Nickname} has errors.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // failure
                return false;
            }
        }

        private void emptySlot(int slot)
        {
            // removes member from party, clears partyData and clears display of that slot
            Party.removeMemberBySlot(slot);
            _trainingData[slot] = null;
            displaySlotDefault(slot);
        }

        private int[] getSelectedSlots()
        // returns slot numbers of selected partners
        {
            int[] selected = new int[0];

            for (int slot = 0; slot < _trainingData.Length; slot++)
            {
                // get checkbox
                CheckBox chkBox = (CheckBox)tlpMembersTable.Controls["chkDoTrainingPokemon" + slot];
                if (chkBox.Checked)
                {
                    // mark slot for edit
                    selected = selected.Append(slot).ToArray();
                }
            }

            return selected;
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

            for (int i = 0; i < _trainingData.Length; i++)
            {
                displaySlotData(i);
            }
        }

        private void btnConfirmTraining_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < _trainingData.Length; i++)
            {
                if (_trainingData[i] != null)
                {
                    if (trySaveToDatabase(i))
                    {
                        // save succeeded
                        count++;
                    }
                }
            }
            
            if (count > 0)
            {
                MessageBox.Show(count + " Partners successfully updated.", "Success");
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
            int[] selected = getSelectedSlots();

            int partyCount = Party.count();

            // check that partners are selected
            if (selected.Length <= 0)
            {
                // none selected; display "No Partner Selected" message
                MessageBox.Show("You need to select at least one partner to remove.", "No Partner Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (selected.Length == partyCount)
            {
                // if the number of selected partners is equal to the number in the party cancel the operation and notify user
                MessageBox.Show("You must have at least one party member to continue training. Please check your selection.", "Cannot Remove Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                // confirm removal
                DialogResult result = MessageBox.Show("Are you sure you want to remove the selected member(s) from the party? Any unsaved changes will be lost.", "Unsaved Changes Will Be Lost", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // remove all selected
                    for(int i = 0; i < selected.Length; i++)
                    {
                        emptySlot(selected[i]);
                    }
                }
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
                    form.Text += " | " + _trainingData[slot].Nickname; // update Form title text for clarity
                    form.ShowDialog();
                    return;
                }
            }

            MessageBox.Show("No partner was selected. Select a partner to preview its changes.", "Select a Partner To Preview Changes");
        }

        private void btnUseItem_Click(object sender, EventArgs e)
        {
            for (int slot = 0; slot < _trainingData.Length; slot++)
            {
                // get checkbox
                CheckBox chkBox = (CheckBox)tlpMembersTable.Controls["chkDoTrainingPokemon" + slot];
                if (chkBox.Checked)
                {
                    // open form
                    Form form = new frmConsumables(_trainingData[slot]);
                    form.Text += " | " + _trainingData[slot].Nickname; // update Form title text for clarity
                    form.ShowDialog();

                    // update display
                    displaySlotData(slot);

                    return;
                }
            }

            // inform user that at least one partner needs to be selected
            MessageBox.Show("You need to select one Partner to use items.", "No Partner Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEvolveAndLevel_Click(object sender, EventArgs e)
        {

            for (int slot = 0; slot < _trainingData.Length; slot++)
            {
                // get checkbox
                CheckBox chkBox = (CheckBox)tlpMembersTable.Controls["chkDoTrainingPokemon" + slot];
                if (chkBox.Checked)
                {
                    // open form
                    frmEvolveAndLevel form = new frmEvolveAndLevel(_trainingData[slot]);
                    form.Text += " | " + _trainingData[slot].Nickname; // update Form title text for clarity
                    form.ShowDialog();

                    // update display
                    displaySlotData(slot);

                    return;
                }
            }

            // inform user that at least one partner needs to be selected
            MessageBox.Show("You need to select one Partner to evolve.", "No Partner Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInfect_Click(object sender, EventArgs e)
        {
            int[] selected = getSelectedSlots();

            if (selected.Length == 0)
            {
                // inform user that at least one partner needs to be selected
                MessageBox.Show("You need to select at least one Partner to infect.", "No Partner Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Cannot be undone messge.
            DialogResult result = MessageBox.Show(
                "You are about to infect " + selected.Length + " partner(s) with pokerus." + Environment.NewLine +
                "This action cannot be undone without leaving the Training Utility." + Environment.NewLine + 
                "Double check that you have selected the correct partners." + Environment.NewLine +
                "Infection is not saved to database until Confirm Training is clicked." + Environment.NewLine + 
                "Do you want to proceed?", 
                "Infect Pokerus", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                // infect selected
                for (int i = 0; i < selected.Length; i ++)
                {
                    _trainingData[selected[i]].HasPokerus = true;
                    displaySlotData(selected[i]);
                }
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            for (int slot = 0; slot < _trainingData.Length; slot++)
            {
                // get checkbox
                CheckBox chkBox = (CheckBox)tlpMembersTable.Controls["chkDoTrainingPokemon" + slot];
                if (chkBox.Checked)
                {
                    // open form
                    frmStats form = new frmStats(_trainingData[slot]);
                    form.Text += " | " + _trainingData[slot].Nickname; // update Form title text for clarity
                    form.ShowDialog();

                    return;
                }
            }

            // inform user that at least one partner needs to be selected
            MessageBox.Show("You need to select one Partner to view stats.", "No Partner Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumUpDown_Enter(object sender, EventArgs e)
        {
            // event only for numericUpDown controls
            NumericUpDown numeric = (NumericUpDown)sender;
            numeric.Select(0, numeric.Text.Length); // NOTE: Text property is hidden by IntelliSense for NumericUpDown objects :(
        }

        private void frmTraining_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Any unsaved changes will be discarded. Is this OK?", "Discard Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); ;

            e.Cancel = (result == DialogResult.No);
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            // enable conrols appropriate for numSelected
            int numSelected = getSelectedSlots().Length;
            if (numSelected == 0)
            {
                // disable all buttons
                btnEvolveAndLevel.Enabled = false;
                btnUseItem.Enabled = false;
                btnStats.Enabled = false;
                btnPreview.Enabled = false;
                btnRemove.Enabled = false;
                btnInfect.Enabled = false;
                btnAdd.Enabled = false;
            } else if (numSelected == 1)
            {
                // enable all buttons
                btnEvolveAndLevel.Enabled = true;
                btnUseItem.Enabled = true;
                btnStats.Enabled = true;
                btnPreview.Enabled = true;
                btnRemove.Enabled = true;
                btnInfect.Enabled = true;
                btnAdd.Enabled = true;
            } else
            {
                // enable only multi-select friendly buttons and disable single-select friendly buttons
                btnEvolveAndLevel.Enabled = false;
                btnUseItem.Enabled = false;
                btnStats.Enabled = false;
                btnPreview.Enabled = false;
                btnRemove.Enabled = true;
                btnInfect.Enabled = true;
                btnAdd.Enabled = true;
            }
        }
    }
}
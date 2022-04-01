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
        private Partner[] _partyData = new Partner[6];

        /** HELPERS **/
        private Partner buildPartner(PokemonDataSet.PartnersRow partnersRow, PokemonDataSet.NaturesRow naturesRow, PokemonDataSet.FormsRow formsRow)
        {
            // determine favored/hindered stat
            string statBonus = naturesRow.StatBonus;
            string statMalus = naturesRow.StatBonus;

            // Form Data
            PokeForm form = new PokeForm(
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

        private void displaySlotData(int slotNum)
        {
            // check slot for partner
            if (_partyData[slotNum] != null)
            {
                // set values
                Partner partner = _partyData[slotNum];

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
            } else
            {
                displaySlotDefault(slotNum);
            }
        }

        private void displaySlotDefault(int slotNum)
        {
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
        }

        private void getPartnerDataForSlot(int slotNum)
        {
            int id = Party.getIDBySlot(slotNum);
            if (id > -1)
            {
                // slot not empty, get data
                Partner partner = getPartnerData(id);
                _partyData[slotNum] = partner;
            }
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
                formsRow = formsTableAdapter.GetFormByID(partnersRow.NatureID).First();

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

        /** EVENTS **/
        private void frmTraining_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _partyData.Length; i++)
            {
                getPartnerDataForSlot(i);
                displaySlotData(i);
            }
        }
    }
}

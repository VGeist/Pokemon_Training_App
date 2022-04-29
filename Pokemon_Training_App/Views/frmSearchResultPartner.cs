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
    public partial class frmSearchResultPartner : Form
    {
        // -1 returns all rows and empty string returns all rows when using FillBySearch (see SQL statement)
        private int FilterNumber = -1, FilterNatureID = -1, FilterMinLevel = -1, FilterMaxLevel = -1, FilterMinEV = -1, FilterMaxEV = -1;
        private string FilterNickname = "";

        public frmSearchResultPartner()
        {
            InitializeComponent();
        }

        /*** HELPERS ***/
        private void getFilterValues()
        {
            // get filter values from user
            // open frmSearchPartner dialog
            frmSearchPartner searchDialog = new frmSearchPartner();
            searchDialog.ShowDialog();

            if (searchDialog.DialogResult == DialogResult.OK)
            {
                // set filter values
                FilterNumber = searchDialog.Number;
                FilterNickname = searchDialog.Nickname;
                FilterNatureID = searchDialog.NatureID;
                FilterMinLevel = searchDialog.MinLevel;
                FilterMaxLevel = searchDialog.MaxLevel;
                FilterMinEV = searchDialog.MinEV;
                FilterMaxEV = searchDialog.MaxEV;
            }
        }

        private void getData()
        {
            // gets data based on filter values
            partnersTableAdapter.FillBySearch(pokemonDataSet.Partners, FilterNumber, FilterNickname, FilterNatureID, FilterMinLevel, FilterMaxLevel, FilterMinEV, FilterMaxEV);
        }

        // returns null if nothing is selected
        private int? getSelectedID()
        {
            // get selected partner
            int? partnerID = (int?)dgvPartners.SelectedRows[0].Cells[colPartnerID.Index].Value;
            return partnerID;
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

        private Partner buildSelectedPartner(int id)
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

        /*** EVENTS ***/
        private void frmSearchResultPartner_Load(object sender, EventArgs e)
        {
            getFilterValues();
            getData();
        }

        private void dgvPartners_SelectionChanged(object sender, EventArgs e)
        {
            // enable or disable btnEdit and btnGroup if no rows are selected
            // check if rows are selected
            if (dgvPartners.SelectedRows.Count > 0)
            {
                // enable
                btnEdit.Enabled = true;
                btnGroup.Enabled = true;
                btnStats.Enabled = true;

                // update btnGroup if selected row is already in party
                if (Party.containsPartner((int)getSelectedID()))
                {
                    // Partner already in party
                    btnGroup.Text = "Remove from Party";
                } else
                {
                    // Parnter not in party
                    btnGroup.Text = "Add to Party";
                }
            }
            else
            {
                // disable
                btnEdit.Enabled = false;
                btnGroup.Enabled = false;
                btnStats.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            int partnerID = (int)getSelectedID(); // TODO: possible error, only prevented by disabling Stats button when no rows are selected

            Partner partner = buildSelectedPartner(partnerID);

            // open form
            frmStats form = new frmStats(partner);
            form.Text += " | " + partner.Nickname; // update Form title text for clarity
            form.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // open new partner form
            frmAddPartner form = new frmAddPartner();
            form.ShowDialog();

            // refresh
            getData();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            int selectedId = (int)getSelectedID(); // TODO: possible error, only prevented by disabling Edit button when no rows are selected
            if (Party.containsPartner(selectedId))
            {
                // Partner already in party
                Party.removeMemberByID(selectedId);
                btnGroup.Text = "Add to Party";
            }
            else
            {
                // Partner not in Party
                Party.addMember(selectedId);
                btnGroup.Text = "Remove from Party";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int partnerID = (int)getSelectedID(); // TODO: possible error, only prevented by disabling Edit button when no rows are selected

            // open form
            frmEditPartner form = new frmEditPartner(partnerID);
            form.ShowDialog();

            // refresh
            getData();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            getFilterValues();
            getData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmSearchResultPartner : Form
    {
        // -1 returns all rows and empty string returns all rows when using FillBySearch (see SQL statement)
        private int FilterNumber = -1, FilterNatureID = -1, FilterMinLevel = -1, FilterMaxLevel = -1, FilterMinEV = -1, FilterMaxEV = -1;
        private string FilterNickname = "";

        public frmSearchResultPartner()
        {
            InitializeComponent();
            getFilterValues();
            getData();
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

        /*** EVENTS ***/
        private void dgvPartners_SelectionChanged(object sender, EventArgs e)
        {
            // enable or disable btnEdit and btnForms if no rows are selected
            // check if rows are selected
            if (dgvPartners.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnGroup.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnGroup.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
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
            // add selected to group TODO: implement
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // get selected pokemon
            int partnerID = (int)dgvPartners.SelectedRows[0].Cells[colPartnerID.Index].Value;

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

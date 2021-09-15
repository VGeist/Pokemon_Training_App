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
        }

        private void getFilterValues()
        {
            // open frmSearchPartner dialog
            frmSearchPartner filter = new frmSearchPartner();
            filter.ShowDialog();

            if (filter.DialogResult == DialogResult.Yes)
            {
                // set filter values
                FilterNumber = filter.Number;
                FilterNatureID = filter.NatureID;
                FilterMinLevel = filter.MinLevel;
                FilterMaxLevel = filter.MaxLevel;
                FilterMinEV = filter.MinEV;
                FilterMaxEV = filter.MaxEV;
            }
        }

        private void frmSearchResultPartner_Load(object sender, EventArgs e)
        {
            getFilterValues();
            partnersTableAdapter.FillBySearch(pokemonDataSet.Partners, FilterNumber, FilterNickname, FilterNatureID, FilterMinLevel, FilterMaxLevel, FilterMinEV, FilterMaxEV);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // open new partner form
            frmAddPartner form = new frmAddPartner();
            form.ShowDialog();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            // add selected to group
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // get selected pokemon
            int partnerID = (int)dgvPartners.SelectedRows[0].Cells[colPartnerID.Index].Value;

            // open form
            frmEditPartner form = new frmEditPartner(partnerID);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.Cancel)
            {
                // cancel search
                this.Close();
                return;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            getFilterValues();
            partnersTableAdapter.FillBySearch(pokemonDataSet.Partners, FilterNumber, FilterNickname, FilterNatureID, FilterMinLevel, FilterMaxLevel, FilterMinEV, FilterMaxEV);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

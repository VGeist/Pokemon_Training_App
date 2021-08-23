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
    public partial class frmPokemonForms : Form
    {
        int PokeNum;
        string PokeName;

        public frmPokemonForms(int pokeNum, string pokeName)
        {
            InitializeComponent();
            PokeNum = pokeNum;
            PokeName = pokeName;
        }

        /*** EVENTS ***/
        private void frmPokemonForms_Load(object sender, EventArgs e)
        {
            this.Text += PokeNum + " " + PokeName; // set text
            // load data
            this.formsTableAdapter.FillByPokeNum(this.pokemonDataSet.Forms, PokeNum);
        }

        private void frmPokemonForms_Activated(object sender, EventArgs e)
        {
            // update data in data grid view
            this.formsTableAdapter.FillByPokeNum(this.pokemonDataSet.Forms, PokeNum);
        }

        private void dgvForms_SelectionChanged(object sender, EventArgs e)
        {
            // enable or disable btnEdit
            if (dgvForms.SelectedRows.Count > 0)
            {
                // enable
                btnEdit.Enabled = true;
            } else
            {
                // disable
                btnEdit.Enabled = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // open frmAddForm
            frmAddForm form = new frmAddForm();
            form.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // open frmEditForm
            // get selected ID
            int selectedID = (int)dgvForms.SelectedRows[0].Cells[colFormID.Index].Value;

            // open frmEditForm
            frmEditForm form = new frmEditForm(selectedID);
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // close window
            this.Close();
        }
    }
}

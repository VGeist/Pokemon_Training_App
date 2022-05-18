using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokemon_Training_App.Data;

namespace Pokemon_Training_App.Views
{
    public enum PokemonFilter
    {
        None = 0,
        Number = 1,
        Name = 2
    }

    public partial class frmSearchResultPokemon : Form
    {
        public int PokeNum = 0;
        public string PokeName = "";
        PokemonFilter Filter = PokemonFilter.None;

        public frmSearchResultPokemon()
        {
            InitializeComponent();
        }

        /*** HELPERS ***/
        private void getData()
        {
            // filter data
            if (Filter == PokemonFilter.Number)
            {
                this.pokemonTableAdapter.FillByPokeNum(this.pokemonDataSet.Pokemon, PokeNum);
            }
            else if (Filter == PokemonFilter.Name)
            {
                this.pokemonTableAdapter.FillByPokeName(this.pokemonDataSet.Pokemon, PokeName);
            } else
            {
                this.pokemonTableAdapter.Fill(this.pokemonDataSet.Pokemon);
            }

            // if no result display message
            if (dgvPokemon.RowCount == 0)
            {
                // display no results message
                dataMessage("No Results");
            } else
            {
                // remove any exisiting messages
                clearDataMessage();
            }
        }

        private void dataMessage(string text)
        {
            // show a message in the dataGridView
            lblMessage.Text = text;
            lblMessage.Show();
        }

        private void clearDataMessage()
        {
            lblMessage.Hide();
        }

        private void getFilterValues()
        {
            // get parameters from user
            frmSearchPokemon searchDialog = new frmSearchPokemon(Filter, PokeNum, PokeName);
            searchDialog.ShowDialog(); 

            // check if should apply the filter
            if (searchDialog.DialogResult == DialogResult.OK)
            {
                // set parameters
                Filter = searchDialog.Filter;
                PokeNum = searchDialog.getNumberValue();
                PokeName = searchDialog.getNameText();
            }
        }

        /*** EVENTS ***/
        private void frmSearchResultPokemon_Load(object sender, EventArgs e)
        {
            getFilterValues();
            getData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            getFilterValues();
            getData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // get selected pokemon
            int pokeNum = (int)dgvPokemon.SelectedRows[0].Cells[colPokeNum.Index].Value;

            // open form
            frmEditPokemon form = new frmEditPokemon(pokeNum);
            form.ShowDialog();

            // refresh
            getData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddPokemon form = new frmAddPokemon();
            form.ShowDialog();

            // refresh
            getData();
        }

        private void btnForms_Click(object sender, EventArgs e)
        {
            // get selected pokemon
            int pokeNum = (int)dgvPokemon.SelectedRows[0].Cells[colPokeNum.Index].Value;
            string pokeName = dgvPokemon.SelectedRows[0].Cells[colName.Index].Value.ToString();

            // open form
            frmPokemonForms form = new frmPokemonForms(pokeNum, pokeName);
            form.ShowDialog();
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            // enable or disable btnEdit and btnForms if no rows are selected
            // check if rows are selected
            if (dgvPokemon.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnForms.Enabled = true;
            } else
            {
                btnEdit.Enabled = false;
                btnForms.Enabled = false;
            }
        }
    }
}
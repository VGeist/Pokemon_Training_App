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

            searchPokemon();
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

        private void searchPokemon()
        {
            // get parameters from user
            frmSearchPokemon searchDialog = new frmSearchPokemon();
            searchDialog.ShowDialog();

            // check if should apply the filter
            if (searchDialog.DoFilter)
            {
                // set parameters
                Filter = searchDialog.Filter;
                if (Filter == PokemonFilter.Number)
                {
                    PokeNum = searchDialog.getNumberValue();
                }
                else if (Filter == PokemonFilter.Name)
                {
                    PokeName = searchDialog.getNameText();
                }

                getData();
            }
        }

        /*** EVENTS ***/
        private void frmSearchResultPokemon_Load(object sender, EventArgs e)
        {
            getData();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            dataMessage("Refreshing...");
            await Task.Delay(1000);
            getData();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            // update data
            this.Validate();
            this.pokemonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pokemonDataSet);
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            searchPokemon();
        }
    }
}
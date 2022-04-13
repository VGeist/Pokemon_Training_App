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
    public partial class frmEvolve : Form
    {
        /** Fields **/
        private Partner _partner;

        public Partner Partner { get => _partner; }

        public frmEvolve(Partner partner)
        {
            InitializeComponent();
            _partner = partner;
        }

        /** HELPERS **/
        private Pokemon getPokemonData()
        {
            PokemonDataSet.PokemonRow pokemonRow;
            PokemonDataSet.FormsRow formsRow;

            try
            {
                // get data from database
                pokemonRow = pokemonTableAdapter.GetByPokeNum((int)cmbPokeNum.SelectedValue).First();
                formsRow = formsTableAdapter.GetFormByID((int)cmbForm.SelectedValue).First();
            } catch
            {
                MessageBox.Show("A database error occured. No changes were made.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return new Pokemon();
            }

            // assign values and return
            Pokemon pokemon = new Pokemon();
            PokeForm pokeForm = new PokeForm(
                formsRow.FormID,
                formsRow.BaseHealth,
                formsRow.BaseAttack,
                formsRow.BaseDefense,
                formsRow.BaseSpAttack,
                formsRow.BaseSpDefense,
                formsRow.BaseSpeed,
                formsRow.Name
                );

            pokemon.PokeName = pokemonRow.Name;
            pokemon.PokeNumber = pokemonRow.PokeNum;
            pokemon.FormList[0] = pokeForm;

            return pokemon;
        }

        private void resetValues()
        {
            // reset input values to that of the partner
            cmbPokeNum.SelectedValue = _partner.PokeNumber;
            cmbForm.SelectedValue = _partner.Form.GetID();
            numHealth.Value = _partner.Health;
            numAttack.Value = _partner.Attack;
            numDefense.Value = _partner.Defense;
            numSpAttack.Value = _partner.SpAttack;
            numSpDefense.Value = _partner.SpDefense;
            numSpeed.Value = _partner.Speed;
        }

        /** EVENTS **/
        private void btnEvolve_Click(object sender, EventArgs e)
        {
            // retrieve Pokemon Data from selected number
            Pokemon evolved = getPokemonData();

            _partner.Evolve(evolved, (int)numHealth.Value, (int)numAttack.Value, (int)numDefense.Value, (int)numSpAttack.Value, (int)numSpDefense.Value, (int)numSpeed.Value, evolved.FormList[0]);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetValues();
        }

        private void frmEvolve_Load(object sender, EventArgs e)
        {
            // populate combobox data
            pokemonTableAdapter.Fill(pokemonDataSet.Pokemon);
            formsTableAdapter.Fill(pokemonDataSet.Forms);
            resetValues();
        }
    }
}

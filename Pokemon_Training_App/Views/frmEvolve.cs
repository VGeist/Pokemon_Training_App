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

        // start values
        private int _startPokeNum;
        private PokeForm _startForm;
        private int _startHealth;
        private int _startAttack;
        private int _startDefense;
        private int _startSpAttack;
        private int _startSpDefense;
        private int _startSpeed;

        private bool commitChange = false;

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
            // reset input values to initial state
            cmbPokeNum.SelectedValue = _startPokeNum;
            cmbForm.SelectedValue = _startForm.GetID();
            numHealth.Value = _startHealth;
            numAttack.Value = _startAttack;
            numDefense.Value = _startDefense;
            numSpAttack.Value = _startSpAttack;
            numSpDefense.Value = _startSpDefense;
            numSpeed.Value = _startSpeed;

            // set _partner back to start values
            _partner.PokeNumber = _startPokeNum;
            _partner.Form = _startForm;
            _partner.Health = _startHealth;
            _partner.Attack = _startAttack;
            _partner.Defense = _startDefense;
            _partner.SpAttack = _startSpAttack;
            _partner.SpDefense = _startSpDefense;
            _partner.Speed = _startSpeed;
        }

        /** EVENTS **/
        private void btnEvolve_Click(object sender, EventArgs e)
        {
            // retrieve Pokemon Data from selected number
            Pokemon evolved = getPokemonData();
            _partner.Evolve(evolved, (int)numHealth.Value, (int)numAttack.Value, (int)numDefense.Value, (int)numSpAttack.Value, (int)numSpDefense.Value, (int)numSpeed.Value, evolved.FormList[0]);

            // get errors
            string[] errors = _partner.GetErrors();
            if (errors.Length == 0)
            {
                // mark for change and exit form
                commitChange = true;
                this.Close();
            }
            else
            {
                // errors found, display message
                string errorMsg = Program.buildErrorListMessage(errors);
                MessageBox.Show(errorMsg, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetValues();
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

            // initialize start values
            _startPokeNum = _partner.PokeNumber;
            _startForm = _partner.Form;
            _startHealth = _partner.Health;
            _startAttack = _partner.Attack;
            _startDefense = _partner.Defense;
            _startSpAttack = _partner.SpAttack;
            _startSpDefense = _partner.SpDefense;
            _startSpeed = _partner.Speed;

            resetValues();
        }

        private void frmEvolve_FormClosing(object sender, FormClosingEventArgs e)
        {
            // NOT commitChange
            if (!commitChange)
            {
                // undo changes
                resetValues();
            }
        }
    }
}

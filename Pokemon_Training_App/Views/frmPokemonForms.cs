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

        public frmPokemonForms(int pokeNum)
        {
            InitializeComponent();
            PokeNum = pokeNum;
        }

        /*** EVENTS ***/
        private void frmPokemonForms_Load(object sender, EventArgs e)
        {
            this.formsTableAdapter.FillByPokeNum(this.pokemonDataSet.Forms, PokeNum);
        }

        private void frmPokemonForms_Activated(object sender, EventArgs e)
        {
            this.formsTableAdapter.FillByPokeNum(this.pokemonDataSet.Forms, PokeNum);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}

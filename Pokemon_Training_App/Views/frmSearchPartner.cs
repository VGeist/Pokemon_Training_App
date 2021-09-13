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
    public partial class frmSearchPartner : Form
    {
        public frmSearchPartner()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // clsoe this window
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // send data back to frmSearchResultPartner
        }

        private void frmSearchPartner_Load(object sender, EventArgs e)
        {
            // get data for combo boxes
            pokemonTableAdapter.Fill(pokemonDataSet.Pokemon);
            naturesTableAdapter.Fill(pokemonDataSet.Natures);
        }
    }
}
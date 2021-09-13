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
        public frmSearchResultPartner()
        {
            InitializeComponent();
        }

        private void frmSearchResultPartner_Load(object sender, EventArgs e)
        {
            frmSearchPartner form = new frmSearchPartner();
            form.ShowDialog();
            // TODO: This line of code loads data into the 'pokemonDataSet.Partners' table. You can move, or remove it, as needed.
            this.partnersTableAdapter.Fill(this.pokemonDataSet.Partners);

        }
    }
}

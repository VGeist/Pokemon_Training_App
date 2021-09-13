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

            partnersTableAdapter.FillBySearch(pokemonDataSet.Partners, form.Number, form.Nickname, form.NatureID, form.MinLevel, form.MaxLevel, form.MinEV, form.MaxEV);
        }
    }
}

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
            // validate inputs
            // construct query
            // query database
            // open frmSearchResult with query results
            frmSearchResultPokemon form = new frmSearchResultPokemon();
            form.Show();
        }
    }
}

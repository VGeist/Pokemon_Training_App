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
    public partial class frmMain : Form
    {public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the program
            this.Close();
        }

        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            // create and open an add partner form
            frmAddPartner form = new frmAddPartner();
            form.ShowDialog();
            /* 
             * ShowDialog() opens a "modal" form prevents 
             * focus from shifting to a different form
            */
        }

        private void btnAddPokemon_Click(object sender, EventArgs e)
        {
            /* 
            // create and open an add pokemon form
            frmAddPokemon form = new frmAddPokemon();
            form.ShowDialog();
            */
        }

        private void btnSearchPokemon_Click(object sender, EventArgs e)
        {
            /* 
            // create and open an search pokemon form
            frmSearchPokemon form = new frmSearchPokemon();
            form.Show();
            */
        }

        private void btnSearchPartner_Click(object sender, EventArgs e)
        {
            /* 
            // create and open an search pokemon form
            frmSearchPartner form = new frmSearchPartner();
            form.Show();
            */
        }
    }
}
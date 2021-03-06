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
            // create and open an add pokemon form
            frmAddPokemon form = new frmAddPokemon();
            form.ShowDialog();
        }

        private void btnSearchPokemon_Click(object sender, EventArgs e)
        {
            // create and open an search pokemon form
            frmSearchResultPokemon form = new frmSearchResultPokemon();
            form.ShowDialog();
        }

        private void btnSearchPartner_Click(object sender, EventArgs e)
        {
            // create and open an search pokemon form
            frmSearchResultPartner form = new frmSearchResultPartner();
            form.ShowDialog();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            // open training form if Party has any members
            for (int i = 0; i < 6; i++)
            {
                if(Party.getIDBySlot(i) > -1)
                {
                    // party has at least one member, display form
                    frmTraining form = new frmTraining();
                    form.ShowDialog();
                    return;
                }
            }

            // no party members: notify user
            MessageBox.Show("No partners in party. Please add members via Search Partners.", "No partners", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
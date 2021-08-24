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
    public partial class frmAddForm : Form
    {
        int PokeNum;

        public frmAddForm(int pokeNum)
        {
            InitializeComponent();
            PokeNum = pokeNum;
        }

        /*** HELPERS ***/
        private bool inputsValid()
        {
            // check number values are positive
            foreach (NumericUpDown numericUpDown in this.Controls.OfType<NumericUpDown>())
            {
                if (numericUpDown.Value < 0)
                {
                    return false;
                }
            }

            // check name is not null or empty
            if (String.IsNullOrEmpty(txtFormName.Text))
            {
                return false;
            }

            // valid
            return true;
        }

        /*** EVENTS ***/
        private void frmAddForm_Load(object sender, EventArgs e)
        {
            // set poke num display
            lblPokeNum.Text = '#' + PokeNum.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // validate then insert data into database
            if (inputsValid())
            {
                // valid inputs, try to send to database
                try
                {
                    // insert data into table
                    formsTableAdapter.InsertForm(
                        PokeNum,
                        txtFormName.Text,
                        (int)numBaseHealth.Value,
                        (int)numBaseAttack.Value,
                        (int)numBaseDefense.Value,
                        (int)numBaseSpAttack.Value,
                        (int)numBaseSpDefense.Value,
                        (int)numBaseSpeed.Value
                        );
                    //formsTableAdapter.Update(pokemonDataSet);

                    // success message
                    MessageBox.Show("Successful operation!", "Success", MessageBoxButtons.OK);

                    // close form
                    this.Close();
                } catch
                {
                    // database error
                    MessageBox.Show("There was a problem with the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                // invalid, display error message
                MessageBox.Show("Inputs invalid.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // set values to default
            // set number values to 1
            foreach (NumericUpDown numericUpDown in this.Controls.OfType<NumericUpDown>())
            {
                numericUpDown.Value = 1;
            }

            // clear txtFormName
            txtFormName.Clear();

            // focus on form name input
            txtFormName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close form
            this.Close();
        }
    }
}

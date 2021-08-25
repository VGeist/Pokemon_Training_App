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
    public partial class frmAddForm : Form
    {
        int PokeNum;

        public frmAddForm(int pokeNum)
        {
            InitializeComponent();
            PokeNum = pokeNum;
        }

        /*** HELPERS ***/
        private bool inputsValid(out string[] errList)
        {
            // check number values are positive
            errList = PokeForm.GetErrors(txtFormName.Text, 
                                                (int)numBaseHealth.Value,
                                                (int)numBaseAttack.Value,
                                                (int)numBaseDefense.Value,
                                                (int)numBaseSpAttack.Value,
                                                (int)numBaseSpDefense.Value, 
                                                (int)numBaseSpeed.Value);

            if (errList.Length > 0)
            {
                // an error was found, invalid
                return false;
            } else
            {
                // no errors, valid
                return true;
            }
        }

        /*** EVENTS ***/
        private void frmAddForm_Load(object sender, EventArgs e)
        {
            // set poke num display
            lblPokeNum.Text = '#' + PokeNum.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] errors;
            // validate then insert data into database
            if (inputsValid(out errors))
            {
                // no errors, insert data
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
                // errors have occured
                // build error message
                string errorMsg = "There is a problem with this information:" + Environment.NewLine;

                for (int i = 0; i < errors.Length; i++)
                {
                    // add error
                    errorMsg += errors[i];

                    // check if there is another error
                    if (i < errors.Length)
                    {
                        // another error exists, put on a new line
                        errorMsg += Environment.NewLine;
                    }
                }

                // display message
                MessageBox.Show(errorMsg, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

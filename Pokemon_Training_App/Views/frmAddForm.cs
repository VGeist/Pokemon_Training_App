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

        /*** EVENTS ***/
        private void frmAddForm_Load(object sender, EventArgs e)
        {
            // set poke num display
            lblPokeNum.Text = '#' + PokeNum.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] errors = PokeForm.GetErrors(txtFormName.Text,
                                                (int)numBaseHealth.Value,
                                                (int)numBaseAttack.Value,
                                                (int)numBaseDefense.Value,
                                                (int)numBaseSpAttack.Value,
                                                (int)numBaseSpDefense.Value,
                                                (int)numBaseSpeed.Value); ;

            if (errors.Length == 0)
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
                string errorMsg = Program.buildErrorListMessage(errors);

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

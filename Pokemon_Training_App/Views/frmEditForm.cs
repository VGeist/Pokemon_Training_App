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
    public partial class frmEditForm : Form
    {
        int FormID;

        public frmEditForm(int formID)
        {
            InitializeComponent();
            FormID = formID;
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
        private void frmEditForm_Load(object sender, EventArgs e)
        {
            this.formsTableAdapter.FillByID(this.pokemonDataSet.Forms, FormID);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // validate then update database data
            if (inputsValid())
            {
                // valid inputs, try update
                try
                {
                    // insert data into table
                    formsTableAdapter.UpdateForm(
                        FormID,
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
                }
                catch
                {
                    // database error
                    MessageBox.Show("There was a problem with the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // invalid, display error message
                MessageBox.Show("Inputs invalid.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // confirm deletion then delete form data
            // show confirmation message
            DialogResult confirm = MessageBox.Show("Are you sure? Data can not be recovered.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // delete the Pokemon
                    this.formsTableAdapter.DeleteByID(FormID);

                    this.Close();
                }
                catch (Exception ex)
                {
                    // exception message
                    MessageBox.Show("A problem occured: " + Environment.NewLine + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close this form
            this.Close();
        }
    }
}

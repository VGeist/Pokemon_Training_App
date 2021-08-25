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
    public partial class frmEditForm : Form
    {
        int FormID;

        public frmEditForm(int formID)
        {
            InitializeComponent();
            FormID = formID;
        }

        /*** HELPERS ***/

        /*** EVENTS ***/
        private void frmEditForm_Load(object sender, EventArgs e)
        {
            this.formsTableAdapter.FillByID(this.pokemonDataSet.Forms, FormID);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
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
                // no errors, try update
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
                // there were errors, display error message
                // build error message
                string errorMsg = Program.buildErrorListMessage(errors);

                // display message
                MessageBox.Show(errorMsg, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

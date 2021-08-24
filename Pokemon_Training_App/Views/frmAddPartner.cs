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
    public partial class frmAddPartner : Form
    {
        public frmAddPartner()
        {
            InitializeComponent();
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            // open frmAddForm as a modal window
            frmAddForm form = new frmAddForm(-1);
            form.ShowDialog();
        }

        // TODO: implement add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* TODO: implement */
            // validate data
            // send data to database
            // display success or faliure message

            // PLACEHOLDER message box
            MessageBox.Show("Button working.\n" +
                cmbNature.SelectedItem +
                Environment.NewLine +
                cmbForm.SelectedItem, "Temporary Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /* TODO: redo this method to work with new control types
            // clear values from all inputs
            // clear values from text boxes
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Clear();
            }

            foreach (TabPage page in tabStats.TabPages)
            {
                foreach (TextBox textBox in page.Controls.OfType<TextBox>())
                {
                    textBox.Clear();
                }
            }

            // set combo boxes to default values
            foreach (ComboBox comboBox in this.Controls.OfType<ComboBox>())
            {
                comboBox.SelectedIndex = 0;
            }

            // focus on first textbox
            numPokeNum.Focus();
            */
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close window
            this.Close();
        }
    }
}

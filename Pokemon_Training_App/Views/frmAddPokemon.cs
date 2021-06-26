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
    public partial class frmAddPokemon : Form
    {
        public frmAddPokemon()
        {
            InitializeComponent();
        }

        // TODO: implement Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // validate data,
            // send data to database
            // display success or faliure message

            // PLACEHOLDER message box
            MessageBox.Show("Button working.", "Temporary Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear values from all textboxes
            var controls = this.Controls.OfType<TextBox>();
            foreach (TextBox textBox in controls)
            {
                textBox.Clear();
            }
            // focus on first textbox
            txtPokemonNum.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close this window
            this.Close();
        }
    }
}

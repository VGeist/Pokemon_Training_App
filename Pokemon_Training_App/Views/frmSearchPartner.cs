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
        // values given here are 'default' and return all rows when using FillBySearch (see SQL)
        public int Number = -1, MinLevel = -1, MaxLevel = -1, NatureID = -1, MinEV = -1, MaxEV = -1;
        public string Nickname = "";

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
            // set properties to be accessed by parent form
            if (chkFilterNumber.Checked)
            {
                Number = (int)numPokeNum.Value;
            }

            if (chkFilterNickname.Checked)
            {
                Nickname = txtNickname.Text;
            }

            if (chkFilterNature.Checked)
            {
                NatureID = (int)cmbNature.SelectedValue;
            }

            if (chkFilterLevel.Checked)
            {
                MinLevel = (int)numMinLevel.Value;
                MaxLevel = (int)numMaxLevel.Value;
            }

            if (chkFilterEV.Checked)
            {
                MinEV = (int)numMinEV.Value;
                MaxEV = (int)numMaxEV.Value;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void NumUpDown_Enter(object sender, EventArgs e)
        {
            // event only for numericUpDown controls
            NumericUpDown numeric = (NumericUpDown)sender;
            numeric.Select(0, numeric.Text.Length); // NOTE: Text property is hidden by IntelliSense for NumericUpDown objects :(
        }

        private void txtNickname_Enter(object sender, EventArgs e)
        {
            txtNickname.SelectAll();
        }

        private void frmSearchPartner_Load(object sender, EventArgs e)
        {
            // get data for combo boxes
            pokemonTableAdapter.Fill(pokemonDataSet.Pokemon);
            naturesTableAdapter.Fill(pokemonDataSet.Natures);
        }

        private void numMinLevel_ValueChanged(object sender, EventArgs e)
        {
            // correct max level if min level is greater than max level
            if (numMinLevel.Value > numMaxLevel.Value)
            {
                numMaxLevel.Value = numMinLevel.Value;
            }
        }

        private void numMinEV_ValueChanged(object sender, EventArgs e)
        {
            // corect max EV if min EV is greater than max EV
            if (numMinEV.Value > numMaxEV.Value)
            {
                numMaxEV.Value = numMinEV.Value;
            }
        }

        private void numMaxLevel_ValueChanged(object sender, EventArgs e)
        {
            // correct min Level if max Level is less than min Level
            if (numMaxLevel.Value < numMinLevel.Value)
            {
                numMinLevel.Value = numMaxLevel.Value;
            }
        }

        private void numMaxEV_ValueChanged(object sender, EventArgs e)
        {
            // correct min EV if max EV is less than min EV
            if (numMaxEV.Value < numMinEV.Value)
            {
                numMinEV.Value = numMaxEV.Value;
            }
        }
    }
}
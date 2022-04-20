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
    public partial class frmLevelUp : Form
    {
        /** Baking Fields **/
        private Partner _partner;

        /** CONSTRUCTOR **/
        public frmLevelUp(Partner partner)
        {
            InitializeComponent();
            _partner = partner;
        }

        /** HELPER METHODS **/
        private void resetValues()
        {
            // sets input fields to current partner's values
            numLevel.Value = _partner.Level;
            numHealth.Value = _partner.Health;
            numAttack.Value = _partner.Attack;
            numDefense.Value = _partner.Defense;
            numSpAttack.Value = _partner.SpAttack;
            numSpDefense.Value = _partner.SpDefense;
            numSpeed.Value = _partner.Speed;
        }

        /** EVENTS **/
        private void frmLevelUp_Load(object sender, EventArgs e)
        {
            resetValues();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetValues();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _partner.LevelUp((int)numLevel.Value, (int)numHealth.Value, (int)numHealth.Value, (int)numHealth.Value, (int)numHealth.Value, (int)numHealth.Value, (int)numHealth.Value);
            this.Close();
        }
    }
}

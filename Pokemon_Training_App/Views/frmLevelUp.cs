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

        // start values
        private int _startLevel;
        private int _startHealth;
        private int _startAttack;
        private int _startDefense;
        private int _startSpAttack;
        private int _startSpDefense;
        private int _startSpeed;

        private bool commitChange = false;

        /** CONSTRUCTOR **/
        public frmLevelUp(Partner partner)
        {
            InitializeComponent();
            _partner = partner;
        }

        /** HELPER METHODS **/
        private void resetValues()
        {
            // reset fields to start values
            numLevel.Value = _startLevel;
            numHealth.Value = _startHealth;
            numAttack.Value = _startAttack;
            numDefense.Value = _startDefense;
            numSpAttack.Value = _startSpAttack;
            numSpDefense.Value = _startSpDefense;
            numSpeed.Value = _startSpeed;

            // set _partner back to start values
            _partner.Level = _startLevel;
            _partner.Health = _startHealth;
            _partner.Attack = _startAttack;
            _partner.Defense = _startDefense;
            _partner.SpAttack = _startSpAttack;
            _partner.SpDefense = _startSpDefense;
            _partner.Speed = _startSpeed;
        }

        /** EVENTS **/
        private void frmLevelUp_Load(object sender, EventArgs e)
        {
            // initialize start values
            _startLevel = _partner.Level;
            _startHealth = _partner.Health;
            _startAttack = _partner.Attack;
            _startDefense = _partner.Defense;
            _startSpAttack = _partner.SpAttack;
            _startSpDefense = _partner.SpDefense;
            _startSpeed = _partner.Speed;

            resetValues();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetValues();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetValues();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Level up temp with given values
            _partner.LevelUp((int)numLevel.Value, (int)numHealth.Value, (int)numAttack.Value, (int)numDefense.Value, (int)numSpAttack.Value, (int)numSpDefense.Value, (int)numSpeed.Value);

            // get errors
            string[] errors = _partner.GetErrors();
            if (errors.Length == 0)
            {
                // mark for change and exit form
                commitChange = true;
                this.Close();
            }
            else
            {
                // errors found, display message
                string errorMsg = Program.buildErrorListMessage(errors);
                MessageBox.Show(errorMsg, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLevelUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            // NOT commitChange
            if (!commitChange)
            {
                // undo changes
                resetValues();
            }
        }
    }
}

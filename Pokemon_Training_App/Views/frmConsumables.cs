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
    public partial class frmConsumables : Form
    {
        /** Constants **/
        public int BerryValue = -10;
        public int WingValue = 1;
        public int VitaminValue = 10;

        /** Fields **/
        private Partner _partner;

        public Partner Partner { get => _partner; }

        public frmConsumables(Partner partner)
        {
            InitializeComponent();
            _partner = partner;
        }

        /** Helper Functions **/
        private void gainEVs(string statName, int gain)
        {
            _partner.AddEVs(statName, gain);

            // Total EV checks
            if (_partner.TotalEVs() == 510)
            {
                // total is at max, values may have been adjusted; notify user
                MessageBox.Show("Partner has reached max total EVs. Values may have been adjusted to not exceed the EV Total limit of 510.", "Max EVs Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (_partner.TotalEVs() < 0)
            {
                // total will be reduced below 0, values adjusted in AddEVs(); notify user
                MessageBox.Show("Total EVs has reached zero.", "Zero Total EVs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            int ev = _partner.GetEV(statName);

            // stat EV checks
            if (ev == 255)
            {
                MessageBox.Show("Partner has reached max EVs for " + statName + " stat. Values may have been adjusted to not exceed the EV limit of 255.", "Max " + statName + " EVs Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ev == 0)
            {
                MessageBox.Show("Partner has zero EVs for " + statName + " stat.", "Zero " + statName + " EVs Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int getAdjustedVitaminGain(string statName)
        {
            // returns the adjusted gain of vitamins to not exceed their 100 EV max influence
            // check that EVs will not exceed 100 when gains are applied
            int startVal = _partner.GetEV(statName);
            int newVal = startVal + VitaminValue;
            if (newVal > 100)
            {
                // exceeded 100, return adjusted val
                int adjustedVal = 100 - startVal;

                if (adjustedVal <= 0)
                {
                    // adjustedVal is negative; return 0
                    MessageBox.Show("Vitamin was ineffective. Vitamins can only give EVs if the EV is below 100.", "No EVs Added");
                    return 0;
                } else
                {
                    // notify user of adjustment and return value
                    MessageBox.Show("Vitamin gain has reached 100. Only " + adjustedVal + " EVs were added.", "Vitamin Gain Adjusted");
                    return adjustedVal;
                }
            } else
            {
                // no adjustment needed
                return VitaminValue;
            }
        }

        /** EVENTS **/
        // health items
        private void btnHpUp_Click(object sender, EventArgs e)
        {
            int gain = getAdjustedVitaminGain("Health");
            gainEVs("Health", gain);
        }

        private void btnHealthWing_Click(object sender, EventArgs e)
        {
            gainEVs("Health", WingValue);
        }

        private void btnPomeg_Click(object sender, EventArgs e)
        {
            gainEVs("Health", BerryValue);
        }

        // attack items
        private void btnProtien_Click(object sender, EventArgs e)
        {
            int gain = getAdjustedVitaminGain("Attack");
            gainEVs("Attack", gain);
        }

        private void btnMuscleWing_Click(object sender, EventArgs e)
        {
            gainEVs("Attack", WingValue);
        }

        private void btnKelpsy_Click(object sender, EventArgs e)
        {
            gainEVs("Attack", BerryValue);
        }

        // defense items
        private void btnIron_Click(object sender, EventArgs e)
        {
            int gain = getAdjustedVitaminGain("Defense");
            gainEVs("Defense", gain);
        }

        private void btnResistWing_Click(object sender, EventArgs e)
        {
            gainEVs("Defense", WingValue);
        }

        private void btnQualot_Click(object sender, EventArgs e)
        {
            gainEVs("Defense", BerryValue);
        }

        // sp attack items
        private void btnCalcium_Click(object sender, EventArgs e)
        {
            int gain = getAdjustedVitaminGain("SpAttack");
            gainEVs("SpAttack", gain);
        }

        private void btnGeniusWing_Click(object sender, EventArgs e)
        {
            gainEVs("SpAttack", WingValue);
        }

        private void btnHondew_Click(object sender, EventArgs e)
        {
            gainEVs("SpAttack", BerryValue);
        }

        // sp defense items
        private void btnZinc_Click(object sender, EventArgs e)
        {
            int gain = getAdjustedVitaminGain("SpDefense");
            gainEVs("SpDefense", gain);
        }

        private void btnCleverWing_Click(object sender, EventArgs e)
        {
            gainEVs("SpDefense", WingValue);
        }

        private void btnGrepa_Click(object sender, EventArgs e)
        {
            gainEVs("SpDefense", BerryValue);
        }

        // speed items
        private void btnCarbos_Click(object sender, EventArgs e)
        {
            int gain = getAdjustedVitaminGain("Speed");
            gainEVs("Speed", gain);
        }

        private void btnSwiftWing_Click(object sender, EventArgs e)
        {
            gainEVs("Speed", WingValue);
        }

        private void btnTamato_Click(object sender, EventArgs e)
        {
            gainEVs("Speed", BerryValue);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

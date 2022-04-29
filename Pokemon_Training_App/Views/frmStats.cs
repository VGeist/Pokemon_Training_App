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
    public partial class frmStats : Form
    {
        private Partner _partner;

        public frmStats(Partner partner)
        {
            InitializeComponent();

            _partner = partner;
        }

        /** HELPERS **/
        private void displayData()
        {
            // partner data displays
            lblNickname.Text = _partner.Nickname;
            picPokerus.Visible = _partner.HasPokerus;
            lblNumber.Text = "#" + _partner.PokeNumber;
            lblSpecies.Text = _partner.PokeName;
            lblLevel.Text = _partner.Level.ToString();
            lblNature.Text = _partner.Nature;
            lblForm.Text = _partner.Form.GetFormName() + " Form";

            int[] ivRange;

            // Health values
            lblHealth.Text = _partner.Health.ToString();
            lblHealthEV.Text = _partner.HealthEV.ToString();
            ivRange = _partner.GetIVRange("Health");
            lblHealthIV.Text = getIvRangeString(ivRange[0], ivRange[1]);

            // Attack values
            lblAttack.Text = _partner.Attack.ToString();
            lblAttackEV.Text = _partner.AttackEV.ToString();
            ivRange = _partner.GetIVRange("Attack");
            lblAttackIV.Text = getIvRangeString(ivRange[0], ivRange[1]);

            // Defense values
            lblDefense.Text = _partner.Defense.ToString();
            lblDefenseEV.Text = _partner.DefenseEV.ToString();
            ivRange = _partner.GetIVRange("Defense");
            lblDefenseIV.Text = getIvRangeString(ivRange[0], ivRange[1]);

            // SpAttack values
            lblSpAttack.Text = _partner.SpAttack.ToString();
            lblSpAttackEV.Text = _partner.SpAttackEV.ToString();
            ivRange = _partner.GetIVRange("SpAttack");
            lblSpAttackIV.Text = getIvRangeString(ivRange[0], ivRange[1]);

            // SpDefense values
            lblSpDefense.Text = _partner.SpDefense.ToString();
            lblSpDefenseEV.Text = _partner.SpDefenseEV.ToString();
            ivRange = _partner.GetIVRange("SpDefense");
            lblSpDefenseIV.Text = getIvRangeString(ivRange[0], ivRange[1]);

            // Speed values
            lblSpeed.Text = _partner.Speed.ToString();
            lblSpeedEV.Text = _partner.SpeedEV.ToString();
            ivRange = _partner.GetIVRange("Speed");
            lblSpeedIV.Text = getIvRangeString(ivRange[0], ivRange[1]);
        }

        /** HELPER **/
        private string getIvRangeString(int min, int max)
        {
            /*
            if (min == max)
            {
                return min.ToString();
            } else if (min > max)
            {
                return "Impossible Stat";
            } else
            {
                return min + " to " + max;
            }
            */
            return min + " to " + max;
        }

        /** EVENTS **/
        private void frmStats_Load(object sender, EventArgs e)
        {
            displayData();
        }
    }
}

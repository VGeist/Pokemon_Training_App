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

            // Health values
            lblHealth.Text = _partner.Health.ToString();
            lblHealthEV.Text = _partner.HealthEV.ToString();
            lblHealthIV.Text = _partner.MinHealthIV() + " to " + _partner.MaxHealthIV();

            // Attack values
            lblAttack.Text = _partner.Attack.ToString();
            lblAttackEV.Text = _partner.AttackEV.ToString();
            lblAttackIV.Text = _partner.MinStatIV("Attack", _partner.Attack) + " to " + _partner.MaxStatIV("Attack", _partner.Attack);

            // Defense values
            lblDefense.Text = _partner.Defense.ToString();
            lblDefenseEV.Text = _partner.DefenseEV.ToString();
            lblDefenseIV.Text = _partner.MinStatIV("Defense", _partner.Defense) + " to " + _partner.MaxStatIV("Defense", _partner.Defense);

            // SpAttack values
            lblSpAttack.Text = _partner.SpAttack.ToString();
            lblSpAttackEV.Text = _partner.SpAttackEV.ToString();
            lblSpAttackIV.Text = _partner.MinStatIV("SpAttack", _partner.SpAttack) + " to " + _partner.MaxStatIV("SpAttack", _partner.SpAttack);

            // SpDefense values
            lblSpDefense.Text = _partner.SpDefense.ToString();
            lblSpDefenseEV.Text = _partner.SpDefenseEV.ToString();
            lblSpDefenseIV.Text = _partner.MinStatIV("SpDefense", _partner.SpDefense) + " to " + _partner.MaxStatIV("SpDefense", _partner.SpDefense);

            // Speed values
            lblSpeed.Text = _partner.Speed.ToString();
            lblSpeedEV.Text = _partner.SpeedEV.ToString();
            lblSpeedIV.Text = _partner.MinStatIV("Speed", _partner.Speed) + " to " + _partner.MaxStatIV("Speed", _partner.Speed);
        }

        /** EVENTS **/
        private void frmStats_Load(object sender, EventArgs e)
        {
            displayData();
        }
    }
}

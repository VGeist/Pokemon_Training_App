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
    public partial class frmPreview : Form
    {
        public frmPreview(Partner current, Partner trained)
        {
            InitializeComponent();

            lblNickname.Text = trained.Nickname;
            picPokerus.Visible = trained.HasPokerus;

            // current data (in database)
            lblCurrentLevel.Text = current.Level.ToString();
            lblCurrentNumber.Text = current.PokeNumber.ToString();

            lblCurrentHealth.Text = current.Health.ToString();
            lblCurrentAttack.Text = current.Attack.ToString();
            lblCurrentDefense.Text = current.Defense.ToString();
            lblCurrentSpAttack.Text = current.SpAttack.ToString();
            lblCurrentSpDefense.Text = current.SpDefense.ToString();
            lblCurrentSpeed.Text = current.Speed.ToString();

            lblCurrentHealthEV.Text = current.HealthEV.ToString();
            lblCurrentAttackEV.Text = current.AttackEV.ToString();
            lblCurrentDefenseEV.Text = current.DefenseEV.ToString();
            lblCurrentSpAttackEV.Text = current.SpAttackEV.ToString();
            lblCurrentSpDefenseEV.Text = current.SpDefenseEV.ToString();
            lblCurrentSpeedEV.Text = current.SpeedEV.ToString();

            // trained data (not in database)
            lblTrainedLevel.Text = trained.Level.ToString();
            lblTrainedNumber.Text = trained.PokeNumber.ToString();

            lblTrainedHealth.Text = trained.Health.ToString();
            lblTrainedAttack.Text = trained.Attack.ToString();
            lblTrainedDefense.Text = trained.Defense.ToString();
            lblTrainedSpAttack.Text = trained.SpAttack.ToString();
            lblTrainedSpDefense.Text = trained.SpDefense.ToString();
            lblTrainedSpeed.Text = trained.Speed.ToString();

            lblTrainedHealthEV.Text = trained.HealthEV.ToString();
            lblTrainedAttackEV.Text = trained.AttackEV.ToString();
            lblTrainedDefenseEV.Text = trained.DefenseEV.ToString();
            lblTrainedSpAttackEV.Text = trained.SpAttackEV.ToString();
            lblTrainedSpDefenseEV.Text = trained.SpDefenseEV.ToString();
            lblTrainedSpeedEV.Text = trained.SpeedEV.ToString();
        }
    }
}

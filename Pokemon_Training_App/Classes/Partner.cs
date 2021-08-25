using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Training_App.Classes
{
    class Partner : Pokemon
    {
        private static float NatureBonusValue = 1.1f;
        private static float NatureMalusValue = 0.9f;

        /*** PROPERTIES ***/
        public string Nickname { get; set; }
        public int Level { get; set; }
        public string Nature { get; set; }
        private string _favoredStat;   // used to calculaate IVs, MUST match the name of the stat EXACTLY
        private string _hinderedStat;  // used to calculate IVs, MUST match the name of the stat EXACTLY

        private PokeForm _currentForm;

        public bool HasPokerus { get; set; }

        // Stat properties
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAttack { get; set; }
        public int SpDefense { get; set; }
        public int Speed { get; set; }

        // EV properteis
        public int HealthEV { get; set; }
        public int AttackEV { get; set; }
        public int DefenseEV { get; set; }
        public int SpAttackEV { get; set; }
        public int SpDefenseEV { get; set; }
        public int SpeedEV { get; set; }

        /*** CONSTRUCTORS ***/
        public Partner(Pokemon species,
                        string nickname = "undefined",
                        int level = 1,
                        string nature = "Hardy",
                        string favoredStat = "undefined",
                        string hinderedStat = "undefined",
                        // Stat parameters
                        int healthStat = -1,
                        int attackStat = -1,
                        int defenseStat = -1,
                        int spAttackStat = -1,
                        int spDefenseStat = -1,
                        int speedStat = -1,
                        // EV parameters
                        int healthEV = 0,
                        int attackEV = 0,
                        int defenseEV = 0,
                        int spAttackEV = 0,
                        int spDefenseEV = 0,
                        int speedEV = 0)
        {
            // Set Pokemon species
            SetSpecies(species);

            /** Set partner properties **/
            Nickname = nickname;
            Level = level;
            Nature = nature;
            _favoredStat = favoredStat;
            _hinderedStat = hinderedStat;
            // Set Stats
            Health = healthStat;
            Attack = attackStat;
            Defense = defenseStat;
            SpAttack = spAttackStat;
            SpDefense = spDefenseStat;
            Speed = speedStat;
            // Set EVs
            HealthEV = healthEV;
            AttackEV = attackEV;
            DefenseEV = defenseEV;
            SpAttackEV = spAttackEV;
            SpDefenseEV = spDefenseEV;
            SpeedEV = speedEV;
        }

        /*** GETTERS ***/
        public string GetFavoredStat()
        {
            return _favoredStat;
        }

        public string GetHinderedStat()
        {
            return _hinderedStat;
        }

        /*** METHODS ***/
        public int TotalEVs()
        {
            return this.HealthEV + this.AttackEV + this.DefenseEV + this.SpAttackEV + this.SpDefenseEV + this.SpeedEV;
        }

        public int MaxStatIV(string statName, int stat)
        {
            // find the max possible IV for the given stat

            // get the nature bonus
            float natureBonus = GetNatureBonus(statName);

            // add one to stat, sets calculation up for upper bound
            double iv = stat + 1;

            // apply nature bonus
            iv *= natureBonus;

            // finish calculation
            return FinalizeStatIV(statName, iv);
        }

        public int MinStatIV(string statName, int stat)
        {
            // find min possible IV for the given stat

            // initialize iv equal to stat
            double iv = stat;

            // get the nature bonus
            float natureBonus = GetNatureBonus(statName);

            // apply nature bonus
            iv *= natureBonus;

            // finish calculation
            return FinalizeStatIV(statName, iv);
        }

        // Health stat uses different calculations for IVs
        public int MaxHealthIV()
        {
            // find max possible Health IV
            // do common operations and return value, an input of 900 returns Max value
            return EstimateHealthIV(900);
        }

        public int MinHealthIV()
        {
            // find min possible Health IV
            // do common operations and return value, an input of 1000 returns Min value
            return EstimateHealthIV(1000);
        }

        public void ChangeNature(string name, string favored, string hindered)
        {
            Nature = name;
            _favoredStat = favored;
            _hinderedStat = hindered;
        }

        public void SetForm(PokeForm newForm)
        {
            // set current form of this parter to the new form
            // check if this pokemon can become the new form
            if (this.FormList.Contains(newForm))
            {
                _currentForm = newForm;
            }
            else {
                // if not a valid form, set to first valid form
                FormToDefault();
            }
        }

        public void FormToDefault()
        {
            _currentForm = this.FormList[0];
        }

        /* TRAINING methods */
        public void LevelUp(int targetLevel, int hp, int attack, int defense, int spAttack, int spDefense, int speed)
        {
            Level = targetLevel;
            Health = hp;
            Attack = attack;
            Defense = defense;
            SpAttack = spAttack;
            SpDefense = spDefense;
            Speed = speed;
        }

        public void Evolve(Pokemon nextStage, int hp, int attack, int defense, int spAttack, int spDefense, int speed)
        {
            // Evolve a pokemon without specifying a form
            this.SetSpecies(nextStage);
            Health = hp;
            Attack = attack;
            Defense = defense;
            SpAttack = spAttack;
            SpDefense = spDefense;
            Speed = speed;
            FormToDefault();
        }

        public void Evolve(Pokemon nextStage, int hp, int attack, int defense, int spAttack, int spDefense, int speed, PokeForm form)
        {
            // Evolve a pokemon
            Evolve(nextStage, hp, attack, defense, spAttack, spDefense, speed);
            SetForm(form);
        }

        public void AddEVs(string statName, int value)
        {
            // adds value to given stat
            if (statName.Equals("Health"))
            {
               HealthEV += value;
            }
            else if (statName.Equals("Attack"))
            {
               AttackEV += value;
            }
            else if (statName.Equals("Defense"))
            {
               DefenseEV += value;
            }
            else if (statName.Equals("SpAttack"))
            {
               SpAttackEV += value;
            }
            else if (statName.Equals("SpDefense"))
            {
               SpDefenseEV += value;
            }
            else if (statName.Equals("Speed"))
            {
                SpeedEV += value;
            }
        }

        /*** HELPER FUNCTIONS ***/
        private float GetNatureBonus(string statName)
        {
            // returns nature bonus value if the given name matches the favored or hindered stat
            // if name given does not match, bonus is 1
            if (statName.Equals(_favoredStat))
            {
                return NatureBonusValue;
            }
            else if (statName.Equals(_hinderedStat))
            {
                return NatureMalusValue;
            }
            else
            {
                return 1;
            }
        }

        private int GetBase(string statName)
        {
            // gets the base stat of the given stat, if invalid retuns -1
            if (statName.Equals("Health"))
            {
                return _currentForm.GetBaseHealth();
            }
            else if (statName.Equals("Attack"))
            {
                return _currentForm.GetBaseAttack();
            }
            else if (statName.Equals("Defense"))
            {
                return _currentForm.GetBaseDefense();
            }
            else if (statName.Equals("SpAttack"))
            {
                return _currentForm.GetBaseSpAttack();
            }
            else if (statName.Equals("SpDefense"))
            {
                return _currentForm.GetBaseSpDefense();
            }
            else if (statName.Equals("Speed"))
            {
                return _currentForm.GetBaseSpeed();
            }
            else
            {
                return -1;
            }
        }

        private int GetEV(string statName)
        {
            // gets the EV of the given stat, if invalid returns 0
            if (statName.Equals("Health")) {
                return HealthEV;
            }
            else if (statName.Equals("Attack"))
            {
                return AttackEV;
            }
            else if (statName.Equals("Defense"))
            {
                return DefenseEV;
            }
            else if (statName.Equals("SpAttack"))
            {
                return SpAttackEV;
            }
            else if (statName.Equals("SpDefense"))
            {
                return SpDefenseEV;
            }
            else if (statName.Equals("Speed"))
            {
                return SpeedEV;
            }
            else
            {
                return 0;
            }
        }

        private int FinalizeStatIV(string statName, double value)
        {
            // set of operations that occur in both upper and lower bound stat IV calculation
            // set boundary and apply nature bonus before using this function

            // get base
            int baseValue = GetBase(statName);

            // get ev
            int ev = GetEV(statName);

            // calculate
            value *= 100;
            value -= 500;
            value /= Level;
            value -= 2 * baseValue;
            value -= GetSignificantEVs(ev);
            
            // drop decimal and return value
            return (int)value;
        }

        private int EstimateHealthIV(double value)
        {
            // calculates IV for Health stat
            /* NOTE: due to the nature of the calculation the returned value will be wildy 
             * inaccurate and should only be used to get the MAX and MIN possible values for Health IV.
             * An input of 1000 will get the MIN possible IV and an input of 900 will get the 
             * MAX possible IV.
             */
            // get base health
            int baseValue = _currentForm.GetBaseHealth();

            // calculate
            value /= Level;
            value -= 100 * Health / Level;
            value -= 100;
            value -= 2 * baseValue;
            value -= GetSignificantEVs(HealthEV);

            // round
            value = Math.Round(value);

            // if a negative number set to 0
            if (value < 0)
            {
                value = 0;
            }

            // convert to int and return value
            return (int)value;
        }

        private int GetSignificantEVs(int ev)
        {
            // drop decimal of ev / 4 and return
            return ev / 4;
        }

        #region Error Checking
        // function to validate all Partner fields, returns a list of errors
        public string[] GetErrors(string healthStatLabel = "Health",
                                        string attackStatLabel = "Attack",
                                        string defenseStatLabel = "Defense",
                                        string spAttackStatLabel = "Sp. Attack",
                                        string spDefenseStatLabel = "Sp. Defense",
                                        string speedStatLabel = "Speed")
        {
            List<string> errors = new List<string>();

            // check nickname
            errors.Add(GetNicknameError());

            // check level
            errors.Add(GetLevelError());

            // EV error checking
            errors.Add(GetEVError(this.HealthEV, healthStatLabel + " EV"));
            errors.Add(GetEVError(this.AttackEV, attackStatLabel + " EV"));
            errors.Add(GetEVError(this.DefenseEV, defenseStatLabel + " EV"));
            errors.Add(GetEVError(this.SpAttackEV, spAttackStatLabel + " EV"));
            errors.Add(GetEVError(this.SpDefenseEV, spDefenseStatLabel + " EV"));
            errors.Add(GetEVError(this.SpeedEV, speedStatLabel + " EV"));
            errors.Add(GetEVTotalError());

            // filter out NULL values
            errors.RemoveAll(error => error == null);

            string[] output = errors.ToArray();

            return output;
        }

        // funcitons that check a single field - return error messages; if no error is found retuns null 
        public string GetEVError(int ev, string displayString)
        {
            // checks that ev is between 0 and 255
            if (ev < 0)
            {
                return displayString + " must be zero or greater.";
            } else if (ev > 255)
            {
               return displayString + " cannot be greater than 255.";
            } else
            {
                return null;
            }
        }

        public string GetEVTotalError()
        {
            int total = TotalEVs();
            if (total > 510)
            {
                return "EVs may not total more than 510.";
            } else
            {
                return null;
            }
        }

        public string GetLevelError()
        {
            if (this.Level <= 0)
            {
                return "Level must be greater than zero.";
            } else if (this.Level < 100)
            {
                return "Level cannot be more than 100.";
            } else
            {
                return null;
            }
        }

        public string GetNicknameError()
        {
            if (String.IsNullOrEmpty(this.Nickname))
            {
                return "Nickname is required.";
            }
            else if (String.Equals(this.Nickname, "undefined", StringComparison.OrdinalIgnoreCase))
            {
                return "Nickname cannot be 'undefined'";
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Training_App.Classes
{
    public class Partner : Pokemon
    {
        private static double NatureBonusValue = 1.1;
        private static double NatureMalusValue = 0.9;

        /*** BACKING FIELDS ***/
        private string _favoredStat;   // used to calculaate IVs, MUST match the name of the stat EXACTLY
        private string _hinderedStat;  // used to calculate IVs, MUST match the name of the stat EXACTLY

        // Stat fields
        private int _health;
        private int _attack;
        private int _defense;
        private int _spAttack;
        private int _spDefense;
        private int _speed;

        // EV fields
        private int _healthEV;
        private int _attackEV;
        private int _defenseEV;
        private int _spAttackEV;
        private int _spDefenseEV;
        private int _speedEV;


        /*** PROPERTIES ***/
        public string Nickname { get; set; }
        public int Level { get; set; }
        public string Nature { get; set; }

        public PokeForm Form { get; set; }

        public bool HasPokerus { get; set; }

        // Stat properties
        public int Health { get => _health; set => _health = value; }
        public int Attack { get => _attack; set => _attack = value; }
        public int Defense { get => _defense; set => _defense = value; }
        public int SpAttack { get => _spAttack; set => _spAttack = value; }
        public int SpDefense { get => _spDefense; set => _spDefense = value; }
        public int Speed { get => _speed; set => _speed = value; }

        // EV properteis
        public int HealthEV { get => _healthEV; set => _healthEV = value; }
        public int AttackEV { get => _attackEV; set => _attackEV = value; }
        public int DefenseEV { get => _defenseEV; set => _defenseEV = value; }
        public int SpAttackEV { get => _spAttackEV; set => _spAttackEV = value; }
        public int SpDefenseEV { get => _spDefenseEV; set => _spDefenseEV = value; }
        public int SpeedEV { get => _speedEV; set => _speedEV = value; }

        /*** CONSTRUCTORS ***/
        public Partner(Pokemon species,
                        string nickname = "undefined",
                        int level = 1,
                        string nature = "Hardy",
                        string favoredStat = "undefined",
                        string hinderedStat = "undefined",
                        bool hasPokerus = false,

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
            HasPokerus = hasPokerus;

            // Set Stats
            _health = healthStat;
            _attack = attackStat;
            _defense = defenseStat;
            _spAttack = spAttackStat;
            _spDefense = spDefenseStat;
            _speed = speedStat;
            // Set EVs
            _healthEV = healthEV;
            _attackEV = attackEV;
            _defenseEV = defenseEV;
            _spAttackEV = spAttackEV;
            _spDefenseEV = spDefenseEV;
            _speedEV = speedEV;
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

        public int GetStatByName(string statName)
        {
            // gets the EV of the given stat, if invalid returns 0
            if (statName.Equals("Health"))
            {
                return Health;
            }
            else if (statName.Equals("Attack"))
            {
                return Attack;
            }
            else if (statName.Equals("Defense"))
            {
                return Defense;
            }
            else if (statName.Equals("SpAttack"))
            {
                return SpAttack;
            }
            else if (statName.Equals("SpDefense"))
            {
                return SpDefense;
            }
            else if (statName.Equals("Speed"))
            {
                return Speed;
            }
            else
            {
                return 0;
            }
        }

        /*** METHODS ***/
        public int TotalEVs()
        {
            return this.HealthEV + this.AttackEV + this.DefenseEV + this.SpAttackEV + this.SpDefenseEV + this.SpeedEV;
        }

        public void ChangeNature(string name, string favored, string hindered)
        {
            Nature = name;
            _favoredStat = favored;
            _hinderedStat = hindered;
        }

        public void FormToDefault()
        {
            Form = this.FormList[0];
        }

        public int[] GetValidStatRange(string statName)
        {
            double min = GetTrueStat(statName, 0);
            double max = GetTrueStat(statName, 31);

            // apply nature bonus
            double natureBonus = GetNatureBonus(statName);

            min *= natureBonus;
            max *= natureBonus;

            return new int[] { (int)min, (int)max };
        }

        private int[] BruteForceIVRange(string statName)
        {
            // Gets the IV Range by brute force, returns -1 for invalid values
            int stat = GetStatByName(statName);
            double natureBonus = GetNatureBonus(statName);

            int minIV = 0;

            // round before applying nature (converting to int) apply natureBonus and round down again
            while (minIV <= 31 && (int)((int)GetTrueStat(statName, minIV) * natureBonus) != stat)
            {
                // not equal, try the next one
                minIV++;
            }

            int maxIV = minIV + 1;
            while (maxIV <= 31 && (int)(((int)GetTrueStat(statName, maxIV)) * natureBonus) == stat)
            {
                maxIV++;
            }
            maxIV--;

            /*
            int maxIV = 31;
            while (maxIV > minIV && (int)(((int)GetTrueStat(statName, maxIV)) * natureBonus) != stat)
            {
                maxIV--;
            }
            */

            // check for invalid results
            if (minIV > 32)
            {
                minIV = -1;
            }

            return new int[] { minIV, maxIV};
        }

        public int[] GetIVRange(string statName)
        {
            int maxIV;
            int minIV;

            if (GetNatureBonus(statName) != 1)
            {
                // Impossible to adjust for rounding when nature is involved, use brute force.
                return BruteForceIVRange(statName);
            }

            // nature not applied, do quick calculation
            // The code below calculates ivs by checking how many IVs would THEORETICALLY be needed to reach the given stat value. 
            // IMPORTANT: DOES NOT APPLY NATURE BONUS
            int stat = GetStatByName(statName);
            double trueMin = GetTrueStat(statName, 0);
            double ivBoost = (Level / 100D); // determine the value of an IV at current level

            double temp = stat - trueMin;   // Get the difference between stat and trueMin
            temp = Math.Round(temp, 4);     // round off any trailing decimal, causes errors when rounding up

            minIV = (int)Math.Ceiling(temp / ivBoost); // minIV is how many times ivBoost goes into temp (i.e. temp / ivBoost), round up. (concept applies to maxIV)

            // calculating maxIV, add one before dividing
            temp++; // add one to determine how many IVs we would need to get to the next point
            temp /= ivBoost;
            temp = Math.Round(temp, 4); // round off any trailing decimal, causes errors when rounding up

            maxIV = (int)Math.Ceiling(temp) - 1; // round up and subtract one, we don't actually have the next stat point

            /* The method below returns is a more accurate version of the one above and can accomodate nature bonus.
             * This method is accurate in cases where the nature bonus is 1 (not affected by nature). 
             * The decimal value of trueMin (designated trueRound) is not affected by nature because nature is applied after rounding down.
             * Due to rounding, it is impossible to adjust for the nature bonus and causes a loss of precision in this method.
             * While an estimate may be generated, it cannot be 100% accurate. The resulting output is usualy slightly below the real value.
            
            double natureBonus = GetNatureBonus(statName);
            int stat = GetStatByName(statName);
            double trueMin = GetTrueStat(statName, 0);      // trueStat is a stat without rounding and before natureBonus is applied
            double trueRound = trueMin % 1;                 // trueRound is the decimal value of trueMin. trueRound does not have nature applied to it, because Stats are rounded prior to the bonus being applied.
            trueMin = Math.Floor(trueMin);                  // round down trueMin
            trueMin *= natureBonus;                         // apply nature
            trueMin += trueRound;                           // add trueRound back to trueMin

            double ivBoost = (Level / 100D) * natureBonus;  // determine how much one IV point is worth at this level, apply nature bonus

            double temp = stat - trueMin;                   // get the difference between stat and trueMin
            temp = Math.Round(temp, 4);                     // round off any trailing decimal, causes errors when rounding up

            // calculate minIV
            minIV = (int)Math.Ceiling(temp / ivBoost);      // minIV is how many times ivBoost goes into temp (i.e. temp / ivBoost), round up

            // calculate maxIV
            temp += natureBonus;        // add natureBonus to estimate how many IVs are needed for the next stat point
            temp /= ivBoost;
            temp = Math.Round(temp, 4); // round off any trailing decimal, causes errors when rounding up

            maxIV = (int)Math.Ceiling(temp) - 1; // subtract one, we don't actually have the next stat point
            */

            // Because this function determines how many IVs would THEORETICALLY be needed, values out of range are eliminated
            if (minIV < 0)
            {
                minIV = 0;
            }

            if (maxIV > 31)
            {
                maxIV = 31;
            }

            return new int[] { minIV, maxIV };
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
            Form = form;
        }

        public void AddEVs(string statName, int gain)
        {
            // adds value to given stat
            ref int ev = ref _healthEV;

            if (statName.Equals("Health"))
            {
                ev = ref _healthEV;
            }
            else if (statName.Equals("Attack"))
            {
                ev = ref _attackEV;
            }
            else if (statName.Equals("Defense"))
            {
                ev = ref _defenseEV;
            }
            else if (statName.Equals("SpAttack"))
            {
                ev = ref _spAttackEV;
            }
            else if (statName.Equals("SpDefense"))
            {
                ev = ref _spDefenseEV;
            }
            else if (statName.Equals("Speed"))
            {
                ev = ref _speedEV;
            }

            // apply gain
            ev += gain;

            int newTotal = TotalEVs();

            if (newTotal > 510)
            {
                // total max exceeded; adjust ev gain
                int excess = newTotal - 510;
                ev -= excess;
            }

            if (ev < 0)
            {
                // ev min
                ev = 0;
            }
            else if (ev >= 255)
            {
                // ev max
                ev = 255;
            }
        }

        public int GetEV(string statName)
        {
            // gets the EV of the given stat, if invalid returns 0
            if (statName.Equals("Health"))
            {
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

        /*** HELPER FUNCTIONS ***/
        private double GetTrueStat(string statName, int iv)
        {
            /* Gets a decimal accurate stat given an IV for that stat.
            * Does NOT apply Nature. Apply any nature bonus AFTER calling this method.
            * IV must be between 0 and 31 to be valid.
            */
            int baseStat = GetBase(statName);
            int sigEV = GetSignificantEVs(GetEV(statName));

            double trueStat = (2 * baseStat) + iv + sigEV;
            trueStat *= Level / 100D;

            if (statName == "Health")
            {
                trueStat += Level + 10;
            } else
            {
                trueStat += 5;
            }

            return Math.Round(trueStat, 4);
        }

        private double GetNatureBonus(string statName)
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
                return Form.GetBaseHealth();
            }
            else if (statName.Equals("Attack"))
            {
                return Form.GetBaseAttack();
            }
            else if (statName.Equals("Defense"))
            {
                return Form.GetBaseDefense();
            }
            else if (statName.Equals("SpAttack"))
            {
                return Form.GetBaseSpAttack();
            }
            else if (statName.Equals("SpDefense"))
            {
                return Form.GetBaseSpDefense();
            }
            else if (statName.Equals("Speed"))
            {
                return Form.GetBaseSpeed();
            }
            else
            {
                return -1;
            }
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

            return errors.ToArray();
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
            } else if (this.Level > 100)
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
            else if (this.Nickname.Length > 12)
            {
                return "Nickname cannot be more than 12 characters.";
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
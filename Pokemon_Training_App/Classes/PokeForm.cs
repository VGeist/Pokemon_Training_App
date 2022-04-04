using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Training_App.Classes
{
    class PokeForm
    {
        // Properties
        private int _id;
        private int _baseHealth;
        private int _baseAttack;
        private int _baseDefense;
        private int _baseSpAttack;
        private int _baseSpDefense;
        private int _baseSpeed;
        private string _formName;

        /** CONSTRUCTORS **/
        public PokeForm(int id, int baseHealth, int baseAttack, int baseDefense, int baseSpAttack, int baseSpDefense, int baseSpeed, string name = "Default")
        {
            Change(id, baseHealth, baseAttack, baseDefense, baseSpAttack, baseSpDefense, baseSpeed, name);
        }

        /** GETTERS **/
        public int GetID()
        {
            return _id;
        }

        public int GetBaseHealth()
        {
            return _baseHealth;
        }

        public int GetBaseAttack()
        {
            return _baseAttack;
        }

        public int GetBaseDefense()
        {
            return _baseDefense;
        }

        public int GetBaseSpAttack()
        {
            return _baseSpAttack;
        }

        public int GetBaseSpDefense()
        {
            return _baseSpDefense;
        }

        public int GetBaseSpeed()
        {
            return _baseSpeed;
        }

        public string GetFormName()
        {
            return _formName;
        }

        /*** METHODS ***/
        public void Change(int id, int baseHealth, int baseAttack, int baseDefense, int baseSpAttack, int baseSpDefense, int baseSpeed, string name)
        {
            // change form data
            _id = id;
            _baseHealth = baseHealth;
            _baseAttack = baseAttack;
            _baseDefense = baseDefense;
            _baseSpAttack = baseSpAttack;
            _baseSpDefense = baseSpDefense;
            _baseSpeed = baseSpeed;
            _formName = name;
        }

        #region ErrorChecking
        // function to validate all fields, returns a list of errors
        public static string[] GetErrors(string formName,
                                        int baseHealth, 
                                        int baseAttack,
                                        int baseDefense,
                                        int baseSpAttack,
                                        int baseSpDefense,
                                        int baseSpeed,
                                        string formNameLabel = "Form Name",
                                        string baseHealthLabel = "Base Health",
                                        string baseAttackLabel = "Base Attack",
                                        string baseDefenseLabel = "Base Defense",
                                        string baseSpAttackLabel = "Base Sp. Attack",
                                        string baseSpDefenseLabel = "Base Sp. Defense",
                                        string baseSpeedLabel = "Base Speed")
        {
            List<string> errors = new List<string>();

            // check form name
            errors.Add(GetFormNameError(formName, formNameLabel));

            // check base health
            errors.Add(GetBaseStatError(baseHealth, baseHealthLabel));

            // check base attack
            errors.Add(GetBaseStatError(baseAttack, baseAttackLabel));

            // check base defense
            errors.Add(GetBaseStatError(baseDefense, baseDefenseLabel));

            // check base sp attack
            errors.Add(GetBaseStatError(baseSpAttack, baseSpAttackLabel));

            // check base sp defense
            errors.Add(GetBaseStatError(baseSpDefense, baseSpDefenseLabel));

            // check base speed
            errors.Add(GetBaseStatError(baseSpeed, baseSpeedLabel));

            // filter out NULL values
            errors.RemoveAll(error => error == null);

            // convert to array
            string[] output = errors.ToArray();

            return output;
        }
        
        // funcitons that check one property - return error messages, if no error is found retuns null 
        public static string GetBaseStatError(int stat, string displayString)
        {
            // checks that a value is valid for 'stats', if not valid sends an error to Errors
            if (stat <= 0)
            {
                return displayString + " must be greater than zero.";
            }
            else
            {
                return null;
            }
        }

        public static string GetFormNameError(string formName, string displayString)
        {
            if (String.IsNullOrEmpty(formName))
            {
                return displayString + " is required.";
            } else
            {
                return null;
            }
        }
        #endregion
    }
}

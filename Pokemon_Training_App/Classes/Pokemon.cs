using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Training_App.Classes
{
    class Pokemon
    {
        /*** POKEMON PROPERTIES ***/
        public int PokeNumber { get; set; }
        public string PokeName { get; set; }
        public Form[] FormList { get; set; }

        /*** CONSTRUCTORS ***/
        protected Pokemon() { }

        public Pokemon(int number, string name, Form[] forms)
        {
            PokeNumber = number;
            PokeName = name;
            FormList = forms;
        }

        /*** METHODS ***/
        public void SetSpecies(Pokemon species)
        {
            // change this pokemon to a different species
            // set the Name, Number, and base stats of this pokemon
            this.PokeNumber = species.PokeNumber;
            this.PokeName = species.PokeName;
            this.FormList = species.FormList;
        }

        /*****************
         * ERROR CHECKING
        // function to validate all fields, returns a list of errors
        public virtual string[] GetErrors(string baseHealthLabel = "Base Health", 
                                        string baseAttackLabel = "Base Attack", 
                                        string baseDefenseLabel = "Base Defense", 
                                        string baseSpAttackLabel = "Base Sp. Attack",
                                        string baseSpDefenseLabel = "Base Sp. Defense",
                                        string baseSpeedLabel = "Base Speed")
        {
            List<string> errors = new List<string>();

            // check number
            errors.Add(GetNumberError());

            // check name
            errors.Add(GetNameError());

            // check base health
            errors.Add(GetStatError(this.BaseHealth, baseHealthLabel));

            // check base attack
            errors.Add(GetStatError(this.BaseAttack, baseAttackLabel));

            // check base defense
            errors.Add(GetStatError(this.BaseDefense, baseDefenseLabel));

            // check base sp attack
            errors.Add(GetStatError(this.BaseSpAttack, baseSpAttackLabel));

            // check base sp defense
            errors.Add(GetStatError(this.BaseSpDefense, baseSpDefenseLabel));

            // check base speed
            errors.Add(GetStatError(this.BaseSpeed, baseSpeedLabel));

            // filter out NULL values
            errors.RemoveAll(error => error == null);

            // convert to array
            string[] output = errors.ToArray();

            return output;
        }

        // funcitons that check one property - return error messages, if no error is found retuns null 
        public string GetNumberError()
        {
            string displayString = "Pokemon number";
            if (PokeNumber < 0) {
                return displayString + " must be positive.";
            }
            else {
                return null;
            }
        }

        public string GetNameError()
        {
            // if invalid returns false and sends error to Erros
            string displayString = "Name";
            if (PokeName.Length == 0) {
                return displayString + " is required.";
            }
            else if ( PokeName == "undefined" )
            {
                return displayString + " cannot be 'undefined'";
            }
            else {
                return null;
            }
        }

        public string GetStatError(float stat, string displayString)
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
        * END OF ERROR CHECKING
        ***********************/
    }
}
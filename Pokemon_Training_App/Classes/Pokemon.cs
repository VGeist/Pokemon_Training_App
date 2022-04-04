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
        public PokeForm[] FormList { get; set; }

        /*** CONSTRUCTORS ***/
        public Pokemon()
        {
            PokeNumber = -1;
            PokeName = "default";
            FormList = new PokeForm[] { new PokeForm(-1, -1, -1, -1, -1, -1, -1) };
        }

        public Pokemon(int number, string name, PokeForm[] forms)
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

        #region Error Checking
        // function to validate all fields, returns a list of errors
        public static string[] GetErrors(int pokeNum,
                                        string pokeName,
                                        string numberLabel = "Pokemon Number",
                                        string nameLabel = "Pokemon Name",
                                        string baseHealthLabel = "Base Health", 
                                        string baseAttackLabel = "Base Attack", 
                                        string baseDefenseLabel = "Base Defense", 
                                        string baseSpAttackLabel = "Base Sp. Attack",
                                        string baseSpDefenseLabel = "Base Sp. Defense",
                                        string baseSpeedLabel = "Base Speed")
        {
            List<string> errors = new List<string>();

            // check number
            errors.Add(GetNumberError(pokeNum));

            // check name
            errors.Add(GetNameError(pokeName));

            // filter out NULL values
            errors.RemoveAll(error => error == null);

            // convert to array
            string[] output = errors.ToArray();

            return output;
        }

        // funcitons that check one property - return error messages, if no error is found retuns null 
        public static string GetNumberError(int num, string displayString = "Pokemon number")
        {
            if (num < 0) {
                return displayString + " must be positive.";
            }
            else {
                return null;
            }
        }

        public static string GetNameError(string nameString, string displayString = "Pokemon name")
        {
            // if invalid returns false and sends error to Erros
            if (String.IsNullOrEmpty(nameString)) {
                return displayString + " is required.";
            }
            else if (String.Equals(nameString, "undefined", StringComparison.OrdinalIgnoreCase))
            {
                return displayString + " cannot be 'undefined'";
            }
            else {
                return null;
            }
        }
        #endregion
    }
}
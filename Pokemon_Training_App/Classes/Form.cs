using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Training_App.Classes
{
    class Form
    {
        // Properties
        private int _baseHealth;
        private int _baseAttack;
        private int _baseDefense;
        private int _baseSpAttack;
        private int _baseSpDefense;
        private int _baseSpeed;
        private string _formName;

        /** CONSTRUCTORS **/
        public Form(int baseHealth, int baseAttack, int baseDefense, int baseSpAttack, int baseSpDefense, int baseSpeed, string name = "Default")
        {
            Change(baseHealth, baseAttack, baseDefense, baseSpAttack, baseSpDefense, baseSpeed, name);
        }

        /** GETTERS **/
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
        public void Change(int baseHealth, int baseAttack, int baseDefense, int baseSpAttack, int baseSpDefense, int baseSpeed, string name)
        {
            // change form data
            _baseHealth = baseHealth;
            _baseAttack = baseAttack;
            _baseDefense = baseDefense;
            _baseSpAttack = baseSpAttack;
            _baseSpDefense = baseSpDefense;
            _baseSpeed = baseSpeed;
            _formName = name;
        }
    }
}

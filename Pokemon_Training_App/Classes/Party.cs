using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon_Training_App.Classes;

namespace Pokemon_Training_App.Classes
{
    static class Party
    {
        /*** BACKING FIELDS ***/
        private static int?[] _members = new int?[6]; // stores partner IDs

        /*** FUNCTIONS ***/
        public static Partner getPartnerInSlot(int num)
        {
            // TODO: implement
            return new Partner(new Pokemon());
        }

        public static void addMember (int partnerID)
        {
            // TODO: implement
            // check if party is full -> T: display error and return; F: continue;
            int slot = findAvailableSlot();

            if (slot == -1)
            {
                // display "full party" message
                return;
            }
            
            // find partner in database by ID
            // if not found - display error
            // if found - build partner and add to available slot
        }

        public static void removeMember(int slotNum)
        {
            // TODO: implement
            // delete data in 
            return;
        }

        public static void synchronizeData()
        {
            // TODO:implement
            // syncronize party member data with data from DB
        }

        /*** HELPERS ***/
        private static int findAvailableSlot()
        {
            // Return index of an empty slot in _members; Returns -1 if no slot is found
            for (int i = 0; i < _members.Length; i++)
            {
                if (_members[i] == null)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

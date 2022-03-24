using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                MessageBox.Show("Party is full. Partner has not been added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // add ID to party
            _members[slot] = partnerID;
            MessageBox.Show("Successfully added to party.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void removeMember(int slotNum)
        {
                _members[slotNum] = null;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Training_App.Classes
{
    public static class Party
    {
        /*** BACKING FIELDS ***/
        private static int?[] _members = new int?[6]; // stores partner IDs

        /*** FUNCTIONS ***/
        // returns ID of the given slot (slots start at 0), returns -1 for null value
        public static int getIDBySlot(int slotNum)
        {
            int? id = _members[slotNum];
            if (id == null)
            {
                return -1;
            } else
            {
                return (int)id;
            }
        }

        public static void addMember (int partnerID)
        {
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

        public static void removeMemberBySlot(int slotNum)
        {
            // removes member at the given index
            _members[slotNum] = null;
        }

        public static void removeMemberByID(int id)
        {
            // removes the first instance of an id
            for (int i = 0; i < _members.Length; i++) {
                if (_members[i] == id)
                {
                    _members[i] = null;
                    return;
                }
            }
        }

        public static bool containsPartner(int id)
        {
            return _members.Contains(id);
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

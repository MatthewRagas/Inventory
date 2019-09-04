using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{
    class DefenseItem : Item
    {
        private int _defense;

        public int Defense
        {
            get
            {
                return _defense;
            }
        }

        public DefenseItem(string newName, int newDefense, int newWeight)
        {
            name = newName;
            _defense = newDefense;
            weight = newWeight;
        }
    }
}

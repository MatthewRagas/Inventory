using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class AttackItem : Item
    {
        private int _damage;

       public int Damage
        {
            get
            {
                return _damage;
            }
        }

        //Constructor. Automatically returns stats for new AttackItem.
        public AttackItem(string newName, int newDamage, int newWeight)
        {
            name = newName;
            _damage = newDamage;
            weight = newWeight;
        }   
        


    }
}

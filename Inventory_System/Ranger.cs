using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Ranger : Character
    {
        public Ranger(string name) : base(name)
        {
            _health = 110;
            _mana = 120;
            _strength = 15;
            _speed = 16;
            _wisdom = 14;
        }
    }
}

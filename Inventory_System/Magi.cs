using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{
    class Magi : Character
    {
        public Magi(string name) : base(name)
        {
            _health = 150;
            _mana = 300;
            _strength = 12;
            _speed = 14;
            _wisdom = 20;
        }
    }
}

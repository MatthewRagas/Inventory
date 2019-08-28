using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{

    //inherited subclass;
    class Assassin : Character
    {
        public Assassin(string name) : base(name)
        {
            _health = 150;
            _mana = 200;
            _strength = 13;
            _speed = 20;
            _wisdom = 17;            
        }
    }
}

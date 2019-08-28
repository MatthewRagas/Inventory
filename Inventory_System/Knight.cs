﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Knight : Character
    {
        public Knight(string name) : base(name)
        {
            _health = 250;
            _mana = 150;
            _strength = 19;
            _speed = 12;
            _wisdom = 16;
        }
    }
}
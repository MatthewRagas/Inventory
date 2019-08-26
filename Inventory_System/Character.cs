﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Character
    {
        private string _name = "";
        private int _playerLevel = 1;
        private int _xp = 0;
        private int[] _requiredXP = { 100, 500, 1500, 3000 };

        public Character(string name)
        {
            _name = name;
        }

        public string Name()
        {
            return _name;
        }

        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level: " + _playerLevel);
            Console.WriteLine("XP: " + _xp);
        }


        //property declaration;
        public int Experience
        {
            get
            {
                return _xp;
            }
            set
            {
                _xp = value;
                Console.WriteLine(_name + " gained experience and now has " + _xp);

                //
                if (_playerLevel <= _requiredXP.Length)
                {
                    if (_xp >= _requiredXP[_playerLevel - 1])
                    {
                        _playerLevel++;
                        Console.WriteLine(_name + "'s level increased to " + _playerLevel + "!");
                    }
                }
                
            }
        }
    }
}
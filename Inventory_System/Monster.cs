using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{
    class Monster
    {
        private string _name = "Monster";
        private int _health = 10;
        private int _maxHealth = 10;
        private int _damage = 10;
        
        //Functions are turned into constructors if they have 
        //the same name as the class they are in.
        public Monster(string newName, int newHealth, int newDamage)
        {
            _name = newName;
            _health = newHealth;
            _maxHealth = newHealth;
            _damage = newDamage;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetDamage()
        {
            return _damage;
        }
        

        //properties use "get" and "set".
        //"get" gives you the value of a variable.
        //"set" will assign a new value to a variable.
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                if(value >= _maxHealth)
                {
                    _health = _maxHealth;
                }
                else if(_health <= 0)
                {
                    _health = 0;
                }                
                
            }
        }

        public void Print()
        {
            Console.WriteLine("\n" + _name + "'s health: " + _health + "/" + _maxHealth);
            Console.WriteLine(_name + "'s damage: " + _damage);
        }

        //targets health - monster damage!!!!!!!!!!
        public void Fight(Monster target)
        {
            int damage = GetDamage();

            target.Health -= damage;
            Console.WriteLine(GetName() + " attacks " + target.GetName() + "\n" +
                target.GetName() + "health: " + target.Health);
        }
    }
}

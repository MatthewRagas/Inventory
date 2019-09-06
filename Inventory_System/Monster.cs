using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{
    class Monster : Creature
    {
        private string _name = "Monster";        
        private int _damage = 10;
        
        //Functions are turned into constructors if they have 
        //the same name as the class they are in.
        public Monster(string newName, int newHealth, int newDamage, int storedXP)
        {
            _name = newName;
            _health = newHealth;
            _maxHealth = newHealth;
            _damage = newDamage;
            _xp = storedXP;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetDamage()
        {
            return _damage;
        }
        

        //properties use "get" and "set".
        //"get" gives you the value of a variable.
        //"set" will assign a new value to a variable.      

        public override void Print()
        {
            Console.WriteLine("\n" + _name + "'s health: " + _health + "/" + _maxHealth);
            Console.WriteLine(_name + "'s damage: " + _damage);
        }

        //targets health - monster damage!!!!!!!!!!
        public override void Fight(Creature target)
        {
            if (Health <= 0)
            {                
                return;
            }

            int damage = GetDamage();

            target.Health -= damage;
            Console.WriteLine("\n" + GetName() + " attacks " + target.GetName() + "\n" +
                target.GetName() + "health: " + target.Health);

           
        }

        public override void Fight(Creature[] targets)
        {
            if (Health <= 0)
            {
                return;
            }            
            int choice = Program.random.Next(0, targets.Length);
            Fight(targets[choice]);           
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{
    class Character : Creature
    {        
        private int _playerLevel = 1;
        private int _xp = 0;
        private int[] _requiredXP = { 100, 500, 1500, 3000 };

        private Inventory inventory = new Inventory();

        int currenWeapon = 0;

        protected string _name = "";
        protected int _health = 100;
        protected int _maxHealth = 100;
        protected int _mana = 100;
        protected int _strength = 5;
        protected int _speed = 5;
        protected int _wisdom = 5;

        public Character(string name)
        {
            _name = name;            
        }

        public override string GetName()
        {
            return _name;
        }

        public override void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level: " + _playerLevel);
            Console.WriteLine("XP: " + _xp);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Mana: " + _mana);
            Console.WriteLine("Strength: " + _strength);
            Console.WriteLine("Speed: " + _speed);
            Console.WriteLine("Wisdom: " + _wisdom);
            Console.WriteLine("");
        }

        public void OpenInventory()
        {
            inventory.Menu();
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
        public override int GetDamage()
        {
            int damage = inventory.Damage;

            return damage + _strength;
        }
        public override void Fight(Creature target)
        {
            if (Health <= 0)
                return;
            int damage = GetDamage();

            target.Health -= damage;
            Console.WriteLine("\n" + GetName() + " attacks " + target.GetName() + "\n" +
                target.GetName() + "health: " + target.Health);

           
        }

        public override void Fight(Creature[] targets)
        {
            if(Health <= 0)
            {
                return;
            }

            bool validInput = false;
            while(!validInput)
            {
                Console.WriteLine("\nWho will " + GetName() + " fight?");
                //print menu

                //iterate though targets
                for(int i = 0; i < targets.Length ; i++)
                {
                    //Printh the current number (i) and current target
                    Console.WriteLine(i +": " + targets[i].GetName()); 
                }                

                //ReadLine to get user input
                string input = Console.ReadLine();
                //Conver the input to an integer
                int choice = Convert.ToInt32(input);
                //Check that the choice is valid (above 0 and below the array length)
                if(choice >= 0 && choice < targets.Length)
                {
                    //set validInput to true and fight the chosen target
                    validInput = true;
                    //Fight the chosen target
                    targets[choice].Health -= GetDamage();
                    Console.WriteLine(targets[choice].GetName() + "'s health" + targets[choice].Health);
                }
                
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{
    class Monster : Creature
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
                return;
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
            int choice = Program. random.Next(0, targets.Length);
            Fight(targets[choice]);


            //bool validInput = false;
            //while (!validInput)
            //{
            //    Console.WriteLine("\nWho will " + GetName() + " fight?");
            //    //print menu

            //    //iterate though targets
            //    for (int i = 0; i < targets.Length; i++)
            //    {
            //        //Printh the current number (i) and current target
            //        Console.WriteLine(i + ": " + targets[i].GetName());
            //    }

            //    //ReadLine to get user input
            //    string input = Console.ReadLine();
            //    //Conver the input to an integer
            //    int choice = Convert.ToInt32(input);
            //    //Check that the choice is valid (above 0 and below the array length)
            //    if (choice >= 0 && choice < targets.Length)
            //    {
            //        //set validInput to true and fight the chosen target
            //        validInput = true;
            //        //Fight the chosen target
            //        targets[choice].Health -= GetDamage();
            //        Console.WriteLine(targets[choice].GetName() + "'s health" + targets[choice].Health);
            //    }


            //}
        }
    }
}

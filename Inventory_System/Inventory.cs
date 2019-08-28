using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{
    class Inventory
    {
        private int _damage = 10;
        private float _gold = 0.00f;
        private bool _weapon = false;
        private string _option = "";
        private int _currentWeight = 0;
        private int _maxWeight = 200;        
        private AttackItem[] _weaponList = new AttackItem[4];        

       //populating the attack item list.
       public Inventory()
        {
            _weaponList[0] = new AttackItem("Dagger", 10, 3);
            _weaponList[1] = new AttackItem("Sword", 15, 7);
            _weaponList[2] = new AttackItem("Scepter", 8, 8);
            _weaponList[3] = new AttackItem("Bow", 22, 12);
            

        }
       

        public void Menu()
        {
            string choice = "";
            

            while(choice != "0")
            {

                //Display menu;
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Equip Weapon");
                Console.WriteLine("2: Unequip Weapon");
                Console.WriteLine("3: Add gold");
                Console.WriteLine("4: Subtract gold");

                //Get user input;
                choice = Console.ReadLine();
                Console.WriteLine("");
                if(choice == "1")
                {
                   
                }
                else if (choice == "2" && _weapon == true)
                {
                   
                }
                else if(choice == "3")
                {
                    Console.WriteLine("How much gold?");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if(choice== "4")
                {
                    Console.WriteLine("You want to lose money?\n" +
                        "Okay, how much do you want to spend");
                    float lostGold = Convert.ToSingle(Console.ReadLine());
                    SubtractGold(lostGold);
                }               
            }
        }

        public void WeaponMenu()
        {
           
                       
        }

        public void EquipWeapon()
        {
           
                      
;       }

        public void UnequipWeapon()
        {
            //You cannot unequip your hands;
          
        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold.");
            _gold += amount;
            Console.WriteLine("Gold: " + _gold);        }

        public void SubtractGold(float amount)
        {
            _gold -= amount;
            if (_gold < 0)
            {
                _gold += amount;
                Console.WriteLine("You don't have enough to buy that.");
            }
            else
            {
                Console.WriteLine("Lost " + amount + " gold.");
            }
            
            Console.WriteLine("Gold: " + _gold);
        }
    }

}

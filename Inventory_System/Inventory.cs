using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{
    class Inventory
    {
        private int _damage = 5;
        private int _defense = 0;
        private float _gold = 0.00f;
        private bool _weapon = false;
        private bool _armor = false;
        private int _currentWeight = 0;
        private int _maxWeight = 200;
        private AttackItem _currentWeapon;
        private DefenseItem _currentArmor;
        private AttackItem[] _weaponList = new AttackItem[4];
        private DefenseItem[] _armorList = new DefenseItem[4];

        //populating the attack item list.
        //Constructor for inventory
        public Inventory()
        {
            _weaponList[0] = new AttackItem("Dagger", 10, 3);
            _weaponList[1] = new AttackItem("Sword", 15, 7);
            _weaponList[2] = new AttackItem("Scepter", 8, 8);
            _weaponList[3] = new AttackItem("Bow", 22, 12);

            _armorList[0] = new DefenseItem("Leather", 25, 5);
            _armorList[1] = new DefenseItem("Chain Mail", 35, 15);
            _armorList[2] = new DefenseItem("Plate", 50, 25);
            _armorList[3] = new DefenseItem("Robes", 0, 1);
        }


        public void Menu()
        {
            string choice = "";


            while (choice != "0")
            {

                //Display menu;
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Equip Weapon");
                Console.WriteLine("2: Unequip Weapon");
                Console.WriteLine("3: Equip Armor");
                Console.WriteLine("4: Unequip Armor");
                Console.WriteLine("5: Add gold");
                Console.WriteLine("6: Subtract gold");

                //Get user input;
                choice = Console.ReadLine();
                Console.WriteLine("");
                if (choice == "1")
                {
                    WeaponMenu();
                }
                else if (choice == "2" && _weapon == true)
                {
                    UnequipWeapon(_currentWeapon);
                }
                else if(choice == "3")
                {
                    ArmorMenu();
                }
                else if(choice == "4")
                {
                    UnequipArmor(_currentArmor);
                }
                else if (choice == "5")
                {
                    Console.WriteLine("How much gold?");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if (choice == "6")
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
            Console.WriteLine("Which weapon would you like to Equip?");
            Console.WriteLine("0: Exit\n1: Dagger\n2: Sword\n3: Scepter\n4: Bow");
            string choice = Console.ReadLine();

            if (choice == "0")
            {

            }
            else if (choice == "1")
            {
                EquipWeapon(_weaponList[0]);
            }
            else if (choice == "2")
            {
                EquipWeapon(_weaponList[1]);
            }
            else if (choice == "3")
            {
                EquipWeapon(_weaponList[2]);
            }
            else if (choice == "4")
            {
                EquipWeapon(_weaponList[3]);
            }

        }

        public void EquipWeapon(AttackItem newWeapon)
        {
            if(_weapon)
            {                
                _currentWeight += newWeapon.weight;
                if (_currentWeight < _maxWeight)
                {
                    _damage = newWeapon.Damage;
                    Console.WriteLine("You have Equipped a " + newWeapon.name + ".");
                    Console.WriteLine("Damage: " + newWeapon.Damage);
                    Console.WriteLine("Weight: " + _currentWeight);
                    _weapon = true;
                    _currentWeapon = newWeapon;
                }
                else
                {
                    _currentWeight -= newWeapon.weight;
                    Console.WriteLine("That item is too heavy.");
                    _weapon = false;
                }
            }
            else
            {
                _currentWeight += newWeapon.weight;
                if(_currentWeight < _maxWeight)
                {
                    _damage = newWeapon.Damage;
                    Console.WriteLine("You have Equipped a " + newWeapon.name + ".");
                    Console.WriteLine("Damage: " + newWeapon.Damage);
                    Console.WriteLine("Weight: " + _currentWeight);
                    _weapon = true;
                    _currentWeapon = newWeapon;
                }
                else
                {
                    _currentWeight -= newWeapon.weight;
                    Console.WriteLine("That item is too heavy.");
                    _weapon = false;
                }
                
            }
        }

        public void UnequipWeapon(AttackItem weapon)
        {
            //You cannot unequip your hands;
            _damage = 5;
            _currentWeight -= weapon.weight;
        }

        public void ArmorMenu()
        {
            Console.WriteLine("Which armor set are you wearing?");
            Console.WriteLine("0: Exit\n1: Leather\n2: Chain Mail\n3: Plate Armor\n4: Robes");

            string choice = Console.ReadLine();

            if (choice == "0")
            {

            }
            else if (choice == "1")
            {
                EquipArmor(_armorList[0]);
            }
            else if (choice == "2")
            {
                EquipArmor(_armorList[1]);
            }
            else if (choice == "3")
            {
                EquipArmor(_armorList[2]);
            }
            else if (choice == "4")
            {
                EquipArmor(_armorList[3]);
            }
        }
        public void EquipArmor(DefenseItem newArmor)
        {
            if(_armor)
            {
                UnequipArmor(_currentArmor);

                _currentWeight += newArmor.weight;

                if(_currentWeight < _maxWeight)
                {
                    _defense = newArmor.Defense;

                    Console.WriteLine("You have swapped to " + newArmor.name + " armor");
                    Console.WriteLine("Defense: " + _defense);
                    Console.WriteLine("Weight: " + _currentWeight);
                    _armor = true;
                    _currentArmor = newArmor;
                }
                else
                {
                    _currentWeight -= newArmor.weight;
                    Console.WriteLine("That item is too heavy");
                    _armor = false;
                }

                

            }
            else
            {
                _currentWeight += newArmor.weight;

                if (_currentWeight < _maxWeight)
                {
                    _defense = newArmor.Defense;

                    Console.WriteLine("You have swapped to " + newArmor.name + " armor");
                    Console.WriteLine("Defense: " + _defense);
                    Console.WriteLine("Weight: " + _currentWeight);
                    _armor = true;
                    _currentArmor = newArmor;
                }
                else
                {
                    _currentWeight -= newArmor.weight;
                    Console.WriteLine("That item is too heavy");
                    _armor = false;
                }
            }
        }
        public void UnequipArmor(DefenseItem armor)
        {
            _defense = 0;
            _currentWeight -= armor.weight;
        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold.");
            _gold += amount;
            Console.WriteLine("Gold: " + _gold);
        }

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

        public int Damage
        {
            get
            {
                return _damage;
            }
        }


    }   

}

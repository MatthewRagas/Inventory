using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Inventory
    {
        int damage = 10;
        float gold = 0.00f;
        bool weapon = false;
        string option = "";
        int currentWeight = 0;
        int maxWeight = 200;

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
                    WeaponMenu();
                }
                else if (choice == "2" && weapon == true)
                {
                    if (option == "0")
                        UnequipWeapon("Dagger", 9, 3);
                    else if(option == "1")
                        UnequipWeapon("Sword", 15, 7);
                    else if(option == "2")
                        UnequipWeapon("WarHammer", 25, 20);
                    else if(option == "3")
                        UnequipWeapon("GreatSword", 22, 16);
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
            string choice = "";

            while(choice != "4")
            {
                //Display Weapon Menu;
                Console.WriteLine("\n Weapon Menu:\n0: Dagger\n1: Sword\n2: " +
                    "Warhammer\n3: Greatsword\n4: Cancel");
                //Get use input for weapon choice;
                option = Console.ReadLine();

                //calls function to equip weapon;
                if (option == "0")
                    EquipWeapon("Dagger", 9, 3);
                else if (option == "1")
                    EquipWeapon("Sword", 15, 7);
                else if (option == "2")
                    EquipWeapon("WarHammer", 25, 20);
                else if (option == "3")
                    EquipWeapon("GreatSword", 22, 16);
                else if (option == "4")
                {
                    choice = "4";
                }
            }           
        }

        public void EquipWeapon(string weaponName, int weaponDamage, int weaponWeight)
        {
           
            while(weapon == false)
            { 

                damage = weaponDamage;
                currentWeight += weaponWeight;
                weapon = true;

                //checks weight limit;
                if (currentWeight > maxWeight)
                {
                    UnequipWeapon(weaponName, weaponDamage, weaponWeight);
                }
                Console.WriteLine("You have equipped a " + weaponName + "!\n" +
                    "Damage: " + damage + "\nWeight: " + currentWeight + "/" + maxWeight);
            }            
;        }

        public void UnequipWeapon(string weaponName, int weaponDamage, int weaponWeight)
        {
            //You cannot unequip your hands;
            if(weapon == false)
            {
                Console.WriteLine("You do not have a weapon equipped.");
                Console.WriteLine("Damage: " + damage);
                Console.WriteLine("Weight: " + currentWeight + "/" + maxWeight);
            }

            //Used to force Unequip weapon if weight breaks limit;
            else if(weapon == true && currentWeight > maxWeight)
            {
                Console.WriteLine("That Weapon is too heavy!");
                weapon = false;
                damage = 10;
                if (option == "0")
                    currentWeight -= 3;
                else if (option == "1")
                    currentWeight -= 9;
                else if (option == "2")
                    currentWeight -= 20;
                else if (option == "3")
                    currentWeight -= 201;
                Console.WriteLine("Damage: " + damage);
                Console.WriteLine("Weight: " + currentWeight + "/" + maxWeight);
                WeaponMenu();
            }

            //Option to Unequip Weapon
            else if(weapon == true)
            {
                Console.WriteLine("Unequipped a weapon.");
                currentWeight -= weaponWeight;
                damage = 10;
                weapon = false;
                Console.WriteLine("Damage: " + damage);
                Console.WriteLine("Weight: " + currentWeight + "/" + maxWeight);
            }
            
        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold.");
            gold += amount;
            Console.WriteLine("Gold: " + gold);        }

        public void SubtractGold(float amount)
        {
            gold -= amount;
            if (gold < 0)
            {
                gold += amount;
                Console.WriteLine("You don't have enough to buy that.");
            }
            else
            {
                Console.WriteLine("Lost " + amount + " gold.");
            }
            
            Console.WriteLine("Gold: " + gold);
        }
    }
}

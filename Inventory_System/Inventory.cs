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
                    EquipWeapon();
                }
                else if (choice == "2")
                {
                    UnequipWeapon();
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
                else
                {
                    Console.WriteLine("What????");
                }
            }
        }

        public void EquipWeapon()
        {
           
            if(weapon == false)
            {
                //Display Weapon Menu;
                Console.WriteLine("\n Weapon Menu:\n0: Dagger\n1: Sword\n2: " +
                    "Warhammer\n3: Greatsword\n4: Cancel");
                option = Console.ReadLine();
                if(option == "0")
                {
                    Console.WriteLine("Equipped a Dagger!");
                    damage = 25;
                    weapon = true;
                    Console.WriteLine("Damage: " + damage);
                }                
                else if (option == "1")
                {
                    Console.WriteLine("Equipped a Sword!");
                    damage = 35;
                    weapon = true;
                    Console.WriteLine("Damage: " + damage);
                }
                else if(option == "2")
                {
                    Console.WriteLine("Equipped a Warhammer!");
                    damage = 45;
                    weapon = true;
                    Console.WriteLine("Damage: " + damage);
                }
                else if(option == "3")
                {
                    Console.WriteLine("Equipped a GreatSword!");
                    damage = 45;
                    weapon = true;
                    Console.WriteLine("Damage: " + damage);
                }
                else if(option == "4")
                {

                }
            }            
;        }

        public void UnequipWeapon()
        {
            if(weapon == false)
            {
                Console.WriteLine("You do not have a weapon equipped.");
                Console.WriteLine("Damage: " + damage);
            }
            else if(weapon == true)
            {
                Console.WriteLine("Unequipped a weapon.");
                weapon = false;
                damage = 10;
                Console.WriteLine("Damage: " + damage);
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

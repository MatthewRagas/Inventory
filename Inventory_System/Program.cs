using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{
    class Program
    {
        static void Main(string[] args)
        {

            //created monsters
            Monster matt = new Monster("Ninja", 30, 30);
            Monster boi = new Monster("Jake Paul", 20, 20);
            Monster ree = new Monster("ree", 30, 30);
            Monster eer = new Monster("eer", 20, 20);
            Monster sam = new Monster("Sam", 20, 20);

            //created two arrays of existing monsters
            Monster[] blueTeam = { matt, boi, sam };
            Monster[] redTeam = { ree, eer };

            //Created an encounter using the two arrays.
            Encounter encounter = new Encounter(blueTeam, redTeam);

            encounter.Print();
            encounter.Start();


            Console.ReadKey();

            return;

            Inventory inventory = new Inventory();
            inventory.Menu();

            string name = "";
            string choice = "";

            Console.WriteLine("Enter the name for player1:");
            name = Console.ReadLine();
            while (choice != "1" && choice != "2" && choice != "3" && choice != "4")
            {
               

                //Display menu
                Console.WriteLine("\nWhat's your regiment?");
                Console.WriteLine("1: Shadow Assassins");
                Console.WriteLine("2: Rangers Core");
                Console.WriteLine("3: Castle Knights");
                Console.WriteLine("4: Temple Magi");
                choice = Console.ReadLine();

            }

            Character player;
            if (choice == "1")
                player = new Assassin(name);
            else if (choice == "2")
                player = new Ranger(name);
            else if (choice == "3")
                player = new Knight(name);
            else if (choice == "4")
                player = new Magi(name);
            else
                player = new Character(name);
            player.Print();

            Character mike = new Character("Mike");
            Character jeff = new Character("Jeff");
            Character kyle = new Character("Kyle");
            kyle.Print();
            mike.Print();
            jeff.Print(); 

            while(choice != "0")
            {
                Console.WriteLine("Whose inventory?");                
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: " + player.Name());
                Console.WriteLine("2: " + kyle.Name());
                Console.WriteLine("3: " + mike.Name());
                Console.WriteLine("4: " + jeff.Name());
                choice = Console.ReadLine();

                if (choice == "0")
                {

                }
                else if(choice == "1")
                {
                    Console.WriteLine(player.Name());
                    player.OpenInventory();
                }
                else if(choice == "2")
                {
                    Console.WriteLine(kyle.Name());
                    kyle.OpenInventory();
                }
                else if (choice == "3")
                {
                    Console.WriteLine(mike.Name());
                    mike.OpenInventory();
                }
                else if (choice == "4")
                {
                    Console.WriteLine(jeff.Name());
                    jeff.OpenInventory();
                }
            }            

            Assassin hero = new Assassin("Weaboo Johnson");

            hero.Experience = 30;
            hero.Experience += 70;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience += 200;
            hero.Experience++;
            hero.Print();            

            //an array is a list of a variable type;
            //first slot of an array is always 0;
            //you can initialize a variable in the list of an array;
            int[] testArray = new int[4];

            //assigning the slots of the array;
            testArray[0] = 1;        
            testArray[1] = 3;
            testArray[2] = 5;
            testArray[3] = 7;

          

            Console.ReadKey();
        }
    }
}

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
            Character matt = new Ranger("Ninja");
            Character boi = new Assassin("Jake Paul");
            Monster ree = new Monster("ree", 30, 30);
            Monster eer = new Monster("eer", 20, 20);
            Monster sam = new Monster("Sam", 20, 20);

            //created two arrays of existing monsters
            Creature[] blueTeam = { matt, boi, sam };
            Creature[] redTeam = { ree, eer };

            //Created an encounter using the two arrays.
            Encounter encounter = new Encounter(blueTeam, redTeam);

            encounter.Print();
            encounter.Start();


            Console.ReadKey();

            return;

            //Inventory inventory = new Inventory();
            //inventory.Menu();

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
                Console.WriteLine("1: " + player.GetName());
                Console.WriteLine("2: " + kyle.GetName());
                Console.WriteLine("3: " + mike.GetName());
                Console.WriteLine("4: " + jeff.GetName());
                choice = Console.ReadLine();

                if (choice == "0")
                {

                }
                else if(choice == "1")
                {
                    Console.WriteLine(player.GetName());
                    player.OpenInventory();
                }
                else if(choice == "2")
                {
                    Console.WriteLine(kyle.GetName());
                    kyle.OpenInventory();
                }
                else if (choice == "3")
                {
                    Console.WriteLine(mike.GetName());
                    mike.OpenInventory();
                }
                else if (choice == "4")
                {
                    Console.WriteLine(jeff.GetName());
                    jeff.OpenInventory();
                }
            }                                   

            //an array is a list of a variable type;
            //first slot of an array is always 0;
            //you can initialize a variable in the list of an array;

          

            Console.ReadKey();
        }
    }
}

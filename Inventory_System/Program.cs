using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{
    class Program
    {
        public static Random random = new Random();


        static void Main(string[] args)
        {
            ////0: courtyard
            ////1: Graveyard
            ////2: Caslte Gates
            ////3: Village
            //Scene courtYard = new Scene("Courtyard", 2, 3, 1, 0, "The yard has a beautiful garden of many different flowers. The sky is clear and its nice and cool outside. There are exits in three directions N/S/E");
            //Scene graveYard = new Scene("Graveyard", 1, 3, 1, 0, "There are many Topmbstones around. Most of them belonging to the Scout Regiment. You press F to pay respects. There are two exits", "You found The Devil's Scepter!");
            //Scene castleGates = new Scene("Castle Gates", 2, 0, 2, 2, "The castle is massive but the gaurds stop you from entering. You are not permitted into the castle just yet.");
            //Scene village = new Scene("Village", 0, 3, 1, 3, "There are towns people walking around and the shops are busy today. You feel crowded. There are two exits N/S");
            //Scene[] scenes = { courtYard, graveYard, castleGates, village };
            //Map map = new Map(0, scenes);
           

            ////map.PrintCurrentScene();
            //map.Menu();

            ////map.CurrnetSceneID = 1;
            ////map.PrintCurrentScene();
            ////map.CurrnetSceneID = 2;
            ////map.PrintCurrentScene();
            ////map.CurrnetSceneID = 3;
            ////map.PrintCurrentScene();

            //Console.ReadKey();

            //return;














            //created monsters
            Character matt = new Ranger("Ninja");
            Character boi = new Assassin("Jake Paul");
            Monster ree = new Monster("ree", 30, 30);
            Monster eer = new Monster("eer", 20, 20);
            Monster sam = new Monster("Sam", 20, 20);

            //created two arrays of existing monsters
            Creature[] blueTeam = { matt, boi, sam };
            Creature[] redTeam = { ree, eer };


            matt.OpenInventory();
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

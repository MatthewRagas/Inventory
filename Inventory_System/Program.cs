using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inventory inventory = new Inventory();
            //inventory.Menu();

            Character hero = new Character("Weaboo Johnson");
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

            Character mike = new Character("Mike");
            Character jeff = new Character("Jeff");
            mike.Print();
            jeff.Print();

            Console.ReadKey();
        }
    }
}

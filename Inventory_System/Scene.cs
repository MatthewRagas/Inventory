﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{
    class Scene
    {

        private string _name = "";
        private string _description = "";
        private int _north;
        private int _south;
        private int _east;
        private int _west;
        private string _hidden;
        private Creature[] _monsterList;

        //Scene constructor
        public Scene(string name, int northID, int southID, int eastID, int westID, Creature[] monsters, string description, string hidden)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
            _hidden = hidden;
            _monsterList = monsters;
        }
        public Scene(string name, int northID, int southID, int eastID, int westID, Creature[] monsters, string description)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
            _monsterList = monsters;
        }

        //Return the name
        public string GetName()
        {
            return _name;
        }

        //return the description
        public string GetDescription()
        {
            return _description;
        }   

        public int ChooseExit()
        {
            string choice = "";

            while (choice != "N" && choice != "S" && choice != "E" && choice != "W")
            {
                Console.WriteLine("Which direction would you like to go in?");
                Console.WriteLine("North: N\nSouth: S\nEast: E\nWest: W");
                choice = Console.ReadLine();
                choice = choice.ToUpper();
            }
            if (choice == "N")
            {
                return _north;
            }
            else if (choice == "S")
            {
                return _south;
            }
            else if (choice == "E")
            {
                return _east;
            }
            else if (choice == "W")
            {
                return _west;
            }
            else
                return -1;
        }

        public string GetHidden()
        {
            return _hidden;
        }
    }
}

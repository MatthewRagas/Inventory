using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPG_System
{
    class Map
    {
        private int _currentLocation;
        private Scene[] _sceneList;

        public Map(int startingSceneID, Scene[] scenes)
        {
            _currentLocation = startingSceneID;
            _sceneList = scenes;
        }

        public void PrintCurrentScene()
        {
            //if the current scene id is in range
            if (_currentLocation >= 0  && _currentLocation < _sceneList.Length)
            {
                //Print the current scene's name and description
                Console.WriteLine("");
                Console.WriteLine(_sceneList[_currentLocation].GetName());
                Console.WriteLine(_sceneList[_currentLocation].GetDescription());
            }
            else
            {
                Console.WriteLine("\nInvalid scene ID");
            }
        }

        public int CurrnetSceneID
        {
            get
            {
                return _currentLocation;
            }
            set
            {
                if(value >= 0 && value < _sceneList.Length)
                {
                    _currentLocation = value;
                }
                else
                {
                    Console.WriteLine("\nInvalid scene ID");
                }
            }
        }

        public void Menu()
        {
            string choice = "";

            while (choice != "0")
            {
                Console.WriteLine("Would you like to travel?");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Travel");
                Console.WriteLine("2: Save");
                Console.WriteLine("3: Load");
                Console.WriteLine("4: Search");
                choice = Console.ReadLine();

                if(choice == "1")
                {
                    Travel();
                    PrintCurrentScene();
                }
                else if ( choice == "2")
                {
                    Save("Save.txt");
                }
                else if(choice == "3")
                {
                    load("save.txt");
                }
                else if(choice == "4")
                {
                    Search();
                }
            }
        }
        public void Travel()
        {
            int destination = -1;

            if(_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                destination = _sceneList[_currentLocation].ChooseExit();
            }

            if(destination >= 0 && destination < _sceneList.Length)
            {
                CurrnetSceneID = destination;
            }
            else
            {
                Console.WriteLine("\nInvalid scene ID.");
            }
        }

        public void Save(string path)
        {
            //Create a writer for he file at our path
            StreamWriter writer = File.CreateText(path);
            
            //Write to it the same way we write
            writer.WriteLine(CurrnetSceneID);
            writer.Close();
        }

        public void load(string path)
        {
            if(File.Exists(path))
            {
                //Create a reader for the file at our path
                StreamReader reader = File.OpenText(path);
                //Write to it the same way we read to it.
                CurrnetSceneID = Convert.ToInt32(reader.ReadLine());
                reader.Close();
            }            
        }

        public void Search()
        {
            if(_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                Console.WriteLine(_sceneList[_currentLocation].GetHidden());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{
    class Encounter
    {
        private Creature[] _blueMonsters;
        private Creature[] _redMonsters;
        private Creature _player;

        //Constructor
        public Encounter(Creature[] playerParty, Creature[] monsters)
        {
            _blueMonsters = playerParty;
            _redMonsters = monsters;
        }
        public Encounter(Creature player, Creature[] monsters)
        {
            _player = player;
            _blueMonsters = monsters;
        }

        public void Print()
        {
            for(int i = 0; i < _blueMonsters.Length; i++)
            {
                Creature currentMonster = _blueMonsters[i];
                currentMonster.Print();
            }
            for(int i = 0; i < _redMonsters.Length; i++)
            {
                Creature currentMonster = _redMonsters[i];
                currentMonster.Print();
            }
        }

        public void BeginRound()
        {
            //iterates through blue monster and fight first red monster
            for(int i = 0; i < _blueMonsters.Length; i++)
            {
                _blueMonsters[i].Fight(_redMonsters);
            }

            //iterates though red monsters and fights first blue
            for (int i = 0; i < _redMonsters.Length; i++)
            {
                _redMonsters[i].Fight(_blueMonsters);
            }

        }

        public void Start()
        {
            Console.WriteLine("\nEncounter Start!");
            bool stillFighting = true;
            while(stillFighting)
            {
                //chekc if team1 is alive
                bool blueAlive = true;
                for(int i = 0; i < _blueMonsters.Length; i++)
                {
                    if(_blueMonsters[i].Health > 0)
                    {
                        blueAlive = true;
                        break;
                    }
                    else if(_blueMonsters[i].Health <= 0)
                    {
                        blueAlive = false;
                    }
                }
                if(blueAlive)
                {
                    Console.WriteLine("Blue Team is still alive!");
                }
                //check if team2 is alive

                bool redAlive = true;
                for(int i = 0; i < _redMonsters.Length; i++)
                {
                    if(_redMonsters[i].Health > 0)
                    {
                        redAlive = true;
                        break;
                    }
                    else if(_redMonsters[i].Health <= 0)
                    {
                        redAlive = false;
                    }
                }
                //if both teams are alive
                if(redAlive)
                {
                    Console.WriteLine("Red Team is still alive!");
                }
                if(blueAlive && redAlive)
                {
                    stillFighting = true;
                    BeginRound();
                }
                else
                {
                    stillFighting = false;
                }
                    //fight
                //otherwise
                    //stop
            }
        }
    }
}

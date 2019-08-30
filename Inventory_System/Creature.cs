using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_System
{
    class Creature
    {
        protected int _health = 5;
        protected int _maxHealth = 5;       
        public virtual void Fight(Creature target)
        {

        }

        public virtual void Fight(Creature[] targets)
        {

        }

        public virtual void Print()
        {

        }

        public virtual int GetDamage()
        {
            return 0;
        }
        public virtual string GetName()
        {
            return "";
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                if (value >= _maxHealth)
                {
                    _health = _maxHealth;
                }
                else if (_health <= 0)
                {
                    _health = 0;
                }

            }
        }
    }
}

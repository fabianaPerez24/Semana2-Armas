using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Weapon : Item
    {
        protected string name;
        protected float damage;
        protected float attackSpeed;


        public virtual float GetDamagePerSecond()
        {
            return damage * attackSpeed;
        }

        public string Name
        {
            get { return name; }
        }

    }
}

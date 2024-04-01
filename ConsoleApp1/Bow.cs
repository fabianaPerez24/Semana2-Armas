using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bow : RangedWeapon
    {
        public Bow(string name, float damage, float attackSpeed, float price, Arrow arrow)
        {
            this.name = name;
            this.damage = damage;
            this.price = price;
            this.attackSpeed = attackSpeed;
            this.projectile = arrow;
        }

        public override float GetDamagePerSecond()
        {
            return base.GetDamagePerSecond() + projectile.Damage;
        }
    }
}

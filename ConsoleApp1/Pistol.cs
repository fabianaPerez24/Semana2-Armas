using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pistol : RangedWeapon
    {
        public Pistol(string name, float damage, float attackSpeed, float price, Bullet bullet)
        {
            this.name = name;
            this.damage = damage;
            this.price = price;
            this.attackSpeed = attackSpeed;
            this.projectile=bullet;
        }

        public override float GetDamagePerSecond()
        {
            return base.GetDamagePerSecond()+ projectile.Damage;
        }
    }
}

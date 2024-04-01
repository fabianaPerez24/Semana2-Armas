using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bullet : Projectile
    {
        public Bullet(float damage, float price)
        {
            this.damage = damage;
            this.price = price;
        }

    }
}

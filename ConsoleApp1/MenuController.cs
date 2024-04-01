using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MenuController
    {
        private List<Weapon> weapon=new List<Weapon>();
        public void Execute()
        {
            bool continueFlag=true; 
            while(continueFlag)
            {
                Console.WriteLine("Selecciona la opción: ");
                Console.WriteLine("1. Agregar espada");
                Console.WriteLine("2. Agregar pistola");
                Console.WriteLine("3. Agregar arco");


                Console.WriteLine("7.Borrar arma del inventario");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        AddSword();
                        break;

                    case "2":
                            AddPistol();
                        break;
                    case "3":
                        AddBow();
                        break;
                       

                    case "7":
                            EraseWeapon();
                        break;

                    case "0":
                        continueFlag=false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.Clear();
            }
        }

        private void EraseWeapon()
        {
            if(weapon.Count==0)
            {
                Console.WriteLine("No tienes armas xd");
                return;
            }

            for(int i = 0; i < weapon.Count; i++)
                    Console.WriteLine($"{i}.- {weapon[i].Name}");
            Console.WriteLine("Que arma quieres eliminar?");
            int Indice= int.Parse(Console.ReadLine());
                weapon.RemoveAt(Indice);
        }

        private void AddSword()
        {
            Console.WriteLine("Introduce el nombre de la espada:");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce el daño de la espada:");
            float damage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la velocidad de ataque de la espada:");
            float attackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el precio de la espada:");
            float price = float.Parse(Console.ReadLine());
            weapon.Add(new Sword(name, damage, attackSpeed, price));
        }
        private void AddPistol()
        {
            Console.WriteLine("Introduce el nombre de la pistola:");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce el daño de la pistola:");
            float damage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la velocidad de ataque de la pistola:");
            float attackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el precio de la pistola:");
            float price = float.Parse(Console.ReadLine());

            //agregar nueva bala

            Console.WriteLine("Introduce el daño de la bala:");
            float Bulletdamage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el precio de la bala:");
            float Bulletprice = float.Parse(Console.ReadLine());
            Bullet bullet= new Bullet(Bulletdamage,Bulletprice);

            weapon.Add(new Pistol(name, damage, attackSpeed, price, bullet));
        }

        private void AddBow()
        {
            Console.WriteLine("Introduce el nombre del arco:");
            string Bowname = Console.ReadLine();
            Console.WriteLine("Introduce el daño del arco:");
            float Bowdamage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la velocidad de ataque del arco:");
            float BowattackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el precio del arco:");
            float Bowprice = float.Parse(Console.ReadLine());

            //agregar nueva flecha

            Console.WriteLine("Introduce el daño de la flecha:");
            float Arrowdamage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el precio de la flecha:");
            float Arrowprice = float.Parse(Console.ReadLine());
            Arrow arrow = new Arrow(Arrowdamage, Arrowprice);

            weapon.Add(new Bow(Bowname, Bowdamage, BowattackSpeed, Bowprice, arrow));
        }
    }


}

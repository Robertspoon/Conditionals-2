using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_2
{
    internal class Program
    {
        static int health;
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");
            Console.WriteLine();

            health = 100;
            TakeDamage(20);
            TakeDamage(30);
            

            ShowHud();
            if (health == 0)
            {
                Console.WriteLine("Game Over");
            }
           

            Console.ReadKey(true);

        }
        static void TakeDamage(int Damage)
        {
            Console.WriteLine("Player is about to take " + Damage + " damage...");
            health = health - Damage;

            if (health < 0)
            health = 0;
        }
        static void ShowHud()
        {
            string status;
            status = "";
             
            Console.WriteLine("Health: " + health);
            

            if ((health >=50) && (health <= 75))
            {
                status = "HURT";
            }

            Console.WriteLine("Status: " + status);
        }
    }
}

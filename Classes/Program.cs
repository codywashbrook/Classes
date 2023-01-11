using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        struct Vector2
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Classes: ");
            Console.WriteLine();

            //Player player = new Player();
            Player player; //declaration
            player  = new Player("Cody", 100); //instantiation
            player.health = 100;
            player.ShowStats();
            //Console.WriteLine(player.name + " health = " + player.health);
            player.TakeDamage(15);
            player.ShowStats();
            //Console.WriteLine(player.name + " health = " + player.health);


            Vector2 position;


            Enemy enemy = new Enemy();

            Console.ReadKey(true);
        }
    }
}

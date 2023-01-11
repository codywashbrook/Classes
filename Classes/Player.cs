using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Player
    {
        public int x;
        public int y;
        public int health;
        public string name;

        public Player(string name, int health)
        {
            x = 0;
            y = 0;
            this.health = health;
            this.name = name; //use for different gamertags for example
            Console.WriteLine("Player class constructed");
        }

        public void TakeDamage(int hp)
        {
            health -= hp;

            Console.WriteLine(name + " has taken .. " + hp + " damage");

        }

        public void ShowStats()
        {
            Console.WriteLine(name + " Health: " + health);
        }
    }
}

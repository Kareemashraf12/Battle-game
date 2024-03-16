using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit player = new Unit(100, 12, 20, "kareem");
            Unit enemy = new Unit(100, 12, 20, "ruby");
            Random ra = new Random();

            while (!player.IsDead && !enemy.IsDead)
            {
                Console.WriteLine(player.unitname + " " + player.HP + " . " + enemy.unitname + " " + enemy.HP);
                Console.WriteLine("player turn ! what will yo do ?");
                string chiose = Console.ReadLine();

                if (chiose == "a")
                    player.Attack(enemy);
                else
                    player.Heal();
                if (player.IsDead || enemy.IsDead)
                    break;

                Console.WriteLine(player.unitname + " " + player.HP + " . " + enemy.unitname + " " + enemy.HP);
                Console.WriteLine("enmy turn!");
                int rand = ra.Next(0 ,2);
                if (rand == 0)
                    enemy.Attack(player);
                else
                    enemy.Heal();

            }
            Console.ReadKey();
        }
    }
}

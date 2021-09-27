using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUD_V1._1
{
    class Program
    {

        static int health;
        static int score;
        static int xp;
        

        static void Main(string[] args)
        {
            Title();
            Armour(25);
            HUD();
        }


        static void Damage()
        {

        }
        static void HUD()
        {
            Console.WriteLine("Health = " + health);
            Console.WriteLine("Armour = " + armour);
            Console.ReadKey(true);
        }

        static void Armour(int armour)
        {
            
        }

        static void Title()
        {
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("Welcome to working_title!");
            Console.WriteLine();
            Console.WriteLine("buy a better game....");
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}

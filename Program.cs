using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bebe vs Poppy

            Random rnd = new Random();

            int poopyHealth, bebeHealth;

            bebeHealth = 10;
            poopyHealth = 10;
            int damage;
            int b = 0;
            int p = 0;


            while (b != 10 && p !=10)
            {


                while (poopyHealth != 0 && bebeHealth != 0)
            {
                    if (poopyHealth == 10 && bebeHealth == 10)
                    {
                        Console.WriteLine(b + " Times Bebe won");
                        Console.WriteLine(p + " Times Poppy won");
                        Console.ReadLine();
                    }

                    damage = rnd.Next(1, 7);
                Console.WriteLine("Bebe took " + damage + " damage !");
                Console.ReadLine();
                bebeHealth -= damage;

                damage = rnd.Next(1, 7);
                Console.WriteLine("Poppy took " + damage + " damage !");
                Console.ReadLine();
                poopyHealth -= damage;

                if (poopyHealth <= 0)
                {
                    poopyHealth = 0;
                }
                if (bebeHealth <= 0)                                            // using random class
                {
                    bebeHealth = 0;
                }

                Console.WriteLine("Bebe health : " + bebeHealth + "/10");
                Console.WriteLine("Poppy health : " + poopyHealth + "/10");

                Console.ReadLine();

                    if (bebeHealth != 0 && poopyHealth == 0)
                    {
                        Console.WriteLine("Beeby win");
                        b++;
                        bebeHealth = 10;
                        poopyHealth = 10;
                        Console.ReadLine();
                        Console.Clear();

                    }
                    if (poopyHealth != 0 && bebeHealth == 0)
                    {
                        Console.WriteLine("Poopy win");
                        p++;
                        bebeHealth = 10;
                        poopyHealth = 10;
                        Console.ReadLine();
                        Console.Clear();

                    }
                    if (poopyHealth == 0 && bebeHealth == 0)
                    {
                        Console.WriteLine("Both fainted!");
                        bebeHealth = 10;
                        poopyHealth = 10;
                        Console.ReadLine();
                        Console.Clear();

                    }


                }

            }



            Console.ReadLine();

        }
    }
}

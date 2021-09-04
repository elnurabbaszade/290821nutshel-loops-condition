using System;

namespace Loops.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 9; i >= 0; i--)
            //{
            //    Console.WriteLine(i+1);
            //}

            //int i = 10;
            //while (i > 0)
            //{
            //    Console.WriteLine(i--);
            //}

            //int i = 11;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i < 10);

            string[] sozler = { "soz22", "soz-3", "2ci soz" };

            //for (int i = 0; i < sozler.Length; i++)
            //{
            //    Console.WriteLine(sozler[i]);
            //}

            foreach (string qab in sozler)
            {
                Console.WriteLine(qab);
            }

            Console.ReadKey();

        }
    }
}

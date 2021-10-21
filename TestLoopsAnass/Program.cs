using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLoopsAnass
{
    class Program
    {
        static void Main(string[] args)
        {
            int grootsteGetal = 0;
            int getal = 0;
            int i = 0;

            while (i <= 2)
            {
                Console.WriteLine("Geef een getal in");
                getal = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    grootsteGetal = getal;
                }
                if (getal > grootsteGetal)
                {
                    grootsteGetal = getal;
                }
                i++;
            }
            Console.WriteLine($"Het grootste getal is {grootsteGetal}");
        }
    }
}

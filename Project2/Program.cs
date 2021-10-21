using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string input = "S";
            double markE = 0;
            double markP = 0;
            double markN = 0;
            double sum = 0;
            double gemiddelde = 0;

            do
            {
                Console.WriteLine("Geef de naam van de student in");
                name = Console.ReadLine();

                Console.WriteLine("Geef punten voor Engels");
                markE = double.Parse(Console.ReadLine());
                Console.WriteLine("Geef punten voor Programatie");
                markP = double.Parse(Console.ReadLine());
                Console.WriteLine("Geef punten voor Netwerken");
                markN = double.Parse(Console.ReadLine());

                if (true)
                {
                    sum = markE + markP + markN;
                    gemiddelde = sum / 3;
                }
                break;
                
            } while (input == "S");
            Console.WriteLine($"{name} heeft in totaal {sum} punten gehaald, waarvan het gemiddelde {gemiddelde} is");
        }
    }
}

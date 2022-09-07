using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Velkommen til Ungeråd's Flyt-hjemmefra service");
                Console.WriteLine("Hvad er dit navn:");
                string navn = Console.ReadLine();
                Console.Write("Indtast din timeløn: ");
                string timeløn = Console.ReadLine();
                Console.Write("Hvor mange timer arbejder du om ugen: ");
                string timer = Console.ReadLine();
                double ugeløn = Convert.ToDouble(timeløn) * Convert.ToDouble(timer);
                Console.WriteLine($"Hej, {navn}. Du tjener kr. {ugeløn},- om ugen.");
                int stjerner = Convert.ToInt16(ugeløn) / 100; 
                for (int i = 0; i < stjerner; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                if (ugeløn > 2600)
                {
                    Console.WriteLine("Du har råd til at flytte hjemmefra.");
                }
                else
                {
                    Console.WriteLine("Du har ikke råd til at flytte hjemmefra.");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

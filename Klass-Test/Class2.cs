using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    internal class Bil
    {
        private string namn;
        private string vikt;
        private string modell;

        public void SetNamn()
        {
            Regex regexp = new(@"\w");

            Console.WriteLine();
            Console.Write("Skriv in bilens namn: ");

            string input = Console.ReadLine();
            MatchCollection match = regexp.Matches(input);

            if (match.Count > 0)
            {
                namn = input;
            }
            else
            {
                Console.WriteLine("Fel input");
                SetNamn();
            }
        }

        public void SetVikt()
        {
            Regex regexp = new(@"\d");

            Console.WriteLine();
            Console.Write("Skriv in vikten: ");

            string input = Console.ReadLine();
            MatchCollection match = regexp.Matches(input);

            if (match.Count > 0)
            {
                vikt = input;
            }
            else
            {
                Console.WriteLine("Fel input");
                SetAge();
            }
        }
        public void SetModell()
        {
            Regex regexp = new(@"\w");

            Console.WriteLine();
            Console.Write("Skriv in bilens modell: ");

            string input = Console.ReadLine();
            MatchCollection match = regexp.Matches(input);

            if (match.Count > 0)
            {
                modell = input;
            }
            else
            {
                Console.WriteLine("Fel input");
                SetModell();
            }
        }

        public void WriteValue()
        {
            Console.WriteLine("Vilket värde vill du skriva ut?");
            Console.WriteLine("1. Skriv ut alla värden");
            Console.WriteLine("2. Skriv ut namn");
            Console.WriteLine("3. Skriv ut vikt");
            Console.WriteLine("4. Skriv ut modell");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Namn: " + namn);
                    Console.WriteLine("Vikt:" + vikt);
                    Console.WriteLine("Modell: " + modell);
                    break;

                case 2:
                    Console.WriteLine("Namn: " + namn);
                    break;

                case 3:
                    Console.WriteLine("Vikt:" + vikt);
                    break;

                case 4:
                    Console.WriteLine("Modell: " + modell);
                    break;

                default:
                    Console.WriteLine("Felaktig input");
                    WriteValue();
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    internal class Personregister
    {
        private string namn;
        private string ålder;
        private string adress;
        private string postNummer;

        public void SetNamn()
        {
            Regex regexp = new(@"\w");

            Console.WriteLine();
            Console.Write("Skriv in ditt namn: ");

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

        public void SetAge()
        {
            Regex regexp = new(@"^(1[0-4][0-9])|(0?[1-9][0-9])|([0]{0,2}[1,9])$");

            Console.WriteLine();
            Console.Write("Skriv in din ålder: ");

            string input = Console.ReadLine();
            MatchCollection match = regexp.Matches(input);

            if (match.Count > 0)
            {
                ålder = input;
            }
            else
            {
                Console.WriteLine("Fel input");
                SetAge();
            }
        }

        public void SetAddress()
        {
            Regex regexp = new(@"^\w+ ?\d+$");

            Console.WriteLine();
            Console.Write("Skriv in din address: ");

            string input = Console.ReadLine();
            MatchCollection match = regexp.Matches(input);

            if (match.Count > 0)
            {
                adress = input;
            }
            else
            {
                Console.WriteLine("Fel input");
                SetAddress();
            }
        }

        public void SetPostNummer()
        {
            Regex regexp = new(@"\d{3}[ |\-|\/]?\d{2}");

            Console.WriteLine();
            Console.Write("Skriv in ditt postnummer: ");

            string input = Console.ReadLine();
            MatchCollection match = regexp.Matches(input);

            if (match.Count > 0)
            {
                postNummer = input;
            }
            else
            {
                Console.WriteLine("Fel input");
                SetPostNummer();
            }
        }

        public void WriteValue()
        {
            Console.WriteLine("Vilket värde vill du skriva ut?");
            Console.WriteLine("1. Skriv ut alla värden");
            Console.WriteLine("2. Skriv ut namn");
            Console.WriteLine("3. Skriv ut ålder");
            Console.WriteLine("4. Skriv ut address");
            Console.WriteLine("5. Skriv ut postnummer");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Namn: " + namn);
                    Console.WriteLine("Ålder:" + ålder);
                    Console.WriteLine("Adress: " + adress);
                    Console.WriteLine("Postnummer: " + postNummer);
                    break;

                case 2:
                    Console.WriteLine("Namn: " + namn);
                    break;

                case 3:
                    Console.WriteLine("Ålder:" + ålder);
                    break;

                case 4:
                    Console.WriteLine("Adress: " + adress);
                    break;

                case 5:
                    Console.WriteLine("Postnummer: " + postNummer);
                    break;

                default:
                    Console.WriteLine("Felaktig input");
                    WriteValue();
                    break;
            }
        }
    }
}

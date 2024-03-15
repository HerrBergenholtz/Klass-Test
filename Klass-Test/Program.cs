using System;
using System.Security.Cryptography;

namespace Test
{

    class Program
    {
        static void Main()
        {
            List<Personregister> personLista = new();
            List<Bil> bilLista = new();

            while (true)
            {
                Console.WriteLine("Välkommen, vad vill du göra?");
                Console.WriteLine("1. Lägga till personer till Personregister");
                Console.WriteLine("2. Skriva ut personer från personregister");
                Console.WriteLine("----------==----------");
                Console.WriteLine("3. Lägga till bilar");
                Console.WriteLine("4. Skriva ut bilar");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        NyPerson(personLista);
                        break;

                    case "2":
                        SkrivPerson(personLista);
                        break;

                    case "3":
                        NyBil(bilLista);
                        break;

                    case "4":
                        SkrivBil(bilLista);
                        break;

                    default:
                        Console.WriteLine("Felakti input");
                        break;

                }
                Console.ReadKey();
            }
        }

        static void NyPerson(List<Personregister> personLista)
        {
            Console.WriteLine("Hur många personer vill du lägga till");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                personLista.Add(new Personregister());
            }

            foreach (var person in personLista)
            {
                person.SetNamn();
                person.SetAge();
                person.SetAddress();
                person.SetPostNummer();
                Console.WriteLine();
            }
        }

        static void SkrivPerson(List<Personregister> personLista)
        {
            foreach (var person in personLista)
            {
                person.WriteValue();
                Console.WriteLine();
            }
        }

        static void NyBil(List<Bil> billista)
        {
            Console.WriteLine("Hur många bilar vill du lägga till");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                billista.Add(new Bil());
            }

            foreach (var person in billista)
            {
                person.SetNamn();
                person.SetVikt();
                person.SetModell();
                Console.WriteLine();
            }
        }

        static void SkrivBil(List<Bil> billista)
        {
            foreach (var bil in billista)
            {
                bil.WriteValue();
                Console.WriteLine();
            }
        }
    }
}
using System;
using Testas111.Models;

namespace ManoPrograma
{
    public class PagrindineKlase
    {

        //1 uzduotis
        //public static void Main()
        //{
        //    Automobilis auto1 = new Automobilis("Suzuki", 1993);

        //    Console.WriteLine(auto1);

        //}

        //2 uzduotis

        //public static void Main()
        //{
        //    Console.WriteLine("Iveskite zmogaus amziu:");
        //    int Amzius = int.Parse(Console.ReadLine());

        //    if (Amzius >= 18 &&  Amzius < 75)
        //    {
        //        Console.WriteLine("Zmogus yra pilnametis");
        //    }
        //    else if (Amzius > 75)
        //    {
        //        Console.WriteLine("Zmogus yra senjoras");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Zmogus yra nepilnametis");
        //    }

        //}

        //3 uzduotis

        //public static void Main()
        //{
        //    int skaicius = 1;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(skaicius++);
        //    }
        //}

        //4 uzduotis
        //public static void Main()
        //{
        //    int skaicius = 1;

        //    while (skaicius > 0 && skaicius <= 5)
        //    {
        //        Console.WriteLine(skaicius);
        //        skaicius++;

        //    }

        //}

        //5 uzduotis
        public static void Main()
        {
            Studentas stud1 = new Studentas("Petras", 8);
            Studentas stud2 = new Studentas("Kestas", 8);

            Studentas.ArIslaike(stud1);
        }

    }
}

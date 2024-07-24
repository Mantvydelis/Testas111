using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testas111.Models
{
    public class Studentas
    {
        public string Vardas { get; set; }
        public int Pazymys { get; set; }

        public Studentas (string vardas, int pazymys)
        {
            Vardas = vardas;
            Pazymys = pazymys;
        }

        public static bool ArIslaike(Studentas studentas)
        {
            if (studentas.Pazymys >= 5)
            {
                Console.WriteLine("Studentas islaike egzamina");
                return true;
            }
            Console.WriteLine("Studentas egzamino neislaike");
            return false;
        }

    }
}

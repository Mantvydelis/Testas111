using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testas111.Models
{
    internal class Automobilis
    {
        public string Marke { get; set; }
        public int Metai { get; set; }

        public Automobilis (string marke, int metai)
        {
            Marke = marke;
            Metai = metai;
        }
        public override string ToString()
        {
            return $"Automobilio marke: {Marke}, pagaminimo metai: {Metai}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RibolovniDnevnik.Model
{
    internal class Ulov:Entitet
    {
        

        public Ribe? Ribe { get; set; }
        public Unos? Unos { get; set; }
        public string? Tezina { get; set; }
        public string? Duzina { get; set; }
        public int? Kolicina { get; set; }


        public override string ToString()
        {
            return "RIbe " + Ribe + ", Kolicina , Duzina i tezina " + Kolicina + Duzina + Tezina;
        }
    }
}

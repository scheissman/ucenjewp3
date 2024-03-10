using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibolovniDnevnik.Model
{
    internal class Unos:Entitet
    {
        
        public Korisnik Korisnik { get; set; }

        public DateTime? Datum { get; set; }
        public int? Vodostaj { get; set; }
        public string? Biljeska { get; set; }

        public override string ToString()
        {
            return "Vodostaj " + Vodostaj + " " + Biljeska + " Vrijeme " + Datum;
        }
    }
}

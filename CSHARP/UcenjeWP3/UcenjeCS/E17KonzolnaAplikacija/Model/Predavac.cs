using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17KonzolnaAplikacija.Model
{
    internal class Predavac : Entitet
    {
        
    
        public int? Sifra { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Email { get; set; }
        public string? Oib { get; set; }
        public string? BrojUgovora { get; set; }
        public string Iban { get; internal set; }
    

    public override string ToString()
        {
            return Ime + " " + Prezime + ", " + Email + "," + Iban;
        }
    }
}

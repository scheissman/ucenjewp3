using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RibolovniDnevnik.Model
{
    internal class Ribe:Entitet

    {
        
        public string Vrsta { get; set; }
       
        public override string ToString()
        {
            return "Riba: " + Vrsta;
        }
    }
}

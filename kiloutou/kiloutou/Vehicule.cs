using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiloutou
{
    abstract class Vehicule
    {
        string numeroDeSerie;
        public string NumeroDeSerie { get => numeroDeSerie; set => numeroDeSerie = value; }
    }
}

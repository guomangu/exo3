using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiloutou
{
    class Voiture:Vehicule
    {
        private string marque;
        private string modele;

        public string Marque { get => marque; set => marque = value; }
        public string Modele { get => modele; set => modele = value; }

        public Voiture(string _NumeroDeSerie, string _Marque, string _Modele)
        {
            NumeroDeSerie = _NumeroDeSerie;
            Marque = _Marque;
            Modele = _Modele;
        }

        public override string ToString()
        {
            string str;
            str = "vehicule " + NumeroDeSerie + " est une " + Marque + " " + Modele;
            return str;
        }

        
    }
}

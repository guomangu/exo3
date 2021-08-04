using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Voiture:Vehicule
    {
        private double vitesseActuel;
        private string modele;

        public double VitesseActuel { get => vitesseActuel; set => vitesseActuel = value; }
        public string Modele { get => modele; set => modele = value; }



        public Voiture()
        {
            VitesseActuel = 110;
            Modele = "Kangoo";
            NbRoue = 4;
            Proprio = "gugu";
        }



        public override string ToString()
        {
            string str;
            str = base.ToString();
            str += "vitesse : " + VitesseActuel;
            str += "modele : " + Modele;
            return str;
        }
    }
}

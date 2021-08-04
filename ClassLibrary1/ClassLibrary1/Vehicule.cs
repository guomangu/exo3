using System;

namespace ClassLibrary1
{
    abstract class Vehicule
    {
        private int nbRoue;
        private string proprio;

        public int NbRoue { get => nbRoue; set => nbRoue = value; }
        public string Proprio { get => proprio; set => proprio = value; }



        public override string ToString()
        {
            string str;
            str="le vehicule a " + NbRoue + " roue";
            str += "le proprio est " + Proprio;
            return str;
        }

    }
}

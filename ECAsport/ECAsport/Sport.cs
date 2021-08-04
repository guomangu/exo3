using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECAsport
{
    class Sport
    {
        private string nomSport;
        private string typeSport;

        public string NomSport { get => nomSport; set => nomSport = value; }
        public string TypeSport { get => typeSport; set => typeSport = value; }

        public Sport()
        {
            NomSport ="Beach Volley";
            TypeSport ="plaia";
        }
        public Sport(string _NomSport)
        {
            NomSport = _NomSport;
        }
        public Sport(string _NomSport,string _TypeSport)
        {
            NomSport = _NomSport;
            TypeSport = _TypeSport;
        }

        public void NewTypeSport(string _TypeSport)
        {
            TypeSport = _TypeSport;
        }

        public override string ToString()
        {
            string str;
            str=NomSport + " est le nom du sport. ";
            if (TypeSport==null)
            {

            }
            else
            {
                str += TypeSport + " est le type du sport.";
            }
            return str;
        }
    }
}

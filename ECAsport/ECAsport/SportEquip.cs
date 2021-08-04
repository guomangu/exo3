using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECAsport
{
    class SportEquip : Sport
    {
        private string ekipChamp;
        private string nbPersonneEkip;

        public string EkipChamp { get => NbPersonneEkip; set => ekipChamp = value; }
        public string NbPersonneEkip { get => nbPersonneEkip; set => EkipChamp= value; }

        public SportEquip(string _EkipChamp,string _NbPersonneEkip,string _NomSport):base(_NomSport)
        {
            NomSport = _NomSport;
            EkipChamp = _EkipChamp;
            NbPersonneEkip = _NbPersonneEkip;
        }
        public SportEquip()
        {
            EkipChamp = "Brasilian";
            NbPersonneEkip = "4";
        }

        public string Gagne()
        {
            string str;
            str = "Le nom du champion = " + EkipChamp;
            return str;

        }

        public override string ToString()
        {
            string str;
            str = "Par exemple : en " + NomSport;
            if (TypeSport==null)
            {

            }
            else
            {
                str += " le fameux sport de " + TypeSport;
            }
            str +=" , c'est "+ EkipChamp + " (nom de l'équipe championne) " +
            "sur le terrain comportant "+ NbPersonneEkip + " joueuseures (le nombre de personnes dans l'équipe).";
            return str;
        }
    }
}

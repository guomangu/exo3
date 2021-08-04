using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECAsport
{
    class SportIndiv:Sport
    {
        private string nomChampion;
        private string record;
        private string lieuRecord;
        private DateTime dateRecord;

        public string NomChampion { get => nomChampion; set => nomChampion = value; }
        public string Record { get => record; set => record = value; }
        public string LieuRecord { get => lieuRecord; set => Record = value; }
        public DateTime DateRecord { get => dateRecord; set => dateRecord = value; }

        public SportIndiv(string _NomChampion,string _Record,string _LieuRecord, DateTime _DateRecord, string _NomSport) : base(_NomSport)
        {
            NomSport = _NomSport;
            NomChampion = _NomChampion;
            Record = _Record;
            LieuRecord = _LieuRecord;
            DateRecord = _DateRecord;
        }

        public string Gagne()
        {
            string str;
            str= "Le nom du champion = "+ NomChampion + ". Le record = "+ record + ". voila-_- ";
            return str;

        }

        public override string ToString()
        {
            string str;
            str = "Par exemple "+NomChampion + " (nom de la championne) a battu le record du monde du " +
                NomSport + " en "+Record+" ( le record proprement dit) en finale a " +
                LieuRecord+" (le lieu) le "+ DateRecord + " (la date).";
            if (TypeSport == null)
            {

            }
            else
            {
                str += " le fameux sport de " + TypeSport+" lol";
            }
            return str;
        }
    }
}

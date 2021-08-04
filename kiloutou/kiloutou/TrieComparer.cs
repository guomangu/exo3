using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiloutou
{
    class TrieComparer : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            return x.Modele.CompareTo(y.Modele);
        }

        public void CompDirect(List<Voiture> _god)
        {
            _god.Sort(new TrieComparer());
            _god.ForEach(voiture => Console.WriteLine(voiture));
        }
    }
}

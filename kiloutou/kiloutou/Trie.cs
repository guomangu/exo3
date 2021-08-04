using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiloutou
{
    class Trie:TrieComparer
    {
        public Trie ()
        {

        }

        public List<Voiture> Trier(List<Voiture> _god)
        {
            _god.Sort(delegate (Voiture x, Voiture y) {
                return x.NumeroDeSerie.CompareTo(y.NumeroDeSerie);
            });
            return _god;
        }
    }
}

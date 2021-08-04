using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Emprunt emprunt1 = new Emprunt(8, 4,10000);
           
            Console.WriteLine(" Mensualité du prêt à payer :" + emprunt1.CalculMens());

            emprunt1.TabAmor();










            Console.ReadKey();
        }
    }
}

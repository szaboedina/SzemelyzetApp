using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzemelyzetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fonok = new Szemely("Szultan","szultan",new DateTime(854,11,1));
            var szemelyzet = new Szemelyzet(fonok);
            var sz1 = new Szemely("Jázmin", "hercegnő", new DateTime(880, 5, 12));
            var sz2 = new Szemely("Jafar", "főtanácsadó", new DateTime(856, 12, 5));
            var sz3 = new Szemely("Iago", "papagáj", new DateTime(881, 1, 1));
            fonok.Hozzaad(sz1);
            fonok.Hozzaad(sz2);
            sz2.Hozzaad(sz3);

            Szemely keresett = szemelyzet.Keres("Jafar", new DateTime(856, 12, 5));
            Console.WriteLine(keresett);
            Console.WriteLine(szemelyzet.Letszam);
            Console.ReadLine();
        }
    }
}

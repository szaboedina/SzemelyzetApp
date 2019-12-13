using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzemelyzetApp
{
    class Szemely : IComparable<Szemely>
    {
        // Java : final
        readonly string nev;
        readonly DateTime szuletes;

        readonly ISet<Szemely> beosztottak = new SortedSet<Szemely>();

        string beosztas;

        public Szemely(string nev, string beosztas, DateTime szuletes)
        {
            this.nev = nev;
            this.Beosztas = beosztas;
            this.szuletes = szuletes;
        }

        public void Hozzaad(Szemely sz)
        {
            beosztottak.Add(sz);
        }
        public Szemely Keres(string nev, DateTime szuletes)
        {
            if (this.nev.Equals(nev) && this.szuletes.Equals(szuletes))
            {
                return this;
            }
            foreach(var b in beosztottak)
            {
                var keresett = b.Keres(nev, szuletes);
                if (keresett!= null)
                {
                    return keresett;
                }
            }
            return null;
        }

        public string Nev => nev;
        public DateTime Szuletes => szuletes;
        public string Beosztas { get => beosztas; set => beosztas = value; }
        public int CompareTo(Szemely other)
        {
            int i = this.Nev.CompareTo(other.Nev);
            if (i!=0)
            {
                return i;
            }
            return this.Szuletes.CompareTo(other.Szuletes);
        }

        public override string ToString()
        {
            return  nev + " " + szuletes;
        }
        public int Letszam
        {
            get
            {
                var l = 1;
                foreach (var b in beosztottak)
                {
                    l += b.Letszam;
                }
                return l;
            }
        }

    }
}

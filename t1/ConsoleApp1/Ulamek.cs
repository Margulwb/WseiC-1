using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulamek
{
    class Ulamek
    {
        private int licznik;

        private int mianownik;

        Ulamek()
        {
            licznik = 1;
            mianownik = 2;
        }

        public Ulamek(int l, int m)
        {
            this.licznik = l;
            this.mianownik = m;
        }

        public Ulamek(Ulamek u)
        {
            licznik = u.licznik;
            mianownik = u.mianownik;
        }

        public override string ToString() => $"{licznik}\n-\n{mianownik}";
        public static Ulamek operator +(Ulamek a, Ulamek b) 
             =>new (a.licznik * b.mianownik + b.licznik * a.mianownik, a.mianownik * b.mianownik);

        public static Ulamek operator -(Ulamek a, Ulamek b)
            => new Ulamek(a.licznik * b.mianownik - b.licznik * a.mianownik, a.mianownik * b.mianownik);
        public static Ulamek operator *(Ulamek a, Ulamek b)
            => new Ulamek(a.licznik * b.licznik, a.mianownik * b.mianownik);
        public static Ulamek operator /(Ulamek a, Ulamek b)
            => new Ulamek(a.licznik * b.mianownik, a.mianownik * b.licznik);

    }
}

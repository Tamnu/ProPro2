using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Träning
{
    class Logg
    {
        public int sträcka;
        public int tid;

        public Logg(int a , int b)
        {
            sträcka = a;
            tid = b;

        }
        public override string ToString()
        {
            return tid.ToString();
        }
    }
}

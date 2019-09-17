using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar
{
    class Resor
    {
        string kund;
        string destination;
        int dagar;








        public Resor (string k,string d, int a)
        {
            kund = k;
            destination = d;
            dagar = a;
        }

        public override string ToString()
        {
            return kund;
        }

    }
}

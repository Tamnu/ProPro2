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

        public Resor(string x, string y, int z)
        {
            kund = x;
            destination = y;
            dagar = z;
        }
        public string Kund

        {

            get { return kund; }
        }
        public override string ToString()

        {

            return destination + ": " + dagar + " dagar";
        }



        }
}

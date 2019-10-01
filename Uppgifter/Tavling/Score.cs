using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavling
{
    class Score
    {
        string namn;
        public int points;
        public Score(string a, int b)
        {
            namn = a;
            points = b;
        }
        public override string ToString()
        {
            return namn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt04ClassLib
{
    public class ForConsole4
    {
        public int Solve(int a, int b)
        {
            int res = 0;
            for (; a <= b; a++) res += a * a;
            return res;
        }
    }
}

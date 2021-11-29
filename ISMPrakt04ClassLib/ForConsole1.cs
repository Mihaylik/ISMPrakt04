using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt04ClassLib
{
    public class ForConsole1
    {
        public double Solve(int a=0, int b=0)
        {
            double res = 1;
            for (; a <= b; a++) res *= a;
            return res;
        }

    }
}

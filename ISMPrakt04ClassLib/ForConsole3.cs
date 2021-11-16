using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt04ClassLib
{
    public class ForConsole3
    {
        public double Solve(int n, double a)
        {
            double res = 1;
            for (int i = 0; i < n; i++) res *= a;
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt04ClassLib
{
    public class ForConsole2
    {
        public double Solve(int n)
        {
            double res = 0;
            for (double i = 1; i <= n; i++) res += 1 / i;
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt04ClassLib
{
    public class Pi3Console
    {
        public double Solve(int k)
        {
            double res;
            res = Math.Pow((2 * k + 1), 2) / 2.0;
            k -= 1;
            for (; k >= 0; k--)
            {
                res = Math.Pow((2 * k + 1), 2) / (res + 2.0);
            }
            return 4/(1.0+res);
        }
    }
}

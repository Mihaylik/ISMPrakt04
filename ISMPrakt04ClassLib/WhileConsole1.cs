using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt04ClassLib
{
    public class WhileConsole1
    {
        public double Solve(double n)
        {
            double res = 0;
            int x=1;
            while (n >= 1)
            {
                res += Math.Pow(x, n);
                x++;
                n--;
            }
            return res;
        }
    }
}

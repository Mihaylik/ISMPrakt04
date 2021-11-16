using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt04ClassLib
{
    public class WhileConsole2
    {
        public double Solve(double n)
        {
            double k = 1;
            while (Math.Pow(3, k) < n)
            {
                k++;
            }
            return k;
        }
    }
}

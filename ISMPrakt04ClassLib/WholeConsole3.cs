using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt04ClassLib
{
    public class WholeConsole3
    {
        public double[] Solve(double p)
        {
            double res = 10, cols = 0;
            while (res < 210)
            {
                res += (res / 100.0) * p;
                cols++;
            }
            double[] arr =
            {
                cols, res
            };
            return arr;
        }
    }
}

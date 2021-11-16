using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt04ClassLib
{
    public class Pi1Console
    {
        public double Solve(int k)
        {
            double res;
            double[] tmp = new double[k];
            tmp[0] = Math.Pow(0.5, 0.5);
            res = tmp[0];
            for (int i = 1; i < tmp.Length; i++)
            {
                tmp[i] = Math.Pow(0.5 + 0.5 * tmp[i - 1], 0.5);
                res *= tmp[i];
            }
            return 2/res;
        }
    }
}

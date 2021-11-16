using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt04ClassLib
{
    public class Pi4Console
    {
        public double Solve(int k)
        {
            double res = 0, x = 1;
            for (int i = 0; i < k; i++)
            {
                if (i % 2 == 0)
                {
                    res += 1 / x;
                }
                else
                {
                    res -= 1 / x;
                }
                x += 2;
            }
            return 4 * res;
        }
    }
}

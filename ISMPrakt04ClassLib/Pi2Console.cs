using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt04ClassLib
{
    public class Pi2Console
    {
        public double Solve(int k)
        {
            double res=1;
            int x = 1;
            for (int i = 0; i < k; i++)
            {
                res *= (x * (x + 2)) / Math.Pow(x + 1, 2);
                x += 2;
            }
            return 2/res;
        }
    }
}

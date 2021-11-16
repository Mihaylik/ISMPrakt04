using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt04ClassLib
{
    public class ForConsole5
    {
        public int Solve(int n)
        {
            int res = 0, f = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    f *= j;
                }
                res += f;
                f = 1;
            }
            return res;
        }
    }
}

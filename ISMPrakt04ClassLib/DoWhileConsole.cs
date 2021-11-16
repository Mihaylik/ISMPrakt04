using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt04ClassLib
{
    public class DoWhileConsole
    {
        public int Solve(int[] vals)
        {
            int i = 0, res=0;
            do
            {
                res += vals[i];
                i++;
            }
            while (vals[i] != 0);
            return res;
        }
    }
}

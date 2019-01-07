using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapper
{
    public class Helper
    {
        public static void Swap(ref int x, ref int y)
        {
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
        }
    }
}

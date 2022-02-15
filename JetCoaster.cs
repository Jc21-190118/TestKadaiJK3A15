using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class JetCoaster
    {
        public static int ride
            (int k, int[] g, int r)
        {
            int n = 0;
            int s = k;

            for (int j = 0; ; j += 1)
            {
                if(r == 0)
                {
                    break;
                }

                if(j > g.Length - 1)
                {
                    j = 0;
                }

                Console.WriteLine("g" + g[j]);
                if(g[j] <= s)
                {
                    n += g[j];
                    s -= g[j];
                }

                else
                {
                    s = k;
                    r -= 1;

                    if(j <= g.Length - 1)
                    {
                        j -= 1;
                    }
                    else
                    {
                        j = g.Length - 1;
                    }
                }
            }
            return n;
        }
    }
}


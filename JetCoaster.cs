using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class JetCoaster
    {
        static int i = 0;

        public static int ride
            (int k, int[] g, int r)
        {
            i = 0;
            int s = 0; //sはsaishukekka
            int n = 0;

            if (!g.Any())
            {
                return n;
            }


            for (int j = 1; j <= r; j++)//回す回数
            {
                s += ride2(k, g);
            }
            return s;
        }
        public static int ride2(int k, int[] g)//定員、配列
        {
            int e = 0;  //eはkekka

            Boolean flg = true;
            while (flg)
            {
                Console.Write(i);
                if (e + g[i] > k)
                {
                    flg = false;

                }
                else
                {
                    e += g[i];
                    if (g.Length == 1)
                    {
                        flg = false;
                    }
                    i = (i + 1) % g.Length;
                }

            }

            return e;

        }

    }
}



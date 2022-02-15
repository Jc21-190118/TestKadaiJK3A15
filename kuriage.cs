using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class kuriage
    {
        public static int Kuriage10(int j)
        {
            if (j == 0)
            {
                return 0;
            }
            else if (j >= 0)
            {
                double i = j;
                j = Convert.ToInt32(Math.Ceiling(i / 10) * 10);
            }
            else
            {
                double i = j;
                j = Convert.ToInt32(Math.Floor(i / 10) * 10);
            }

            return j;
        }

    }
}

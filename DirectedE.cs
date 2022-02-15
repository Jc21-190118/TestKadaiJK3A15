using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DirectedE
    {
        public static int[] SEARCH
            (int[] edgefirst, int[] edgenext, int s)
        {
            int[] current = new int[7];
            int[] searched = new int[9];
            int[] start = { 0, 1, 2, 3, 1, 4, 3, 5 };
            int[] end = { 1, 2, 3, 0, 4, 3, 5, 1 };
            int[] path = new int[8];
            int N = 6;
            int M = 8;
            int top = 0;
            int last = M - 1;
            int x = s - 1;
            int temp;
            for (int i = 0; i < N; i++)
            {
                current[i] = edgefirst[i] - 1;

            } while (last >= 0)
            {
                if (current[x] != -1)
                {
                    temp = current[x];
                    searched[top] = temp;
                    current[x] = edgenext[temp] - 1;
                    x = end[temp];
                    top++;
                }
                else
                {
                    top = top - 1;
                    temp = searched[top];
                    path[last] = temp + 1;
                    x = start[temp];
                    last--;
                }
            } return path;
        }
    }
}

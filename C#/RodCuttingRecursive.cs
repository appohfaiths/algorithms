using System.Collections.Generic;
namespace Recursive;

public class CUT_ROD_RECURSIVE
{

    public static int CUT_ROD(List<int> p, int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else
        {
            int q = -1000000;
            for (int i = 1; i <= n + 1; i++)
            {
                q = Math.Max(q, p[i] + CUT_ROD(p, n - i));

            }
            return q;
        }
    }
}
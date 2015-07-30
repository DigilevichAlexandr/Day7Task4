using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task4
{
    static class BinerySearch<T> where T : IComparable
    {
        public static bool IfExist(T[] a,T k)
        {
            Array.Sort<T>(a);
            int first = 0;
            int last = a.Length - 1;
            int cmp;
            if (a.Length == 0)
                return false;
            else
                if ((cmp=a[0].CompareTo(k)) > 0)
                    return false;
                else
                    if ((cmp=a[0].CompareTo(k)) > 0)
                        return false;

            while(first < last)
            {
                int mid=first + (last - first) / 2;

        if ((cmp=k.CompareTo(a[mid]))<=0)
            last = mid;
        else
            first = mid + 1;
            }

        if ((cmp=a[last].CompareTo(k))==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

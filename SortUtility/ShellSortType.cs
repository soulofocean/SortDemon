using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortUtility
{
    public class ShellSortType : BasicSortType
    {
        public override void SortArr(SortEnum st)
        {
            base.SortArr(st);
            int len = intArr.Length;
            int i, j;
            for (int gap = len / 2; gap > 0; gap /= 2)
            {
                for (i = gap; i < len; i++)
                {
                    int key = intArr[i];
                    for (j = i - gap; j >= 0 && LeftIsBigger(intArr[j], key); j -= gap)
                    {
                        intArr[j + gap] = intArr[j];
                    }
                    intArr[j + gap] = key;
                }
            }
        }
    }
}

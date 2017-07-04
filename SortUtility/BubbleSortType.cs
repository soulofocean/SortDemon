using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortUtility
{
    public class BubbleSortType:BasicSortType
    {
        public override void SortArr(SortEnum st)
        {
            base.SortArr(st);
            bool hasChange = false;
            int time = 0;
            while (time!=intArr.Length-1)
            {
                ++time;
                hasChange = false;
                for (int index = 0; index < intArr.Length - time; index++)
                {
                    if (LeftIsBigger(intArr[index], intArr[index + 1]))
                    {
                        SwapArrByIndex(index, index + 1);
                        hasChange = true;
                    }
                }
                if (!hasChange)
                { 
                    break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortUtility
{
    public class SelectionSortType:BasicSortType
    {
        public override void SortArr(SortEnum st)
        {
            base.SortArr(st);
            for (int keyIndex = 0; keyIndex < intArr.Length-1; keyIndex++)
            {
                var key = intArr[keyIndex];
                for (int j = keyIndex + 1; j < intArr.Length; j++)
                {
                    if (LeftIsBigger(key, intArr[j]))
                    {
                        key = intArr[j];
                        SwapArrByIndex(keyIndex, j);
                    }
                }
            }
        }
    }
}

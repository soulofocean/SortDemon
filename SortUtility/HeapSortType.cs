using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortUtility
{
    public class HeapSortType:BasicSortType
    {
        public override void SortArr(SortEnum st)
        {
            base.SortArr(st);
            BuildHeap(intArr.Length);
            int currentLen = intArr.Length;
            while(currentLen > 1)
            {
                --currentLen;
                //移至队尾
                SwapArrByIndex(0, currentLen);
                //长度已经减1，直接维护堆就好
                KeepHeap(currentLen, 0);
            }
        }
        private void BuildHeap(int arrLen)
        {
            int lastIndex = (arrLen - 2) / 2;
            for (int index = lastIndex; index >= 0; index--)
            {
                KeepHeap(arrLen, index);
            }
        }
        private void KeepHeap(int arrLen, int currentIndex)
        {
            int lcIndex = 2 * currentIndex + 1;
            int rcIndex = 2 * currentIndex + 2;
            int keyIndex = currentIndex;
            if (lcIndex < arrLen && LeftIsBigger(intArr[lcIndex], intArr[keyIndex]))
            {
                keyIndex = lcIndex;
            }
            if (rcIndex < arrLen && LeftIsBigger(intArr[rcIndex], intArr[keyIndex]))
            {
                keyIndex = rcIndex;
            }
            if (keyIndex != currentIndex)
            {
                SwapArrByIndex(keyIndex, currentIndex);
                KeepHeap(arrLen, keyIndex);
            }
        }
    }
}

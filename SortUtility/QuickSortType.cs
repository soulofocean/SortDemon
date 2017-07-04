using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortUtility
{
    public class QuickSortType:BasicSortType
    {
        public override void SortArr(SortEnum st)
        {
            base.SortArr(st);
            quickSort(0, intArr.Length - 1);

        }
        private void quickSort(int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                throw new Exception(string.Format("Left:{0} bigger than Right:{1}",leftIndex,rightIndex));
            }
            if(leftIndex==rightIndex)
            {
                return;
            }
            SwapArrByIndex(leftIndex, (leftIndex + rightIndex) / 2);
            int key = intArr[leftIndex];
            int i = leftIndex;
            int j = rightIndex;
            while (i != j)
            {
                while (i!=j&&!LeftIsBigger(key,intArr[j]))
                {
                    --j;
                }
                intArr[i] = intArr[j];
                while (i != j && !LeftIsBigger(intArr[i], key))
                {
                    ++i;
                }
                intArr[j] = intArr[i];
            }
            intArr[i] = key;
            quickSort(leftIndex, i);
            quickSort(Math.Min(i + 1, rightIndex), rightIndex);
        }
    }
}

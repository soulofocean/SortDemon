using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortUtility
{
    public class MergeSortType:BasicSortType
    {
        public override void SortArr(SortEnum st)
        {
            base.SortArr(st);
            int[] tempArr = GetArrayCopy(0, intArr.Length - 1);
            MergeSort(0, intArr.Length - 1, tempArr);
        }
        private void MergeSort(int startIndex, int endIndex, int[] tempArr)
        {
            if (endIndex != startIndex)
            {
                int midIndex = (endIndex + startIndex) / 2;
                MergeSort(startIndex, midIndex, tempArr);
                MergeSort(midIndex + 1, endIndex, tempArr);
                MergeArr(startIndex, midIndex, endIndex, tempArr);
            }
        }
        private void MergeArr(int startIndex, int midIndex, int endIndex, int[] tempArr)
        {
            for (int l = startIndex, r = midIndex + 1,i=startIndex; i<=endIndex;i++ )
            {
                if (l > midIndex)
                {
                    intArr[i] = tempArr[r];
                    ++r;
                    continue;
                }
                if (r > endIndex)
                {
                    intArr[i] = tempArr[l];
                    ++l;
                    continue;
                }
                if (LeftIsBigger(tempArr[l], tempArr[r]))
                {
                    intArr[i] = tempArr[r];
                    ++r;
                }
                else
                {
                    intArr[i] = tempArr[l];
                    ++l;
                }
            }
            for (int index = startIndex; index <= endIndex; index++)
            {
                tempArr[index] = intArr[index];
            }
        }
        private int[] GetArrayCopy(int startIndex, int endIndex)
        {
            if (endIndex < startIndex)
            {
                throw new Exception("Index Error!");
            }
            int len = endIndex - startIndex + 1;
            int[] newArr = new int[len];
            for (int i = startIndex; i <= endIndex; i++)
            {
                newArr[i] = intArr[i];
            }
            return newArr;
        }
    }
}

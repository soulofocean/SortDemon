using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortUtility
{
    public enum SortEnum
    {
        None,
        ASC,
        DESC
    }
    public class BasicSortType
    {
        public const int MAXNUM = 100;
        protected int[] intArr;
        protected SortEnum sortType = SortEnum.None;
        public void GenArr(int arrLen = 9, bool isRandom = false)
        {
            Random r = isRandom ? new Random() : new Random(0);
            intArr = new int[arrLen];
            for (int i = 0; i < arrLen; i++)
            {
                intArr[i] = r.Next(0, MAXNUM);
            }
        }
        public void DispArr()
        {
            if (intArr == null || intArr.Length == 0)
            {
                Console.WriteLine("Arr is null or empty.");
                return;
            }
            foreach (var i in intArr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
        public virtual void SortArr(SortEnum st)
        {
            if (intArr == null || intArr.Length == 0)
            {
                throw new Exception("Arr is null or empty.");
            }
            sortType = st;
        }
        protected bool LeftIsBigger(int leftValue,int rightValue)
        {
            switch (sortType)
            {
                case SortEnum.ASC: return leftValue > rightValue;
                case SortEnum.DESC: return leftValue < rightValue;
                default: throw new Exception(string.Format("Invalid SortEnum {0}", sortType.ToString()));
            }
        }
        protected void SwapArrByIndex(int firstIndex, int secondIndex)
        {
            var temp = intArr[firstIndex];
            intArr[firstIndex] = intArr[secondIndex];
            intArr[secondIndex] = temp;
        }
    }
}

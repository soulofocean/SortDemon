using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortUtility
{
    public class InsertSortType:BasicSortType
    {
        public override void SortArr(SortEnum st)
        {
            base.SortArr(st);
            for (int index = 1; index < intArr.Length; index++)
            {
                var key = intArr[index];
                int frontIndex = index - 1;
                while (frontIndex > -1 && LeftIsBigger(intArr[frontIndex], key))
                {
                    intArr[frontIndex + 1] = intArr[frontIndex];
                    --frontIndex;
                }
                intArr[frontIndex + 1] = key;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SortUtility;

namespace MainConProj
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicSortType b = new ShellSortType();
            b.GenArr(9,false);
            b.DispArr();
            b.SortArr(SortEnum.ASC);
            b.DispArr();
            b.SortArr(SortEnum.DESC);
            b.DispArr();
            b.SortArr(SortEnum.ASC);
            b.DispArr();
            Console.ReadLine();
        }
    }
}

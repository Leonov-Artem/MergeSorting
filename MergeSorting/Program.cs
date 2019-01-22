using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting<int> sorting = new Sorting<int>(new int[] { 6, 3, 7, 12, 68, 21, -4 });
            sorting.Print();

            sorting.MergeSort();
            sorting.Print();

            Console.ReadKey();
        }
    }
}

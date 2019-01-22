using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSorting
{
    partial class Sorting<T>
    {
        private void RecMergeSort(T[] temp, int lower_bound, int upper_bound)
        {
            if (lower_bound == upper_bound) return;

            int mid = (lower_bound + upper_bound) / 2;
            RecMergeSort(temp, lower_bound, mid);
            RecMergeSort(temp, mid + 1, upper_bound);
            Merge(temp, lower_bound, mid, upper_bound);
        }
        private void Merge(T[] temp, int lower_bound, int mid, int upper_bound)
        {

        }
    }
}

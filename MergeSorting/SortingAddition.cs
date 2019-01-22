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
            Merge(temp, lower_bound, mid + 1, upper_bound);
        }
        private void Merge(T[] temp, int lower_limiter, int high_limiter, int upper_bound)
        {
            int i = 0;
            int lower_bound = lower_limiter;
            int mid = high_limiter - 1;

            while(lower_limiter <= mid && high_limiter <= upper_bound)
            {
                if (array[lower_limiter].CompareTo(array[high_limiter]) < 0)
                    temp[i++] = array[lower_limiter++];
                else
                    temp[i++] = array[high_limiter++];
            }

            while (lower_limiter <= mid)
                temp[i++] = array[lower_limiter++];

            while (high_limiter <= upper_bound)
                temp[i++] = array[high_limiter++];

            for (i = 0; i < upper_bound - lower_bound + 1; i++)
                array[lower_bound + i] = temp[i];
        }
    }
}

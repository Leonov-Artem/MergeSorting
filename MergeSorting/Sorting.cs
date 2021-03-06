﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSorting
{
    partial class Sorting<T> : ISorting<T> where T : IComparable
    {
        private T[] array;

        public Sorting(T[] array) => this.array = array;

        public void MergeSort() => RecMergeSort(new T[array.Length], 0, array.Length - 1);
        public void Print()
        {
            foreach (var elem in array)
                Console.Write(elem + " ");
            Console.WriteLine();
        }
    }
}

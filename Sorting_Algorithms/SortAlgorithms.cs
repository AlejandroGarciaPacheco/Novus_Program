using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SortAlgorithms
    {

        //Average case O(n log (n))
        public void MergeSort(int[] array, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2 + 1;
                MergeSort(array, l, m - 1);
                MergeSort(array, m, r);
                merge(array, l, m, r);
            }
        }
        public void merge(int[] array, int l, int m, int r)
        {
            //Pointers
            int i, j, k;
            int lArrayLength = m - l, rArrayLength = r - m + 1;
            int[] left = new int[lArrayLength];
            int[] right = new int[rArrayLength];

            for (i = 0; i < lArrayLength; i++)
            {
                left[i] = array[l + i];
            }

            for (j = 0; j < rArrayLength; j++)
            {
                right[j] = array[m + j];
            }

            i = 0; j = 0; k = l;

            while (i < lArrayLength && j < rArrayLength)
            {
                if (left[i] < right[j])
                {
                    array[k++] = left[i++];
                }
                else
                {
                    array[k++] = right[j++];
                }
            }

            if (i == lArrayLength)
            {
                //left array completed sorted
                for (int ii = j; ii < rArrayLength; ii++)
                {
                    array[k++] = right[ii];
                }
            }

            if (j == rArrayLength)
            {
                //right array completed sorted
                for (int ii = i; ii < lArrayLength; ii++)
                {
                    array[k++] = left[ii];
                }
            }
        }


        //------------------------------------QUICK SORT-------------------------------------
        //average time complexity = n(log(n)) and worse case n^2
        public void swap(int[] array, int i, int j)
        {
            int t = array[i];
            array[i] = array[j];
            array[j] = t;
        }

        public int partition(int[] array, int l, int r)
        {
            //stores pivot position
            int ndx = l;
            int pivot = array[l];
            for (int i = l + 1; i <= r; i++)
            {
                if (array[i] < pivot)
                {
                    ndx++;
                    swap(array, ndx, i);
                }
            }

            swap(array, ndx, l);
            return ndx;
        }

        public void quickSort(int[] array, int l, int r)
        {
            if (l < r)
            {
                var pivot = partition(array, l, r);
                quickSort(array, l, pivot-1);
                quickSort(array, pivot + 1, r);
            }
        }


        // ------------------------------------SELECTION SORT ---------------------------------------------------
        //n^2
        public void selectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j=i+1; j < array.Length; j++)
                {
                    if ((array[min] > array[j]))
                    {
                        min = j;
                    }
                }

                int tmp = array[i];
                array[i] = array[min];
                array[min] = tmp;
            }
        }

        //------------------------------------ SHELL SORT ------------------------------------------------------------
        // O(nlog(n)) - average case
        public void shellSort(int[] array)
        {
            int i, j, inc, tmp;
            inc = 3;

            while (inc > 0)
            {
                for (i=0; i< array.Length; i++)
                {
                    j = i;
                    tmp = array[i];

                    while (j >= inc && array[j - inc] > tmp)
                    {
                        array[j] = array[j - inc];
                        j=j- inc;
                    }
                    array[j] = tmp;
                }

                if (inc/2 != 0)
                {
                    inc = inc / 2;
                } else if (inc == 1)
                {
                    inc = 0;
                } else
                {
                    inc = 1;
                }
            }
        }

        // ----------------------------------------INSERTION SORT-------------------------------------------
        // average case O(n^2)
        public void insertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int tmp = array[i];
                int j = i - 1;
                while (j>=0 && array[j] > tmp)
                {
                    array[j+1] = array[j];
                    j--;

                }
                array[j+1] = tmp;
        }
    }

    

    
    




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class MergeSort
    {
        public static void  ImplementMergerSort()
        {
            //Initializing array
            int[] arr = { 4,2,7,8,9,0,5 };
            Console.WriteLine();
            mergesort(arr);
        }
        //Sorting in non decreasing order
        private static void mergesort(int[] arr)
        {
            int mid;
            
            Console.Write("Initial Array: ");
            int length = arr.Length;
            if (length < 2)
                return;
            mid = length / 2;
            int i = 0;
            int[] left = new int[mid];
            int[] right = new int[length-mid];
            for ( i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            for (i = mid; i <= length-1; i++)
            {
                right[i-mid] = arr[i];
            }
            mergesort(left);
            mergesort(right);
            merge(arr, left, right);
        }

        private static void merge(int[] arr, int[] left, int[] right)
        {
            int arrlength = arr.Length;
            int i =0,j=0, k = 0;
            while(i < left.Length && j < right.Length)
            {
                if(left[i]< left[j])
                {
                    arr[k] = left[i];
                    i++;
                    k++;
                }
                else
                {
                    arr[k] = left[j];
                    j++;
                    k++;
                }
            }
            while(i< left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < right.Length)
            {
                arr[k] = left[j];
                j++;
                k++;

            }
            Console.ReadLine();
        }
    }
}

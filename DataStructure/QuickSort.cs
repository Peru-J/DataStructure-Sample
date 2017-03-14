using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class QuickSortAlgoritham
    {
        public static void QuickSort()
        {
            int[] arr ={5,7,3,2,9 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted Values:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            Console.ReadLine();
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int pIndex = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    pIndex++;
                    temp = arr[pIndex];
                    arr[pIndex] = arr[j];
                    arr[j] = temp;
                }
            }
            temp = arr[pIndex + 1];
            arr[pIndex + 1] = arr[end];
            arr[end] = temp;
            return pIndex + 1;
        }
    }
}

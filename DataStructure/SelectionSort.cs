//Selection Sort
using System;
class SelectionSort
{
    public static void selectionSort()
    {
        //initializing array
        int[] arr = { 10, 7, 3, 1, 9, 7, 4, 3 };
        Console.Write("Initial Array : ");
        Console.WriteLine(String.Join(" ", arr));
        selectionSort(arr);
        foreach (var item in arr)
        {

            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
    //Sorting in non decreasing order
    public static void selectionSort(int[] arr)
    {
        int length = arr.Length;
        int small;
        int smallIndex;

        for (int i = 0; i < length-1; i++)
        {
            small = arr[i];
            smallIndex = i;
            for (int j = i+1; j < length-1; j++)
            {
                if(arr[j] <small)
                {
                    small = arr[j];
                    smallIndex = j;
                }
            }
            int temp = arr[i];
            arr[i] = arr[smallIndex];
            arr[smallIndex] = temp;

        }
    }
}
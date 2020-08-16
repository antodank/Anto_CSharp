using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlgos
{
    public class NewSorting
    {
        public void swap(ref int[] arr, int m, int n)
        {
            int temp = arr[m];
            arr[m] = arr[n];
            arr[n] = temp;
        }


        public void bubblesort(ref int[] arr)
        {
            int length = arr.Length;

            for(int i = 0; i < length - 1; i++)
            {

                for(int j = 0; j < length - i - 1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        swap(ref arr, j, j+1);
                    }
                }

            }

        }


        public void selectionSort(ref int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int min = i;

                for(int j = i+1;  j < length; j++ )
                {
                    if(arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                swap(ref arr, i, min);

            }
        }

        public int patition(int[] arr, int lb, int ub)
        {
            int start = lb;
            int end = ub;
            int pivot = arr[lb];

            while (start < end)
            {
                while (arr[start] <= pivot && start < ub)
                {
                    start++;
                }

                while (arr[end] > pivot)
                {
                    end--;

                }

                if (start < end)
                {
                    swap(ref arr, start, end);
                }
            }

            swap(ref arr, lb,end);

            return end;

        }


        public int patitionFor(int[] arr, int lb, int ub)
        {
            int pivot = arr[ub];
            int i = lb -1;

            for(int j = lb ;j < ub;j++)
            {
                if(arr[j] < pivot)
                {
                    i++;

                    swap(ref arr, i, j);
                }
            }

            swap(ref arr, i+1, ub);

            return i+1;


        }


        public void quickSort(ref int[] arr, int lb , int ub)
        {
            if(lb < ub)
            {
                int pi = patitionFor(arr, lb, ub);

                // Recursively sort elements before 
                // partition and after partition 
                quickSort(ref arr, lb, pi - 1);
                quickSort(ref arr, pi + 1, ub);
            }

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlgos
{
    public class sorting
    {

        public void swap(int a, int b)
        {
            b = a + b;
            a = b - a;
            b = b - a;

        }


        public void swap(ref int[] arr,int m , int n)
        {
            int temp = arr[m];
            arr[m] = arr[n];
            arr[n] = temp;
        }
        public void bubbleSort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i -1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap(ref arr, j, j + 1);
                    }
                }
            }
        }


        public void selectionSort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; i < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                swap(ref arr, i, min);
            }
        }

    }
}

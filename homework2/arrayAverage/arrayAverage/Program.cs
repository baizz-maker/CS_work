using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayAverage
{
    class Program
    {   

        int getAverage(int []arr, int amount)
        {
            int sum = 0;
            foreach (int elem in arr)
            {
                sum += elem;
            }
            return sum / amount;

        }

        int getSum(int[] arr)
        {
            int sum = 0;
            foreach (int elem in arr)
            {
                sum += elem;
            }
            return sum;
        }

        int getMax(int []arr,int amount)
        {
           for(int i = amount - 1; i >= 0; i--)//Bubble Sort
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j +1] = temp;
                    }
                }
            }

            return arr[amount - 1];
        }
        int getMin(int[] arr, int amount)
        {
            for (int i = amount - 1; i >= 0; i--)//Bubble Sort
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int temp = arr[i];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
            return arr[0];
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = { 5, 7, 3, 4, 6, 1, 2 };
            Console.WriteLine("Sum:  {0}", p.getSum(arr));
            Console.WriteLine("Average:  {0}", p.getAverage(arr, 7));
            Console.WriteLine("Max:  {0}", p.getMax(arr, 7));
            Console.WriteLine("Min:  {0}", p.getMin(arr, 7));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber
{
    class Program
    {
        static int max = 0;
        void primeSearch(char[]arr)//arr数组储存素数信息，如arr[3]=1代表3为素数
        {
            for(int i = 2; i < max; i++)//arr[]全部置1
            {
                arr[i] = (char)1;
            }

            for(int i = 2; i < max; i++)//从2与2的倍数开始依次筛除非素数
            {
                for(int j = i * 2; j < max; j += i)
                {
                    arr[j] = (char)0;
                }
            }
        }

        void printPrime(char[]arr)
        {
            for(int i = 2; i < max; i++)
            {
                if (arr[i] == (char)1)
                {
                    Console.Write(i);
                    Console.Write(" ");

                }
                
            }
        }
        static void Main(string[] args)
        {
           Console.WriteLine("Input the max number pls: ");
            max=int.Parse(Console.ReadLine());//获得max以下的素数
            Program p = new Program();
            char[] arr = new char[max];
            p.primeSearch(arr);
            p.printPrime(arr);
            Console.ReadKey();
        }
    }
}

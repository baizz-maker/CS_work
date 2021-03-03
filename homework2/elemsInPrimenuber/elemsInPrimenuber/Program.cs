using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elemsInPrimenuber
{
    class Program
    {
        static int target = 0;
        void primeSearch(char[] arr)//arr数组储存素数信息，如arr[3]='P'代表3为素数
        {
            for (int i = 2; i < target+1; i++)//arr[]全部置'P'
            {
                arr[i] = 'P';
            }

            for (int i = 2; i < target+1; i++)//从2与2的倍数开始依次筛除非素数
            {
                for (int j = i * 2; j < target+1; j += i)
                {
                    arr[j] = 'N';
                }
            }
        }

        void getElems(char[] arr)
        {
            int flag = 0;
            for(int i = 2; i < target; i++)//将目标依次与素数表中元素相模找出质因数
            {
                if(arr[i]=='P'&& target % i == 0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Console.Write(target);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number pls:  ");

            Program p = new Program();
             target = int.Parse(Console.ReadLine());
            char[] arr = new char[target+1];
            p.primeSearch(arr);
            p.getElems(arr);
            Console.ReadKey();
        }
    }
}

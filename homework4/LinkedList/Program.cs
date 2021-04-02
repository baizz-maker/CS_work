using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {   
 
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            for (int i = 1; i <= 10; i++)
            {
                intList.Add(i);
            }

            
            intList.ForEach(x => Console.WriteLine(x));

          
            int max = int.MinValue;
            intList.ForEach(x => max = x > max ? x : max);
            Console.WriteLine($"MAX: {max}");

            
            int min = int.MaxValue;
            intList.ForEach(x => min = x < min ? x : min);
            Console.WriteLine($"MIN: {min}");

        
            int sum = 0;
            intList.ForEach(x => sum += x);
            Console.WriteLine($"SUM: {sum}");
        }
    }
}

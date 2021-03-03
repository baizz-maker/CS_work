using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toeplitz
{
    class Program
    {   
        bool toeplitzTest(int [,]arr, int row , int line)
        {
            
            for(int i=0; i < row; i++)
            {
                for(int j=0; j < line; j++)
                {
                    if (i + 1 < row && j + 1 < line)
                    {
                        if (arr[i,j] != arr[i + 1,j + 1])
                        {
                            return false;
                        }
                        
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Program t = new Program();
             int [,]arr = new int[3, 3] { { 1, 2, 0 },{ 2, 1, 2 },{ 0, 2, 1} };
            /* 
                    1      2       0
                    2      1       2
                    0      2       1
            */
            if(t.toeplitzTest(arr, 3, 3))
            {
                Console.WriteLine("Toeplitz Detected~~");
            }

            else
            {
                Console.WriteLine("Toeplitz Not Detected..");
            }

            Console.ReadKey();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new int[] { 1, 4, 7, 11, 13, 15, 18, 21 };

            int start = 0;
            int end = ints.Length-1;
            int mid = 0;
            int target = 7;

            while (start <= end && target != ints[mid])
            {

                mid = (start + end) / 2;
                if (target < ints[mid])
                {
                    end = mid - 1;

                }
                else if (target > ints[mid])
                {
                    
                    start = mid + 1;
                }
                else
                {
                    Console.WriteLine(mid);
                }
            }
          
        }
        
    }
}

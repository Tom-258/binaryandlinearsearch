using System;

namespace Linear_and_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[]{0,1,2,3,4,5,6,10,18, 27, 63, 72, 96,97,98};
            var n = int.Parse(Console.ReadLine());
            LinearSearch(arr,n);
        }
        
        static void LinearSearch(int[] Arr, int n)
        {
            var i = 0;
            do
            {
                if (Arr[i] == n )
                {
                    Console.WriteLine("The number is at {0}", i);
                    break;
                }

                i += 1;

            } while (i < Arr.Length);
        }
        
    }
}

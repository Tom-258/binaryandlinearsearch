using System;

namespace Linear_and_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] {0, 1, 2, 3, 4, 5, 6, 10, 18, 27, 63, 72, 96, 97, 98};
            var n = int.Parse(Console.ReadLine());
            LinearSearch(arr, n);
            BinarySearch(arr, n);

            static void LinearSearch(int[] arr, int n)
            {
                var i = 0;
                do
                {
                    if (arr[i] == n)
                    {
                        Console.WriteLine("The number is at {0}", i);
                        break;
                    }

                    i += 1;

                } while (i < arr.Length);
            }

            static void BinarySearch(int[] arr, int n)
            {
                var isInlist = false;
                var i = arr.Length / 2 - 1;
                
                while (!isInlist)
                {
                    if (n < arr[i])
                        i -= i / 2;
                    if (n > arr[i])
                        i += i / 2;
                    if (n == arr[i])
                    {
                        isInlist = true;
                    }
                    else
                    {
                        break;
                    }
                }

                if (isInlist)
                    Console.WriteLine("Number is at {0}", i);
                else
                    Console.WriteLine("Number is not in list");
            }
        }
    }
}

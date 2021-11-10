using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a;

            Console.Write("Nhap so n: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(1, 100);
            }

            Console.WriteLine("Phan tu trong mang");
            Print(arr);
            Console.WriteLine("Sap xep tang dan");
            arr = arr.OrderBy(x => x).ToArray();
            Print(arr);
            Console.WriteLine("Tim kiem nhi phan");
            Console.Write("Nhap so can tim: ");
            a = int.Parse(Console.ReadLine());
            if (BinarySearch(arr, a).ToString() == "Nil")
                Console.WriteLine("Khong tim thay gia tri {0}", a);
            else Console.WriteLine("Tim thay gia tri {0}", a);
            Console.ReadKey();
        }

        static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static object BinarySearch(int[] inputArray, int key)
        {
            int min = 1;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "Nil";
        }
    }
}

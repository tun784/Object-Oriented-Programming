using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace List_inOOP
{
    class Program
    {
        /// <summary>
        /// 1. Sum all elements in the list
        /// 2. Count even numbers
        ///    Sum even numbers
        /// 3. List of numbers that divisible by 5
        /// 4. Find an integer number inputed from keyboard
        /// </summary>
        static void _Main()
        {
            // Initialize list
            List<int> danhsach = new List<int>();
            // Input every elements into the list
            Console.Write("Enter the size of the List: ");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write("Index[{0}] of the List: ", i);
                int x = int.Parse(Console.ReadLine());
                danhsach.Add(x);
            }
            // Show all elements in the list
            Console.Write("List:");
            foreach (int element in danhsach)
            {
                Console.Write(" {0}", element);
            }
            Console.ReadLine();
            //1. Sum all elements in the list
            int sum = danhsach.Sum();
            Console.WriteLine("Tong cac phan tu trong danh sach: {0}", sum);
            //2. Sum even numbers
            int sumEvenNumbers = danhsach.Where(item => item % 2 == 0).Sum();
            Console.WriteLine("Tong cac so chan trong danh sach: {0}", sumEvenNumbers);
            //Count even numbers
            int countEvenNumbers = danhsach.Count(item => item % 2 == 0);
            Console.WriteLine("So luong so chan trong danh sach: {0}", countEvenNumbers);
            //3. List of numbers that divisible by 3
            List<int> danhsach1 = danhsach.Where(t => t % 3 == 0).ToList();
            Console.Write("List of numbers that divisible by {0} are", 3);
            foreach (int k in danhsach1)
            {
                Console.Write(" {0}", k);
            }
            //4. Find an integer number inputed from keyboard
            int y = int.Parse(Console.ReadLine());
            int result = danhsach.FirstOrDefault(x => x == y);
            if (result == null)
                Console.WriteLine("Unable to find out {0}", y);
            else
                Console.WriteLine("{0} was found.", y);
        }
    }
}
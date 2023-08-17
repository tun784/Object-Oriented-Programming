using System.IO;
using System.Linq;
namespace Bai1 {
    class program {
        /// <summary>
        /// 1. Sum all elements in the list
        /// 2. Count even numbers
        ///    Sum even numbers
        /// 3. List of numbers that divisible by 5
        /// 4. Find an integer number inputed from keyboard
        /// </summary>
        static void Main() {
            // Initialize list
            List<int> danhsach= new List<int>();
            // Input every elements into the list
            int size = int.Parse(Console.ReadLine());
            for (int i=0; i<size; i++) {
                int x = int.Parse(Console.ReadLine());
                danhsach.Add(x);
            }
            // Show all elements in the list
            foreach (int element in danhsach) {
                Console.Write("List: ", element);
            }
            Console.ReadLine();
            //1. Sum all elements in the list
            int sum = danhsach.Sum();
            Console.WriteLine("Tong cac phan tu trong danh sach= {0}", sum);
            //2. Count even numbers
            int countEvenNumbers = danhsach.Count(k => k % 2 == 0);
            Console.WriteLine("So luong so chan trong danh sach: {0}", countEvenNumbers);
            // Sum even numbers
            int sumEvenNumbers = danhsach.Where(y => y % 2 == 0).Sum();
            Console.WriteLine("Tong cac so chan trong danh sach: {0}", sumEvenNumbers);
            //3. List of numbers that divisible by 5
            List<int> danhsach1 = danhsach.Where(t => t % 5 == 0).ToList();
            foreach(int k in danhsach1) {
                Console.Write("{0} ", k);
            }
            //4. Find an integer number inputed from keyboard
            int y = int.Parse(Console.ReadLine());
            int result = danhsach.FirstOrDefault(x => x == y);
            if (result == null) {
                Console.WriteLine("Unable to find out {0}", y);
            else
                    Console.WriteLine("{0} was found.", y);
            }
        }
    }
}
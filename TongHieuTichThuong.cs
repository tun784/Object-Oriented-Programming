using System;

namespace Basic_calculate{
    class _Program{
        static void Main()
        {
            int a, b;
            Console.WriteLine("Nhap hai so nguyen bat ky.");
            Console.Write("Moi nhap so thu nhat: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Moi nhap so thu hai: ");
            b = int.Parse(Console.ReadLine());
            while (b == 0) {
                Console.Write("Ban da nhap so thu hai la so {0}, yeu cau ban nhap lai: ", b);
                b = int.Parse(Console.ReadLine());
            }
            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            float thuong = (float) a / b;
            Console.WriteLine("Tong= {0}, Hieu= {1}, Tich= {2}, Thuong= {3}.", tong, hieu, tich, thuong);
        }
    }
}
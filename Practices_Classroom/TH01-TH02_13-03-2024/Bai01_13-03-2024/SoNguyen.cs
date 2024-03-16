using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01_13_03_2024
{
    class SoNguyen
    {
        public int a, b;
        public SoNguyen()
        {
            a = b = 0;
        }
        public SoNguyen(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Tong()
        {
            return a + b;
        }
        public int Hieu()
        {
            return a - b;
        }
        public int Tich()
        {
            return a * b;
        }
        public double Thuong()
        {
            return (double)a / b;
        }
        public void Nhap()
        {
            Console.Write("Nhap so nguyen a bat ki: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen b bat ki: ");
            b = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("{0} & {1}", a, b);
        }
    }
}

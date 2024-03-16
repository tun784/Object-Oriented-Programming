using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01_13_03_2024
{
    class PTbac1
    {
        public int a, b, c;
        public double x1, x2;
        public PTbac1()
        {
            a = b = c = 0;
        }
        public PTbac1(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Nhap()
        {
            Console.Write("Nhap so nguyen a bat ki: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen b bat ki: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen c bat ki: ");
            c = int.Parse(Console.ReadLine());
        }
        public int Delta(){
            return b*b - (4*a*c);
        }
        public int timNghiem()
        {
            if (Delta() < 0)
                return -1;
            else if (Delta() == 0)
                return 0;
            else
                return 1;
        }
        public double nghiemKep()
        {
            return (double)(-b) / (2 * a);
        }
        public double X1()
        {
            return (double)(-b + Math.Sqrt(Delta())) / (2*a);
        }
        public double X2()
        {
            return (double)(-b - Math.Sqrt(Delta())) / (2 * a);
        }
        public void XuatHeSo()
        {
            Console.WriteLine("{0} ; {1} ; {2}", a, b, c);
            Console.WriteLine("{0} ; {1}", Delta(), timNghiem());
        }
        public void Xuat()
        {
            if (timNghiem() == -1)
                Console.WriteLine("Phuong trinh vo nghiem.");
            else if (timNghiem() == 0)
                Console.WriteLine("Phuong trinh co 1 nghiem kep la {0:0.00}", nghiemKep());
            else
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet la x1 = {0:0.00} va x2 = {1:0.00}", X1(), X2());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_13_03_2024
{
    class HinhTron
    {
        double r;
        public double R
        {
            get { return r; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Ban kinh khong hop le.");
                    r = 0;
                } 
                else
                    r = value;
            }
        }
        public HinhTron()
        {
            r = 0;
        }
        public HinhTron(double r)
        {
            this.r = r;
        }
        public void Nhap()
        {
            Console.Write("Vui long nhap ban kinh: ");
            r = double.Parse(Console.ReadLine());
        }
        public double chuVi()
        {
            return 2 * Math.PI * r;
        }
        public double dienTich()
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public void Xuat()
        {
            Console.WriteLine("Chu vi = {0:0.00} - Dien tich = {1:0.00}", chuVi(), dienTich());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_13_03_2024
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 2;
            switch (option)
            {
                case 1:
                    {
                        HinhTron A = new HinhTron();
                        A.Nhap();
                        A.Xuat();
                    }break;
                case 2:
                    {
                        NhanVien B = new NhanVien();
                        B.Nhap();
                        B.Xuat();
                    }break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}

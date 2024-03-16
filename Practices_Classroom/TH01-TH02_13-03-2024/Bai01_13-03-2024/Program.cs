using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01_13_03_2024
{
    class Program {
        static void Main(string[] args)
        {
            int option = 4;
            switch (option)
            {
                case 1:
                    {
                        // Bai 1
                        SoNguyen A = new SoNguyen();
                        A.Nhap();

                        Console.WriteLine("Tong {0} va {1} la {2}", A.a, A.b, A.Tong());
                        Console.WriteLine("Hieu {0} va {1} la {2}", A.a, A.b, A.Hieu());
                        Console.WriteLine("Tich {0} va {1} la {2}", A.a, A.b, A.Tich());
                        Console.WriteLine("Thuong {0} va {1} la {2:0.00}", A.a, A.b, A.Thuong());
                    }break;
                case 2:
                    {
                        // Bai 2
                        SinhVien B = new SinhVien();
                        B.Nhap();
                        B.Xuat();
                    }break;
                case 3:
                    {
                        int n;
                        Console.Write("Nhap phan tu day so: ");
                        n = int.Parse(Console.ReadLine());
                        List<int> dso = new List<int>(n);
                        Random a = new Random();
                        for (int i = 0; i < dso.Capacity; i++) {
                            int k = a.Next(100);
                            dso.Add(k);
                        }
                        foreach (int t in dso)
                            Console.Write(t + " ");
                    }break;
                case 4:
                    {
                        PTbac1 nghiem = new PTbac1();
                        nghiem.Nhap();
                        nghiem.Xuat();
                    }break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}

using System;
namespace Bai_1_Ngay_Thang
{
    class Program{
        static void Main(){
            NgayThang b = new NgayThang();
            b.Nhap();
            Console.Write("Ngay vua nhap la: ");
            b.Xuat();
            Console.Write("\nNgay hom truoc: ");
            NgayThang a = b.NgayTruoc();
            a.Xuat();
            Console.Write("\nNgay hom sau: ");
            NgayThang c = b.NgaySau();
            c.Xuat();
            Console.ReadLine();
        }
    }
}
using System;

namespace GachBong
{
    class program{
        static void Main(){
        Console.WriteLine("\tHoa don loai 1");
        HDloai_1 hdLoai1 = new HDloai_1();
        hdLoai1.Nhap();
        Console.WriteLine("\tHoa don loai 2");
        HDloai_2 hdLoai2 = new HDloai_2();
        hdLoai2.Nhap();
        Console.WriteLine("\tHoa don loai ngoai nhap");
        HDngoaiNhap hdNgoaiNhap = new HDngoaiNhap();
        hdNgoaiNhap.Nhap();

        Console.WriteLine("\n\tHoa don loai 1");
        hdLoai1.Xuat();
        Console.WriteLine("\tHoa don loai 2");
        hdLoai2.Xuat();
        Console.WriteLine("\tHoa don ngoai nhap");
        hdNgoaiNhap.Xuat();

        Console.ReadLine(); // Keep the console window open in debug mode.
        }
    }
}
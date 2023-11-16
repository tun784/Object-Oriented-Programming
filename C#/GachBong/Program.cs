using System;

namespace GachBong
{
    class program{
        static void Main(){
        Console.WriteLine("\tHoa don loai 1");
        HDloai_1 hdLoai1 = new HDloai_1("HD0001", "a", 69.3, 34.2, 799, 30, "Dong Tam");
        //hdLoai1.Nhap();
        Console.WriteLine("\tHoa don loai 2");
        HDloai_2 hdLoai2 = new HDloai_2("HD0002", "b", 54.2, 45.8, 650, 20, "Ceramic", 4);
        //hdLoai2.Nhap();
        Console.WriteLine("\tHoa don loai ngoai nhap");
        HDngoaiNhap hdNgoaiNhap = new HDngoaiNhap("HD0010", "c", 40.1, 25.8, 199, 40, "China", 3);
        //hdNgoaiNhap.Nhap();

        Console.WriteLine("\n\tHoa don loai 1");
        hdLoai1.Xuat();
        Console.WriteLine("\n\tHoa don loai 2");
        hdLoai2.Xuat();
        Console.WriteLine("\n\tHoa don ngoai nhap");
        hdNgoaiNhap.Xuat();

        Console.ReadLine(); // Keep the console window open in debug mode.
        }
    }
}
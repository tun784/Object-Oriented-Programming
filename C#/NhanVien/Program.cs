using System;
namespace NhanVien
{
    class Program
    {
        static void Main(){
            QLNhanVien NV_a = new QLNhanVien("402", "Tran Tinh", 2.34, 2010);
            System.Console.Write("Luong cua nguoi nay la: {0}", NV_a.LuongMoiNhanVien());
        }
    }
}
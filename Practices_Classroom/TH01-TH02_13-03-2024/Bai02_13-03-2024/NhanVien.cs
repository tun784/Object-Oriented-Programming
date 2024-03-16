using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_13_03_2024
{
    class NhanVien
    {
        string ms, ht; // ma so, ho ten

        public string Ht
        {
            get { return ht; }
            set { ht = value; }
        }
        public string Ms
        {
            get { return ms; }
            set { ms = value; }
        }
        int nc; // so ngay cong

        public int Nc
        {
            get { return nc; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("So ngay cong khong hop le.");
                    nc = 0;
                }
                else
                    nc = value;
            }
        }
        public char Xl {
            get {
                if (nc > 26)
                    return 'A';
                else if (nc >= 22)
                    return 'B';
                else
                    return 'C';
            }
        }
        public static int LuongNgay = 200000;

        public NhanVien()
        {
            Ms = Ht = "";
            Nc = 0;
        }
        public NhanVien(string ht, string ms, int nc)
        {
            this.Ht = ht;
            this.Ms = ms;
            this.Nc = nc;
        }
        public NhanVien(NhanVien a)
        {
            this.Ht = a.Ht;
            this.Ms = a.Ms;
            this.Nc = a.Nc;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma so: ");
            Ms = Console.ReadLine();
            Console.Write("Nhap ho va ten: ");
            Ht = Console.ReadLine();
            Console.Write("Nhap so ngay cong: ");
            Nc = int.Parse(Console.ReadLine());
        }
        public long Luong()
        {
            return nc * LuongNgay;
        }
        public double Thuong()
        {
            if (Xl == 'A')
                return (double)0.05 * Luong();
            else if (Xl == 'B')
                return (double)0.02 * Luong();
            else
                return 0;
        }
        public void Xuat()
        {
            Console.WriteLine("Ma So: {0} - Ho va ten: {1} - So ngay cong: {2}", ms, ht, nc);
            Console.WriteLine("Xep loai: {0} - Luong: {1} dong - Thuong: {2} dong", Xl, Luong(), Thuong());
        }
    }
}

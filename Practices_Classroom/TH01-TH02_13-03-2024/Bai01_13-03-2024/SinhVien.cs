using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01_13_03_2024
{
    class SinhVien
    {
        public string mssv, hoten, xeploai;
        public float dtb;
        public SinhVien()
        {
            mssv = "xxxxxxxxxx";
            hoten = "Nguyen Van A";
            xeploai = "xxx";
            dtb = 0;
        }
        public SinhVien(string mssv, string hoten, float dtb)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.dtb = dtb;
        }
        public void Nhap(){
            Console.Write("Nhap MSSV: ");
            mssv = Console.ReadLine();
            Console.Write("Nhap ho va ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            dtb = float.Parse(Console.ReadLine());
        }
        public string XepLoai()
        {
            if (dtb >= 8)
                xeploai = "Gioi";
            else if (dtb >= 6.5)
                xeploai = "Kha";
            else if (dtb >= 5)
                xeploai = "Trung binh";
            else
                xeploai = "Yeu kem";
            return xeploai;
        }
        public void Xuat()
        {
            Console.WriteLine("Thong tin sinh vien:");
            Console.Write("MSSV: {0} - Ho va ten: {1} - Diem trung binh: {2:0.00} - Xep loai: {3}", mssv, hoten, dtb, XepLoai());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_1_Nhan_Vien
{
    class NhanVien
    {
        // properties
        string maNhanVien, hoTen;
        double heSoLuong;
        int namVaoLam;
        public static int mucLuongToiThieu = 1750000;
        // get - set
        public string MaNV { get { return maNhanVien; } set { maNhanVien = value; } }
        public string HoTen { get { return hoTen; } set { hoTen = value; } }
        public double hsl
        {
            get { return heSoLuong; }
            set
            {
                if (value < 0)
                    heSoLuong = 0;
                else
                    heSoLuong = value;
            }
        }
        public int nvl
        {
            get { return namVaoLam; }
            set
            {
                if (value < 0)
                    namVaoLam = 0;
                else
                    namVaoLam = value;
            }
        }
        // constructors
        public NhanVien()
        {
            MaNV = "---";
            HoTen = "---";
            hsl = 0;
            nvl = 0;
        }
        public NhanVien(string MaNV, string HoTen, double hsl, int nvl)
        {
            this.MaNV = MaNV;
            this.HoTen = HoTen;
            this.hsl = hsl;
            this.nvl = nvl;
        }
        // Methods
        public void Nhap()
        {
            Console.Write("\tNhap ma so nhan vien: ");
            MaNV = Console.ReadLine();
            Console.Write("\tNhap ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("\tNhap he so luong: ");
            hsl = double.Parse(Console.ReadLine().Replace('.', ','));
            Console.Write("\tNhap nam vao lam: ");
            nvl = int.Parse(Console.ReadLine());
        }
        public double LuongCoBan()
        {
            return heSoLuong * mucLuongToiThieu;
        }
        public double heSoPhuCapThamNiem()
        {
            return (DateTime.Today.Year - namVaoLam)*1.0;
        }
        public double Luong()
        {
            return LuongCoBan() * heSoPhuCapThamNiem();
        }
        public void Xuat()
        {
            Console.WriteLine("\tMa nhan vien: {0}", maNhanVien);
            Console.WriteLine("\tHo va ten: {0}", hoTen);
            Console.WriteLine("\tHe so luong: {0}", heSoLuong);
            Console.WriteLine("\tNam vao lam: {0}", namVaoLam);
            Console.WriteLine("\tLuong: {0}", Luong());
        }
    }
}

using System;
namespace Bai_1_Nhan_Vien
{
    class NhanVien{
        // properties
        string maNhanVien = "---", hoTen = "---";
        double heSoLuong = 0.0;
        int namVaoLam = 0;
        public static int mucLuongToiThieu = 1750000;
        // get - set
        public string MaNV { get {return maNhanVien; } set{ maNhanVien = value; } }
        public string HoTen { get {return hoTen; } set { hoTen = value; } }
        public double hsl {
            get { return heSoLuong; }
            set {
                if (value < 0)
                    heSoLuong = 0;
                else
                    heSoLuong = value;
            }
        }
        public int nvl {
            get { return namVaoLam; }
            set {
                if (value < 0)
                    namVaoLam = 0;
                else
                    namVaoLam = value;
            }
        }
        // constructors
        public NhanVien(){
            MaNV = "---";
            HoTen = "---";
            hsl = 0;
            nvl = 0;
        }
        public NhanVien(string MaNV, string HoTen, double hsl, int nvl){
            this.MaNV = MaNV;
            this.HoTen = HoTen;
            this.hsl = hsl;
            this.nvl = nvl;
        }
        // Methods
        public void Nhap(){
            System.Console.Write("Nhap ma so nhan vien: ");
            MaNV = Console.ReadLine();
            System.Console.Write("Nhap ho va ten: ");
            HoTen = Console.ReadLine();
            System.Console.Write("Nhap he so luong: ");
            hsl = double.Parse(Console.ReadLine());
            System.Console.Write("Nhap nam vao lam: ");
            nvl = int.Parse(Console.ReadLine());
        }
        public void Xuat(){
            System.Console.WriteLine("\n\t{0}\t{1}\t{2}\t{3}", maNhanVien, hoTen, heSoLuong, namVaoLam);
        }
        public double LuongCoBan(){
            return heSoLuong * mucLuongToiThieu;
        }
        public double heSoPhuCapThamNiem(){
            return (DateTime.Today.Year - namVaoLam)*1.0 / 100;
        }
        public double Luong(){
            return LuongCoBan() * heSoPhuCapThamNiem();
        }
    }
}
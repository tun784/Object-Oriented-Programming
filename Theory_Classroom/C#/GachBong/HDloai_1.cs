using System;

namespace GachBong
{
    class HDloai_1 : HoaDon, HoTro{
        public string HangSanXuat;
        public static string hangSX = "Dong Tam";
        public static int sl1 = 200, sl2 = 800;
        public HDloai_1() : base(){
            HangSanXuat = "Dong Tam";
        }
        public HDloai_1(string mahoadon, string tengachbong, double chieudai, double chieurong, int soluong, double dongia, string hangsanxuat) : base(mahoadon, tengachbong, chieudai, chieurong, soluong, dongia){
            this.HangSanXuat = hangsanxuat;
        }
        public override double GiamGia(){
            if (HangSanXuat == hangSX)
                return donGia * 0.1;
            else if (soLuong >= 1000)
                return donGia * 0.04;
            else
                return donGia * 0.0;
        }
        public double HoTroGia(){
            if (soLuong < sl1)
                return donGia * 0.03;
            else if (soLuong > sl2)
                return donGia * 0.05;
            else
                return donGia * 0.04;
        }
        public override void Nhap(){
            try{
                base.Nhap();
                Console.Write("Vui long nhap hang san xuat: ");
                HangSanXuat = Console.ReadLine();
            }
            catch (FormatException){
                Console.WriteLine("Nhap sai dinh dang. Vui long nhap lai.");
                // Có thể thêm các xử lý khác tùy vào yêu cầu của bài toán
            }
        }
        public override void Xuat(){
            base.Xuat();
            Console.WriteLine($"Hang san xuat: {HangSanXuat}");
        }
    }
}
using System;

namespace GachBong
{
    class HDloai_2 : HoaDon, HoTro{
        public string loai;
        public string loai01 = "Granite", loai02 = "Ceramic";
        public double khoangCachGiaoHang;
        public static double kcgh_1 = 5, kcgh_2 = 15;
        public HDloai_2() : base(){
            loai = loai02;
            khoangCachGiaoHang = 4.0;
        }
        public HDloai_2(string mahoadon, string tengachbong, double chieudai, double chieurong, int soluong, double dongia, string loai, double kcgh) : base(mahoadon, tengachbong, chieudai, chieurong, soluong, dongia){
            this.loai = loai;
            this.khoangCachGiaoHang = kcgh;
        }
        public override double GiamGia(){
            if (khoangCachGiaoHang > kcgh_2)
                return donGia * 0.0;
            else if (khoangCachGiaoHang < kcgh_1)
                return donGia * 0.05;
            else
                return donGia * 0.03;
        }
        public double HoTroGia(){
            if (loai == loai01)
                return soLuong * 3.0;
            else
                return soLuong * 5.0;
        }
        public override void Nhap(){
            try{
                base.Nhap();
                Console.Write("Vui long nhap loai gach: ");
                loai = Console.ReadLine();
                Console.Write("Vui long nhap khoang cach giao hang (km): ");
                khoangCachGiaoHang = double.Parse(Console.ReadLine().Replace('.', ','));
            }
            catch (FormatException){
                Console.WriteLine("Nhap sai dinh dang. Vui long nhap lai.");
                // Có thể thêm các xử lý khác tùy vào yêu cầu của bài toán
            }
        }
        public override void Xuat(){
            base.Xuat();
            Console.WriteLine($"Loai: {loai}");
            Console.WriteLine("Khoang cach giao hang: {0} km", khoangCachGiaoHang);
        }
    }
}
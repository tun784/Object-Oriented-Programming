using System;

namespace GachBong
{
    class HDloai_2 : HoaDon, HoTro{
        public string loai;
        public string loai01 = "Granite", loai02 = "Ceramic";
        public double khoangCachGiaoHang;
        public double kcgh_1 = 5, kcgh_2 = 15;
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
                // Console.Write("Vui long nhap ma hoa don: ");
                // MaHD = Console.ReadLine();
                // Console.Write("Vui long nhap ten gach bong: ");
                // tenGachBong = Console.ReadLine();
                // Console.Write("Vui long nhap chieu dai (cm): ");
                // chieuDai = double.Parse(Console.ReadLine().Replace('.', ','));
                // Console.Write("Vui long nhap chieu rong (cm): ");
                // chieuRong = double.Parse(Console.ReadLine().Replace('.', ','));
                // Console.Write("Vui long nhap so luong: ");
                // SL = int.Parse(Console.ReadLine());
                // Console.Write("Vui long nhap don gia: ");
                // donGia = double.Parse(Console.ReadLine().Replace('.', ','));
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
    }
}
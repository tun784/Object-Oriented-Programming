using System;

namespace GachBong
{
    class HDloai_1 : HoaDon, HoTro{
        public string HangSanXuat;
        public static string hangSX = "Dong Tam";
        public int sl1 = 200, sl2 = 800;
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
                // Console.Write("Vui long nhap ma hoa don: ");
                // MaHD = Console.ReadLine();
                // Console.Write("Vui long nhap ten gach bong: ");
                // tenGachBong = Console.ReadLine();
                // Console.Write("Vui long nhap chieu dai (cm): ");
                // chieuDai = double.Parse(Console.ReadLine());
                // Console.Write("Vui long nhap chieu rong (cm): ");
                // chieuRong = double.Parse(Console.ReadLine());
                // Console.Write("Vui long nhap so luong: ");
                // SL = int.Parse(Console.ReadLine());
                // Console.Write("Vui long nhap don gia: ");
                // donGia = double.Parse(Console.ReadLine());
                base.Nhap();
                Console.Write("Vui long nhap hang san xuat: ");
                HangSanXuat = Console.ReadLine();
            }
            catch (FormatException){
                Console.WriteLine("Nhap sai dinh dang. Vui long nhap lai.");
                // Có thể thêm các xử lý khác tùy vào yêu cầu của bài toán
            }
        }
    }
}
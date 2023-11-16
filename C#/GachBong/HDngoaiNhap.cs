using System;

namespace GachBong
{
    class HDngoaiNhap : HoaDon{
        public string noiSanXuat;
        public int chatLuong; //1, 2, 3
        public static double thueNhapKhau = 0.05;
        protected string NSX1 = "Italia";
        protected string NSX2 = "Japan";
        protected int loai1 = 1, loai2 = 2, loai3 = 3;
        public override double GiamGia(){
            if (noiSanXuat == NSX1 || noiSanXuat == NSX2)
                return donGia * 0.0;
            else if (chatLuong == loai1)
                return donGia * 0.03;
            else if (chatLuong == loai2)
                return donGia * 0.02;
            else
                return donGia * 0.0;
        }
        public override double ThueNhapKhau(){
            if (chatLuong == loai1 || chatLuong == loai2)
                return 0.0;
            else{
                return TongTien() * 0.05;
            }
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
                Console.Write("Vui long nhap noi san xuat: ");
                noiSanXuat = Console.ReadLine();
                Console.Write("Vui long nhap chat luong theo so 1, 2, 3: ");
                chatLuong = int.Parse(Console.ReadLine());
            }
            catch (FormatException){
                Console.WriteLine("Nhap sai dinh dang. Vui long nhap lai.");
                // Có thể thêm các xử lý khác tùy vào yêu cầu của bài toán
            }
        }
    }
}
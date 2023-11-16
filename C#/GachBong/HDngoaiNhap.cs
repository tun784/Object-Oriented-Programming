using System;

namespace GachBong
{
    class HDngoaiNhap : HoaDon{
        public string noiSanXuat;
        public int chatLuong; //1, 2, 3
        protected string NSX1 = "Italia";
        protected string NSX2 = "Japan";
        public static double thueNhapKhau = 0.05;
        protected static int loai1 = 1, loai2 = 2, loai3 = 3;
        public HDngoaiNhap() : base(){
            noiSanXuat = "China";
            chatLuong = 3;
        }
        public HDngoaiNhap(string mahoadon, string tengachbong, double chieudai, double chieurong, int soluong, double dongia, string noisanxuat, int chatluong) : base(mahoadon, tengachbong, chieudai, chieurong, soluong, dongia){
            this.noiSanXuat = noisanxuat;
            this.chatLuong = chatluong;
        }
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
        public override void Xuat(){
            base.Xuat();
            Console.WriteLine($"Noi san xuat: {noiSanXuat}");
            Console.WriteLine($"Chat luong: loai {chatLuong}");
        }
    }
}
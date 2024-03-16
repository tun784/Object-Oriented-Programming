using System;

namespace GachBong
{
    abstract class HoaDon{
        // properties
        protected string maHoaDon;
        public string MaHD
        {
            get { return maHoaDon; }
            set{ 
                if (value.Length == 6 && value.StartsWith("HD"))
                    maHoaDon = value;
                else
                    Console.WriteLine("Ma hoa don khong hop le.");
            }
        }
        public string tenGachBong;
        public double chieuDai;
        public double chieuRong;
        protected int soLuong;
        public int SL
        {
            get { return soLuong; }
            set{
                if (value > 10)
                    soLuong = value;
                else
                    Console.WriteLine("So luong khong hop le.");
            }
        }
        public double donGia;
        public static double tyLe_VAT = 0.1;
        // constructors
        public HoaDon(){
            maHoaDon = "HD0001";
            tenGachBong = "op tuong phong khach";
            chieuDai = 60.0;
            chieuRong = 40.0;
            soLuong = 1200;
            donGia = 60.0;
        }
        public HoaDon(string mahoadon, string tengachbong, double chieudai, double chieurong, int soluong, double dongia){
            this.maHoaDon = mahoadon;
            this.tenGachBong = tengachbong;
            this.chieuDai = chieudai;
            this.chieuRong = chieurong;
            this.soLuong = soluong;
            this.donGia = dongia;
        }
        public abstract double GiamGia();
        public double TongTien(){
            return soLuong * donGia - GiamGia();
        }
        public virtual double ThueNhapKhau(){
            return 0.0;
        }
        public virtual double Thue(){
            return tyLe_VAT * TongTien() + ThueNhapKhau();
        }
        public virtual void Nhap(){
            try{
                Console.Write("Vui long nhap ma hoa don: ");
                MaHD = Console.ReadLine();
                Console.Write("Vui long nhap ten gach bong: ");
                tenGachBong = Console.ReadLine();
                Console.Write("Vui long nhap chieu dai (cm): ");
                chieuDai = double.Parse(Console.ReadLine().Replace('.', ','));
                Console.Write("Vui long nhap chieu rong (cm): ");
                chieuRong = double.Parse(Console.ReadLine().Replace('.', ','));
                Console.Write("Vui long nhap so luong (cai): ");
                SL = int.Parse(Console.ReadLine());
                Console.Write("Vui long nhap don gia (dong): ");
                donGia = double.Parse(Console.ReadLine().Replace('.', ','));
            }
            catch (FormatException){
                Console.WriteLine("Nhap sai dinh dang. Vui long nhap lai.");
                // Có thể thêm các xử lý khác tùy vào yêu cầu của bài toán
            }
        }
        public virtual void Xuat(){
            Console.WriteLine($"Ma hoa don: {maHoaDon}");
            Console.WriteLine($"Ten gach bong: {tenGachBong}");
            Console.WriteLine($"Chieu dai: {chieuDai} cm");
            Console.WriteLine($"Chieu rong: {chieuRong} cm");
            Console.WriteLine($"So luong: {soLuong} cai.");
            Console.WriteLine("Don gia: {0:0.000} dong", donGia);
            Console.WriteLine("Tong tien: {0:0.000} dong", TongTien());
            Console.WriteLine("Thue: {0:0.000} dong", Thue());
        }
    }
}
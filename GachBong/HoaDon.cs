using System

namespace GachBong
{
    class HoaDon
    {
        // properties
        private string maHoaDon;
        public string MaHD
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        unsigned int soLuong;
        public string tenGachBong;
        public double chieuDai;
        public double chieuRong;
        private unsigned int soLuong;
        public unsigned int SL
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public double donGia;
        static public double tyLeThue;
        // constructors
        public HoaDon(){
            maHoaDon = "HD0000";
            tenGachBong = "......";
            chieuDai = 0.0;
            chieuRong = 0.0;
            soLuong = 0;
            donGia = 0.0;
        }
        public HoaDon(string mahoadon, string tengachbong, double chieudai, double chieurong, unsigned int soluong, double dongia){
            this.maHoaDon = mahoadon;
            this.tenGachBong = tengachbong;
            this.chieuDai = chieudai;
            this.chieuRong = chieurong;
            this.soLuong = soluong;
            this.donGia = dongia;
        }
        public double TongTien(){

        }
        abstract double ThueNhapKhau();
        abstract double GiamGia();
        public double Thue(){

        }
        public void Nhap(){
            
        }
        public void Xuat(){

        }
    }
}
using System;

namespace BaiLam{
    class HinhTron{
        public double banKinh;
        public void input(){
            Console.Write("Nhap gia tri cho ban kinh: ");
            banKinh = double.Parse(Console.ReadLine()); // Nhập vào một chuỗi string và ép kiểu double
        }
        public void output(){
            Console.WriteLine("Ban kinh ban vua nhap la {0}.", banKinh);
        }
        public double chuVi(){
            return banKinh * 2 * Math.PI;
        }
        public double dienTich(){
            return Math.Pow(banKinh,2) * Math.PI;
        }
    }
    class NgayThang{
        private int day, month, year;
        public int d {
            get {
                return d;
            }
            set {
                day = value;
            }
        }
        public int m {
            get {
                return m;
            }
            set {
                month = value;
            }
        }
        public int y {
            get {
                return y;
            }
            set {
                year = value;
            }
        }
        public NgayThang(NgayThang date) {
            day = date.day;
            month = date.month;
            year = date.year;
        }
        public bool checkLeapYear() {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                return true;
            else return false;
        }
    }
    class Program{
        static void Main(){
            HinhTron circle_01 = new HinhTron();
            circle_01.input();
            circle_01.output();
            Console.WriteLine("Chu vi hinh tron la: {0:0.00}", circle_01.chuVi());
            Console.WriteLine("Dien tich hinh tron: {0:0.00}", circle_01.dienTich());
        }
    }
}
using System;
using System.Globalization;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace Class_basic
{
    class HinhTron
    {
        // Properties
        private double banKinh;
        // get - set
        public double R{
            get { return banKinh; }
            set { banKinh = value; }
        }
        // Phương thức khởi tạo
        public HinhTron(){
            banKinh = 0;
        }
        public HinhTron(double R){
            banKinh = R;
        }
        public HinhTron(HinhTron hinh){
            this.banKinh = hinh.banKinh;
        }
        // Phương thức xử lý
        public void input(){
            Console.Write("Nhap gia tri cho ban kinh: ");
            banKinh = double.Parse(Console.ReadLine().Replace('.',','));
            //banKinh = double.Parse(Console.ReadLine()); // Nhập vào một chuỗi string và ép kiểu double
        }
        public void output(){
            Console.WriteLine("Ban kinh ban vua nhap la {0}", banKinh);
        }
        public double chuVi(){
            return this.banKinh * 2 * Math.PI;
            //return banKinh * 2 * Math.PI;
        }
        public double dienTich(){
            return Math.Pow(this.banKinh, 2) * Math.PI;
            //return Math.Pow(banKinh, 2) * Math.PI;
        }
        public double duongKinh(){
            return this.banKinh * 2;
        }
    }
    class Diem2D{
        int x, y;
        // get - set
        public int diemX{
            get { return x; }
            set { x = value; }
        }
        public int diemY{
            get { return y; }
            set { y = value; }
        }
        // Phương thức khởi tạo
        public Diem2D(){
            x = y = 0;
        }
        public Diem2D(int hoanhdo, int tungdo){
            x = hoanhdo;
            y = tungdo;
        }
        public Diem2D(Diem2D diem){
            this.x = diem.x;
            this.y = diem.y;
        }
        // Phương thức xử lý
        public void Input(){
            Console.Write("Nhap toa do x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
            y = int.Parse(Console.ReadLine());
        }
        public double KhoangCach_2Diem(Diem2D d){
            return Math.Sqrt(Math.Pow(this.x - d.x, 2) + Math.Pow(this.y - d.y, 2));
        }
    }
    class NgayThang
    {
        private int day, month, year;
        public int d
        {
            get { return day; }
            set { day = value; }
        }
        public int m
        {
            get { return month; }
            set { month = value; }
        }
        public int y
        {
            get { return year; }
            set { year = value; }
        }
        public NgayThang(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public NgayThang(NgayThang date)
        {
            day = date.day;
            month = date.month;
            year = date.year;
        }
        public bool checkLeapYear()
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                return true;
            else return false;
        }
    }
}
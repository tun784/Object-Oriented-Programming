using System;
using System.Globalization;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
namespace BaiTap
{
    class HinhTron
    {
        // Properties
        private double banKinh;
        // get - set
        public double R
        {
            get { return banKinh; }
            set { banKinh = value; }
        }
        // Phương thức khởi tạo
        public HinhTron()
        {
            banKinh = 0;
        }
        public HinhTron(double R)
        {
            banKinh = R;
        }
        public HinhTron(HinhTron hinh)
        {
            this.banKinh = hinh.banKinh;
        }
        // Phương thức xử lý
        public void input()
        {
            Console.Write("Nhap gia tri cho ban kinh: ");
            banKinh = double.Parse(Console.ReadLine().Replace('.',','));
            //banKinh = double.Parse(Console.ReadLine()); // Nhập vào một chuỗi string và ép kiểu double
        }
        public void output()
        {
            Console.WriteLine("Ban kinh ban vua nhap la {0}", banKinh);
        }
        public double chuVi()
        {
            return this.banKinh * 2 * Math.PI;
            //return banKinh * 2 * Math.PI;
        }
        public double dienTich()
        {
            return Math.Pow(this.banKinh, 2) * Math.PI;
            //return Math.Pow(banKinh, 2) * Math.PI;
        }
    }
    class Diem2D
    {
        int x, y;
        // get - set
        public int diemX
        {
            get { return x; }
            set { x = value; }
        }
        public int diemY
        {
            get { return y; }
            set { y = value; }
        }
        // Phương thức khởi tạo
        public Diem2D()
        {
            x = y = 0;
        }
        public Diem2D(int hoanhdo, int tungdo)
        {
            x = hoanhdo;
            y = tungdo;
        }
        // Phương thức xử lý
        public double KhoangCach_2Diem(Diem2D d)
        {
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

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hinh Tron");
            Console.WriteLine("Ngay Thang");
            Console.WriteLine("Do thi 2 chieu");

            int option;
            Console.Write("Ban muon chon bai nao: ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        HinhTron circle_01 = new HinhTron(4.1);
                        circle_01.input();
                        circle_01.output();
                        Console.WriteLine("Chu vi hinh tron la: {0:0.00}", circle_01.chuVi());
                        Console.WriteLine("Dien tich hinh tron: {0:0.00}", circle_01.dienTich());
                    }
                    break;
                case 2:
                    {
                        NgayThang date_01 = new NgayThang(31, 12, 2021);
                        if (date_01.checkLeapYear() == true)
                            Console.WriteLine("Nam {0} la nam nhuan.", date_01.y);
                        else
                            Console.WriteLine("Nam {0} la nam khong nhuan.", date_01.y);
                    }
                    break;
                case 3:
                    {
                        Diem2D point_01 = new Diem2D(2, 1);
                        Diem2D point_02 = new Diem2D(4, 5);
                        Console.WriteLine("Khoang cach giua 2 diem ({0},{1}) va ({2},{3}) la {4:0.00}.", point_01.diemX, point_01.diemY, point_02.diemX, point_02.diemY, point_01.KhoangCach_2Diem(point_02));
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
using System;
namespace Bai_1_Ngay_Thang
{
    class NgayThang
    {
        private int day, month, year;
        public int ngay
        {
            get { return day; }
            set { day = (value >= 1 && value <= 31) ? value : 1; }
        }
        public int thang
        {
            get { return month; }
            set { month = (value >= 1 && value <= 12) ? value : 1; }
        }
        public int nam
        {
            get { return year; }
            set { year = (value <= DateTime.Today.Year) ? value : DateTime.Today.Year; }
        }
        // constructor
        public NgayThang()
        {
            ngay = 1;
            thang = 1;
            nam = 1900;
        }
        public NgayThang(int ngay, int thang, int nam)
        {
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
        }
        public NgayThang(NgayThang date)
        {
            this.ngay = date.day;
            this.thang = date.month;
            this.nam = date.year;
        }
        // methods
        public bool checkYear(int year){
            if (year % 400 == 0 || (year % 4 ==0 && year % 100 != 0))
                return true;
            else
                return false;
        }
        public int NgayCuoiThang(int month, int year){
            if (month == 4 || month == 6 || month == 9 || month == 11)
                return 30;
            else if (month == 2){
                if (checkYear(year))
                    return 29;
                else
                    return 28;
            }
            else
                return 31;
        }
        public NgayThang NgayTruoc(){
            NgayThang ngaytruoc = new NgayThang();
            if (day > 1){
                ngaytruoc.day = day - 1;
                ngaytruoc.month = month;
                ngaytruoc.year = year;
            }
            else{
                if (month == 1){
                    ngaytruoc.day = 31;
                    ngaytruoc.month = 12;
                    ngaytruoc.year = year - 1;
                }
                else{
                    ngaytruoc.day = NgayCuoiThang(month - 1, year);
                    ngaytruoc.month = month - 1;
                    ngaytruoc.year = year;
                }
            }
            return ngaytruoc;
        }
        public NgayThang NgaySau(){
            NgayThang ngaysau = new NgayThang();
            int ngayCuoiThang = NgayCuoiThang(month, year);

            if (day < ngayCuoiThang){
                ngaysau.day = day + 1;
                ngaysau.month = month;
                ngaysau.year = year;
            }
            if (day == ngayCuoiThang){
                if (month == 12){
                    ngaysau.day = 1;
                    ngaysau.month = 1;
                    ngaysau.year = year + 1;
                }
                else{
                    ngaysau.day = 1;
                    ngaysau.month = month + 1;
                    ngaysau.year = year;
                }
            }
            return ngaysau;
        }
        public void Nhap(){
            Console.Write("Nhap ngay: ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());
        }
        public void Xuat(){
            System.Console.WriteLine("{0}/{1}/{2}",day, month, year);
        }
    }
}
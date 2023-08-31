using System;

namespace Bai2{
    public class NgayThang{
        private int day, month, year;
        public int d {
            get { return d; }
            set { day = value }
        }
        public int m {
            get { return m; }
            set { month = m;}
        }
        public int y {
            get { return y; }
            set { year = y; }
        }

        public NgayThang(NgayThang date){
            day = date.day;
            month = date.month;
            year = date.year;
        }

        public static bool checkLeapYear(){
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                return true;
            else return false;
        }
    }
    class Program{
        static void Main(){
            
        }
    }
}
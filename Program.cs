using System;
using System.Globalization;

namespace Object_Oriented_Programming{
    class Program{
        static void Main(){
            string choice;
            do {
                Console.WriteLine("Hinh Tron.");
                Console.WriteLine("Ngay Thang.");
                Console.WriteLine("Do thi 2 chieu.");
                Console.WriteLine("Xay dung class Animal don gian.");
                int option = 0;
                Console.Write("Ban muon chon bai nao: ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            HinhTron circle_01 = new HinhTron();
                            circle_01.input();
                            circle_01.output();
                            Console.WriteLine("Duong kinh hinh tron: {0:0.00}", circle_01.duongKinh());
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
                    case 4:
                        {
                            Animal pet01 = new Animal("Lion", 2, 0.9, 48.7, "Female");
                            Animal pet02 = new Animal("Tiger", 1, 0.8, 46.4, "Male");
                            Console.WriteLine("{0} and {1}", pet01.showName(), pet02.showName());
                            Animal pet03 = new Animal();
                            pet03.Input();
                            Console.WriteLine("");
                            pet03.Output();
                        }
                        break;
                }

                Console.Write("Ban muon tiep tuc khong (Y/N)? ");
                choice = Console.ReadLine();
                while (!( choice == 'y' || choice == 'Y' || choice == 'n' || choice == 'N' ) ){
                    Console.Write("Yeu cau khong hop le, xin vui long nhap lai: ");
                    choice = Console.ReadLine();
                }
            } while(choice == 'y' || choice == 'Y');
            //Console.ReadLine();
        }
    }
}
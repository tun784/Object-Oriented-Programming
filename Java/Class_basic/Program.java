package Class_basic;

import java.util.Scanner;

public class Program {
    public static void main(String[] args) {
        String choice;
        do {
            System.out.println("Hinh Tron.");
            System.out.println("Ngay Thang.");
            System.out.println("Do thi 2 chieu.");
            System.out.println("Xay dung class Animal don gian.");
            int option = 0;
            System.out.print("Ban muon chon bai nao: ");
            Scanner scanner = new Scanner(System.in);
            option = Integer.parseInt(scanner.nextLine());

            switch (option) {
                case 1: {
                    HinhTron circle_01 = new HinhTron();
                    circle_01.input();
                    circle_01.output();
                    System.out.printf("Duong kinh hinh tron: %.2f%n", circle_01.duongKinh());
                    System.out.printf("Chu vi hinh tron la: %.2f%n", circle_01.chuVi());
                    System.out.printf("Dien tich hinh tron: %.2f%n", circle_01.dienTich());
                }
                break;
                case 2: {
                    NgayThang date_01 = new NgayThang(31, 12, 2021);
                    if (date_01.checkLeapYear()) {
                        System.out.printf("Nam %d la nam nhuan.%n", date_01.getY());
                    } else {
                        System.out.printf("Nam %d la nam khong nhuan.%n", date_01.getY());
                    }
                }
                break;
                case 3: {
                    Diem2D point_01 = new Diem2D(2, 1);
                    Diem2D point_02 = new Diem2D(4, 5);
                    System.out.printf("Khoang cach giua 2 diem (%d,%d) va (%d,%d) la %.2f.%n",
                            point_01.getDiemX(), point_01.getDiemY(), point_02.getDiemX(), point_02.getDiemY(), point_01.KhoangCach_2Diem(point_02));
                }
                break;
                case 4: {
                    Animal pet01 = new Animal("Lion", 2, 0.9, 48.7, "Female");
                    Animal pet02 = new Animal("Tiger", 1, 0.8, 46.4, "Male");
                    System.out.printf("%s and %s%n", pet01.showName(), pet02.showName());
                    Animal pet03 = new Animal();
                    pet03.Input();
                    System.out.println();
                    pet03.Output();
                }
                break;
                default: {
                    main(args);
                }
                break;
            }

            System.out.print("Ban muon tiep tuc khong (Y/N)? ");
            choice = scanner.nextLine();
            while (!(choice.equalsIgnoreCase("y") || choice.equalsIgnoreCase("n"))) {
                System.out.print("Yeu cau khong hop le, xin vui long nhap lai: ");
                choice = scanner.nextLine();
            }
        } while (choice.equalsIgnoreCase("y"));
        System.out.println("Cam on ban da su dung san pham cua toi");
    }
}

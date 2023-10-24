package Class_basic;
import java.util.Scanner;

class HinhTron {
    private double banKinh;

    public double getR() {
        return banKinh;
    }

    public void setR(double value) {
        banKinh = value;
    }

    public HinhTron() {
        banKinh = 0;
    }

    public HinhTron(double R) {
        banKinh = R;
    }

    public HinhTron(HinhTron hinh) {
        this.banKinh = hinh.banKinh;
    }

    public void input() {
        System.out.print("Nhap gia tri cho ban kinh: ");
        Scanner scanner = new Scanner(System.in);
        banKinh = Double.parseDouble(scanner.nextLine().replace(',', '.'));
    }

    public void output() {
        System.out.printf("Ban kinh ban vua nhap la %.2f%n", banKinh);
    }

    public double chuVi() {
        return this.banKinh * 2 * Math.PI;
    }

    public double dienTich() {
        return Math.pow(this.banKinh, 2) * Math.PI;
    }

    public double duongKinh() {
        return this.banKinh * 2;
    }
}

class Diem2D {
    private int x, y;

    public int getDiemX() {
        return x;
    }

    public void setDiemX(int value) {
        x = value;
    }

    public int getDiemY() {
        return y;
    }

    public void setDiemY(int value) {
        y = value;
    }

    public Diem2D() {
        x = y = 0;
    }

    public Diem2D(int hoanhdo, int tungdo) {
        x = hoanhdo;
        y = tungdo;
    }

    public Diem2D(Diem2D diem) {
        this.x = diem.x;
        this.y = diem.y;
    }

    public void Input() {
        System.out.print("Nhap toa do x: ");
        Scanner scanner = new Scanner(System.in);
        x = Integer.parseInt(scanner.nextLine());
        System.out.print("Nhap toa do y: ");
        y = Integer.parseInt(scanner.nextLine());
    }

    public double KhoangCach_2Diem(Diem2D d) {
        return Math.sqrt(Math.pow(this.x - d.x, 2) + Math.pow(this.y - d.y, 2));
    }
}

class NgayThang {
    private int day, month, year;

    public int getD() {
        return day;
    }

    public void setD(int value) {
        day = value;
    }

    public int getM() {
        return month;
    }

    public void setM(int value) {
        month = value;
    }

    public int getY() {
        return year;
    }

    public void setY(int value) {
        year = value;
    }

    public NgayThang(int day, int month, int year) {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public NgayThang(NgayThang date) {
        day = date.day;
        month = date.month;
        year = date.year;
    }

    public boolean checkLeapYear() {
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            return true;
        else
            return false;
    }
}

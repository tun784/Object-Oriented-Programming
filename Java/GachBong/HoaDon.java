import java.util.Scanner;

abstract class HoaDon {
    // properties
    protected String maHoaDon;
    public String getMaHD() {
        return maHoaDon;
    }
    public void setMaHD(String value) {
        if (value.length() == 6 && value.startsWith("HD")) {
            maHoaDon = value;
        } else {
            System.out.println("Ma hoa don khong hop le.");
        }
    }
    public String tenGachBong;
    public double chieuDai;
    public double chieuRong;
    protected int soLuong;
    public int getSL() {
        return soLuong;
    }
    public void setSL(int value) {
        if (value > 10) {
            soLuong = value;
        } else {
            System.out.println("So luong khong hop le.");
        }
    }
    public double donGia;
    public static double tyLe_VAT = 0.1;

    // constructors
    public HoaDon() {
        maHoaDon = "HD0001";
        tenGachBong = "op tuong phong khach";
        chieuDai = 60.0;
        chieuRong = 40.0;
        soLuong = 1200;
        donGia = 60.0;
    }

    public HoaDon(String mahoadon, String tengachbong, double chieudai, double chieurong, int soluong, double dongia) {
        this.maHoaDon = mahoadon;
        this.tenGachBong = tengachbong;
        this.chieuDai = chieudai;
        this.chieuRong = chieurong;
        this.soLuong = soluong;
        this.donGia = dongia;
    }

    public abstract double GiamGia();

    public double TongTien() {
        return soLuong * donGia - GiamGia();
    }

    public abstract double Thue();

    public void Nhap() {
        try {
            Scanner scanner = new Scanner(System.in);
            System.out.print("Vui long nhap ma hoa don: ");
            setMaHD(scanner.nextLine());

            System.out.print("Vui long nhap ten gach bong: ");
            tenGachBong = scanner.nextLine();

            System.out.print("Vui long nhap chieu dai: ");
            chieuDai = Double.parseDouble(scanner.nextLine());

            System.out.print("Vui long nhap chieu rong: ");
            chieuRong = Double.parseDouble(scanner.nextLine());

            System.out.print("Vui long nhap so luong: ");
            setSL(Integer.parseInt(scanner.nextLine()));

            System.out.print("Vui long nhap don gia: ");
            donGia = Double.parseDouble(scanner.nextLine());
        } catch (NumberFormatException e) {
            System.out.println("Nhap sai dinh dang. Vui long nhap lai.");
            // You can add more error handling as needed
        }
    }

    public void Xuat() {
        System.out.println("Ma hoa don: " + maHoaDon);
        System.out.println("Ten gach bong: " + tenGachBong);
        System.out.println("Chieu dai: " + chieuDai);
        System.out.println("Chieu rong: " + chieuRong);
        System.out.println("So luong: " + soLuong + " cai.");
        System.out.println("Don gia: " + donGia);
    }
}
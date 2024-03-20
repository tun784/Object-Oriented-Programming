using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachThiSinh
{
    public class ThiSinh
    {
        string soBaoDanh;
        string tenThiSinh;
        int namSinh;
        double diemToan;
        double diemVan;
        double diemNgoaiNgu;
        public static int diemChuan = 25;
        public double DiemNgoaiNgu
        {
            get { return diemNgoaiNgu; }
            set { diemNgoaiNgu = value; }
        }

        public double DiemVan
        {
            get { return diemVan; }
            set { diemVan = value; }
        }

        public double DiemToan
        {
            get { return diemToan; }
            set { diemToan = value; }
        }

        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }

        public string TenThiSinh
        {
            get { return tenThiSinh; }
            set { tenThiSinh = value; }
        }

        public string SoBaoDanh
        {
            get { return soBaoDanh; }
            set { soBaoDanh = value; }
        }

        public ThiSinh() { }
        public ThiSinh(string soBaoDanh, string tenThiSinh, int namSinh, double diemToan, double diemVan, double diemNgoaiNgu)
        {
            this.soBaoDanh = soBaoDanh;
            this.tenThiSinh = tenThiSinh;
            this.namSinh = namSinh;
            this.diemToan = diemToan;
            this.diemVan = diemVan;
            this.diemNgoaiNgu = diemNgoaiNgu;
        }

        public double TongDiem()
        {
            return (double)diemNgoaiNgu * 2 + diemToan + diemVan;
        }
        public string KetQua()
        {
            if (TongDiem() > 25)
                return "Dau";
            else
                return "Rot";
        }
        public void Nhap1TS()
        {
            Console.Write("Nhap SBD: ");
            soBaoDanh = Console.ReadLine();
            Console.Write("Nhap ho ten thi sinh: ");
            tenThiSinh = Console.ReadLine();
            Console.Write("Nhap nam sinh thi sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem toan: ");
            diemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem van: ");
            diemVan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem ngoai ngu: ");
            diemNgoaiNgu = double.Parse(Console.ReadLine());
        }
        public void Xuat1TS()
        {
            Console.WriteLine("SBD: {0} - Ho ten: {1} - Nam sinh: {2}", soBaoDanh, tenThiSinh, namSinh);
            Console.WriteLine("Diem Toan: {0:0.00} - Diem Van: {1:0.00} - Diem Ngoai Ngu: {2:0.00}", diemToan, diemVan, diemNgoaiNgu);
        }
    }
}

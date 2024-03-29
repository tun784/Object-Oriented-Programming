using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_10_2001224555_NguyenHoangTuan
{
    public class ThiSinh
    {
        string hoTen, soBaoDanh;
        int namSinh;

        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }
        double diemToan, diemVan, diemNgoaiNgu;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string SoBaoDanh
        {
            get { return soBaoDanh; }
            set { soBaoDanh = value; }
        }

        public double DiemToan
        {
            get { return diemToan; }
            set { diemToan = value; }
        }

        public double DiemVan
        {
            get { return diemVan; }
            set { diemVan = value; }
        }

        public double DiemNgoaiNgu
        {
            get { return diemNgoaiNgu; }
            set { diemNgoaiNgu = value; }
        }
        static double diemChuan = 25;
        public ThiSinh()
        {
            hoTen = "Nguyen Van A";
            soBaoDanh = "TS01";
            namSinh = 2000;
            diemToan = diemVan = diemNgoaiNgu = 0;
        }
        public ThiSinh(string hoten, string sbd, int ns, double dt, double dv, double dnn)
        {
            HoTen = hoten;
            namSinh = ns;
            SoBaoDanh = sbd;
            DiemToan = dt;
            DiemVan = dv;
            DiemNgoaiNgu = dnn;
        }
        public double TongDiem
        {
            get { return diemToan + diemVan + diemNgoaiNgu * 2; }
        }
        public string KetQua
        {
            get
            {
                if (TongDiem < diemChuan)
                    return "Rot";
                else
                    return "Dau";
            }
        }
        public void Xuat()
        {
            Console.WriteLine("{0,5}\t{1,-20}\t{2,5}\t{3:0.0}\t{4:0.0}\t{5:0.0}\t{6}\t{7}", soBaoDanh, hoTen, namSinh, diemToan, diemVan, diemNgoaiNgu, TongDiem, KetQua);
        }
    }
}

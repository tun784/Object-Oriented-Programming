using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH07_03_04_2024
{
    public class NhanVienSanXuat : NhanVien
    {
        public double phuCapNangNhoc = 0.1;
        protected int soNgayNghi;
        public int SoNgayNghi
        {
            get { return soNgayNghi; }
            set { soNgayNghi = value; }
        }
        public NhanVienSanXuat(): base()
        {
            soNgayNghi = 0;
        }
        public NhanVienSanXuat(string maNhanVien, string tenNhanVien, string gioiTinh, int namSinh, int namVaoLam, double heSoLuong, int SoNgayNghi) 
            : base(maNhanVien, tenNhanVien, gioiTinh, namSinh, namVaoLam, heSoLuong)
        {
            this.soNgayNghi = SoNgayNghi;
        }
        public override char XepLoai()
        {
            if (soNgayNghi <= 1)
                return 'A';
            if (soNgayNghi <= 3)
                return 'B';
            if (soNgayNghi <= 5)
                return 'C';
            return 'D';
        }
        public override double Luong()
        {
            return heSoLuong * luongCoBan * (1 + phuCapNangNhoc);
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("So ngay nghi: ");
            SoNgayNghi = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So ngay nghi: {0,2} ngay", soNgayNghi);
        }
    }
}

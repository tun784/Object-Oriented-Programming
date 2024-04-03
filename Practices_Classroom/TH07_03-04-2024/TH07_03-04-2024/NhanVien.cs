using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace TH07_03_04_2024
{
    public abstract class NhanVien
    {
        int loaiNV;
        protected string maNhanVien, tenNhanVien, gioiTinh;
        protected int namSinh, namVaoLam;
        protected double heSoLuong;
        public static int luongCoBan = 1150;
        public int now = DateTime.Now.Year;
        public NhanVien()
        {
            maNhanVien = "XXX";
            tenNhanVien = "Nguyen Van A";
            gioiTinh = "BeDe";
            namSinh = 1997;
            namVaoLam = 2024;
            heSoLuong = 0.0;
        }
        public NhanVien(string maNhanVien, string tenNhanVien, string gioiTinh, int namSinh, int namVaoLam, double heSoLuong)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.gioiTinh = gioiTinh;
            this.namSinh = namSinh;
            this.namVaoLam = namVaoLam;
            this.heSoLuong = heSoLuong;
        }
        public int LoaiNV
        {
            get { return loaiNV; }
            set { loaiNV = value; }
        }
        public double HeSoLuong
        {
            get { return heSoLuong; }
            set { heSoLuong = value; }
        }
        public int NamVaoLam
        {
            get { return namVaoLam; }
            set { namVaoLam = value; }
        }
        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }
        public int soNamLamViec(){
            return now - namVaoLam;
        }
        public double PhuCapThamNien()
        {
            if (soNamLamViec() < 5)
                return 0;
            else
                return (double)soNamLamViec() * (double)luongCoBan / 100;
        }
        abstract public char XepLoai();
        abstract public double Luong();
        public double ThuNhap()
        {
            char xl = XepLoai();
            if (xl == 'A')
                return Luong() + PhuCapThamNien();
            else if (xl == 'B')
                return 0.75 * Luong() + PhuCapThamNien();
            else if (xl == 'C')
                return 0.5 * Luong() + PhuCapThamNien();
            else
                return PhuCapThamNien();
        }
        public virtual void Nhap()
        {
            Console.Write("Ma nhan Vien: ");
            MaNhanVien = Console.ReadLine();
            Console.Write("Ho ten nhan vien: ");
            TenNhanVien = Console.ReadLine();
            Console.Write("Nam sinh: ");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("He so luong: ");
            HeSoLuong = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nam vao lam: ");
            NamVaoLam = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ma nhan vien: {0,6}; Ho ten: {1,-20}; Nam sinh: {2,5}", maNhanVien, tenNhanVien, namSinh);
            Console.WriteLine("Gioi tinh: {0,4}; He so luong: {1,3}; Nam vao lam: {2,5}", gioiTinh, heSoLuong, namVaoLam);
            Console.WriteLine("So nam lam viec: {0,2} nam; Xep loai: {1,2}; Phu cap tham nien: {2,4} trieu dong", soNamLamViec(), XepLoai(), PhuCapThamNien());
            Console.WriteLine("Luong: {0,7} trieu dong; Thu nhap: {1,7} trieu dong", Luong(), ThuNhap());
        }
    }
}

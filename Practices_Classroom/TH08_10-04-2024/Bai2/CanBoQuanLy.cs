using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class CanBoQuanLy : NhanVien
    {
        protected string chucVu;
        protected double heSoChucVu;

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        public double HeSoChucVu
        {
            get { return heSoChucVu; }
            set { heSoChucVu = value; }
        }
        public CanBoQuanLy(): base()
        {
            chucVu = "Giam doc";
            heSoChucVu = 1;
        }
        public CanBoQuanLy(string maNhanVien, string tenNhanVien, string gioiTinh, int namSinh, int namVaoLam, double heSoLuong, string chucVu, double heSoChucVu)
            : base(maNhanVien, tenNhanVien, gioiTinh, namSinh, namVaoLam, heSoLuong)
        {
            this.chucVu = chucVu;
            this.heSoChucVu = heSoChucVu;
        }
        public override char XepLoai()
        {
            return 'A';
        }
        public double PhuCapChucVu()
        {
            return heSoChucVu * 1100;
        }
        public override double Luong()
        {
            return heSoLuong * luongCoBan + PhuCapChucVu();
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Chuc vu: ");
            ChucVu = Console.ReadLine();
            Console.Write("He so chuc vu: ");
            HeSoChucVu = Convert.ToDouble(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Chuc vu: {0,6}; He so chuc vu: {1,4}", chucVu, heSoChucVu);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH07_03_04_2024
{
    public class NhanVienKinhDoanh : NhanVien
    {
        protected int doanhSoToiThieu, doanhSo;

        public int DoanhSo
        {
            get { return doanhSo; }
            set { doanhSo = value; }
        }

        public int DoanhSoToiThieu
        {
            get { return doanhSoToiThieu; }
            set { doanhSoToiThieu = value; }
        }
        public NhanVienKinhDoanh(): base()
        {
            doanhSo = 0;
            doanhSoToiThieu = 1;
        }
        public NhanVienKinhDoanh(string maNhanVien, string tenNhanVien, string gioiTinh, int namSinh, int namVaoLam, double heSoLuong, int doanhSo, int doanhSoToiThieu)
            : base(maNhanVien, tenNhanVien, gioiTinh, namSinh, namVaoLam, heSoLuong)
        {
            this.doanhSo = doanhSo;
            this.doanhSoToiThieu = doanhSoToiThieu;
        }
        public override char XepLoai()
        {
            if (doanhSo < (double)doanhSoToiThieu * 0.5)
                return 'D';
            if (doanhSo < doanhSoToiThieu)
                return 'C';
            if (doanhSo >= doanhSoToiThieu * 2)
                return 'A';
            else
                return 'B';
        }
        public double HoaHong(){
            if (doanhSo >= doanhSoToiThieu)
                return 0.15 * (double)doanhSo;
            else
                return 0;
        }
        public override double Luong()
        {
            return heSoLuong * luongCoBan + HoaHong();
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Doanh so toi thieu: ");
            DoanhSoToiThieu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Doanh so ban hang trong thang: ");
            DoanhSo = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Doanh so toi thieu: {0,3} hang; doanh so ban hang: {1,3} hang", doanhSoToiThieu, doanhSo);
        }
    }
}

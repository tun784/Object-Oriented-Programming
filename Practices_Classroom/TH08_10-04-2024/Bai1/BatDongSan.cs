using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public abstract class BatDongSan
    {
        protected string maSo, loai;
        protected double chieuDai, chieuRong;
        public string MaSo {
            get { return maSo; }
            set { maSo = value; }
        } 
        public double ChieuDai
        {
            get { return chieuDai; }
            set { chieuDai = value; }
        }
        public double ChieuRong
        {
            get { return chieuRong; }
            set { chieuRong = value; }
        }
        public string Loai
        {
            get { return loai; }
            set { loai = value; }
        }
        public BatDongSan()
        {
            maSo = "xxx";
            chieuDai = 1.0;
            chieuRong = 1.0;
        }
        public BatDongSan(string maso, double chieudai, double chieurong)
        {
            this.MaSo = maso;
            this.ChieuDai = chieudai;
            this.ChieuRong = chieurong;
        }
        public double dienTich {
            get { return chieuDai * chieuRong; }
        }
        abstract public double GiaBan();
        public virtual void Nhap1BDS()
        {
            Console.Write("Nhap ma so: ");
            MaSo = Console.ReadLine();
            Console.Write("Nhap chieu dai: ");
            ChieuDai = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            ChieuRong = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Xuat1BDS()
        {
            Console.WriteLine("Ma so: {0, 5}; chieu dai: {1, 3} m; chieu rong: {2, 3} m", maSo, chieuDai, chieuRong);
            Console.WriteLine("Dien tich: {0, 4} m2; gia ban: {1, -6} dong", dienTich, GiaBan());
        }
    }
}

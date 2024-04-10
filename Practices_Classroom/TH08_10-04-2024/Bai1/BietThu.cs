using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class BietThu : BatDongSan, Phi
    {
        public BietThu() : base() { }
        public BietThu(string maso, double chieudai, double chieurong)
            : base(maso, chieudai, chieurong)
        { }
        public override double GiaBan()
        {
            return dienTich * 10000;
        }
        public double PhiKinhDoanh()
        {
            return dienTich * 1000;
        }
        public override void Nhap1BDS()
        {
            base.Xuat1BDS();
        }
        public override void Xuat1BDS()
        {
            base.Xuat1BDS();
            Console.WriteLine("Phi kinh doanh: {0} dong", PhiKinhDoanh());
        }
    }
}

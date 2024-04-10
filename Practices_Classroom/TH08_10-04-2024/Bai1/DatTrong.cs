using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class DatTrong : BatDongSan
    {
        public DatTrong() : base() { }
        public DatTrong(string maso, double chieudai, double chieurong, int solau)
            : base(maso, chieudai, chieurong)
        { }
        public override double GiaBan()
        {
            return dienTich * 10000;
        }
        public override void Nhap1BDS()
        {
            base.Xuat1BDS();
        }
        public override void Xuat1BDS()
        {
            base.Xuat1BDS();
        }
    }
}

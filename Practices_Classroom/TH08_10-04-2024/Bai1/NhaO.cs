using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class NhaO : BatDongSan
    {
        protected int soLau;
        public int SoLau
        {
            get { return soLau; }
            set { soLau = value; }
        }
        public NhaO()
            : base()
        {
            soLau = 1;
        }
        public NhaO(string maso, double chieudai, double chieurong, int solau)
            : base(maso, chieudai, chieurong)
        {
            this.SoLau = solau;
        }
        public override double GiaBan()
        {
            return dienTich * 10000 + (double)soLau * 100000;
        }
        public override void Nhap1BDS()
        {
            base.Nhap1BDS();
            Console.Write("Nhap so lau: ");
            SoLau = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat1BDS()
        {
            base.Xuat1BDS();
            Console.WriteLine("So Lau: {0} lau", soLau);
        }
    }
}

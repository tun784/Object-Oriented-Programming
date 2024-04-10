using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class KhachSan : BatDongSan, Phi
    {
        protected int soSao;
        public int SoSao
        {
            get { return soSao; }
            set { soSao = value; }
        }

        public KhachSan() : base() { }
        public KhachSan(string maso, double chieudai, double chieurong, int sosao)
            : base()
        {
            this.SoSao = sosao;
        }
        public override double GiaBan()
        {
            return 100000 + (double)soSao * 50000;
        }
        public double PhiKinhDoanh()
        {
            return (double)chieuRong * 5000;
        }
        public override void Nhap1BDS()
        {
            base.Nhap1BDS();
            Console.Write("Nhap so sao: ");
            SoSao = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat1BDS()
        {
            base.Xuat1BDS();
            Console.WriteLine("So sao: {0} sao; Phi kinh doanh: {1} dong", soSao, PhiKinhDoanh());
        }
    }
}

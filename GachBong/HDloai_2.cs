using System;

namespace GachBong
{
    class HDloai_2 : HoaDon{
        public string loai;
        public double khoangCachGiaoHang;
        public double kcgh_1 = 5, kcgh_2 = 15;
        public override double GiamGia(){
            if (khoangCachGiaoHang < kcgh_1)
                return 0.05;
            else if (khoangCachGiaoHang < kcgh_2)
                return 0.03;
            else
                return 0.0;
        }
    }
}
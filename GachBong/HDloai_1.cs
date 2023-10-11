using System;

namespace GachBong
{
    class HDloai_1 : HoaDon{
        public string hangSX;
        public static string HangSanXuat = "Dong Tam";

        public override double GiamGia(){
            if (hangSX == HangSanXuat)
                return 0.1;
            else if (soLuong >= 1000)
                return 0.04;
            else
                return 0.0;
        }
    }
}
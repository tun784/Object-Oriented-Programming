using System;

namespace GachBong
{
    class HDloai_1 : HoaDon, HoTro{
        public string HangSanXuat;
        public static string hangSX = "Dong Tam";

        public override double GiamGia(){
            if (HangSanXuat == hangSX)
                return donGia * 0.1;
            else if (soLuong >= 1000)
                return donGia * 0.04;
            else
                return donGia * 0.0;
        }
        public override double HoTroGia(){
            if (soLuong < 200)
                return donGia * 0.03;
            else if (soLuong <= 800)
                return donGia * 0.04;
            else
                return donGia * 0.05;
        }
    }
}